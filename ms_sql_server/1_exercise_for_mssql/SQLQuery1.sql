--To create database
create database hari_database

--to use the created database
use hari_database

--to create table
create table employee(eid int, ename varchar(20), esalary money, edept varchar(10))

--to view table details(not table data)
sp_help employee

--to insert data into created table
insert into employee values(101, 'hariharan', 40000, 'IT')

--to view all datas in a table
select * from employee

--to view particular column datas only
select eid, ename from employee

insert into employee values(104, 'hari', 30000, '.Net');

--to view data without repeat data
select distinct edept from employee

--TO COUNT 
--1. to count no.of data in a specific row
select count (edept) from employee

--2. to count no.of data(witout repeat) in a row
select count (distinct edept) from employee

--WHERE Clause
--where clause operators
select * from employee where edept='IT'		--(=) equal
select eid from employee where edept='IT'	--equal
select eid, ename from employee where edept='IT' --equal
select ename, esalary from employee where esalary>40000		--(>) greater than
select ename, esalary from employee where esalary<40000		--(<) less than
select ename, esalary from employee where esalary>=40000	--(>=) greater than or equal
select ename, esalary from employee where esalary<=40000	--(<=) lesser than or equal
select ename, esalary from employee where esalary!=40000	--(!=) not equal
select ename, esalary from employee where esalary<>40000	--(<>) not equal
select ename, esalary from employee where esalary between 35000 and 55000	--(between) between a certain range
select * from employee where ename like 'hari'	--(like) search exact data matches
select * from employee where ename like 'ha%'	--search starting with this data
select * from employee where edept in ('IT', '.Net')	--(in) to get multiple possible values of a column

select * from employee where edept='IT' and esalary>45000	--(and) operator
select * from employee where edept='IT' or esalary>45000	--(or) operator	
--(not) operator
select * from employee where not edept='IT'
select * from employee where not edept='IT' and esalary>45000
select * from employee where not (edept='IT' and esalary>45000)
select * from employee where not edept='IT' and not esalary>45000

--order by
select * from employee order by ename --default order (ascending order)
select * from employee order by ename asc --ascending order
select * from employee order by ename desc --descending order
select * from employee order by ename, esalary --order by several columns
select * from employee order by ename desc , esalary asc

--INSERT INTO
insert into employee (eid, ename, esalary, edept) values (105, 'navanith', 100000, 'IT')
insert into employee values(107,'ram', 30000, 'IT')
insert into employee (eid, ename) values (106, 'sanjay')

--null operator
select * from employee where edept is null --is null
select * from employee where edept is not null --is not null

--update statement
update employee set esalary=80000, edept='.Net' where (esalary is null)
update employee set esalary = 55000 where edept = 'IT'

--delete statement
delete from employee where ename='ram'
delete from employee	--it will delete all records in a table (without delete table)

--SELECT TOP, LIMIT, FETCH, FIRST or ROWNUM Clause
select top 3 * from employee --select top
select top 50 percent * from employee --to view 50% of top of the data
select top 2 * from employee where edept='IT'
select top 2 * from employee where esalary>45000



select * from employee;