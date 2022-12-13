--create database HHcustomer

--create table purchase_details(cid int, cname varchar(30), purchase_item varchar(50), price money)

--sp_help purchase_details

--insert into purchase_details values(101, 'hari', 'TV', 40000), 
--(102, 'haran', 'AC', 100000),
--(103, 'narah', 'TV', 80943),
--(104, 'irah', 'AC', 50765) 

--select*from purchase_details
--select * from purchase_details where purchase_item='TV'
select * from purchase_details where purchase_item='TV' and price>75000