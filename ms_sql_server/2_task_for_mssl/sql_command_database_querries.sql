create database MS_sql_commands --create database
use MS_sql_commands --use database
create table sql_commands(Slno int identity(1, 1), syntax varchar(100), description_ varchar(8000)) --create table
sp_help sql_commands	--to see table structure
alter table sql_commands add example varchar(1000)
insert into sql_commands values('create database <database_name>', 'To create new database', 'create database MS_sql_commands')
select * from sql_command

insert into sql_commands values('use <database_name>', 'To use the created database name', 'use MS_sql_commands')

alter table sql_commands alter column syntax varchar(1000)	--update data type of a field

insert into sql_commands values('create table <table_name>(<field_name1> <datatype>, <field_name2> <datatype>, <field_name3> <datatype>, ...)', 'To create new table in the selected database', 'create table sql_commands(Slno int identity(1, 1), syntax varchar(100), description_ varchar(8000))')

insert into sql_commands values('sp_help <table_name>', 'To view the structure(fields, datatypes, etc...) of the table', 'sp_help sql_commands'),
('INSERT INTO <table_name> (<field_name1>, <field_name2>, <field_name3>, ...) VALUES(<record 1>, <record 1>, <record 1>, ... )', 'To insert one record(one row)', 'INSERT INTO table1(eid, ename, esal) values(101, "hariharan", "10000")')

insert into sql_commands values('INSERT INTO <table_name> VALUES(<record 1>, <record 1>, <record 1>, ... )', 'if you are adding values for all the columns of the table you dont need to specify the column names in the sl query, However, make sure the order of the values is in the same order as the columns in the table', 'INSERT INTO table1 VALUES(101, "hariharan", "10000")')

alter table sql_commands add pupose varchar(1000) --add new field(columnn)

update sql_commands set purpose = 'create database and table' where Slno<9

exec sp_rename 'sql_commands.pupose', 'purpose', 'column'

update sql_commands set purpose = 'create database and table' where Slno<9
update sql_commands set purpose = 'view table structure' where Slno=9
update sql_commands set purpose = 'insert field' where Slno>9
insert into sql_commands(syntax, purpose) values('UPDATE <table_name> SET <column_name> = <value> WHERE <condition>','update record data')
insert into sql_commands(syntax, purpose) values('EXEC SP_RENAME "<table_name.column_name>", "<new_column_name>","column"','update field data')
insert into sql_commands(syntax, purpose) values('ALTER TABLE <table_name> ALTER COLUMN <field_name> <datatype>','update data type of a field')
alter table sql_commands alter column syntax varchar(1000)

delete from sql_commands where Slno = 17
update sql_commands set purpose = NULL where slno = 16

insert into sql_commands(syntax, purpose) values('UPDATE <table_name> SET <column_name> = NULL WHERE <condition>','Delete a record')
insert into sql_commands(syntax, purpose) values('DELETE FROM <table_name> WHERE <condition>','Delete a row')
update sql_commands set purpose = 'Delete a data' where Slno = 18
update sql_commands set purpose = 'Delete a record(row)' where Slno = 19
insert into sql_commands(syntax, purpose) values('ALTER TABLE <table_name> ALTER COLUMN <field_name> <data_type>', 'ADD new column')
ALTER table sql_commands add catogory varchar(1000)
update sql_commands set syntax = 'ALTER TABLE <table_name> ADD <field_name> <data_type>' where Slno = 20

ALTER TABLE sql_commands DROP COLUMN catogory	--to delete column

insert into sql_commands(syntax, purpose) values('ALTER TABLE <table_name> DROP COLUMN <column_name>', 'Delete a column(field)')

--where
insert into sql_commands (syntax, purpose) values('SELECT * FROM <table_name> WHERE <condition>', 'get specific data')
--where like
select * from sql_querries where syntax like ('%>')
insert into sql_commands(syntax, purpose) values('SELECT * FROM <table_name> WHERE <column_name> LIKE("_%_")', 'Like')

sp_rename 'sql_commands', sql_querries --update table name
insert into sql_querries(syntax, purpose) values('SP_RENAME "<current_table_name>", "<new_table_name>"', 'update table name')
sp_help sql_querries
--aggregate function
select max(Slno) from sql_querries
insert into sql_querries(syntax, purpose) values('SELECT MAX(<col_name>) FROM <table_name>', 'get maximum value')
insert into sql_querries(syntax, purpose) values('SELECT MAX(<col_name>) FROM <table_name>', 'get maximum value'),
('SELECT MIN(<col_name>) FROM <table_name>', 'get minimum value'),
('SELECT AVG(<col_name>) FROM <table_name>', 'get average values'),
('SELECT COUNT(<col_name>) FROM <table_name>', 'get no.of values'),
('SELECT SUM(<col_name>) FROM <table_name>', 'get sum of values')

--AUTO INCR

select * from sql_querries