create database hotel
use hotel
create table userinfo
(
uid int identity, 
uname varchar(100) not null, 
uemail varchar(100) not null unique, 
upswd varchar(16) not null check(len(upswd)>=8),
umobileno bigint check(len(umobileno)=10)
)

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
fid int not null,
fname varchar(100) not null unique,
ftype varchar(100) not null,
fprice money not null check(fprice>0),
favail bit not null
)
--alter table foodmenu alter column fid int unique

create table sales_record
(
billno int identity not null unique,
billdate datetime default getdate(),
fid int not null,
fname varchar(100) not null,
fprice money not null,
quantity int not null check(quantity>0),
amount money not null check(amount>0)
)

select * from userinfo
sp_help userinfo
sp_help admininfo
