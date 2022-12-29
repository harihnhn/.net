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