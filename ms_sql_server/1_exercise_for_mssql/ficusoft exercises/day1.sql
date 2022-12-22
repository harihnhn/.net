--create database
create database shop

use shop

create table sales(cid int identity, cname varchar(100), purchase_item varchar(1000), price money)

sp_help sales

insert into sales values('hari', 'tv', 100000)
insert into sales values('haran', 'tv', 75000), ('hariharan', 'tv', 90000), ('anbu', 'tv', 80000), ('arun', 'tv', 70000), ('arunkumar', 'tv', 60000),
('sneha', 'tv', 50000), ('jagan', 'tv', 30000)

insert into sales values('haran', 'ac', 75000), ('hariharan', 'tv', 90000), ('anbu', 'ac', 80000), ('arun', 'ac', 70000), ('arunkumar', 'ac', 60000),
('sneha', 'ac', 50000), ('jagan', 'ac', 30000)

insert into sales values('haran', 'fridge', 15000), ('hariharan', 'fridge', 10000), ('anbu', 'fridge', 20000), ('arun', 'fridge', 30000), ('arunkumar', 'fridge', 40000),
('sneha', 'fridge', 50000), ('jagan', 'fridge', 90000)

update sales set purchase_item='ac' where cid=10 --update record data

select * from sales where purchase_item='tv'
select * from sales where purchase_item='ac' and price>=75000
select * , (price/100)*10 from sales
select * , (price/100)*10 as discount from sales

SP_HELP --TO VIEW DATABASE DETAILS
