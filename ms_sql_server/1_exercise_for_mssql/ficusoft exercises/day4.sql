--1. SUBQUERY
select * from sales where price = (select max(price) from sales)

--display all records of n th max price using subquery
--4 th max price
select * from sales where price = (
select min(price) from sales where price in(
select top 4 price from sales order by price desc))
order by cid asc

--display who are purchase grater than avg price
select * from sales where price > (
select avg(price) from sales)

--2. TCL (Transaction Control Language) -------------------------------------------------------DOUBT
--COMMIT(to save current transaction)
--ROLLBACK(undo or rollback for last transaction)
--SAVEPOINT(undo or rollback for already saved transaction)

--ROLLBACK
select * from sales
--without commit 
begin tran --to define it's a transaction
save tran t1
update sales set cname = '79. HH' where cid = 1
rollback --undo(it goes to previous begin transaction

--with commit
begin tran
save tran t2
update sales set cname = '7. Hari Haran C' where cid = 1
commit --when we commit the transaction we cant rollback

begin tran
rollback tran t2

--3. CONSTRAINT
--not null(it does not allow null values)
--check(to satisfy certain condition)
--default(we can set default value)
--unique (it does not allow douplicate value, it only one time allow null value)
--primary key(it does not allow douplicate value and null value)
--foreign key (one table foreign key is reference to another table primary key value)

--NOT NULL
alter table sales alter column cid smallint
update sales set cid = 0 where cid = 1
sp_help sales

alter table sales alter column id1 int
insert into sales(cname) values('hari')
update sales set id1 = 100
select * from sales
alter table sales drop column id1

--CHECK
alter table sales add id int check(id>0)
update sales set id = 1
alter table sales drop column id -----------------------------------------------------doubt why this column could not delete
exec sp_rename 'sales.id', 'ID11', 'column' ------------------------------------------doubt why i can't rename the check constrained column

alter table sales add id1 int check(id1>10)
alter table sales drop column id1 ----------------------------------------------------doubt why i can't delete check constrained column

--DEFAULT
alter table sales add name1 int default 100
select * from sales
insert into sales values('name1', 'remote', 60000, 'panruti', '05-20-1999', 9, 1, 11, 1001) -- doubt how it comes to top of the table
insert into sales(cname, purchase_item, price, location, dop, warrenty_period, id, id1) values('name1', 'remote', 60000, 'panruti', '05-20-1999', 9, 1, 11)

--UNIQUE
alter table sales add uni varchar(100) not null check(len(uni) > 9) --------------doubt why i couldn't put two constraints for one variable
alter table sales add uni varchar(100) unique

create table table1 (uni varchar(100) unique)
insert into table1 values('hariharan')
insert into table1 values(null)
select * from table1
alter table sales add uni2 int unique --why i can't put unique constraints on alter section
alter table sales alter column cname varchar(1000) unique -----------------------doubt((why i can't put unique constraints on alter section))


--we can't alter a contrainted column, if we want to alter that column we should first drop the constraint of that column
--1. to delete constraint in a column
alter table sales drop constraint [CK__sales__id1__48CFD27E] --[CK__sales__id1__48CFD27E] you can take this from (delete error msg), when you try to drop that column you can't then it shows a error msg 
----------------doubt((what is this code in above line what does it mean)

--2. 