USE [master]
GO
/****** Object:  Database [QUANLYNHAHANG]    Script Date: 2019-12-09 2:19:00 AM ******/
CREATE DATABASE [QUANLYNHAHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNHAHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MRXIX\MSSQL\DATA\QUANLYNHAHANG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYNHAHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MRXIX\MSSQL\DATA\QUANLYNHAHANG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QUANLYNHAHANG] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNHAHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNHAHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYNHAHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNHAHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYNHAHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNHAHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNHAHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNHAHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNHAHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYNHAHANG] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYNHAHANG', N'ON'
GO
ALTER DATABASE [QUANLYNHAHANG] SET QUERY_STORE = OFF
GO
USE [QUANLYNHAHANG]
GO
/****** Object:  Table [dbo].[FOODSUPPLIER]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOODSUPPLIER](
	[IDSUP] [int] IDENTITY(1,1) NOT NULL,
	[SUPNAME] [nvarchar](50) NOT NULL,
	[PHONENUMBER] [varchar](20) NOT NULL,
	[ADDRESS] [nvarchar](50) NULL,
 CONSTRAINT [PK_SUP] PRIMARY KEY CLUSTERED 
(
	[IDSUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FOODTYPE]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOODTYPE](
	[IDTYPE] [int] IDENTITY(1,1) NOT NULL,
	[TYPENAME] [nvarchar](50) NULL,
	[IDSUPPLIER] [int] NULL,
 CONSTRAINT [PK_FOODTYPE] PRIMARY KEY CLUSTERED 
(
	[IDTYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_FoodType_Supplier]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_FoodType_Supplier]
as
select IDTYPE, TYPENAME, IDSUP, SUPNAME
from FOODTYPE, FOODSUPPLIER
where FOODTYPE.IDSUPPLIER = FOODSUPPLIER.IDSUP
GO
/****** Object:  Table [dbo].[FOOD]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOOD](
	[IDFOOD] [int] IDENTITY(1,1) NOT NULL,
	[FOODNAME] [nvarchar](50) NOT NULL,
	[PRICE] [float] NOT NULL,
	[IDTYPE] [int] NOT NULL,
 CONSTRAINT [PK_FOOD] PRIMARY KEY CLUSTERED 
(
	[IDFOOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Food_FoodType]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VW_Food_FoodType]
as
select FOOD.IDFOOD, FOODNAME, FOOD.PRICE, FOOD.IDTYPE, FOODTYPE.TYPENAME
from FOOD, FOODTYPE
where FOOD.IDTYPE = FOODTYPE.IDTYPE
GO
/****** Object:  Table [dbo].[WORK]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORK](
	[IDWORK] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[SALARY] [int] NOT NULL,
 CONSTRAINT [PK_WORK] PRIMARY KEY CLUSTERED 
(
	[IDWORK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 2019-12-09 2:19:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[IDEMPLOYEE] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[SEX] [nvarchar](10) NOT NULL,
	[DATEOFBIRTH] [date] NULL,
	[IDENTITYCARD] [varchar](20) NULL,
	[ADDRESS] [nvarchar](50) NULL,
	[PHONENUMBER] [varchar](20) NULL,
	[SHIFT] [int] NOT NULL,
	[STARTDAY] [date] NOT NULL,
	[IDWORK] [int] NOT NULL,
	[BONUS] [int] NOT NULL,
	[SALARY] [int] NOT NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[IDEMPLOYEE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_EMPLOYEE_WORK]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[VW_EMPLOYEE_WORK]
as
select IDEMPLOYEE, EMPLOYEES.NAME as EmpName, SEX, DATEOFBIRTH, IDENTITYCARD,
	 ADDRESS, PHONENUMBER, STARTDAY, WORK.NAME as WorkName, SHIFT as CaLam, BONUS, EMPLOYEES.SALARY as TongLuong
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK
GO
/****** Object:  Table [dbo].[AREA]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AREA](
	[IDAREA] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AREA] PRIMARY KEY CLUSTERED 
(
	[IDAREA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FOODTABLE]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOODTABLE](
	[IDTABLE] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[STATUS] [int] NOT NULL,
	[IDAREA] [int] NOT NULL,
 CONSTRAINT [PK_FOODTABLE] PRIMARY KEY CLUSTERED 
(
	[IDTABLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[IDBILL] [int] IDENTITY(1,1) NOT NULL,
	[IDTABLE] [int] NOT NULL,
	[STATUS] [int] NOT NULL,
	[DATECOME] [datetime] NOT NULL,
	[DATELEASE] [datetime] NULL,
	[VOUCHERID] [int] NULL,
	[DISCOUNT] [float] NOT NULL,
	[TOTAL] [float] NOT NULL,
	[USERNAME] [varchar](20) NOT NULL,
 CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
(
	[IDBILL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ThongKe]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[VW_ThongKe]
as
select IDBILL, FOODTABLE.NAME as TenBan, AREA.NAME as KhuVuc, DATECOME as TgDen, DATELEASE as TgDi, DISCOUNT, TOTAL
from BILL, FOODTABLE, AREA
where FOODTABLE.IDAREA = AREA.IDAREA and BILL.IDTABLE = FOODTABLE.IDTABLE
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[USERNAME] [varchar](20) NOT NULL,
	[PASSWORD] [varchar](20) NOT NULL,
	[IDEMPLOYEE] [int] NOT NULL,
	[ISADMIN] [int] NOT NULL,
 CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILLINFO]    Script Date: 2019-12-09 2:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILLINFO](
	[IDBILLINFO] [int] IDENTITY(1,1) NOT NULL,
	[IDBILL] [int] NOT NULL,
	[IDFOOD] [int] NOT NULL,
	[COUNT] [int] NOT NULL,
 CONSTRAINT [PK_BILLINFO] PRIMARY KEY CLUSTERED 
(
	[IDBILLINFO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VOUCHER]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOUCHER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [varchar](20) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[VALUE] [int] NOT NULL,
	[STARTDAY] [date] NOT NULL,
	[EXPIRATIONDATE] [date] NOT NULL,
 CONSTRAINT [PK_VOUCHER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_BILL_DATECOME]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_BILL_DATECOME] ON [dbo].[BILL]
(
	[DATECOME] ASC
)
INCLUDE ( 	[IDBILL],
	[IDTABLE],
	[STATUS],
	[DATELEASE],
	[VOUCHERID],
	[DISCOUNT],
	[TOTAL],
	[USERNAME]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BILL_IDTABLE]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_BILL_IDTABLE] ON [dbo].[BILL]
(
	[IDTABLE] ASC
)
INCLUDE ( 	[IDBILL],
	[STATUS]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_IBILLINFO_IDBILL]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_IBILLINFO_IDBILL] ON [dbo].[BILLINFO]
(
	[IDBILL] ASC
)
INCLUDE ( 	[IDBILLINFO],
	[IDFOOD],
	[COUNT]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EMPLOYEE_SHIFT]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_EMPLOYEE_SHIFT] ON [dbo].[EMPLOYEES]
(
	[SHIFT] ASC
)
INCLUDE ( 	[IDEMPLOYEE],
	[NAME],
	[IDWORK],
	[SALARY]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EMPLOYEE_WORK]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_EMPLOYEE_WORK] ON [dbo].[EMPLOYEES]
(
	[IDWORK] ASC
)
INCLUDE ( 	[IDEMPLOYEE],
	[NAME],
	[SHIFT],
	[SALARY]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FOOD_NAME]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_FOOD_NAME] ON [dbo].[FOOD]
(
	[FOODNAME] ASC
)
INCLUDE ( 	[IDFOOD],
	[PRICE],
	[IDTYPE]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Voucher_CODE]    Script Date: 2019-12-09 2:19:03 AM ******/
CREATE NONCLUSTERED INDEX [IX_Voucher_CODE] ON [dbo].[VOUCHER]
(
	[CODE] ASC
)
INCLUDE ( 	[ID],
	[VALUE],
	[NAME],
	[STARTDAY],
	[EXPIRATIONDATE]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  DEFAULT ('1') FOR [PASSWORD]
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  DEFAULT ('0') FOR [ISADMIN]
GO
ALTER TABLE [dbo].[AREA] ADD  DEFAULT (N'AREA') FOR [NAME]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT ((0)) FOR [STATUS]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT ((0)) FOR [DISCOUNT]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT ((0)) FOR [TOTAL]
GO
ALTER TABLE [dbo].[EMPLOYEES] ADD  DEFAULT (N'Nam') FOR [SEX]
GO
ALTER TABLE [dbo].[EMPLOYEES] ADD  DEFAULT ((0)) FOR [SHIFT]
GO
ALTER TABLE [dbo].[EMPLOYEES] ADD  DEFAULT ((0)) FOR [BONUS]
GO
ALTER TABLE [dbo].[EMPLOYEES] ADD  DEFAULT ((0)) FOR [SALARY]
GO
ALTER TABLE [dbo].[FOOD] ADD  DEFAULT (N'Food Name') FOR [FOODNAME]
GO
ALTER TABLE [dbo].[FOOD] ADD  DEFAULT ((0)) FOR [PRICE]
GO
ALTER TABLE [dbo].[FOODSUPPLIER] ADD  DEFAULT (N'Supplier Name') FOR [SUPNAME]
GO
ALTER TABLE [dbo].[FOODTABLE] ADD  DEFAULT (N'Name Table') FOR [NAME]
GO
ALTER TABLE [dbo].[FOODTABLE] ADD  DEFAULT ((0)) FOR [STATUS]
GO
ALTER TABLE [dbo].[FOODTYPE] ADD  DEFAULT (N'Food Type') FOR [TYPENAME]
GO
ALTER TABLE [dbo].[VOUCHER] ADD  DEFAULT (N'Voucher') FOR [NAME]
GO
ALTER TABLE [dbo].[VOUCHER] ADD  DEFAULT ((0)) FOR [VALUE]
GO
ALTER TABLE [dbo].[VOUCHER] ADD  DEFAULT (getdate()) FOR [STARTDAY]
GO
ALTER TABLE [dbo].[WORK] ADD  DEFAULT ((0)) FOR [SALARY]
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT] FOREIGN KEY([IDEMPLOYEE])
REFERENCES [dbo].[EMPLOYEES] ([IDEMPLOYEE])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_ACCOUNT] FOREIGN KEY([USERNAME])
REFERENCES [dbo].[ACCOUNT] ([USERNAME])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_ACCOUNT]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_FOODTABLE] FOREIGN KEY([IDTABLE])
REFERENCES [dbo].[FOODTABLE] ([IDTABLE])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_FOODTABLE]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_VOUCHER] FOREIGN KEY([VOUCHERID])
REFERENCES [dbo].[VOUCHER] ([ID])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_VOUCHER]
GO
ALTER TABLE [dbo].[BILLINFO]  WITH CHECK ADD  CONSTRAINT [FK_BILLINFO_BILL] FOREIGN KEY([IDBILL])
REFERENCES [dbo].[BILL] ([IDBILL])
GO
ALTER TABLE [dbo].[BILLINFO] CHECK CONSTRAINT [FK_BILLINFO_BILL]
GO
ALTER TABLE [dbo].[BILLINFO]  WITH CHECK ADD  CONSTRAINT [FK_BILLINFO_FOOD] FOREIGN KEY([IDFOOD])
REFERENCES [dbo].[FOOD] ([IDFOOD])
GO
ALTER TABLE [dbo].[BILLINFO] CHECK CONSTRAINT [FK_BILLINFO_FOOD]
GO
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_WORK] FOREIGN KEY([IDWORK])
REFERENCES [dbo].[WORK] ([IDWORK])
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [FK_EMPLOYEE_WORK]
GO
ALTER TABLE [dbo].[FOOD]  WITH CHECK ADD  CONSTRAINT [FK_FOOD_FOODTYPE] FOREIGN KEY([IDTYPE])
REFERENCES [dbo].[FOODTYPE] ([IDTYPE])
GO
ALTER TABLE [dbo].[FOOD] CHECK CONSTRAINT [FK_FOOD_FOODTYPE]
GO
ALTER TABLE [dbo].[FOODTABLE]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_AREA] FOREIGN KEY([IDAREA])
REFERENCES [dbo].[AREA] ([IDAREA])
GO
ALTER TABLE [dbo].[FOODTABLE] CHECK CONSTRAINT [FK_TABLE_AREA]
GO
ALTER TABLE [dbo].[FOODTYPE]  WITH CHECK ADD  CONSTRAINT [FK_FOODTYPE_SUPPLIER] FOREIGN KEY([IDSUPPLIER])
REFERENCES [dbo].[FOODSUPPLIER] ([IDSUP])
GO
ALTER TABLE [dbo].[FOODTYPE] CHECK CONSTRAINT [FK_FOODTYPE_SUPPLIER]
GO
/****** Object:  StoredProcedure [dbo].[AddAccount]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddAccount]
	@UserName	varchar(20),
	@id			int,
	@IsAdmin	int
as
insert into ACCOUNT(USERNAME, IDEMPLOYEE, PASSWORD, ISADMIN)
			 values(@UserName, @id, '1', @IsAdmin)
GO
/****** Object:  StoredProcedure [dbo].[AddArea]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddArea]
	@name	nvarchar(20) = N'Area'
as
insert into AREA values (@name)
GO
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddEmployee]
	@ten		nvarchar(50),
	@goitinh	nvarchar(10) = N'Nam',
	@ngaysinh	date,
	@cmnd		varchar(10),
	@diachi		nvarchar(50),
	@sdt		varchar(20),
	@idcongviec int,
	@ca			int,
	@ngaybd		date,
	@tienthuong	int
as
insert into EMPLOYEES(NAME, SEX, DATEOFBIRTH, IDENTITYCARD,
	 ADDRESS, PHONENUMBER, IDWORK, SHIFT, STARTDAY, BONUS)
 values(@ten, @goitinh, @ngaysinh, @cmnd, @diachi, @sdt, @idcongviec, @ca, @ngaybd, @tienthuong)
GO
/****** Object:  StoredProcedure [dbo].[AddFood]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddFood]
	@FoodName	nvarchar(50),
	@Price		float,
	@IdType		int
as
insert into FOOD values(@FoodName, @Price, @IdType);
GO
/****** Object:  StoredProcedure [dbo].[AddFoodType]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddFoodType]
	@NewName	nvarchar(20),
	@idsup		int
as
insert into FOODTYPE values(@NewName, @idsup);
GO
/****** Object:  StoredProcedure [dbo].[AddSupplier]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddSupplier]
	@ten	nvarchar(200),
	@sdt	varchar(20),
	@diachi	nvarchar(200)
as
insert into FOODSUPPLIER( SUPNAME, PHONENUMBER, ADDRESS)
			values(@ten, @sdt, @diachi)
GO
/****** Object:  StoredProcedure [dbo].[AddTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddTable]
	@name	nvarchar(20) = N'Tên bàn',
	@idarea int
as
insert into FOODTABLE(NAME, IDAREA, STATUS)
			values(@name, @idarea, 0)
GO
/****** Object:  StoredProcedure [dbo].[AddWork]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddWork]
	@name	nvarchar(50) = N'Công việc',
	@luong	int = 0
as
insert into WORK(NAME, SALARY)
		values(@name, @luong)
GO
/****** Object:  StoredProcedure [dbo].[BillDetails]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BillDetails]
	@idbill		int
as
select FOOD.FOODNAME as tenmon, FOOD.PRICE, BILLINFO.COUNT, (FOOD.PRICE * BILLINFO.COUNT) as total
from BILL, BILLINFO, FOOD
where BILL.IDBILL = BILLINFO.IDBILL and BILLINFO.IDFOOD = FOOD.IDFOOD 
	and BILL.IDBILL = @idbill
GO
/****** Object:  StoredProcedure [dbo].[CheckOut]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckOut]
	@datelease	DATETIME,
	@discount	int,
	@totalprice	float
as
update BILL set DATELEASE = @datelease, DISCOUNT = @discount, TOTAL = @totalprice, STATUS = 1;
GO
/****** Object:  StoredProcedure [dbo].[CheckOutTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckOutTable]
	@idtable int
as
update FOODTABLE set STATUS = 1
		where IDTABLE = @idtable;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAccount]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteAccount]
	@UserName varchar(20)
as
delete ACCOUNT where USERNAME = @UserName;
GO
/****** Object:  StoredProcedure [dbo].[DeleteArea]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteArea]
	@id		int
as
delete from AREA where IDAREA = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBill]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteBill]
	@idbill		int
as
DELETE FROM BILL Where IDBILL = @idbill;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBillInfo]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteBillInfo]
	@idbill		int,
	@idfood		int
as
delete BILLINFO 
where IDBILL = @idbill and IDFOOD = @idfood
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteEmployee]
	@id int
as
delete EMPLOYEES where IDEMPLOYEE = @id
GO
/****** Object:  StoredProcedure [dbo].[DeleteFoodType]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteFoodType]
	@IdType	int	
as
Delete FOODTYPE where IDTYPE = @IdType;
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplier]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteSupplier]
	@idsup	int
as
delete FOODSUPPLIER where IDSUP = @idsup;
GO
/****** Object:  StoredProcedure [dbo].[DeleteTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteTable]
	@id		int
as
delete from FOODTABLE where IDTABLE = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteVoucher]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteVoucher]
	@id	varchar(20)
as
delete VOUCHER where ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteWork]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteWork]
	@id int
as
delete WORK where IDWORK = @id;
GO
/****** Object:  StoredProcedure [dbo].[EditVoucher]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditVoucher]
	@id			int,
	@code		varchar(20),
	@name		nvarchar(50),
	@value		int,
	@hethan		date
as
update VOUCHER set CODE = @code, NAME = @name, VALUE = @value, EXPIRATIONDATE = @hethan
		where ID = @id;
GO
/****** Object:  StoredProcedure [dbo].[GetAccount]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAccount]
	@UserName varchar(20),
	@PassWord varchar(20)
as
select ACCOUNT.USERNAME, ACCOUNT.PASSWORD, EMPLOYEES.NAME, ACCOUNT.IDEMPLOYEE, 
	ACCOUNT.ISADMIN, SEX, PHONENUMBER, DATEOFBIRTH, STARTDAY, IDENTITYCARD, ADDRESS, WORK.NAME as WorkName, SHIFT, STARTDAY,
	EMPLOYEES.SALARY 
from ACCOUNT, EMPLOYEES, WORK
where USERNAME = @UserName and PASSWORD = @PassWord and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
	and EMPLOYEES.IDWORK = WORK.IDWORK
GO
/****** Object:  StoredProcedure [dbo].[GetBillInfosByIDBill]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetBillInfosByIDBill]
	@idbill	int
as
select * from BILLINFO where IDBILL = @idbill;
GO
/****** Object:  StoredProcedure [dbo].[GetCountByIDFood]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetCountByIDFood]
	@idfood		int,
	@idbill		int
as
select BILLINFO.COUNT
from BILLINFO
where IDBILL = @idbill and IDFOOD = @idfood
GO
/****** Object:  StoredProcedure [dbo].[GetFoodsByIDType]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetFoodsByIDType]
	@Idtype int
as
select * from FOOD where IDTYPE = @Idtype;
GO
/****** Object:  StoredProcedure [dbo].[GetImployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetImployee]
	@Id		int
as
select * from EMPLOYEES
		where IDEMPLOYEE = @Id;
GO
/****** Object:  StoredProcedure [dbo].[GetListAccount]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListAccount]
as
select USERNAME, ACCOUNT.IDEMPLOYEE, EMPLOYEES.NAME, ISADMIN 
from ACCOUNT, EMPLOYEES
WHERE ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
GO
/****** Object:  StoredProcedure [dbo].[GetListArea]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListArea]
as
select * from AREA;
GO
/****** Object:  StoredProcedure [dbo].[GetListEMP]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListEMP]
as
select * from EMPLOYEES
GO
/****** Object:  StoredProcedure [dbo].[GetListEmployeeByIdWork]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListEmployeeByIdWork]
	@idwork	int
as
select EMPLOYEES.IDEMPLOYEE, EMPLOYEES.NAME, EMPLOYEES.SHIFT, WORK.SALARY
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK and WORK.IDWORK = @idwork
GO
/****** Object:  StoredProcedure [dbo].[GetListEmployeeByShift]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListEmployeeByShift]
	@calam	int
as
select EMPLOYEES.IDEMPLOYEE, EMPLOYEES.NAME, WORK.NAME as WorkName, WORK.SALARY
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK and EMPLOYEES.SHIFT = @calam
GO
/****** Object:  StoredProcedure [dbo].[GetListFood]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListFood]
as
select * from VW_Food_FoodType
GO
/****** Object:  StoredProcedure [dbo].[GetListFoodType]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListFoodType]
as
select FOODTYPE.IDTYPE, FOODTYPE.TYPENAME, FOODTYPE.IDSUPPLIER, FOODSUPPLIER.SUPNAME
from FOODTYPE, FOODSUPPLIER
where FOODSUPPLIER.IDSUP = FOODTYPE.IDSUPPLIER
GO
/****** Object:  StoredProcedure [dbo].[GetListImployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListImployee]
	@colname AS sysname,
	@sorttype bit = 1
as
select * from VW_EMPLOYEE_WORK
ORDER BY
 CASE WHEN @colname = N'IDEMPLOYEE' AND @sorttype = 1
	THEN IDEMPLOYEE END,
 CASE WHEN @colname = N'empname' AND @sorttype = 1
	THEN  EmpName END,
 CASE WHEN @colname = N'SEX' AND @sorttype = 1
	THEN SEX END,
 CASE WHEN @colname = N'DATEOFBIRTH' AND @sorttype = 1
	THEN DATEOFBIRTH END,
 CASE WHEN @colname = N'STARTDAY' AND @sorttype = 1
	THEN STARTDAY END,
 CASE WHEN @colname = N'WorkName' AND @sorttype = 1
	THEN CaLam END,
 CASE WHEN @colname = N'BONUS' AND @sorttype = 1
	 THEN BONUS END,
 CASE WHEN @colname = N'TongLuong' AND @sorttype = 1
	THEN TongLuong END,
 CASE WHEN @colname = N'CaLam' AND @sorttype = 1
	THEN CaLam END,
  CASE WHEN @colname = N'IDEMPLOYEE' AND @sorttype = 0
	THEN IDEMPLOYEE END DESC,
 CASE WHEN @colname = N'empname' AND @sorttype = 0
	THEN EmpName END DESC,
 CASE WHEN @colname = N'SEX' AND @sorttype = 0
	THEN SEX END DESC,
 CASE WHEN @colname = N'DATEOFBIRTH' AND @sorttype = 0
	THEN DATEOFBIRTH END DESC,
 CASE WHEN @colname = N'STARTDAY' AND @sorttype = 0
	THEN STARTDAY END DESC,
 CASE WHEN @colname = N'WorkName' AND @sorttype = 0
	THEN CaLam END DESC,
 CASE WHEN @colname = N'BONUS' AND @sorttype = 0
	THEN BONUS END DESC,
 CASE WHEN @colname = N'TongLuong' AND @sorttype = 0
	THEN TongLuong END DESC,
 CASE WHEN @colname = N'CaLam' AND @sorttype = 0
	THEN CaLam END DESC
 OPTION (RECOMPILE);
 
GO
/****** Object:  StoredProcedure [dbo].[GetListOrder]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListOrder]
	@idtable int
as
SELECT f.FOODNAME, bi.COUNT, f.PRICE, f.PRICE*bi.COUNT AS totalPrice 
FROM BILLINFO AS bi, BILL AS b, FOOD AS f
WHERE bi.IDBILL = b.IDBILL AND bi.IDFOOD = f.IDFOOD 
		AND b.STATUS = 0 AND b.IDTABLE = @idtable
GO
/****** Object:  StoredProcedure [dbo].[GetListOrderedByIDTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListOrderedByIDTable]
	@Idtable int
as
select FOODNAME, COUNT, PRICE, PRICE*COUNT as TotalPrice
from BILLINFO, BILL, FOOD
where BILL.IDBILL = BILLINFO.IDBILL 
	and BILLINFO.IDFOOD = FOOD.IDFOOD and BILL.IDTABLE = IDTABLE;
GO
/****** Object:  StoredProcedure [dbo].[GetListSupplier]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListSupplier]
as
select FOODSUPPLIER.IDSUP, FOODSUPPLIER.SUPNAME, 
		 FOODSUPPLIER.PHONENUMBER, FOODSUPPLIER.ADDRESS
from FOODSUPPLIER
GO
/****** Object:  StoredProcedure [dbo].[GetListTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListTable]
as
select * from FOODTABLE
order by IDAREA, NAME
GO
/****** Object:  StoredProcedure [dbo].[GetListWork]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListWork]
as
select * from WORK;
GO
/****** Object:  StoredProcedure [dbo].[GetMaxIDBill]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaxIDBill]
as
select max(IDBILL) as idbill from BILL;
GO
/****** Object:  StoredProcedure [dbo].[GetNameEmployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetNameEmployee]
	@idbill int
as
select EMPLOYEES.NAME 
from BILL, EMPLOYEES, ACCOUNT
where BILL.IDBILL = @idbill and BILL.USERNAME = ACCOUNT.USERNAME
	 and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
GO
/****** Object:  StoredProcedure [dbo].[GetNameVoucher]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetNameVoucher]
	@idbill	int
as
select VOUCHER.NAME
from VOUCHER, BILL
where BILL.IDBILL = @idbill and BILL.VOUCHERID = VOUCHER.ID
GO
/****** Object:  StoredProcedure [dbo].[GetTableInfo]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetTableInfo]
as
select IDTABLE, FOODTABLE.NAME, FOODTABLE.IDAREA, AREA.NAME, FOODTABLE.STATUS
from FOODTABLE, AREA
where FOODTABLE.IDAREA = AREA.IDAREA
GO
/****** Object:  StoredProcedure [dbo].[GetUnpaidBillID]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetUnpaidBillID]
	@idtable	int
as
select IDBILL from BILL where IDTABLE = @idtable and STATUS = 0
GO
/****** Object:  StoredProcedure [dbo].[GetVoucher]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetVoucher]
	@code	varchar(20)
as
select * from VOUCHER
where CODE = @code;
GO
/****** Object:  StoredProcedure [dbo].[InSertBill]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InSertBill]
	@idtable	int,
	@username	varchar(50)
 as
 insert into BILL values(@idtable, 0, GETDATE(), null, null, 0, 0, @username);
GO
/****** Object:  StoredProcedure [dbo].[InsertBillInfo]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertBillInfo]
	@idbill		int,
	@idfood		int,
	@count		int
as
insert into BILLINFO values(@idbill, @idfood, @count)
GO
/****** Object:  StoredProcedure [dbo].[InsertVoucher]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertVoucher]
	@code		varchar(20),
	@name		nvarchar(50),
	@value		int,
	@hethan		date
as
insert into VOUCHER(CODE, NAME, VALUE, EXPIRATIONDATE) 
				values (@code, @name, @value, @hethan);
GO
/****** Object:  StoredProcedure [dbo].[isBillNull]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[isBillNull]
	@idbill		int
as
SELECT * FROM BILLINFO WHERE BILLINFO.IDBILL = @idbill;
GO
/****** Object:  StoredProcedure [dbo].[MoreInfo]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MoreInfo]
	@idbill		int
as
select EMPLOYEES.NAME, VOUCHER.NAME
from BILL, VOUCHER, EMPLOYEES, ACCOUNT
where BILL.VOUCHERID = VOUCHER.ID and BILL.USERNAME = ACCOUNT.USERNAME
	 and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
GO
/****** Object:  StoredProcedure [dbo].[Pay]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pay]
	@idbill			int,
	@idtable		int,
	@idvoucher		int,
	@giamgia		int,
	@tongtien		float
as
begin try
	begin tran

		if @idvoucher = -1
			begin
				update BILL set STATUS = 1, DATELEASE = GETDATE(), TOTAL = @tongtien
					where IDBILL = @idbill;
				update FOODTABLE set STATUS = 0
					where IDTABLE = @idtable;

			end
		else
			begin
				update BILL set STATUS = 1, DATELEASE = GETDATE(), DISCOUNT = @giamgia,
						TOTAL = @tongtien, VOUCHERID = @idvoucher
					where IDBILL = @idbill;
				update FOODTABLE set STATUS = 0
					where IDTABLE = @idtable;
			end

	commit tran
end try
begin catch
	print N'Lỗi trong quá trình thanh toán!'
	rollback tran
end catch

--
--Tạo store proc GopBan
if OBJECT_ID('GopBan') is not null
	drop proc GopBan;
GO
/****** Object:  StoredProcedure [dbo].[ResetPassword]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ResetPassword]
	@UserName varchar(20)
as 
update ACCOUNT set PASSWORD ='1'
				where USERNAME = @UserName;
GO
/****** Object:  StoredProcedure [dbo].[SearchFood]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchFood]
	@foodname nvarchar(50) ='%'
as
begin
	--declare @name nvarchar(50) = 'N'%'' + @foodname + ''%'';
	select * from FOOD where FOODNAME like CONCAT(N'%', @foodname, '%')
end

GO
/****** Object:  StoredProcedure [dbo].[SwitchIDBill]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SwitchIDBill]
	@srcbill	int,
	@dstbill	int
as
update BILLINFO set IDBILL = @dstbill 
where IDBILL = @srcbill
GO
/****** Object:  StoredProcedure [dbo].[ThongKe]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKe]
	@datefrom	datetime,
	@dateto		datetime,
	@colname AS sysname,
	@sorttype bit = 1
as
select * from VW_ThongKe
where TgDen >= @datefrom and TgDi <= @dateto
ORDER BY
 CASE WHEN @colname = N'IDBILL' AND @sorttype = 1
	THEN IDBILL END,
 CASE WHEN @colname = N'tenban' AND @sorttype = 1
	THEN TenBan END,
 CASE WHEN @colname = N'khuvuc' AND @sorttype = 1
	THEN KhuVuc END,
 CASE WHEN @colname = N'tgden' AND @sorttype = 1
	THEN TgDen END,
 CASE WHEN @colname = N'DISCOUNT' AND @sorttype = 1
	THEN DISCOUNT END,
 CASE WHEN @colname = N'TOTAL' AND @sorttype = 1
	THEN TOTAL END,
 CASE WHEN @colname = N'IDBILL' AND @sorttype = 0
	THEN IDBILL END DESC,
 CASE WHEN @colname = N'tenban' AND @sorttype = 0
	THEN TenBan END DESC,
 CASE WHEN @colname = N'khuvuc' AND @sorttype = 0
	THEN KhuVuc END DESC,
 CASE WHEN @colname = N'tgden' AND @sorttype = 0
	THEN TgDen END DESC,
 CASE WHEN @colname = N'DISCOUNT' AND @sorttype = 0
	THEN DISCOUNT END DESC,
 CASE WHEN @colname = N'TOTAL' AND @sorttype = 0
	THEN TOTAL END DESC
 OPTION (RECOMPILE);

GO
/****** Object:  StoredProcedure [dbo].[UpdateArea]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateArea]
	@id		int,
	@name	nvarchar(20)
as
update AREA set NAME = @name 
				where IDAREA = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCount]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateCount]
	@idbill		int,
	@idfood		int,
	@count		int
as
update BILLINFO set COUNT = @count
where IDBILL = @idbill and IDFOOD = @idfood
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateEmployee]
	@idemployee		int,
	@ten		nvarchar(50),
	@goitinh	nvarchar(10) = N'Nam',
	@ngaysinh	date,
	@cmnd		varchar(10),
	@diachi		nvarchar(50),
	@sdt		varchar(20),
	@idcongviec int,
	@ca			int,
	@ngaybd		date,
	@tienthuong	int
as
update EMPLOYEES set NAME = @ten, SEX = @goitinh, DATEOFBIRTH = @ngaysinh,
 IDENTITYCARD = @cmnd, ADDRESS = @diachi, PHONENUMBER = @sdt, 
 IDWORK = @idcongviec, SHIFT = @ca, STARTDAY = @ngaybd, BONUS = @tienthuong
where IDEMPLOYEE = @idemployee
GO
/****** Object:  StoredProcedure [dbo].[UpdateFood]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateFood]
	@IdFood		int,
	@NewName	nvarchar(50),
	@NewIdType	int,
	@newPrice	float
as
update FOOD set FOODNAME = @NewName, IDTYPE = @NewIdType, PRICE = @newPrice
			where IDFOOD = @IdFood;
GO
/****** Object:  StoredProcedure [dbo].[UpdateFoodType]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateFoodType]
	@IdType		int,
	@NewName	nvarchar(50),
	@idsup		int
as
update FOODTYPE set TYPENAME = @NewName, IDSUPPLIER = @idsup where IDTYPE = @IdType;
GO
/****** Object:  StoredProcedure [dbo].[UpdateInfo]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateInfo]
	@username	varchar(50),
	@oldpass	varchar(50),
	@newpass	varchar(50),
	@id			int,
	@hoten		nvarchar(50),
	@gioitinh	nvarchar(10),
	@cmnd		varchar(10),
	@diachi		nvarchar(50),
	@sdt		varchar(20),
	@ngaysinh	varchar(20)
as
begin
	update ACCOUNT set PASSWORD = @newpass 
		where PASSWORD = @oldpass and USERNAME = @username;

	update EMPLOYEES set NAME = @hoten, SEX = @gioitinh, IDENTITYCARD = @cmnd, 
			ADDRESS = @diachi, PHONENUMBER = @sdt, DATEOFBIRTH = @ngaysinh
	where IDEMPLOYEE = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSalary]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSalary]
	@idnhanvien	int
as
update EMPLOYEES set EMPLOYEES.SALARY = 
	(select EMPLOYEES.BONUS + WORK.SALARY
	from EMPLOYEES, WORK
	where EMPLOYEES.IDWORK = WORK.IDWORK and EMPLOYEES.IDEMPLOYEE = @idnhanvien)
	where IDEMPLOYEE = @idnhanvien
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSupplier]
	@idsup	int,
	@ten	nvarchar(200),
	@sdt	varchar(20),
	@diachi	nvarchar(200)
as
update FOODSUPPLIER set SUPNAME = @ten,
		PHONENUMBER = @sdt, ADDRESS = @diachi
		where IDSUP = @idsup;
GO
/****** Object:  StoredProcedure [dbo].[UpdateTable]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateTable]
	@id		int,
	@name	nvarchar(20),
	@idarea int
as
update FOODTABLE set NAME = @name , IDAREA = @idarea
				where IDTABLE = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateWork]    Script Date: 2019-12-09 2:19:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateWork]
	@id		int,
	@name	nvarchar(50),
	@luong	int
as
update WORK set NAME = @name, SALARY = @luong 
				where IDWORK = @id;
GO
USE [master]
GO
ALTER DATABASE [QUANLYNHAHANG] SET  READ_WRITE 
GO
