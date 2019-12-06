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
	ACCOUNT.ISADMIN, SEX, PHONENUMBER, DATEOFBIRTH, STARTDAY, IDENTITYCARD, ADDRESS, WORK.NAME as WorkName, SHIFT, STARTDAY,
	EMPLOYEES.SALARY 
from ACCOUNT, EMPLOYEES, WORK
where USERNAME = @UserName and PASSWORD = @PassWord and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
	and EMPLOYEES.IDWORK = WORK.IDWORK
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
	@id			int,
	@IsAdmin	int
as
insert into ACCOUNT(USERNAME, IDEMPLOYEE, PASSWORD, ISADMIN)
			 values(@UserName, @id, '1', @IsAdmin)
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

--exec UpdateInfo @username = 'admin', @oldpass = 'admin', @newpass = 'admin', @id = 1, 
--@hoten = 'tamxix', @gioitinh = 'nam', @cmnd = '123456', @diachi = 'DN', @sdt = '123456789', @ngaysinh = '1998-10-10';

--
--=====================TABLE SUPPLIER===============================
--Tạo proc GetListSupplier
if OBJECT_ID('GetListSupplier') is not null
	drop proc GetListSupplier;
go
create proc GetListSupplier
as
select FOODSUPPLIER.IDSUP, FOODSUPPLIER.SUPNAME, 
		 FOODSUPPLIER.PHONENUMBER, FOODSUPPLIER.ADDRESS
from FOODSUPPLIER
go

--Tạo proc AddSupplier
if OBJECT_ID('AddSupplier') is not null
	drop proc AddSupplier;
go
create proc AddSupplier
	@ten	nvarchar(200),
	@sdt	varchar(20),
	@diachi	nvarchar(200)
as
insert into FOODSUPPLIER( SUPNAME, PHONENUMBER, ADDRESS)
			values(@ten, @sdt, @diachi)
go

--Tạo proc UpdateSupplier
if OBJECT_ID('UpdateSupplier') is not null
	drop proc UpdateSupplier;
go
create proc UpdateSupplier
	@idsup	int,
	@ten	nvarchar(200),
	@sdt	varchar(20),
	@diachi	nvarchar(200)
as
update FOODSUPPLIER set SUPNAME = @ten,
		PHONENUMBER = @sdt, ADDRESS = @diachi
		where IDSUP = @idsup;
go

if OBJECT_ID('DeleteSupplier') is not null
	drop proc DeleteSupplier;
go
create proc DeleteSupplier
	@idsup	int
as
delete FOODSUPPLIER where IDSUP = @idsup;
go


--
--=====================TABLE TYPEFOOD===============================
--Tạo proc GetListFoodType
if OBJECT_ID('GetListFoodType') is not null
	drop proc GetListFoodType;
go
create proc GetListFoodType
as
select FOODTYPE.IDTYPE, FOODTYPE.TYPENAME, FOODTYPE.IDSUPPLIER, FOODSUPPLIER.SUPNAME
from FOODTYPE, FOODSUPPLIER
where FOODSUPPLIER.IDSUP = FOODTYPE.IDSUPPLIER
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
go
--
--Tạo proc Update FoodType
if OBJECT_ID('UpdateFoodType') is not null
	drop proc UpdateFoodType;
go
create proc UpdateFoodType
	@IdType		int,
	@NewName	nvarchar(50),
	@idsup		int
as
update FOODTYPE set TYPENAME = @NewName, IDSUPPLIER = @idsup where IDTYPE = @IdType;
go
--
--Tạo proc Add FoodType
if OBJECT_ID('AddFoodType') is not null
	drop proc AddFoodType;
go
create proc AddFoodType
	@NewName	nvarchar(20),
	@idsup		int
as
insert into FOODTYPE values(@NewName, @idsup);
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
if OBJECT_ID('GetListOrderedByIDTable') is not null
	drop proc GetListOrderedByIDTable;
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
--

--Tạo proc DeleteBillInfo
if OBJECT_ID('DeleteBillInfo') is not null
	drop proc DeleteBillInfo;
go
create proc DeleteBillInfo
	@IdFood	int,
	@IdBill int
as
delete BILLINFO where IDFOOD = @IdFood and IDBILL = @IdBill;
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
begin
	--declare @name nvarchar(50) = 'N'%'' + @foodname + ''%'';
	select * from FOOD where FOODNAME like CONCAT(N'%', @foodname, '%')
end

go

--Tạo proc GetListOrder để lấy danh sách các món đã order của 1 bàn
if OBJECT_ID('GetListOrder') is not null
	drop proc GetListOrder;
go
create proc GetListOrder
	@idtable int
as
SELECT f.FOODNAME, bi.COUNT, f.PRICE, f.PRICE*bi.COUNT AS totalPrice 
FROM BILLINFO AS bi, BILL AS b, FOOD AS f
WHERE bi.IDBILL = b.IDBILL AND bi.IDFOOD = f.IDFOOD 
		AND b.STATUS = 0 AND b.IDTABLE = @idtable
go


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
 insert into BILL values(@idtable, 0, GETDATE(), null, null, 0, 0, @username);
go

use QUANLYNHAHANG
--Tao pro GetMaxIDBill de lay bill moi tao
if OBJECT_ID('GetMaxIDBill') is not null
	drop proc GetMaxIDBill;
go
create proc GetMaxIDBill
as
select max(IDBILL) as idbill from BILL;
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

--=====================TABLE WORK===============================
--
--Tao store proc GetListWork
if OBJECT_ID('GetListWork') is not null
	drop proc GetListWork;
go
create proc GetListWork
as
select * from WORK;
go


--Tao store proc AddWork
if OBJECT_ID('AddWork') is not null
	drop proc AddWork;
go
create proc AddWork
	@name	nvarchar(50) = N'Công việc',
	@luong	int = 0
as
insert into WORK(NAME, SALARY)
		values(@name, @luong)
go
--
--Tao store proc DeleteWork
if OBJECT_ID('DeleteWork') is not null
	drop proc DeleteWork;
go
create proc DeleteWork
	@id int
as
delete WORK where IDWORK = @id;
go
--
--Tao store proc UpdateWork
if OBJECT_ID('UpdateWork') is not null
	drop proc UpdateWork;
go
create proc UpdateWork
	@id		int,
	@name	nvarchar(50),
	@luong	int
as
update WORK set NAME = @name, SALARY = @luong 
				where IDWORK = @id;
go

--


--
--Tao store proc GetListEmployeeByIdWork
if OBJECT_ID('GetListEmployeeByIdWork') is not null
	drop proc GetListEmployeeByIdWork;
go
create proc GetListEmployeeByIdWork
	@idwork	int
as
select EMPLOYEES.IDEMPLOYEE, EMPLOYEES.NAME, EMPLOYEES.SHIFT, WORK.SALARY
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK and WORK.IDWORK = @idwork
go

--
--Tao store proc GetListEmployeeByShift
if OBJECT_ID('GetListEmployeeByShift') is not null
	drop proc GetListEmployeeByShift;
go
create proc GetListEmployeeByShift
	@calam	int
as
select EMPLOYEES.IDEMPLOYEE, EMPLOYEES.NAME, WORK.NAME as WorkName, WORK.SALARY
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK and EMPLOYEES.SHIFT = @calam
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

--
--tao proc GetImployee lấy thông tin employee
if OBJECT_ID('GetListImployee') is not null
	drop proc GetListImployee;
go
create proc GetListImployee
	@colname AS sysname,
	@sorttype bit = 1
as
select IDEMPLOYEE, EMPLOYEES.NAME as empname, SEX, DATEOFBIRTH, IDENTITYCARD,
	 ADDRESS, PHONENUMBER, STARTDAY, WORK.NAME as WorkName, SHIFT as CaLam, BONUS, EMPLOYEES.SALARY as TongLuong
from EMPLOYEES, WORK
where EMPLOYEES.IDWORK = WORK.IDWORK
ORDER BY
 CASE WHEN @colname = N'IDEMPLOYEE' AND @sorttype = 1
	THEN IDEMPLOYEE END,
 CASE WHEN @colname = N'empname' AND @sorttype = 1
	THEN EMPLOYEES.NAME END,
 CASE WHEN @colname = N'SEX' AND @sorttype = 1
	THEN SEX END,
 CASE WHEN @colname = N'DATEOFBIRTH' AND @sorttype = 1
	THEN DATEOFBIRTH END,
 CASE WHEN @colname = N'STARTDAY' AND @sorttype = 1
	THEN STARTDAY END,
 CASE WHEN @colname = N'WorkName' AND @sorttype = 1
	THEN SHIFT END,
 CASE WHEN @colname = N'BONUS' AND @sorttype = 1
	 THEN BONUS END,
 CASE WHEN @colname = N'TongLuong' AND @sorttype = 1
	THEN EMPLOYEES.SALARY END,
 CASE WHEN @colname = N'CaLam' AND @sorttype = 1
	THEN SHIFT END,
  CASE WHEN @colname = N'IDEMPLOYEE' AND @sorttype = 0
	THEN IDEMPLOYEE END DESC,
 CASE WHEN @colname = N'empname' AND @sorttype = 0
	THEN EMPLOYEES.NAME END DESC,
 CASE WHEN @colname = N'SEX' AND @sorttype = 0
	THEN SEX END DESC,
 CASE WHEN @colname = N'DATEOFBIRTH' AND @sorttype = 0
	THEN DATEOFBIRTH END DESC,
 CASE WHEN @colname = N'STARTDAY' AND @sorttype = 0
	THEN STARTDAY END DESC,
 CASE WHEN @colname = N'WorkName' AND @sorttype = 0
	THEN SHIFT END DESC,
 CASE WHEN @colname = N'BONUS' AND @sorttype = 0
	THEN BONUS END DESC,
 CASE WHEN @colname = N'TongLuong' AND @sorttype = 0
	THEN EMPLOYEES.SALARY END DESC,
 CASE WHEN @colname = N'CaLam' AND @sorttype = 0
	THEN SHIFT END DESC
 OPTION (RECOMPILE);
 
go

--EXEC GetListImployee 'CaLam', 0
--tao proc AddEmployee thêm Employee
if OBJECT_ID('AddEmployee') is not null
	drop proc AddEmployee;
go
create proc AddEmployee
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
go
--exec AddEmployee N'Nguyễn Thành Tâm', N'Nam', '1999-01-14', '272676143', N'Số 1 Phạm Hồng Thái', '0396925225', 1, 1, '2015-5-12', 20000000


--
--tao proc DeleteEmployee 
if OBJECT_ID('DeleteEmployee') is not null
	drop proc DeleteEmployee;
go
create proc DeleteEmployee
	@id int
as
delete EMPLOYEES where IDEMPLOYEE = @id
go
--
--tao proc UpdateEmployee 
if OBJECT_ID('UpdateEmployee') is not null
	drop proc UpdateEmployee;
go
create proc UpdateEmployee
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
go
--
--tao proc UpdateSalary 
if OBJECT_ID('UpdateSalary') is not null
	drop proc UpdateSalary;
go
create proc UpdateSalary
	@idnhanvien	int
as
update EMPLOYEES set EMPLOYEES.SALARY = 
	(select EMPLOYEES.BONUS + WORK.SALARY
	from EMPLOYEES, WORK
	where EMPLOYEES.IDWORK = WORK.IDWORK and EMPLOYEES.IDEMPLOYEE = @idnhanvien)
	where IDEMPLOYEE = @idnhanvien
go

--
go
--tao proc GetListName lấy thông tin employee
if OBJECT_ID('GetListEMP') is not null
	drop proc GetListEMP;
go
create proc GetListEMP
as
select * from EMPLOYEES
go


--exec AddEmployee N'Huyền Nhung', N'Nam', '1999-11-12', '272123321', N'Xuân Lộc', '0396584756', N'Nhân viên', '2018-04-10', 15000000;

--SELECT * FROM EMPLOYEES

--=====================TABLE AREA===============================
if OBJECT_ID('GetListArea') is not null
	drop proc GetListArea;
go
create proc GetListArea
as
select * from AREA;
go

-- Tạo proc AddTable
if OBJECT_ID('AddArea') is not null
	drop proc AddArea;
go
create proc AddArea
	@name	nvarchar(20) = N'Area'
as
insert into AREA values (@name)
go

--
-- Tạo proc DeleteArea 
if OBJECT_ID('DeleteArea') is not null
	drop proc DeleteArea;
go
create proc DeleteArea
	@id		int
as
delete from AREA where IDAREA = @id;
go

-- Tạo proc UpdateArea
if OBJECT_ID('UpdateArea') is not null
	drop proc UpdateArea;
go
create proc UpdateArea
	@id		int,
	@name	nvarchar(20)
as
update AREA set NAME = @name 
				where IDAREA = @id;
go



--=====================TABLE FOODTABLE===============================
--use QUANLYNHAHANG
if OBJECT_ID('GetListTable') is not null
	drop proc GetListTable;
go
create proc GetListTable
as
select * from FOODTABLE
order by IDAREA, NAME
go

--GetTableInfo
if OBJECT_ID('GetTableInfo') is not null
	drop proc GetTableInfo;
go
create proc GetTableInfo
as
select IDTABLE, FOODTABLE.NAME, FOODTABLE.IDAREA, AREA.NAME, FOODTABLE.STATUS
from FOODTABLE, AREA
where FOODTABLE.IDAREA = AREA.IDAREA
go


-- Tạo proc AddTable de them table
if OBJECT_ID('AddTable') is not null
	drop proc AddTable;
go
create proc AddTable
	@name	nvarchar(20) = N'Tên bàn',
	@idarea int
as
insert into FOODTABLE(NAME, IDAREA, STATUS)
			values(@name, @idarea, 0)
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
	@name	nvarchar(20),
	@idarea int
as
update FOODTABLE set NAME = @name , IDAREA = @idarea
				where IDTABLE = @id;
go
--
-- Tạo proc CheckOutTable để 
if OBJECT_ID('CheckOutTable') is not null
	drop proc CheckOutTable;
go
create proc CheckOutTable
	@idtable int
as
update FOODTABLE set STATUS = 1
		where IDTABLE = @idtable;
go


--=====================TABLE VOUCHER===============================
-- Tạo proc GetVoucher để lấy thông tin voucher
if OBJECT_ID('GetVoucher') is not null
	drop proc GetVoucher;
go
create proc GetVoucher
	@code	varchar(20)
as
select * from VOUCHER
where CODE = @code;
go

--
-- Tạo proc CreateVoucher để tạo thêm voucher
if OBJECT_ID('InsertVoucher') is not null
	drop proc InsertVoucher;
go
create proc InsertVoucher
	@code		varchar(20),
	@name		nvarchar(50),
	@value		int,
	@hethan		date
as
insert into VOUCHER(CODE, NAME, VALUE, EXPIRATIONDATE) 
				values (@code, @name, @value, @hethan);
go
--
-- Tạo proc EditVoucher để chỉnh sửa voucher
if OBJECT_ID('EditVoucher') is not null
	drop proc EditVoucher;
go
create proc EditVoucher
	@id			int,
	@code		varchar(20),
	@name		nvarchar(50),
	@value		int,
	@hethan		date
as
update VOUCHER set CODE = @code, NAME = @name, VALUE = @value, EXPIRATIONDATE = @hethan
		where ID = @id;
go

--
-- Tạo proc DeleteVoucher để xóa voucher
if OBJECT_ID('DeleteVoucher') is not null
	drop proc DeleteVoucher;
go
create proc DeleteVoucher
	@id	varchar(20)
as
delete VOUCHER where ID = @id;
go
--
-- Tạo proc GetNameVoucher
if OBJECT_ID('GetNameVoucher') is not null
	drop proc GetNameVoucher;
go
create proc GetNameVoucher
	@idbill	int
as
select VOUCHER.NAME
from VOUCHER, BILL
where BILL.IDBILL = @idbill and BILL.VOUCHERID = VOUCHER.ID
go

--
-- Tạo proc GetNameEmployee
if OBJECT_ID('GetNameEmployee') is not null
	drop proc GetNameEmployee;
go
create proc GetNameEmployee
	@idbill int
as
select EMPLOYEES.NAME 
from BILL, EMPLOYEES, ACCOUNT
where BILL.IDBILL = @idbill and BILL.USERNAME = ACCOUNT.USERNAME
	 and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
go


--=====================MỘT SỐ STORE PROC KHÁC===============================
--
-- Tạo proc ThanhToan
if OBJECT_ID('Pay') is not null
	drop proc Pay;
go
create proc Pay
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

go
--
--Tạo store proc GopBan
if OBJECT_ID('GopBan') is not null
	drop proc GopBan;
go
create proc GopBan
	@idtable1	int,
	@idtable2	int,
	@username	varchar(20)
as
begin try
	begin tran
		declare @idbill1 int
		declare @idbill2 int

		--lấy idbill thứ nhất
		select @idbill1 = IDBILL 
		from BILL 
		where IDTABLE = @idtable1 and STATUS = 0

		--lấy idbill thứ hai
		select @idbill2 = IDBILL 
		from BILL 
		where IDTABLE = @idtable2 and STATUS = 0
		print 'idbill ban thu nhat:'
		print @idbill1
		print 'idbill ban thu hai:'
		print @idbill2

		if @idbill1 is null
			begin
				print N'Bàn 1 trống!!!'
				commit tran
				return
			end
			
		if @idbill2 is null
			begin
				print N'Bàn 2 trống, tạo bill mới!'

				insert into BILL(IDTABLE, DATECOME, USERNAME)
						values(@idtable2, GETDATE(), @username)

				select @idbill2 = IDBILL 
				from BILL 
				where IDTABLE = @idtable2 and STATUS = 0

				print 'Id bill ban 2: '
				print @idbill2
			end
			
		Update BILLINFO set IDBILL = @idbill2 where IDBILL = @idbill1

		Update FOODTABLE set STATUS = 0 where IDTABLE = @idtable1

		Update FOODTABLE set STATUS = 1 where IDTABLE = @idtable2

		print N'Thành công!'
	commit tran
end try
begin catch
	print N'Lỗi trong quá trình chuyển bàn!'
	rollback tran
end catch
go

--exec GopBan 7, 8, 'admin'

--use QUANLYNHAHANG
--select IDFOOD, SUM(Count) as sumcount
--from BILLINFO
--where IDBILL = 25
--group by IDFOOD


--
--Tạo store proc ThongKe để thống kê thu nhập, thông tin bill
if OBJECT_ID('ThongKe') is not null
	drop proc ThongKe;
go
create proc ThongKe
	@datefrom	datetime,
	@dateto		datetime,
	@colname AS sysname,
	@sorttype bit = 1
as
select IDBILL, FOODTABLE.NAME as tenban, AREA.NAME as khuvuc, DATECOME as tgden, DATELEASE as tgdi, DISCOUNT, TOTAL
from BILL, FOODTABLE, AREA
where FOODTABLE.IDAREA = AREA.IDAREA and BILL.IDTABLE = FOODTABLE.IDTABLE
		and DATECOME >= @datefrom and DATELEASE <= @dateto
ORDER BY
 CASE WHEN @colname = N'IDBILL' AND @sorttype = 1
	THEN IDBILL END,
 CASE WHEN @colname = N'tenban' AND @sorttype = 1
	THEN FOODTABLE.NAME END,
 CASE WHEN @colname = N'khuvuc' AND @sorttype = 1
	THEN AREA.NAME END,
 CASE WHEN @colname = N'tgden' AND @sorttype = 1
	THEN DATECOME END,
 CASE WHEN @colname = N'DISCOUNT' AND @sorttype = 1
	THEN DISCOUNT END,
 CASE WHEN @colname = N'TOTAL' AND @sorttype = 1
	THEN TOTAL END,
 CASE WHEN @colname = N'IDBILL' AND @sorttype = 0
	THEN IDBILL END DESC,
 CASE WHEN @colname = N'tenban' AND @sorttype = 0
	THEN FOODTABLE.NAME END DESC,
 CASE WHEN @colname = N'khuvuc' AND @sorttype = 0
	THEN AREA.NAME END DESC,
 CASE WHEN @colname = N'tgden' AND @sorttype = 0
	THEN DATECOME END DESC,
 CASE WHEN @colname = N'DISCOUNT' AND @sorttype = 0
	THEN DISCOUNT END DESC,
 CASE WHEN @colname = N'TOTAL' AND @sorttype = 0
	THEN TOTAL END DESC
 OPTION (RECOMPILE);

go

--exec ThongKe '2018-01-01', '2019-12-12'

--Tạo store proc BillDetails 
if OBJECT_ID('BillDetails') is not null
	drop proc BillDetails;
go
create proc BillDetails
	@idbill		int
as
select FOOD.FOODNAME as tenmon, FOOD.PRICE, BILLINFO.COUNT, (FOOD.PRICE * BILLINFO.COUNT) as total
from BILL, BILLINFO, FOOD
where BILL.IDBILL = BILLINFO.IDBILL and BILLINFO.IDFOOD = FOOD.IDFOOD 
	and BILL.IDBILL = @idbill
go

--exec BillDetails 18

--Tạo store proc MoreInfo 
if OBJECT_ID('MoreInfo') is not null
	drop proc MoreInfo;
go
create proc MoreInfo
	@idbill		int
as
select EMPLOYEES.NAME, VOUCHER.NAME
from BILL, VOUCHER, EMPLOYEES, ACCOUNT
where BILL.VOUCHERID = VOUCHER.ID and BILL.USERNAME = ACCOUNT.USERNAME
	 and ACCOUNT.IDEMPLOYEE = EMPLOYEES.IDEMPLOYEE
go

--exec MoreInfo 15

CREATE TRIGGER TG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE IDBILL = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.FOODTABLE SET status = 1 WHERE IDTABLE = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.FOODTABLE SET status = 0 WHERE IDTABLE = @idTable	
	end
	
END
GO




exec AddWork N'Admin', 0
exec AddEmployee N'Nguyễn Thành Tâm', N'Nam', '1999-01-14', '272676143', N'Số 1 Phạm Hồng Thái', '0396925225', 1, 1, '2015-5-12', 20000000
exec AddAccount 'Admin', 1, 1
