--day 2
--where (and, or, not, in, between)
select * from sales where purchase_item in ('tv') and price in (100000)
--aggregate function
--avg()
--max()
--min()
--count()
--sum()
select max(price) from sales

CREATE table sample1(d1 int, d2 int)
insert into sample1 values(1,2)
select * from sample1
truncate table sample1 --delete all records in the table
drop table sample1	--delete the whole table

--task for 14-12-2022
--1
alter table sales add city varchar(100)
update sales set city ='chennai' where cid<=5
update sales set city ='madurai' where cid>5 and cid<=10
update sales set city ='tiruchi' where cid between 11 and 15
update sales set city = 'covai' where not cid<=15 or cid>20 --doubt wrong output

--2
exec sp_rename 'sales.city', 'location', 'column' --to change field name

--3
select * from sales where purchase_item in('fridge', 'washing_mechine', 'ac')
select * from sales where purchase_item in('fridge', 'washing_mechine', 'ac') order by cname asc

--4
select * from sales where price between 75000 and 100000 order by price asc

--5
select * from sales where cname like('a%') order by cname asc
select * from sales where cname like('_a%') order by cname asc
select * from sales where cname like('__r%') order by cname asc
select * from sales where cname like('%n') order by cname asc
select * from sales where cname like('%r__') order by cname asc

--6
select max(price) from sales where purchase_item = 'ac'
select max(price) as max_of_price, purchase_item from sales group by purchase_item having purchase_item = 'ac'

--7
select avg(price) as avg_of_price, purchase_item from sales group by purchase_item having purchase_item = 'ac'

--8
select sum(price) as chennai_sales from sales where location='chennai'
select sum(price) as chennai_sales, location from sales group by location having location='chennai'

---------------------------------------------------------------------