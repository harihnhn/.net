create database day2
use day2
create table table1(field1 int identity(100,1), field2 varchar(30), field3 money)	--autoincrement datatype (int identity(initialvalue, increment)
sp_help table1
insert into table1 values('record(1,2)', 10000)
select * from table1
insert into table1 values('record(2,2)', 11000),
('record(3,2)', 12000),
('record(4,2)', 13000),
('record(5,2)', 14000)
select * from table1

--where
select * from table1 where field1 = 103

--rename a column name
exec sp_rename 'table1.field2', person_name,'column'

update table1 set person_name = 'hari' where person_name like('%1,2)')
update table1 set person_name = 'hari' where person_name like('%1,2)')

select * from table1