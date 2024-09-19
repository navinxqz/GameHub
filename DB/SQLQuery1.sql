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

create proc sp_addGame
(
@gameID int = 0,
@gameName varchar(200),
@gameDesc varchar(200),
@gameprice float,
@categoryID int,
@gameImage image,
@releaseDate date
)
as
begin
insert into gamestbl(gameID,gameName,gameDesc,gameprice,categoryID,gameImage,releaseDate) values(@gameID,@gameName,@gameDesc,@gameprice,@categoryID,@gameImage,@releaseDate)
end
go

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
create procedure sp_LoadCategory
as
begin
select catID, catName from categorytbl
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