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
- Stored Procedures: sp_tableName_procedureName
- Tables, Columns, SP Parameters: snake_case
- Airports: Riyadh, Cairo, Dubai, etc.

### Yousef Kilany : 5/16/2023 
______________________________________________________________________
```
create table customer(
	customer_id int identity primary key,
	first_name nvarchar(50) not null,
	middle_name nvarchar(50) not null,
	last_name nvarchar(50) not null,
	email nvarchar(50) not null,
	passport_number varchar(20) not null,
	phone_number varchar(20) not null
);

alter table customer
add password nvarchar(50) not null;

create table aircraft(
	aircraft_id int identity primary key,
	serial_number varchar(20) unique not null,
	model_name varchar(50) not null,
	number_of_seats int not null
);

create table flight(
	flight_id int identity primary key,
	flight_number varchar(20) unique not null,
	origin_airport varchar(10) not null,
	destination_airport varchar(10) not null,
	departure_time datetime2 not null,
	arrival_time datetime2 not null,
	trip_duration decimal(6, 2) not null,
	cost money not null,
	aircraft_id int,
	business_class_seats int not null,
	economy_class_seats int not null,

	foreign key (aircraft_id) references aircraft(aircraft_id)
	on update cascade
	on delete set null
);

create table flight_ticket(
	flight_ticket_id int identity primary key,
	ticket_number varchar(20) not null,
	passenger_id int not null,
	flight_id int not null,
	flight_class nvarchar(20) not null,
	seat_number varchar(10) not null,
	
	foreign key (passenger_id) references customer(customer_id)
	on update cascade
	on delete cascade,

	foreign key (flight_id) references flight(flight_id)
	on update cascade
	on delete cascade
);

```
______________________________________________________________________

### Yousef Kilany : 5/17/2023
______________________________________________________________________
```
CREATE PROCEDURE sp_customer_insert
	@first_name nvarchar(50),
	@middle_name nvarchar(50),
	@last_name nvarchar(50),
	@email nvarchar(50),
	@passport_number varchar(20),
	@phone_number varchar(20),
	@password nvarchar(50),
	@customer_id int = 0 output

AS
BEGIN
	
	SET NOCOUNT ON;

	insert into customer 
	values(@first_name, @middle_name, @last_name, @email, 
	@passport_number, @phone_number, @password);

	select @customer_id = SCOPE_IDENTITY();
END
GO


CREATE PROCEDURE sp_customer_check_email_exists 
	@email nvarchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;

	declare @exists bit;

	if exists (
		select 1 from customer 
		where @email = customer.email
	) 
		set @exists = 1;
	else
		set @exists = 0;

	select @exists as EmailExists;
    
END
GO



CREATE PROCEDURE sp_global_authenticate_user
	@email nvarchar(50),
	@password nvarchar(50)

AS
BEGIN

	SET NOCOUNT ON;

	declare @authenticated bit;

	if exists (
		select * from customer
		where email = @email 
			and customer.password = @password)

		set @authenticated = 1;

	else 
		set @authenticated = 0;

	select @authenticated as UserAuthenticated

END
GO

```
______________________________________________________________________

### Yousef Kilany : 5/18/2023
______________________________________________________________________

```
alter table flight
drop column seat_number


CREATE PROCEDURE sp_flight_get_by_flight_ticket_id
	@flight_ticket_id int

AS
BEGIN

	SET NOCOUNT ON;
	
	select f.* 
	from flight as f
	inner join flight_ticket as t 
		on t.flight_id = f.flight_id
	where @flight_ticket_id = t.flight_ticket_id

END
GO





CREATE PROCEDURE sp_flight_ticket_get_by_customer_id
	@customer_id int

AS
BEGIN

	SET NOCOUNT ON;

	select * 
	from flight_ticket
	where passenger_id = @customer_id;

END
GO



CREATE PROCEDURE sp_customer_get_by_email
	@email nvarchar(50)

AS
BEGIN
	
	SET NOCOUNT ON;

	select * 
	from customer
	where email = @email;
END
GO

```