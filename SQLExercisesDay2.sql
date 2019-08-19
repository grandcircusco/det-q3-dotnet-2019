--CREATE DATABASE GCCompanyDb;
--USE GCCompanyDb;

--CREATE TABLE Employee(
--	id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	employeeName nvarchar(20) NOT NULL,
--	salary real NOT NULL,
--	phoneNumber nchar(10)
--	);

--	Create Table Child(
--	childName nvarchar(50) PRIMARY KEY NOT NULL,
--	age int NOT NULL,	
--	);

--ALTER TABLE Child
--ADD EmployeeID int FOREIGN KEY REFERENCES Employee(id); 

--CREATE TABLE Department(
--DeptNumber int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--departmentName nvarchar(20) NOT NULL,
--Budget real NOT NULL,

--);

--CREATE TABLE DeptEmployee(
--deptEmpId int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--deptID int FOREIGN KEY REFERENCES Department(DeptNumber),
--EmpID int FOREIGN KEY REFERENCES Employee(id)
--);

--ALTER TABLE Department
--ADD ManagerEmpID int REFERENCES Employee(id)

