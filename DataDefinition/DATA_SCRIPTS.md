# Flights Database Scripts
- Please copy any new updates before working with the database on your machine.
	+ Right click on Flights database
	+ New Query
	+ Paste the new script only, and execute all
- And update this file with any script you wrote to modify or add to the database.
    + (e.g., new stored procedure, alter table, etc.).

When you want to check on some table's design: 
- Go to Databases
- Choose Flights -> Tables
- Right click the specific table -> Design

First time use: 
- Go to SSMS
- Right click Databases
- New database
- Name it Flights, and leave every thing as default
- Click Create

Naming Conventions:
- Stored Procedures: spTableName_Operation
- Tables, Columns, SP Parameters: PascalCase (e.g., FlightTicket)
- Airports: RUH, CAI, DUB, etc.

### Yousef Kilany : 5/16/2023 
______________________________________________________________________
```
create table Customer(
	Id int identity primary key,
	FirstName nvarchar(50) not null,
	MiddleName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email nvarchar(100) not null,
	PassportNumber varchar(20) not null,
	PhoneNumber varchar(20) not null,
	Password nvarchar(100) not null
);

create table Aircraft(
	Id int identity primary key,
	SerialNumber varchar(20) unique not null,
	ModelName varchar(50) not null,
	NumberOfSeats int not null
);

create table Flight(
	Id int identity primary key,
	FlightNumber varchar(20) unique not null,
	OriginAirport varchar(10) not null,
	DestinationAirport varchar(10) not null,
	DepartureTime datetime2 not null,
	ArrivalTime datetime2 not null,
	TripDuration decimal(6, 2) not null,
	Cost money not null,
	AircraftId int,
	BusinessClassSeats int not null,
	EconomyClassSeats int not null,

	foreign key (AircraftId) references Aircraft(Id)
	on update cascade
	on delete set null
);

create table FlightTicket(
	Id int identity primary key,
	TicketNumber varchar(20) not null,
	CustomerId int not null,
	FlightId int not null,
	FlightClass int not null,
	
	foreign key (CustomerId) references Customer(Id)
	on update cascade
	on delete cascade,

	foreign key (FlightId) references Flight(Id)
	on update cascade
	on delete cascade
);

```
______________________________________________________________________

### Yousef Kilany : 5/17/2023
______________________________________________________________________
```
CREATE PROCEDURE spCustomer_Insert
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(100),
	@PassportNumber varchar(20),
	@PhoneNumber varchar(20),
	@Password nvarchar(100), 
	@Id int = 0 output

AS
BEGIN
	
	SET NOCOUNT ON;

	insert into Customer 
	values(@FirstName, @MiddleName, @LastName, @Email,
	@PassportNumber, @PhoneNumber, @Password);

	select @Id = SCOPE_IDENTITY();
END
GO


CREATE PROCEDURE spCustomer_CheckEmailExists
	@Email nvarchar(100)
	
AS
BEGIN
	
	SET NOCOUNT ON;

	declare @exists bit;

	if exists (
		select 1 from Customer 
		where @Email = Customer.Email
	) 
		set @exists = 1;
	else
		set @exists = 0;

	select @exists as EmailExists;
    
END
GO



CREATE PROCEDURE spCustomer_Authenticate
	@Email nvarchar(100),
	@Password nvarchar(100)

AS
BEGIN

	SET NOCOUNT ON;

	declare @Authenticated bit;

	if exists (
		select * from Customer
		where Email = @Email 
			and Customer.Password = @Password)

		set @Authenticated = 1;

	else 
		set @Authenticated = 0;

	select @Authenticated as UserAuthenticated

END
GO



```
______________________________________________________________________

### Yousef Kilany : 5/18/2023
______________________________________________________________________

```

CREATE PROCEDURE spFlight_GetByFlightTicketId
	@FlightTicketId int

AS
BEGIN

	SET NOCOUNT ON;
	
	select f.* 
	from Flight as f
	inner join FlightTicket as t 
		on t.FlightId = f.Id
	where @FlightTicketId = t.Id

END
GO


CREATE PROCEDURE spFlightTicket_GetByCustomerId
	@CustomerId int

AS
BEGIN

	SET NOCOUNT ON;

	select * 
	from FlightTicket
	where CustomerId = @CustomerId;

END
GO



CREATE PROCEDURE spCustomer_GetByEmail
	@Email nvarchar(100)

AS
BEGIN
	
	SET NOCOUNT ON;

	select * 
	from Customer
	where Email = @Email;
END
GO

```
<<<<<<< HEAD


### Yousef Kilany : 5/19/2023 
______________________________________________________________________
```

CREATE PROCEDURE spFlight_GetAllOrigins
AS
BEGIN

    SET NOCOUNT ON;
    
    SELECT DISTINCT OriginAirport AS OriginAirports
    FROM Flight;
 
END
GO


CREATE PROCEDURE spFlight_GetAllDestinations
AS
BEGIN

    SET NOCOUNT ON;

    SELECT DISTINCT DestinationAirport AS DestinationAirports
    FROM Flight;

END
GO




CREATE PROCEDURE spFlight_GetByDateOriginDestination
    @StartDatetime datetime2,
    @EndDatetime datetime2,
    @OriginAirport varchar(10),
    @DestinationAirport varchar(10)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM Flight
    WHERE Flight.OriginAirport = @OriginAirport AND Flight.DestinationAirport = @DestinationAirport AND Flight.DepartureTime >= @StartDatetime
    AND Flight.ArrivalTime <= @EndDatetime;

    RETURN;
END
GO


CREATE PROCEDURE spFlightTicket_CheckExists
	@CustomerId int,
	@FlightId int

AS
BEGIN

	SET NOCOUNT ON;

    declare @Exists bit;

	if exists (
		select 1 
		from FlightTicket
		where CustomerId = @CustomerId
			and FlightId = @FlightId
		)
		set @Exists = 1;
	else
		set @Exists = 0;

	select @Exists as TicketExists;

END
GO





CREATE PROCEDURE spFlightTicket_Insert
	@TicketNumber varchar(20),
	@CustomerId int,
	@FlightId int,
	@FlightClass int,
	@Id int = 0 output

AS
BEGIN

	SET NOCOUNT ON;

	insert into FlightTicket
	values(@TicketNumber, @CustomerId, @FlightId, @FlightClass);

	select @Id = SCOPE_IDENTITY();

END
GO


```

### Yusuf Badr : 19/05/2023

```
CREATE PROCEDURE spFlight_GetFligtsBetweenStartDatetimeAndEndDatetime

	@StartDatetime datetime2,
	@EndDatetime datetime2
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM Flight
	WHERE Flight.DepartureTime >= @StartDatetime AND Flight.ArrivalTime <= @EndDatetime;
	RETURN;
END
GO

```



### Yousef Kilany : 5/20/2023 
______________________________________________________________________
```

CREATE PROCEDURE spCustomer_CheckAnotherEmailExists
	@OldEmail nvarchar(100),
	@NewEmail nvarchar(100)

AS
BEGIN

	SET NOCOUNT ON;

	declare @Exists bit;

	if exists (
		select 1 
		from Customer
		where Email <> @OldEmail
			and Email = @NewEmail
		)
		set @Exists = 1;
	else
		set @Exists = 0;

	select @Exists as NewEmailExists;

END
GO



CREATE PROCEDURE spCustomer_Update
	@Id int,
	@FirstName nvarchar(50),
	@MiddleName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(100),
	@PassportNumber varchar(20),
	@PhoneNumber varchar(20),
	@Password nvarchar(100)

AS
BEGIN

	SET NOCOUNT ON;

	update Customer
	set 
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		Email = @Email,
		PassportNumber = @PassportNumber,
		PhoneNumber = @PhoneNumber,
		Password = @Password

	where Id = @Id;

END
GO

```
______________________________________________________________________


### Shehab Diab : 5/19/2023
______________________________________________________________________

```

CREATE PROCEDURE spAircraft_Insert
	@SerialNumber varchar(20),
	@ModelName varchar(50),
	@NumberOfSeats int,
	@Id int = 0 output
	
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Aircraft 
	VALUES (@SerialNumber, @ModelName, @NumberOfSeats);

	SELECT @Id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE spAircraft_GetByDate
	@DepartureTime datetime2(7),
	@ArrivalTime datetime2(7)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Aircraft.*
	FROM Aircraft
	LEFT JOIN Flight
	ON Aircraft.Id = Flight.AircraftId
	AND Flight.DepartureTime < @ArrivalTime
	AND Flight.ArrivalTime > @DepartureTime
	WHERE Flight.AircraftId IS NULL

END
GO

CREATE PROCEDURE spFlight_Insert
	@FlightNumber varchar(20),
	@OriginAirport varchar(10),
	@DestinationAirport varchar(10),
	@DepartureTime datetime2(7),
	@ArrivalTime datetime2(7),
	@TripDuration decimal(6, 2),
	@Cost money,
	@AircraftId int,
	@BusinessClassSeats int,
	@EconomyClassSeats int,
	@Id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO Flight
	VALUES (@FlightNumber,
			@OriginAirport,
			@DestinationAirport,
			@DepartureTime,
			@ArrivalTime,
			@TripDuration,
			@Cost,
			@AircraftId,
			@BusinessClassSeats,
			@EconomyClassSeats)
			
	SELECT @Id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE spAircraft_Update
	@Id int,
	@SerialNumber varchar(20),
	@ModelName varchar(50),
	@NumberOfSeats int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE Aircraft
	SET SerialNumber = @SerialNumber,
		ModelName = @ModelName,
		NumberOfSeats = @NumberOfSeats
	WHERE Id = @Id

END
GO




CREATE PROCEDURE spFlightTicket_DeleteById
	@Id int

AS
BEGIN

	SET NOCOUNT ON;

	delete 
	from FlightTicket
	where Id = @Id;

END
GO



```
______________________________________________________________________


### Shehab Diab : 5/20/2023
______________________________________________________________________

```
CREATE PROCEDURE spFlight_UpdateDate
	@Id int,
	@DepartureTime datetime2(7),
	@ArrivalTime datetime2(7)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Flight
	SET 
	DepartureTime = @DepartureTime,
	ArrivalTime  = @ArrivalTime
	WHERE Id = @Id
END
GO

```

### Shehab Diab : 5/21/2023
______________________________________________________________________

```

CREATE PROCEDURE spAircraft_CheckSerialNumberExists
	@SerialNumber varchar(20)
As
Begin

	DECLARE @exists bit

	if exists (
		SELECT 1 FROM Aircraft
		WHERE 
		SerialNumber = @SerialNumber
	)
		SET @exists = 1;
	else
		SET @exists = 0;

	SELECT @exists AS SerialNumberExists;

END
GO

CREATE PROCEDURE spFlight_CheckFlightNumberExists
	@FlightNumber varchar(20)
As
Begin

	DECLARE @exists bit

	if exists (
		SELECT 1 FROM Flight
		WHERE 
		FlightNumber = @FlightNumber
	)
		SET @exists = 1;
	else
		SET @exists = 0;

	SELECT @exists AS FlightNumberExists;

END
GO


```




### Yousef Kilany : 5/21/2023 
______________________________________________________________________

```

create table Admin(
	Id int identity primary key,
	Email nvarchar(100) not null unique,
	Password nvarchar(100) not null
);


CREATE PROCEDURE spAdmin_Authenticate
	@Email nvarchar(100),
	@Password nvarchar(100)

AS
BEGIN

	SET NOCOUNT ON;

	declare @Authenticated bit;

	if exists (
		select * from Admin
		where Email = @Email 
			and Admin.Password = @Password)

		set @Authenticated = 1;

	else 
		set @Authenticated = 0;

	select @Authenticated as UserAuthenticated

END
GO

```

______________________________________________________________________
