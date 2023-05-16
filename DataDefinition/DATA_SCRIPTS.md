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
