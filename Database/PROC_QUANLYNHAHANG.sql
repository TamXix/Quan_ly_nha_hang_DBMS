USE QUANLYNHAHANG;


GO
--=====================TABLE ACCOUNT===============================

--Tạo proc get account để lấy thông tin tài khoản với username và password truyền vào
IF OBJECT_ID('GETACCOUNT') IS NOT NULL
	DROP PROC GETACCOUNT;
go
CREATE PROC GetAccount
	@UserName varchar(20),
	@PassWord varchar(20)
as
select ACCOUNT.USERNAME, ACCOUNT.PASSWORD, EMPLOYEES.NAME, ACCOUNT.IDEMPLOYEE, 
	ACCOUNT.ISADMIN, SEX, PHONENUMBER, DATEOFBIRTH, IDENTITYCARD, ADDRESS, POSITION, STARTDAY,
	SALARY 
from ACCOUNT, EMPLOYEES
where USERNAME = @UserName and PASSWORD = @PassWord and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
go

--Tạo proc Change Info để thay đổi thông tin tài khoản
IF OBJECT_ID('ChangePass' ) IS NOT NULL
	DROP PROC ChangePass;
go
--
CREATE PROC ChangePass
	@username	varchar(20),
	@oldpass	varchar(20),
	@newpass	varchar(20),
	@hoten		nvarchar(50),
	@gioitinh	nvarchar(10),
	@cmnd		varchar(10),
	@diachi		date,
	@sdt		varchar(20),
	@ngaysinh	varchar(20)
as
begin
	update ACCOUNT set PASSWORD = @NewPass
	where USERNAME = @username and PASSWORD = @OldPass
end
go

--Tạo proc Reset Password để admin có thể reset pass của các user khác
if OBJECT_ID('ResetPassword') is not null
	drop proc ResetPassword;
go
create proc ResetPassword
	@UserName varchar(20)
as 
update ACCOUNT set PASSWORD ='1'
				where USERNAME = @UserName;
go
--
--Tạo proc add Account
if OBJECT_ID('AddAccount') is not null
	drop proc AddAccount;
go
create proc AddAccount
	@UserName	varchar(20),
	@Name		nvarchar(50),
	@IsAdmin		int
as
insert into ACCOUNT values(@UserName, @Name, '1', @IsAdmin)
go
--
--Tạo proc delete Account
if OBJECT_ID('DeleteAccount') is not null
	drop proc DeleteAccount;
go
create proc DeleteAccount
	@UserName varchar(20)
as
delete ACCOUNT where USERNAME = @UserName;
go
--
--Tạo proc GetListAccount
if OBJECT_ID('GetListAccount') is not null
	drop proc GetListAccount;
go
create proc GetListAccount
as
select USERNAME, ACCOUNT.IDEMPLOYEE, EMPLOYEES.NAME, ISADMIN 
from ACCOUNT, EMPLOYEES
WHERE ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
go

--Tạo proc UpdateInfo
use QUANLYNHAHANG
if OBJECT_ID('UpdateInfo') is not null
	drop proc UpdateInfo;
go
create proc UpdateInfo
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
go

exec UpdateInfo @username = 'admin', @oldpass = 'admin', @newpass = '123', @id = 1, 
@hoten = 'tamxix', @gioitinh = 'nam', @cmnd = '123456', @diachi = 'DN', @sdt = '123456789', @ngaysinh = '1998-10-10';

--
--=====================TABLE TYPEFOOD===============================
--Tạo proc GetListFoodType
if OBJECT_ID('GetListFoodType') is not null
	drop proc GetListFoodType;
go
create proc GetListFoodType
as
select * from FOODTYPE;
go
--
--Tạo proc Delete FoodType
if OBJECT_ID('DeleteFoodType') is not null
	drop proc DeleteFoodType;
go
create proc DeleteFoodType
	@IdType	int	
as
Delete FOODTYPE where IDTYPE = @IdType;
go.
--
--Tạo proc Update FoodType
if OBJECT_ID('UpdateFoodType') is not null
	drop proc UpdateFoodType;
go
create proc UpdateFoodType
	@IdType		int,
	@NewName	nvarchar(50)
as
update FOODTYPE set TYPENAME = @NewName where IDTYPE = @IdType;
go
--
--Tạo proc Add FoodType
if OBJECT_ID('AddFoodType') is not null
	drop proc AddFoodType;
go
create proc AddFoodType
	@NewName	nvarchar(20)
as
insert into FOODTYPE values(@NewName);
go

--=====================TABLE FOOD===============================
--Tạo proc GetListFoodByIDType để lấy ra Food của từng loại
if OBJECT_ID('GetFoodsByIDType') is not null
	drop proc GetFoodsByIDType;
go
create proc GetFoodsByIDType
	@Idtype int
as
select * from FOOD where IDTYPE = @Idtype;
go
--
--Tạo proc GetListOrdered để lấy ra Food của từng loại
if OBJECT_ID('GetListOrdered') is not null
	drop proc GetListOrdered;
go
create proc GetListOrderedByIDTable
	@Idtable int
as
select FOODNAME, COUNT, PRICE, PRICE*COUNT as TotalPrice
from BILLINFO, BILL, FOOD
where BILL.IDBILL = BILLINFO.IDBILL 
	and BILLINFO.IDFOOD = FOOD.IDFOOD and BILL.IDTABLE = IDTABLE;
go
--
--Tạo proc AddFood 
if OBJECT_ID('AddFood') is not null
	drop proc AddFood;
go
create proc AddFood
	@FoodName	nvarchar(50),
	@Price		float,
	@IdType		int
as
insert into FOOD values(@FoodName, @Price, @IdType);
go
--
--Tạo proc UpdateFood 
if OBJECT_ID('UpdateFood') is not null
	drop proc UpdateFood;
go
create proc UpdateFood
	@IdFood		int,
	@NewName	nvarchar(50),
	@NewIdType	int,
	@newPrice	float
as
update FOOD set FOODNAME = @NewName, IDTYPE = @NewIdType, PRICE = @newPrice
			where IDFOOD = @IdFood;
go
--
--Tạo proc DeleteFood 
if OBJECT_ID('DeleteFood') is not null
	drop proc DeleteFood;
go
create proc DeleteFood
	@IdFood	int
as
delete FOOD where IDFOOD = @IdFood;
go
--
--Tạo proc GetListFood 
if OBJECT_ID('GetListFood') is not null
	drop proc GetListFood;
go
create proc GetListFood
as
select IDFOOD, FOODNAME, PRICE, FOODTYPE.IDTYPE, TYPENAME
from FOOD, FOODTYPE
where FOOD.IDTYPE = FOODTYPE.IDTYPE
go
--
--Tạo proc SearchFood 
if OBJECT_ID('SearchFood') is not null
	drop proc SearchFood;
go
create proc SearchFood
	@foodname nvarchar(50) ='%'
as
select * from FOOD where FOODNAME like @foodname;
go
--
--=====================TABLE BILLINFO===============================

--Tạo Proc GetBillInfosByIDBill để lấy thông tin billinfo với idbill truyền vào
if OBJECT_ID('GetBillInfosByIDBill') is not null
	drop proc GetBillInfosByIDBill;
go
create proc GetBillInfosByIDBill
	@idbill	int
as
select * from BILLINFO where IDBILL = @idbill;
go
--
--Tạo Proc InsertBillInfo để thêm billinfo
if OBJECT_ID('InsertBillInfo') is not null
	drop proc InsertBillInfo;
go
create proc InsertBillInfo
	@idbill		int,
	@idfood		int,
	@count		int
as
insert into BILLINFO values(@idbill, @idfood, @count)
go
--
--Tạo Proc GetCountByIDFood để thêm billinfo
if OBJECT_ID('GetCountByIDFood') is not null
	drop proc GetCountByIDFood;
go
create proc GetCountByIDFood
	@idfood		int,
	@idbill		int
as
select BILLINFO.COUNT
from BILLINFO
where IDBILL = @idbill and IDFOOD = @idfood
go

--Tạo Proc DeleteBillInfo để xoa billinfo
if OBJECT_ID('DeleteBillInfo') is not null
	drop proc DeleteBillInfo;
go
create proc DeleteBillInfo
	@idbill		int,
	@idfood		int
as
delete BILLINFO 
where IDBILL = @idbill and IDFOOD = @idfood
go

--Tạo Proc UpdateCount để xoa billinfo
if OBJECT_ID('UpdateCount') is not null
	drop proc UpdateCount;
go
create proc UpdateCount
	@idbill		int,
	@idfood		int,
	@count		int
as
update BILLINFO set COUNT = @count
where IDBILL = @idbill and IDFOOD = @idfood
go


--Tạo Proc SwitchIDBill để doi IDBill
if OBJECT_ID('SwitchIDBill') is not null
	drop proc SwitchIDBill;
go
create proc SwitchIDBill
	@srcbill	int,
	@dstbill	int
as
update BILLINFO set IDBILL = @dstbill 
where IDBILL = @srcbill
go


--=====================TABLE BILL===============================

--Tạo Proc GetUnpaidBillID để lấy các Bill chưa thanh toán.
if OBJECT_ID('GetUnpaidBillID') is not null
	drop proc GetUnpaidBillID;
go
create proc GetUnpaidBillID
	@idtable	int
as
select IDBILL from BILL where IDTABLE = @idtable and STATUS = 0
go

--Tạo Proc InSertBill 
if OBJECT_ID('InSertBill') is not null
	drop proc InSertBill;
go
create proc InSertBill
	@idtable	int,
	@username	varchar(50)
 as
 insert into BILL values(@idtable, 0, GETDATE(), null, 0, 0, @username);
go

--Tao pro GetMaxIDBill de lay bill moi tao
if OBJECT_ID('GetMaxIDBill') is not null
	drop proc GetMaxIDBill;
go
create proc GetMaxIDBill
as
select max(IDBILL) from BILL;
go

--Tao proc isBillNull de kiem tra Bill da duoc goi mon chua
if OBJECT_ID('isBillNull') is not null
	drop proc isBillNull;
go
create proc isBillNull
	@idbill		int
as
SELECT * FROM BILLINFO WHERE BILLINFO.IDBILL = @idbill;
go

--tao proc DeleteBill de xoa bill
if OBJECT_ID('DeleteBill') is not null
	drop proc DeleteBill;
go
create proc DeleteBill
	@idbill		int
as
DELETE FROM BILL Where IDBILL = @idbill;
go

--tao proc CheckOut để thanh toán hóa đơn
if OBJECT_ID('CheckOut') is not null
	drop proc CheckOut;
go
create proc CheckOut
	@datelease	DATETIME,
	@discount	int,
	@totalprice	float
as
update BILL set DATELEASE = @datelease, DISCOUNT = @discount, TOTAL = @totalprice, STATUS = 1;
go

--=====================TABLE EMPLOYEE===============================
--tao proc GetImployee lấy thông tin employee
if OBJECT_ID('GetImployee') is not null
	drop proc GetImployee;
go
create proc GetImployee
	@Id		int
as
select * from EMPLOYEES
		where IDEMPLOYEE = @Id;
go

exec GetImployee 1;

--=====================TABLE EMPLOYEE===============================
use QUANLYNHAHANG
if OBJECT_ID('GetListTable') is not null
	drop proc GetListTable;
go
create proc GetListTable
as
select * from FOODTABLE;
go

-- Tạo proc AddTable de them table
if OBJECT_ID('AddTable') is not null
	drop proc AddTable;
go
create proc AddTable
	@name	nvarchar(20) = N'Tên bàn'
as
insert into FOODTABLE values (@name, 0);
go

exec AddTable N'Bàn 1' 
select *  from FOODTABLE
go
--
-- Tạo proc DeleteTable de xoa table
if OBJECT_ID('DeleteTable') is not null
	drop proc DeleteTable;
go
create proc DeleteTable
	@id		int
as
delete from FOODTABLE where IDTABLE = @id;
go

-- Tạo proc UpdateTable de update table
if OBJECT_ID('UpdateTable') is not null
	drop proc UpdateTable;
go
create proc UpdateTable
	@id		int,
	@name	nvarchar(20)
as
update FOODTABLE set NAME = @name 
				where IDTABLE = @id;
go

-- Tạo proc GetListFood de update table
if OBJECT_ID('GetListFood') is not null
	drop proc GetListFood;
go
create proc GetListFood
	@idtype		int = null,
	@name	nvarchar(50) = null
as
begin
	if @idtype is null and @name is null
	begin
		SELECT IDFOOD, FOODNAME, FOOD.IDTYPE, TYPENAME, PRICE 
		FROM FOOD, FOODTYPE 
		WHERE FOOD.IDTYPE = FOODTYPE.IDTYPE
	end
	else if @idtype is not null
	begin
		SELECT * 
		FROM FOOD 
		WHERE IDTYPE = @idtype
	end
	else if @name is not null
	begin
		SELECT * FROM FOOD WHERE FOODNAME LIKE @name
	end
end
go

