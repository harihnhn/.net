create database dotnetsql	--to create new database

use dotnetsql	--to use the created database

create table employee(eid int, ename varchar(30), edesignation varchar(20), salary money)	--to create new table in the current selected database

sp_help employee	--to view table structure

select * from employee	--to view table data(fields(column) and records(row))

insert into employee values(101, 'hari', '.Net developer', 25000) --to insert vlaue(single row) to the table
select * from employee

insert into employee values(102, 'haran', 'Web developer', 30000),	--to insert vlaue(insert multiple rows of data in one line) to the table
(103, 'narah', 'Front end developer', 20000),
(104, 'irah', 'Back end developer', 40000),
(105, 'hariharan', 'Full stack developer', 50000)
select * from employee

select eid, ename from employee --to view particular field of data in the table

select eid, ename, (salary/100)*10 as allowance from employee --to view data with some calculations
select ename +'--'+ edesignation as string_concadination from employee

select * from employee where ename = 'hari'
select * from employee where salary > 25000