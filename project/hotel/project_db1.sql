create database hotel
use hotel

create table userinfo
(
uid int identity primary key,
uname varchar(100) not null,
uemail varchar(100) not null unique,
upswd varchar(16) not null check(len(upswd)>=8),
umobileno bigint check(len(umobileno)=10),
uwallet int default 0
)

select * from userinfo

create table admininfo
(
aid int identity,
aname varchar(100) not null,
aemail varchar(100) not null unique,
apswd varchar(16) not null check(len(apswd)>=8),
amobileno bigint check(len(amobileno)=10) unique not null
)

create table foodmenu
(
fid int not null primary key,
fname varchar(100) not null unique,
veg_or_nonveg char not null,
ftype varchar(100) not null,
fprice money check(fprice>0),
favail bit not null
)

create table cart
(
fid int not null foreign key references foodmenu(fid),
fname varchar(100) not null,
fprice money not null,
quantity int not null check(quantity>0),
amount money not null check(amount>0)
)

create table sales_record
(
billid int,
billdate datetime default getdate(),
uid int foreign key references userinfo(uid),
fid int not null foreign key references foodmenu(fid),
fname varchar(100) not null,
fprice money not null,
quantity int not null check(quantity>0),
amount money not null check(amount>0)
)

select * from sales_record where billdate >= '01-07-2023' and billdate <= '01-08-2023'
select * from sales_record where billdate < '01-08-2023' --not ok
select * from sales_record where billdate >= '01-07-2023' --ok

select * from sales_record