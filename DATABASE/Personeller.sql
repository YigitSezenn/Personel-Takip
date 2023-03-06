create database PersonelTakip

create table Departman
(
ID int primary key identity(1,1),
DepartmanName nvarchar(50)  not null,
);

create table Position
(
ID int   primary key identity(1,1) not null,
PositionName   varchar(50) not null,
DepartmanID int not null,

);

create table Personel(
ID int identity(1,1) primary key,
UserNo int not null,
Name nvarchar(50) not null,
Surname nvarchar(50) not null,
Ýmage nvarchar(max) not null,
DepartmanID int not null,
PozisyonID int not null,
Salary int not null,
Birthday  date not null,
Adress varchar(max) not null,
Password int not null,
ÝsAdmin bit not null,
);
create table Salary(
ID  int identity(0,1) primary key,
PersonelID int not null,
Quantity int not null,
Date int not null,
Ay_ID int not null,
);

create table months
(

ID int identity(1,1) primary key,
Months varchar(15) not null,
);

insert into dbo.months(Months) values('Ocak');
insert into dbo.months(Months) values('Þubat');
insert into dbo.months(Months) values('Mart');
insert into dbo.months(Months) values('Nisan');
insert into dbo.months(Months) values('Mayýs');
insert into dbo.months(Months) values('Haziran');
insert into dbo.months(Months) values('Temmuz');
insert into dbo.months(Months) values('Aðustos');
insert into dbo.months(Months) values('Eylül');
insert into dbo.months(Months) values('Ekim');
insert into dbo.months(Months) values('Kasým');
insert into dbo.months(Months) values('Aralýk');

create table Bussines

(

ID int primary key identity(1,1),
PersonelID int not null,
Tag nvarchar(50) not null,
Contents nvarchar(max) not null,
DateofStart date not null,
EndDate  date not null,
BusinessContinuity int not null,

);

Create Table BusinessContinuity
(
ID int primary key identity(1,1),

BusinessContinuity_ID varchar(50) not null,

)

insert into dbo.BusinessContinuity values('Personel');
insert into dbo.BusinessContinuity values('Tamamlandý');
insert into dbo.BusinessContinuity values('Onaylandý');


create  table Permission
(
ID int identity(1,1) primary key,

PersonelID int not null,

dayoff date not null,
dayoffEnd date not null,
Explanation nvarchar(max) not null,
Duration int not null,
PermissionStatusID int not null,
);

create table PermissionStatus 
(
ID int primary key identity(1,1),
PermissionStatusName nvarchar(50) not null,
);

insert into dbo.PermissionStatus values('Adminde');
insert into dbo.PermissionStatus values('Onaylandý');
insert into dbo.PermissionStatus values('Reddedildi');

ALTER TABLE Position DROP COLUMN PersonelName;


