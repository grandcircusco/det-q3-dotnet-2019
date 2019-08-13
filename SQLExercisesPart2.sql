--CREATE DATABASE BoxOfficeDb
--use BoxOfficeDb

--CREATE TABLE Ticket(
--	Id int PRIMARY KEY NOT NULL IDENTITY(5,5),
--	Seat nvarchar(20) NOT NULL,
--	Price int NOT NULL,
--	NumSold int NOT NULL
--);

--INSERT INTO Ticket(Seat, Price, NumSold)
--Values('Box Level', 105, 4),
--('Dress Circle', 75, 2),
--('Main Floor', 58, 10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19, 3)

----counting how many objects (or rows) are in the Ticket Table
--SELECT COUNT(*) FROM Ticket

----counting how many objects (or rows) have !0 tickets sold
--SELECT COUNT(*) FROM Ticket WHERE NumSold<>0;

--SELECT AVG(NumSold) FROM Ticket;

--select * from ticket

SELECT SUM(NumSold) as 'Total Sold', SUM(Price * NumSold) as 'Total Revenue'
from Ticket 

