create database GameServerDB

use GameServerDB
go

create table admintbl
(
userid int identity(1,1) primary key,
username varchar(50),
upass varchar(50),
fullname varchar(50)
)
select * from admintbl

INSERT INTO admintbl (username, upass, fullname) 
VALUES ('navin98', '123', 'Nawshin Navin');
