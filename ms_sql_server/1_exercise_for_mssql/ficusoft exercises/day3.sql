--day3
--group by clause
select count(cid) as no_of_customers, purchase_item from sales group by purchase_item
select count(*) as no_of_customers, purchase_item from sales group by purchase_item

select sum(price) as no_of_customers, purchase_item from sales group by purchase_item

--having clause
--we can't use HAVING clause when it is not contained in either an aggregate function or the GROUP BY clause
--having clause used to filter output
select sum(price) as no_of_customers, purchase_item from sales group by purchase_item having sum(price)>=260000

--order by
select price, cid as id, purchase_item from sales where price>30000 order by price asc
select price, cid as id, purchase_item from sales where price>30000 order by price desc
select sum(price) as no_of_customers, purchase_item from sales group by purchase_item having sum(price)>=260000 order by sum(price) asc

--top
select top 3 cname from sales
select top 3 cname, cid from sales
select top 3 max(price), cname from sales group by cname
select top 3 max(price), purchase_item from sales group by purchase_item having purchase_item != 'fridge' order by max(price) asc
select top 3 price from sales order by price desc --first decending then select

insert into sales values('jeeva', 'washing_mechine', 80000)
alter table sales alter column cid varchar


--distinct
--it shows output without douplicate value
select distinct(purchase_item) from sales
select count(distinct(purchase_item)) from sales

--pre defined functions
--string
select upper('hello') --to change uppercase
select lower('HeLLo WORLD')	--to change lower case
select cid, upper(cname), upper(purchase_item), price, upper(location) from sales
--to get length of string
select len(cname), cname from sales
select * from sales where len(cname)<=4

--replace
select replace('HELLO hello', 'llo', 'xx')
select replace(purchase_item, 'tv', 'TV') FROM sales --rename how it works doubt

--replicate
select replicate('hello ', 3)
--substring
select substring ('hello world', 2, 8)
--reverse
select reverse('hello world')

--date function
alter table sales add _date date
alter table sales alter column _date datetime
ALTER TABLE sales ALTER COLUMN _date DATE
update sales set _date = '12-10-2022' where cid in(1,2)
update sales set _date = '29-mar-2022' where cid in(3,4)

--getdate() <to get current date and time>
select getdate()
update sales set _date = getdate() where cid>4 and cid<7
select year(getdate()) -- get only year from getdate() function
select month(getdate()) -- get only month from getdate() function
select day(getdate()) -- get only date from getdate() function
select datename(dw, getdate()) --get current day from datename() functionn

select year(_date), _date from sales --get only year from record data
select _date, month(_date) as month, day(_date) as date, datename(dw, _date) as day from sales --get only month, date, day from record data

select datename(year, _date), _date from sales	--get only year from datename() function
select datename(month, _date), _date from sales	--get only month from datename() function
select datename(mm, _date), _date from sales	--get only month from datename() function
select datename(dayofyear, getdate()), getdate() --get completed days in the year
select datename(dayofyear, _date), _date from sales

--dateadd() function
--dateadd() function adds a time/date interval to a date and then returns the date
--Syntax: DATEADD(interval, number, date)
select dateadd(year, 2, getdate()) --add years
select dateadd(year, 10, _date) as newdate, _date as original_date from sales
select dateadd(month, 4, getdate()) --add months
select dateadd(day, 20, getdate()) --add date
select dateadd(week, 1, getdate()) --add week
select dateadd(hour, 1, getdate()) --add hour
select dateadd(minute, 10, getdate()) --add minute,(second, millisecond)

--datediff() function
--DATEDIFF() function returns the difference between two dates
--SYNTAX: DATEDIFF(interval, date1, date2) ==>return (date2-date1)
select datediff(day, dop, getdate()) from sales

--find 2023 new year day
select datename(dw, '01-01-2023') as day
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
--task
--1
alter table sales drop column _date
alter table sales add dop date
update sales set dop = null
update sales set dop = '20-jan-2000' where cid%3 = 0
update sales set dop = '10-may-2021' where cid/2 = 0 and dop is null
update sales set dop = '10-may-2021' where cid%5 = 0 and dop is null
update sales set dop = getdate() where dop is null
select * from sales
select * from sales where dop is null
--2
select purchase_item, max(price) as max_price from sales group by purchase_item
--3
select purchase_item, min(price) as min_price from sales group by purchase_item having min(price)<=20000
--4
select distinct(purchase_item) as Products from sales
select distinct(purchase_item) as Products from sales order by purchase_item asc
--5
select * from sales where year(dop) = 2021
select * from sales where year(dop) = 2021 order by price desc
--6
select * from sales where year(dop) = year(getdate()) order by cname asc --who are all purchase in current year
--7
update sales set month(dop) = '10' where cid%2 = 0 -------------------------------------------doubt
update sales set dop = dateadd(month, 10, dateadd(month, -month(dop), dop)) where cid%2 = 0 --to put october(10) month
select * from sales where month(dop) = '10' order by cid asc --who are all purchase in oct month
--8
select * from sales where month(dop)='10' and year(dop)=year(getdate()) -- who are all purchase in current year oct month
--9
alter table sales add warrenty_period int
update sales set warrenty_period = 5 where purchase_item= 'tv'
update sales set warrenty_period = 4 where purchase_item = 'ac'
update sales set warrenty_period = 5 where purchase_item = 'fridge'
update sales set warrenty_period = 5 where purchase_item = 'washing_mechine'

select * from sales where datediff(year, dop, getdate()) > warrenty_period --warrenty period completed customers

select * from sales