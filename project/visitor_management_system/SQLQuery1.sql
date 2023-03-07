create database visitors_record
use visitors_record
sp_help

sp_rename 'visitors_record' 'visitor_management_system'
alter database visitors_record modify name = visitor_management_system

create table visitors_record(
name varchar(100), 
gender varchar(10),
mobile bigint,
vendor varchar(100),
address varchar(200),
meeting_with varchar(100),
reason varchar(100),
visitor_card varchar(30),
time_in timestamp,
time_out timestamp,
time_spend timestamp,
status bool,


