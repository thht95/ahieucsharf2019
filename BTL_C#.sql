USE master
GO
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'QLHS'
)
DROP DATABASE QLHS
GO
CREATE DATABASE QLHS
GO
USE QLHS
GO


create table tblLop
(
	sMaLop varchar(10) primary key,
	sTenLop nvarchar(50)
)
go

create table tblHocSinh
(
	sMaHS varchar(10) primary key,
	sHoTen nvarchar(50),
	bGioiTinh bit,
	dNgaySinh smalldatetime,
	sDiaChi nvarchar(200),
	sNienKhoa varchar(12),
	sMaLop varchar(10)
)
go

create table tblMonHoc
(
	sMaMon varchar(10) primary key,
	sTenMon nvarchar(100)
)
go

create table tblDiem
(
	sMaMon varchar(10),
	sMaHS varchar(10),
	iHocKi int,
	fDiemM float,
	fDiem15p float,
	fDiem45p float,
	fDiemThi float,
	sNamHoc varchar(10)
	primary key (sMaMon, sMaHS, iHocKi, sNamHoc)
)
go


--1. foreign keys

alter table tblHocSinh
add constraint fk_hosinh_lop foreign key (sMaLop) references tblLop(sMaLop)
go

alter table tblDiem
add constraint fk_diem_mon foreign key (sMaMon) references tblMonHoc(sMaMon)
go

alter table tblDiem
add constraint fk_diem_hocsinh foreign key (sMaHS) references tblHocSinh(sMaHS)
go

/*
--2. Tao view

--2.1. View tblLop

create view view_lop
as
select sMaLop as [Mã lớp], sTenLop as [Tên lớp] from tblLop
go

select * from view_lop
go


--2.2. View tblHocSinh
create view view_hocsinh
as
select sMaHS as [Mã HS], sHoTen as [Họ tên], case bGioiTinh when 1 then N'Nam' when 0 then N'Nữ' else N'Không xác định' end as [Giới tính], CONVERT(smalldatetime,dNgaySinh,105) as [Ngày sinh], sDiaChi as [Địa chỉ], sNienKhoa as [Niên khóa], sMaLop as [Mã lớp] from tblHocSinh
go
select * from view_hocsinh
go


--2.3. View tblMonHoc
create view view_monhoc
as
select sMaMon as [Mã môn], sTenMon as [Tên môn học] from tblMonHoc
go
select * from view_monhoc
go

--2.4. view  tính điểm môn học kì tblDiem
create view view_tbm_hk
as
select c.sMaLop as [Mã lớp]
	, a.sMaHS as [Mã HS]
	, b.sHoTen as [Họ tên]
	, a.sMaMon as [Mã môn]
	, d.sTenMon as [Tên môn]
	, sNamHoc as [Năm học]
	, a.iHocKi as [Học kì]
	, a.fDiemM as [Điểm miệng]
	, a.fDiem15p as [Điểm 15p]
	, a.fDiem45p as [Điểm 1 tiết]
	, a.fDiemThi as [Điểm thi]
	, convert(decimal(4,1),(a.fDiemM+a.fDiem15p+ (a.fDiem45p*2)+ (a.fDiemThi*3))/7) as [Điểm TB học kì]
	 from tblDiem a inner join tblHocSinh b
	ON a.sMaHS=b.sMaHS inner join tblLop c 
	ON b.sMaLop = c.sMaLop inner join tblMonHoc d 
	ON a.sMaMon = d.sMaMon
go
select * from view_tbm_hk
go
-- Tạo view tính trung bình môn học kỳ
create view view_tbmhk
as
	select sMaMon,sMaHS,iHocKi, convert(decimal(4,1),(fDiemM +fDiem15p+ (fDiem45p*2)+ (fDiemThi*3))/7) as [tbhk] from tblDiem
go

select * from view_tbmhk

--Tạo view tính trung bình môn học kỳ 1
create view view_tbm_hk1
as
	select sMaMon,sMaHS,iHocKi, tbhk from view_tbmhk where iHocKi = 1
go

select * from view_tbm_hk1
go

--Tọa view tính trung bình môn học kỳ 2
create view view_tbm_hk2
as
	select sMaMon,sMaHS,iHocKi, tbhk from view_tbmhk where iHocKi = 2
go

select * from view_tbm_hk2
go

-- Tạo view tính điểm trung bình 1 môn cả năm
create view view_dtbm_nam
as
	select a.sMaMon ,a.sMaHS, (a.tbhk + b.tbhk)/2 as [dtbmnam] from view_tbm_hk1 a inner join view_tbm_hk2 b
	ON a.sMaMon = b.sMaMon and a.sMaHS = b.sMaHS
go

select * from view_dtbm_nam
select * from view_tbm_hk2
select * from view_tbm_hk1
go



--Tạo view xem điểm của học sinh
create view view_xemdiem
as
	select a.sMaHS, 
	a.sMaMon, 
	sNamHoc, 
	a.iHocKi, 
	a.fDiemM, 
	a.fDiem15p, 
	a.fDiem45p, 
	a.fDiemThi, 
	b.tbhk, 
	convert(decimal(4,1),c.dtbmnam) as [dtbnam]
	from tblDiem a inner join view_tbmhk b
	ON a.sMaMon = b.sMaMon and a.sMaHS = b.sMaHS and a.iHocKi = b.iHocKi inner join view_dtbm_nam c
	ON b.sMaMon = c.sMaMon and b.sMaHS = c.sMaHS
go

--Tạo function tính điểm tbm cả năm
alter function func_diem()
returns @tbl table ([TBM năm] float)
as
	begin
		declare @mamon varchar(10)
		declare @mahs varchar(10)
		declare @tbmhk1 float
		declare @tbmhk2 float
		declare @tbm float
		set @tbmhk1 = (select [Điểm TB học kì] from view_tbm_hk where [Học kì] = 1)
		set @tbmhk2 = (select [Điểm TB học kì] from view_tbm_hk where [Học kì] = 2)
		set @tbm = (@tbmhk1 + @tbmhk2)/2
		insert into @tbl
		select @tbm
		return
	end
go

select * from dbo.func_diem()

--3. Tạo các Proc
--3.1. tblHocSinh
--3.1.1. Thêm học sinh

create proc sp_them_hs
	@mahs varchar(10), 
	@hoten nvarchar(50), 
	@gioitinh bit, 
	@ngaysinh smalldatetime, 
	@diachi nvarchar(200), 
	@nienkhoa varchar(12), 
	@malop varchar(10)
as
begin
	insert into tblHocSinh	([sMaHS],  
							[sHoTen], 
							[bGioiTinh], 
							[dNgaySinh], 
							[sDiaChi], 
							[sNienKhoa], 
							[sMaLop])
	 values (
			 @mahs, 
			 @hoten, 
			 @gioitinh, 
			 CONVERT(smalldatetime,@ngaysinh,103), 
			 @diachi, 
			 @nienkhoa, 
			 @malop)
end
go

exec sp_them_hs HS02A10,N'Trịnh Văn A',1,'05-12-1995',N'Hà Nội','2013 - 2016','A10'
go
select * from tblHocSinh


--********* proc tính điểm (linh tinh)
create proc sp_tinhdiem
	@mamon varchar(10), 
	@mahs varchar(10), 
	@hk int
as
begin
	declare @dm as float
	declare @d15p as float
	declare @d45p as float
	declare @dt as float
	declare @dtb as float
	set @dm = (select fDiemM from tblDiem where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk)
	set @d15p = (select fDiem15p from tblDiem where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk)
	set @d45p = (select fDiem45p from tblDiem where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk)
	set @dt = (select fDiemThi from tblDiem where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk)
	set  @dtb = (@dm +@d15p + (@d45p*2) + (@dt*3))/7
	print @dtb
end
go

exec sp_tinhdiem @mamon= 'VH10', @mahs = 'HS01A10', @hk = 1
go

--Tạo function xem điểm của sinh viên
ALTER FUNCTION func_xemdiem()
RETURNS @tbl TABLE
	(mahs varchar(10),
	mamon varchar(10),
	namhoc varchar(10),
	hocki int,
	diemM float,
	diem15p float,
	diem45p float,
	diemthi float,
	tbhk float,
	dtbnam float
	)
as
begin
	declare @none int
	set @none = ''
	insert into @tbl (mahs,mamon,namhoc,hocki,diemM,diem15p,diem45p,diemthi,tbhk)
	select sMaHS,sMaMon,sNamHoc, iHocKi, fDiemM, fDiem15p, fDiem45p, fDiemThi, tbhk from view_xemdiem;
	if ((select iHocKi from view_xemdiem) = 1)
	begin
		insert into @tbl (dtbnam)
		select @none
	end
	return
end
go

select * from func_xemdiem()
Select * from view_xemdiem
*/
--proc + view

---tblLop

----1. Xem lớp
create view view_lop
as
select sMaLop as [Mã lớp], sTenLop as [Tên lớp] from tblLop
go
select * from view_lop
go
----2. Thêm lớp
create proc sp_themlop
@malop varchar(10), @tenlop nvarchar(50)
as
begin
insert into tblLop (sMaLop, sTenLop) values(@malop, @tenlop)
end
go

---3. Sửa lớp
create proc sp_sualop
@malop varchar(10), @tenlop nvarchar(50)
as
begin
update tblLop set sTenLop = @tenlop where sMaLop = @malop
end
go

---4. Xóa lóp
create proc sp_xoalop
@malop varchar(10)
as
begin
	delete from tblLop where sMaLop = @malop
end
go

---tblHocSinh

---1. Xem Học sinh
create view view_hocsinh
as
	select sMaHS as [Mã HS], sHoTen as [Họ và tên], case(bGioiTinh) when 1 then N'Nam' when 0 then N'Nữ' else N'Không xác định' end as [Giới tính], CONVERT(smalldatetime,dNgaySinh,105) as [Ngày sinh], sDiaChi as [Địa chỉ], sNienKhoa as [Niên khóa], sMaLop as [Mã lớp] from tblHocSinh
go
select * from view_hocsinh
go
---2. Thêm học sinh
create proc sp_themhocsinh
(
@mahs varchar(10),
@hoten nvarchar(50),
@gioitinh bit,
@ngaysinh smalldatetime,
@diachi nvarchar(200),
@nienkhoa varchar(12),
@malop varchar(10)
)
as
begin
	insert into tblHocSinh(sMaHS,sHoTen,bGioiTinh,dNgaySinh,sDiaChi,sNienKhoa,sMaLop) values(@mahs, @hoten, @gioitinh, @ngaysinh, @diachi, @nienkhoa, @malop)
end
go

---3. Tìm kiếm học sinh
CREATE PROCEDURE sp_timkiemhs
	@mahs varchar(10),
	@tenhs nvarchar(50)
AS
BEGIN

SELECT [Mã HS], [Họ và tên], [Giới tính], [Ngày sinh], [Địa chỉ], [Niên khóa], [Mã lớp] FROM view_hocsinh
WHERE 
   [Mã HS] = (CASE ISNULL(@mahs,'')
							WHEN '' THEN [Mã HS]
							ELSE CONVERT(VARCHAR,@mahs)
						END)
  AND [Họ và tên] LIKE '%' + (CASE ISNULL(@tenhs,'')
							WHEN '' THEN [Họ và tên]
							ELSE CONVERT(NVARCHAR,@tenhs)
						END) + '%'	
END
GO

---4. Sửa học sinh
create proc sp_suahs
	@mahs varchar(10),
	@hoten nvarchar(50),
	@gt bit,
	@ngaysinh smalldatetime,
	@diachi nvarchar(200),
	@nienkhoa varchar(12),
	@malop varchar(10)
as
begin
	update tblHocSinh set sHoTen = @hoten, bGioiTinh = @gt, dNgaySinh = @ngaysinh, sDiaChi = @diachi, sNienKhoa = @nienkhoa, sMaLop = @malop
	where sMaHS = @mahs
end
go

---5. Xóa học sinh
create proc sp_xoahs
	@mahs varchar(10)
as
begin
	delete from tblHocSinh where sMaHS = @mahs
end
go

---------tblMonHoc
---1. Xem môn học
create view view_monhoc
as
select sMaMon as [Mã môn], sTenMon as [Tên môn] from tblMonHoc
go
---2. Thêm môn học
create proc sp_themmon
@mamon varchar(10), @tenmon nvarchar(100)
as
begin
	insert into tblMonHoc(sMaMon, sTenMon) values(@mamon, @tenmon)
end
go
---3. Sửa môn học
create proc sp_suamon
@mamon varchar(10), @tenmon nvarchar(50)
as
begin
update tblMonHoc set sTenMon = @tenmon where sMaMon = @mamon
end
go

---4. Xóa môn học
create proc sp_xoamon
@mamon varchar(10)
as
begin
	delete from tblMonHoc where sMaMon = @mamon
end
go
--------tblDiem
---1. Xem điểm TBM học kì
create view view_diemtbmhk
as
	select sMaMon as [Mã môn học],
	sMaHS as [Mã HS],
	sNamHoc as [Năm học], 
	iHocKi as [Học kì], 
	fDiemM as [Điểm miệng], 
	fDiem15p as [Điểm 15p], 
	fDiem45p as [Điểm 45p],
	fDiemThi as [Điểm học kì], 
	convert(decimal(4,1),(fDiemM +fDiem15p+ (fDiem45p*2)+ (fDiemThi*3))/7) as [Điểm TB học kì] from tblDiem
go
---2. Thêm điểm
create proc sp_themdiem
	@mamon varchar(10),
	@mahs varchar(10),
	@hk int,
	@diemm float,
	@diem15p float,
	@diem45p float,
	@diemthi float,
	@namhoc varchar(10)
as
begin
	insert into tblDiem(sMaMon,sMaHS,iHocKi,fDiemM,fDiem15p,fDiem45p,fDiemThi,sNamHoc) 
	values(@mamon,@mahs,@hk,@diemm,@diem15p,@diem45p,@diemthi,@namhoc)
end
go

---3.Sửa điểm
create proc sp_suadiem
	@mamon varchar(10),
	@mahs varchar(10),
	@hk int,
	@diemm float,
	@diem15p float,
	@diem45p float,
	@diemthi float,
	@namhoc varchar(10)
as 
begin
	update tblDiem set fDiemM = @diemm, fDiem15p = @diem15p, fDiem45p = @diem45p, fDiemThi = @diemthi where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk and sNamHoc = @namhoc
end
go
---4. Xóa điểm
create proc sp_xoadiem
	@mamon varchar(10),
	@mahs varchar(10),
	@hk int,
	@namhoc varchar(10)
as
begin
	delete from tblDiem where sMaMon = @mamon and sMaHS = @mahs and iHocKi = @hk and sNamHoc = @namhoc
end
go

-------Form điểm chi tiết

---1. Lấy Năm học
create view view_namhoc
as
select sNamHoc from tblDiem
group by sNamHoc
GO
select * from tblLop

----2. Điểm TB môn học

----2.1. Điểm TB 1 môn 1 học kì
create view v_tbmonhk
as
	select sMaMon,sMaHS,iHocKi,sNamHoc,convert(decimal(4,1),(fDiemM +fDiem15p+ (fDiem45p*2)+ (fDiemThi*3))/7) as [tbhk] from tblDiem
go
select * from v_tbmonhk
----2.2. Điểm TB 1 môn học kì 1
create view v_tbmonhk1
as
	select sMaMon,sMaHS,iHocKi, sNamHoc,tbhk from v_tbmonhk where iHocKi = 1
go
select * from v_tbmonhk1
----2.3. Điểm TB 1 môn học kì 2
create view v_tbmonhk2
as
	select sMaMon,sMaHS,iHocKi, sNamHoc,tbhk from v_tbmonhk where iHocKi = 2
go
select * from v_tbmonhk2
----2.4. Điểm TB 1 môn cả năm
create view v_tbmon_nam
as
	select sMaMon, sMaHS, sNamHoc, case when (select count(sMaMon) from v_tbmonhk1 group by sNamHoc,sMaHS,iHocKi) > (select count(sMaMon) from v_tbmonhk2 group by sNamHoc,sMaHS,iHocKi) then null when (select count(sMaMon) from v_tbmonhk1 group by sNamHoc,sMaHS,iHocKi) < (select count(sMaMon) from v_tbmonhk2 group by sNamHoc,sMaHS,iHocKi) then null else ((select sum(tbhk) from v_tbmonhk1 group by sMaHS, sNamHoc)/(select count(sMaMon) from v_tbmonhk1 group by sNamHoc,sMaHS,iHocKi)) end as [dtbmNamhk1] from v_tbmonhk1  /* a inner join v_tbmonhk2 b
	ON a.sMaMon = b.sMaMon and a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc */
go
select sum(tbhk) as [tong],sNamHoc, sMaHS from v_tbmonhk1 group by sMaHS, sNamHoc
----3. Điểm TB các môn học
select * from tblDiem
order by sNamHoc
select (count(sMaMon)) as [Tổng môn], sMaHS, iHocKi,sNamHoc from tblDiem
group by sNamHoc,sMaHS,iHocKi
order by sNamHoc
select (count(sMaMon)) as [Tổng môn], sMaHS, iHocKi,sNamHoc from v_tbmonhk1
group by sNamHoc,sMaHS,iHocKi
select * from tblDiem


-- view tổng điểm học kì 1
create view v_tdhk1
as
select sum(tbhk)as [tongdiem], sMaHS,sNamHoc from v_tbmonhk1 group by sMaHS, sNamHoc
go
select * from v_tdhk1
----view tổng số môn học kì 1
create view v_tmhk1
as
select count(sMaMon) as [tongmon],sMaHS,sNamHoc from v_tbmonhk1 group by sMaHS, sNamHoc
go
select * from v_tmhk1
---Điểm trung bình tất cả các môn học kì 1
create view v_tbtonghk1
as
select convert(decimal(4,2),(a.tongdiem/b.tongmon)) as [diemTBhk1], a.sMaHS, a.sNamHoc from v_tdhk1 a inner join v_tmhk1 b
on a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc
go

-- view tổng điểm học kì 2
create view v_tdhk2
as
select sum(tbhk)as [tongdiem], sMaHS,sNamHoc from v_tbmonhk2 group by sMaHS, sNamHoc
go
select * from v_tdhk2
----view tổng số môn học kì 2
create view v_tmhk2
as
select count(sMaMon) as [tongmon],sMaHS,sNamHoc from v_tbmonhk2 group by sMaHS, sNamHoc
go
select * from v_tmhk2
---Điểm trung bình tất cả các môn học kì 2
create view v_tbtonghk2
as
select convert(decimal(4,2),(a.tongdiem/b.tongmon)) as [diemTBhk2], a.sMaHS, a.sNamHoc from v_tdhk2 a inner join v_tmhk2 b
on a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc
go

---** View tính điểm TB tất cả các môn của học sinh cả năm
create view view_diemtbnam
as
select convert(decimal(4,1),((a.diemTBhk1+b.diemTBhk2)/2)) as [Điểm TB năm], a.sMaHS, a.sNamHoc from v_tbtonghk1 a inner join v_tbtonghk2 b
on a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc
go

----View so sánh tổng môn 2 học kì
drop view v_sstm
create view v_sstm
as
	select a.sMaHS, a.sNamHoc,case when a.tongmon > b.tongmon then 'no' when a.tongmon < b.tongmon then 'no' else 'ok' end as [check] from v_tmhk1 a inner join v_tmhk2 b
	ON a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc
go

-----*** View xem điểm TB tổng của học sinh cả năm
drop view view_tbcanam
create view view_tbcanam
as
	select g.sMaLop as [Mã lớp], g.sTenLop as [Tên lớp], c.sMaHS as [Mã HS], e.sHoTen  as [Họ và tên],c.sNamHoc as [Năm học], case (d.[check]) 
	when 'ok'
	then cast(c.[Điểm TB năm] as nvarchar)
	when 'no'
	then N'Chưa có' end as [Điểm TK năm] from v_tbtonghk1 a inner join v_tbtonghk2 b 
	ON a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc inner join view_diemtbnam c
	ON b.sMaHS = c.sMaHS and b.sNamHoc = c.sNamHoc inner join v_sstm d
	ON c.sMaHS = d.sMaHS and c.sNamHoc = d.sNamHoc inner join tblHocSinh e
	ON d.sMaHS = e.sMaHS inner join tblHocSinh f
	ON d.sMaHS = f.sMaHS inner join tblLop g
	ON f.sMaLop = g.sMaLop
go
select * from view_tbcanam
go

-----proc xem bang diem hoc sinh
CREATE PROCEDURE sp_bangdiem_search1
	@malop varchar(10),
	@namhoc varchar(10)
AS
BEGIN
SELECT [Mã lớp], [Tên lớp], [Mã HS], [Họ và tên], [Năm học], [Điểm TK năm] FROM view_tbcanam
WHERE 
	[Mã lớp] = (CASE ISNULL(@malop,'')
							WHEN '' THEN [Mã lớp]
							ELSE CONVERT(VARCHAR,@malop)
							END)
	AND [Năm học] = (CASE ISNULL(@namhoc,'')
							WHEN '' THEN [Năm học]
							ELSE CONVERT(VARCHAR,@namhoc)
							END)
END
GO

----Form chi tiết điểm HS
----1. View xem điểm TB 1 môn cả năm
drop view view_tbmonnam
create view view_tbmonnam
as
	select c.sMaLop as [Mã lớp], a.sMaHS as [Mã HS], e.sMaMon as [Mã môn], e.sTenMon as [Tên môn], c.sHoTen as [Họ và tên], convert(decimal(4,1),((a.tbhk+b.tbhk)/2)) as [Điểm TB môn], a.sNamHoc as [Năm học] from v_tbmonhk1 a inner join v_tbmonhk2 b
	ON a.sMaHS = b.sMaHS and a.sMaMon = b.sMaMon and a.sNamHoc = b.sNamHoc inner join tblHocSinh c
	ON b.sMaHS = c.sMaHS inner join tblLop d
	ON c.sMaLop = d.sMaLop inner join tblMonHoc e
	ON e.sMaMon = a.sMaMon
go
select * from view_tbmonnam
go
select * from tblDiem

---proc xem bảng điểm
create proc sp_bangdiem_ct
	@malop varchar(10),
	@mahs varchar(10),
	@namhoc varchar(10)
as
begin
	select * from view_tbmonnam where [Mã lớp] = @malop and [Mã HS] = @mahs and [Năm học] = @namhoc
end
go


-----view sĩ số lớp
create view view_sisolop
as

	select a.sMaLop as [Mã lớp], a.sTenLop as [Tên lớp], count(b.sMaHS) as [Sĩ số] from tblLop a inner join tblHocSinh b
	on a.sMaLop = b.sMaLop
	group by a.sMaLop,b.sMaLop,a.sTenLop
go

create view view_tbcanamnew
as
	select g.sMaLop as [Mã lớp], g.sTenLop as [Tên lớp], c.sMaHS as [Mã HS], e.sHoTen as [Họ và tên], DATEPART(YEAR,GETDATE()) - DATEPART(YEAR,f.dNgaySinh) as [Tuổi], c.sNamHoc as [Năm học], case (d.[check]) 
	when 'ok'
	then cast(c.[Điểm TB năm] as nvarchar)
	when 'no'
	then N'Chưa có' end as [Điểm TK năm] from v_tbtonghk1 a inner join v_tbtonghk2 b 
	ON a.sMaHS = b.sMaHS and a.sNamHoc = b.sNamHoc inner join view_diemtbnam c
	ON b.sMaHS = c.sMaHS and b.sNamHoc = c.sNamHoc inner join v_sstm d
	ON c.sMaHS = d.sMaHS and c.sNamHoc = d.sNamHoc inner join tblHocSinh e
	ON d.sMaHS = e.sMaHS inner join tblHocSinh f
	ON d.sMaHS = f.sMaHS inner join tblLop g
	ON f.sMaLop = g.sMaLop
go
select * from view_tbcanam
go

select sMaHS, dNgaySinh,  DATEPART(YEAR,GETDATE()) - DATEPART(YEAR,dNgaySinh) as [Tuổi] from tblHocSinh