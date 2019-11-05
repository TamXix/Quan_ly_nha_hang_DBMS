
--drop database QUANLYNHAHANG
--go

create database QUANLYNHAHANG
go
USE QUANLYNHAHANG;
GO

CREATE TABLE FOODTYPE(
	IDTYPE INT IDENTITY,
	TYPENAME NVARCHAR(50) DEFAULT N'Food Type',
	CONSTRAINT PK_FOODTYPE PRIMARY KEY (IDTYPE)
)
go

CREATE TABLE FOOD(
	IDFOOD INT IDENTITY,
	FOODNAME NVARCHAR(50) NOT NULL DEFAULT N'Food Name',
	PRICE FLOAT NOT NULL DEFAULT 0,
	IDTYPE INT NOT NULL,
	CONSTRAINT PK_FOOD PRIMARY KEY(IDFOOD),
	CONSTRAINT FK_FOOD_FOODTYPE FOREIGN KEY(IDTYPE) REFERENCES FOODTYPE(IDTYPE)
)
GO

CREATE TABLE FOODSUPPLIER(
	IDSUP INT IDENTITY,
	SUPNAME NVARCHAR(50) NOT NULL DEFAULT N'Supplier Name',
	PHONENUMBER VARCHAR(20) NOT NULL,
	MAIL VARCHAR(50),
	ADDRESS NVARCHAR(50),
	IDTYPE INT NOT NULL,
	CONSTRAINT PK_SUP PRIMARY KEY(IDSUP),
	CONSTRAINT FK_SUP_FOODTYPE FOREIGN KEY(IDTYPE) REFERENCES FOODTYPE(IDTYPE)
)
GO

CREATE TABLE FOODTABLE(
	IDTABLE INT IDENTITY,
	NAME NVARCHAR(50) NOT NULL DEFAULT N'Name Table',
	STATUS INT NOT NULL DEFAULT 0,
	CONSTRAINT PK_FOODTABLE PRIMARY KEY(IDTABLE)
)
GO
CREATE TABLE EMPLOYEES(
	IDEMPLOYEE INT IDENTITY,
	NAME NVARCHAR(50) NOT NULL,
	SEX NVARCHAR(10) NOT NULL DEFAULT N'Nam',	
	DATEOFBIRTH DATE,
	IDENTITYCARD VARCHAR(20),
	ADDRESS NVARCHAR(50),
	PHONENUMBER VARCHAR(20),
	POSITION NVARCHAR(50) DEFAULT N'Nh�n vi�n',
	STARTDAY DATE NOT NULL,
	SALARY INT NOT NULL DEFAULT 0,
	CONSTRAINT PK_EMPLOYEES PRIMARY KEY(IDEMPLOYEE)

)
GO

CREATE TABLE ACCOUNT(
	USERNAME VARCHAR(20) NOT NULL,
	PASSWORD VARCHAR(20) NOT NULL DEFAULT '1',
	IDEMPLOYEE INT NOT NULL,
	ISADMIN INT NOT NULL DEFAULT '0'
	CONSTRAINT PK_ACCOUNT PRIMARY KEY(USERNAME),
	CONSTRAINT FK_ACCOUNT FOREIGN KEY(IDEMPLOYEE) REFERENCES EMPLOYEES(IDEMPLOYEE)
)
GO

CREATE TABLE BILL(
	IDBILL INT IDENTITY,
	IDTABLE INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0,
	DATECOME DATETIME NOT NULL,
	DATELEASE DATETIME NOT NULL,
	DISCOUNT FLOAT NOT NULL DEFAULT 0,
	TOTAL FLOAT NOT NULL DEFAULT 0,
	USERNAME VARCHAR(20) NOT NULL,
	CONSTRAINT PK_BILL PRIMARY KEY(IDBILL),
	CONSTRAINT FK_BILL_FOODTABLE FOREIGN KEY(IDTABLE) REFERENCES FOODTABLE(IDTABLE),
	CONSTRAINT FK_BILL_ACCOUNT FOREIGN KEY(USERNAME) REFERENCES ACCOUNT(USERNAME)
)
GO

CREATE TABLE BILLINFO(
	IDBILLINFO INT IDENTITY,
	IDBILL INT NOT NULL,
	IDFOOD INT NOT NULL,
	COUNT INT NOT NULL,
	CONSTRAINT PK_BILLINFO PRIMARY KEY(IDBILLINFO),
	CONSTRAINT FK_BILLINFO_FOOD FOREIGN KEY(IDFOOD) REFERENCES FOOD(IDFOOD),
	CONSTRAINT FK_BILLINFO_BILL FOREIGN KEY(IDBILL) REFERENCES BILL(IDBILL)
)

 CREATE TABLE VOUCHER(
	CODE VARCHAR(20) NOT NULL,
	VALUE INT NOT NULL DEFAULT 0,
	EXPIRATIONDATE DATE NOT NULL,
	CONSTRAINT PK_VOUCHER PRIMARY KEY(CODE)
)