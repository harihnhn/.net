create database hari_database

use hari_database

create table employee(eid int, ename varchar(20), esalary money, edept varchar(10))

sp_help employee

insert into employee values(101, 'hariharan', 40000, 'IT')

select * from employee


