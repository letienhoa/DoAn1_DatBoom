use master;
go

if OBJECT_ID('GameDoAn1') is not null drop database GameDoAn1;
go

create database GameDoAn1;
go


use GameDoAn1;
go

if OBJECT_ID('DIEM') is not null drop table DIEM;
go

create table DIEM(
Id int,
TenNguoiChoi varchar(50),
DiemSo varchar(50),
constraint pk_DIEM primary key(Id)
);


insert DIEM
values
(1,'Hoa','1000'),
(2,'Vuong','900'),
(3,'dad','800'),
(4,'asd','700'),
(5,'kg','600'),
(6,'iuti','500'),
(7,'uio','400'),
(8,'df','300'),
(9,'cb','200'),
(10,'df','100')

select * from DIEM;
