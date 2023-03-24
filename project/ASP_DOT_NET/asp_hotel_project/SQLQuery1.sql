create database hotelasp
use hotelasp
create table admininfo(admin_id int identity, admin_name varchar(50) not null, admin_email varchar(50) not null, admin_password varchar(8), conform_password varchar(8), mobile_no bigint)
sp_help admininfo
use hotelasp
alter table admininfo alter column admin_password varchar(50) not null
alter table admininfo alter column conform_password varchar(50) not null