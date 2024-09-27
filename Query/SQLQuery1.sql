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
VALUES ('admin', '123', 'Nawshin Navin');

-----------------------------------------------------

create table gamestbl
(
gameID int identity(1,1) primary key,
gameName varchar(200),
gameDesc varchar(200),
gameprice float,
categoryID int,
gameImage image,
releaseDate date
)

select * from gamestbl
----------------------------------------------------
create proc sp_addGame
(
@gameName varchar(200),
@gameDesc varchar(200),
@gameprice float,
@categoryID int,
@gameImage image,
@releaseDate date
)
as
begin
insert into gamestbl(gameName,gameDesc,gameprice,categoryID,gameImage,releaseDate) values(@gameName,@gameDesc,@gameprice,@categoryID,@gameImage,@releaseDate)
end
go

select g.gameID, g.gameName, g.gameDesc, g.gameprice, g.categoryID, g.gameImage, g.releaseDate from gamestbl g inner join categorytbl c on c.catID = g.categoryID where g.gameName
-----------------------------------------------------

create proc sp_updateGame
(
@gameID int = 0,
@gameName varchar(200) = null,
@gameDesc varchar(200) = null,
@gameprice float = null,
@categoryID int = null,
@gameImage image = null,
@releaseDate date = null
)
as
begin
update gamestbl set gameName = @gameName,gameDesc = @gameDesc,gameprice = @gameprice,categoryID = @categoryID,gameImage = @gameImage,releaseDate = @releaseDate where gameID = @gameID
end
go
-----------------------------------------------------
create proc sp_deleteGame
(
@gameID int = 0
)
as
begin
delete from gamestbl where gameID = @gameID
end
go
-----------------------------------------------------
create table categorytbl
(
catID int identity(1,1) primary key,
catName varchar(50)
)

insert into categorytbl(catName) values('Racing')

select * from categorytbl
-----------------------------------------------------
create procedure sp_DeleteCategory
(
@catID int
)
as
begin
delete from categorytbl where catID = @catID
end
go
-----------------------------------------------------
CREATE PROCEDURE sp_AddCategory
(
    @catID INT = 0,
    @catName VARCHAR(50)
)
AS
BEGIN
    INSERT INTO categorytbl(catName) VALUES(@catName);
END
GO

-----------------------------------------------------
create procedure sp_UpdateCategory
(
@catID int = 0,
@catName varchar(50) = null
)
as
begin
update categorytbl set catName = @catName where catID = @catID
end
go

-----------------------------------------------------
create procedure sp_LoadCategory
(
@catName varchar(50)
)
as
begin
select catID as id, catName as name from categorytbl where catName like '%' + @catName + '%'
end
go
---------------------------------------------------------
INSERT INTO gamestbl
(
    gameName,
    gameDesc,
    gameprice,
    categoryID,
    gameImage,
    releaseDate
)
VALUES
(
    'Test',
    'Test Description',
    99.99,
    3,
    NULL,
    '2021-06-2'
);
Select * from gamestbl

------------------------------------------

create table usertbl
(
userid int identity(1,1) primary key,
firstname varchar(50),
lastname varchar(50),
gender varchar(50),
email varchar(50),
username varchar(50),
upass varchar(50),
dob date
)

select * from usertbl
---------------------------------------------
insert into usertbl (firstname, lastname, gender, email, username, upass, dob)
values ('Hero', 'Alom', 'Male', 'hero.alom@example.com', 'admin', '123', '1999-07-23')


create procedure sp_DeleteUser
(
@userid int
)
as
begin
delete from usertbl where userid = @userid
end
go
-------------------------------------------------

create procedure sp_DeleteAdmin
(
@userid int
)
as
begin
delete from admintbl where userid = @userid
end
go
-------------------------------------------
CREATE PROCEDURE sp_AddAdmin
(
    @username varchar(50),
	@upass varchar(50),
	@fullname varchar(50)
)
AS
BEGIN
    INSERT INTO admintbl(username,upass,fullname) VALUES(@username,@upass,@fullname)
END
GO
--------------------------------------------

CREATE PROCEDURE AddUser
(
@firstname varchar(50),
@lastname varchar(50),
@gender varchar(50),
@email varchar(50),
@username varchar(50),
@upass varchar(50),
@dob date
)
AS
BEGIN
    INSERT INTO usertbl(firstname, lastname, gender, email, username, upass, dob) VALUES(@firstname,@lastname,@gender,@email,@username,@upass,@dob)
END
GO

select * from usertbl