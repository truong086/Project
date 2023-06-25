create database quanlyhocphi11s
go 

use quanlyhocphi11s
go
use quanlyhocphi11
go

select * from lichsu

select * from taikhoan

create table doituong(
	madoituongtt int identity(1,1) unique, -- "unique key" là duy nhất
	madoituong int primary key,
	tendoituong nvarchar(50)
)
go

create table khoa(
	makhoatt int identity(1,1) unique,
	makhoa int primary key,
	tenkhoa nvarchar(100),
	GVCNkhoa nvarchar(100)
)
go

create table nganh(
	manganhtt int identity(1,1) unique,
	manganh int primary key,
	makhoa int references khoa(makhoa),
	tennganh nvarchar(100)
)
go

create table lop(
	maloptt int identity(1,1) unique,
	malop int primary key,
	manganh int references nganh(manganh),
	tenlop nvarchar(50),
	GVCNlop nvarchar(50),
	khoahoc nvarchar(20)
)
go
create table sinhvien(
	masvtt int identity (1,1) unique,
	msv int primary key,
	madoituong int references doituong(madoituong),
	malop int references lop(malop),
	hoten nvarchar(50),
	ngaysinh date,
	diachi nvarchar(200),
	gioitinh nvarchar(20)
)
go
alter table sinhvien
add thongbao nvarchar(100)
create table taikhoannganhangSV(
	manganhang int primary key identity(1,1),
	msv int references sinhvien(msv),
	tennganhang nvarchar(100),
	chinhanh nvarchar(100),
	sotaikhoan nvarchar(50),
	tentaikhoan nvarchar(50),
	ngaytao datetime
)
go
create table taikhoannhantienHP(
	mataikhoannhantien int primary key identity(1,1),
	tennganhhang nvarchar(100),
	tenchinhanh nvarchar(100),
	sotaikhoanNT nvarchar(50),
	tentaikhoanNT nvarchar(50),
	ngaytao datetime
)
go
create table monhoc(
	mamonhoctt int identity(1,1) unique,
	mamonhoc int primary key,
	tenmonhoc nvarchar(100)
)
go
create table phieuthu(
	maphieuthu int primary key identity(1,1),
	msv int references sinhvien(msv),
	mamonhoc int references monhoc(mamonhoc),
	tenkhoanthu nvarchar(150),
	namhoc nvarchar(20),
	hocky nvarchar(20),
	ngaythu date,
	sotien float,
	hinhthuc nvarchar(20),
	mataikhoannganhangSV int references taikhoannganhangSV(manganhang),
	mataikhoannhantienHP int references taikhoannhantienHP(mataikhoannhantien)
)
go
drop table phieuthu
go
create table taikhoan(
	mataikhoantt int identity(1,1) unique,
	tentaikhoan int primary key references sinhvien(msv),
	matkhau nvarchar(20),
	capquyen int
)
go

create table lichsu(
	masvtt int identity (1,1) unique,
	msv int,
	madoituong int references doituong(madoituong),
	malop int references lop(malop),
	hoten nvarchar(50),
	ngaysinh date,
	diachi nvarchar(200),
	gioitinh nvarchar(20),
	mota nvarchar(250),
	id_taikhoan int references taikhoan(tentaikhoan)
)
go

drop table lichsu
go

create table thacmac(
	maduynhat int primary key identity(1,1),
	msv_id int references sinhvien(msv),
	lop_id int references lop(malop),
	khoahoc nvarchar(50),
	email nvarchar(150),
	sodienthoai nvarchar(20),
	diachi nvarchar(200),
	noidung nvarchar(500),
	trangthai nvarchar(50)
)
go
alter table thacmac
add trangthai nvarchar(50)

alter table thacmac
add maduynhat int identity(1,1) unique

select * from phanhoi


create table phanhoi(
	maphanhoiduynhat int primary key identity(1,1),
	tentaikhoan nvarchar(50),
	email nvarchar(150),
	sodienthoai nvarchar(20),
	chucvu nvarchar(50),
	noidung nvarchar(500),
	trangthai nvarchar(50),
	msv_id int references sinhvien(msv)
)
go
alter table phanhoi 
add trangthai nvarchar(50)
add msv_id int references sinhvien(msv)
drop table phanhoi
select * from thacmac
select * from taikhoan
insert into doituong(madoituong, tendoituong) values (1, 'Uu tien'),
												(2, 'Binh thuong')
												go

insert into khoa(makhoa, tenkhoa, GVCNkhoa) values (113, 'CONG NGHE THONG TIN', 'Nguyen Van A'),
										 (114, 'DU LICH', 'Nguyen van B'),
										 (115, 'LUAT', 'Nguyen Van C'),
										 (116, 'QUAN TRI KINH DOANH', 'Nguyen Van D'),
										 (117, 'KY THUAT O TO', 'Tran Van A'),
										 (118, 'DUOC', 'Pham Van C')
										 GO

insert into nganh(manganh, makhoa, tennganh) values (123, 113, 'lap trinh weg'),
													(124, 113, 'Tri tue nhan tao'),
													(125, 113, 'Dien toan dam may'),
													(126, 113, 'Lap trinh Android'),
													(127, 113, 'Lap trinh IOS'),
													(128, 114, 'Huong dan vien du lich'),
													(129, 114, 'Quan ly, dieu hanh du lich'),
													(130, 114, 'Nhan vien phuc vu khach'),
													(131, 114, 'Nhan vien Marketing du lich'),
													(132, 115, 'Luat dat dai'),
													(133, 115, 'Luat nha nuoc'),
													(134, 115, 'Luat lao dong'),
													(135, 115, 'Luat dan su'),
													(136, 116, 'Quan tri kinh doanh'),
													(137, 116, 'Quan tri nhan luc'),
													(138, 116, 'Marketing')
													go

insert into lop(malop, manganh, tenlop, GVCNlop, khoahoc) values (1, 123, 'P.602 - GD2', 'Nguyen van A', 'Khoa 14'),
																(2, 124, 'P.702 - GD1', 'Nguyen Van A', 'Khoa 14'),
																(3, 125, 'P.606 - GD2', 'Nguyen Van A', 'Khoa 14'),
																(4, 126, 'P.604 - GD2', 'Nguyen Van A', 'Khoa 14'),
																(5, 128, 'P.201 - GD1', 'Nguyen Van B', 'Khoa 15'),
																(6, 129, 'P.301 - GD1', 'Nguyen Van B', 'Khoa 15'),
																(7, 130, 'P.303 - GD2', 'Nguyen Van B', 'Khoa 16'),
																(8, 131, 'P.401 - GD1', 'Nguyen Van B', 'Khoa 15'),
																(9, 132, 'P.501 - GD1', 'Nguyen Van C', 'Khoa 16'),
																(10, 133, 'P.601 - GD2', 'Nguyen Van D', 'Khoa 14'),
																(11, 134, 'P.602 - GD2', 'Nguyen Van D', 'Khoa 14'),
																(12, 135, 'P.502 - GD2', 'Nguyen Van E', 'Khoa 15'),
																(13, 136, 'P.601 - GD2', 'Nguyen Van G', 'Khoa 12'),
																(14, 137, 'P.601 - GD2', 'Nguyen Van P', 'Khoa 13'),
																(15, 138, 'P.601 - GD2', 'Nguyen Van K', 'Khoa 16')
																go
insert into sinhvien(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (12345, 2, 1, 'Nguyen Van A', '2002-08-01', 'Ha Noi', 'Nam'),
																						(12346, 2, 2, 'Nguyen Van B', '2002-08-02', 'Ha Nam', 'Nam'),
																						(12347, 2, 3, 'Nguyen Van C', '2002-08-03', 'Sai Gon', 'Nam'),
																						(12348, 2, 4, 'Nguyen Van D', '2002-08-04', 'Da Nang', 'Nam'),
																						(12349, 2, 5, 'Nguyen Van E', '2002-08-05', 'Ha Dong', 'Nam'),
																						(12341, 2, 6, 'Nguyen Van G', '2002-09-01', 'Thanh Xuan', 'Nam'),
																						(12342, 2, 7, 'Nguyen Van H', '2002-09-01', 'Tay Nguyen', 'Nam'),
																						(12343, 2, 8, 'Tran van A', '2002-10-11', 'Cao Bang', 'Nam'),
																						(12344, 2, 9, 'Tran van B', '2002-11-12', 'Ha Noi', 'Nam'),
																						(123410, 2, 10, 'Tran van C', '2002-12-01', 'Nha Trang', 'Nam'),
																						(123411, 2, 11, 'Tran van D', '2002-05-01', 'Quy Nhon', 'Nam'),
																						(123412, 2, 12, 'Pham Van A', '2002-06-02', 'Ha Noi', 'Nam'),
																						(123413, 2, 1, 'Pham Van B', '2002-01-03', 'Nam Dinh', 'Nam'),
																						(123414, 2, 2, 'Pham Van C', '2002-02-20', 'Ca Mau', 'Nam'),
																						(123415, 2, 3, 'Pham Van D', '2002-10-19', 'Ha Noi', 'Nam')
																						go

insert into sinhvien(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (123416, 1, 1, 'Nguyen Van AB', '2002-09-02', 'Ha Noi', 'Nam'),
																						(123417, 1, 2, 'Nguyen Van BC', '2002-10-02', 'Ha Nam', 'Nam'),
																						(123418, 1, 3, 'Nguyen Van CD', '2002-11-06', 'Sai Gon', 'Nam')
																						go

insert into monhoc(mamonhoc, tenmonhoc) values  (211, 'Lap trinh C++'),
												(212, 'Lap trinh Web'),
												(213, 'Lap trinh Web 2'),
												(214, 'Lap trinh Python'),
												(215, 'Lap trinh Net cb'),
												(216, 'Lap trinh Net nc'),
												(217, 'Lap trinh Ruby'),
												(218, 'Lap trinh Java'),
												(219, 'Lap trinh PHP'),
												(220, 'Lap trinh Go'),
												(221, 'Lap trinh C'),
												(222, 'Lap trinh Android'),
												(223, 'Lap trinh Ios'),
												(224, 'Lap trinh Fontend'),
												(225, 'Lap trinh Backend')
												go

insert into phieuthu(msv, mamonhoc, tenkhoanthu, namhoc, hocky, sotien, hinhthuc, mataikhoannganhangSV, mataikhoannhantienHP) values ( 12345, 211, 'Hoc Phi', 'Nam hoc 2022', 'Hoc Ky I' ,9000000, 'Online', 1, 1),
																																						  ( 12346, 222, 'Hoc Phi', 'Nam hoc 2020', 'Hoc Ky II' ,9000000, 'Truc tiep', 12, 1),
																																						  ( 12347, 212, 'Hoc Phi', 'Nam hoc 2021', 'Hoc Ky I' ,9000000, 'Truc tiep', 11, 1),
																																						  ( 12348, 225, 'Hoc Phi', 'Nam hoc 2019', 'Hoc Ky II' ,9000000, 'Truc tiep', 10, 1),
																																						  ( 12349, 216, 'Hoc Phi', 'Nam hoc 2018', 'Hoc Ky I' ,9000000, 'Online', 2, 1),
																																						  ( 123410, 218, 'Hoc lai', 'Nam hoc 2022', 'Hoc Ky I' ,2400000, 'Truc tiep', 3, 1),
																																						  ( 123411, 220, 'Hoc lai', 'Nam hoc 2021', 'Hoc Ky II' ,2400000, 'Online', 4, 1),
																																						  ( 12345, 223, 'Thi lai', 'Nam hoc 2022', 'Hoc Ky I' ,250000, 'Online', 5, 1),
																																						  ( 12346, 221, 'Thi lai', 'Nam hoc 2020', 'Hoc Ky I' ,250000, 'Online', 6, 1),
																																						  ( 12348, 213, 'Thi nang diem', 'Nam hoc 2018', 'Hoc Ky I' ,250000, 'Truc tiep', 8, 1),
																																						  ( 12349, 215, 'Hoc Phi', 'Nam hoc 2019', 'Hoc Ky II' ,9000000, 'Online', 10, 1),
																																						  ( 123415, 222, 'Thi nang diem', 'Nam hoc 2022', 'Hoc Ky I' ,250000, 'Online', 11, 1),
																																						  ( 123410, 211, 'Hoc Phi', 'Nam hoc 2020', 'Hoc Ky I' ,9000000, 'Online', 12, 1),
																																						  ( 123411, 219, 'Hoc Phi', 'Nam hoc 2022', 'Hoc Ky I' ,9000000, 'Online', 10, 1),
																																						  ( 123412, 221, 'Hoc Phi', 'Nam hoc 2022', 'Hoc Ky II' ,9000000, 'Truc tiep', 15, 1)
																																						  go

insert into phieuthu(maphieuthu, msv, mamonhoc, tenkhoanthu, namhoc, hocky, sotien, hinhthuc, mataikhoannganhangSV, mataikhoannhantienHP) values (18, 12345, 211, 'Hoc Phi', 'Nam hoc 2022', 'Hoc Ky I' ,9000000, 'Online', 1, 1)
go
																																						 

insert into taikhoannganhangSV(manganhang, msv, tennganhang, chinhanh, sotaikhoan, tentaikhoan) values  (1, 12345, 'MBBANK', 'Hoai Duc', '0123456789', 'Nguyen Van A'),
												(2, 12346, 'TECHCOMBANK', 'Hoai Duc', '0123456789', 'Nguyen Van B'),
												(3, 12347, 'SACOMBANK', 'Tay Ho', '0928342344', 'Nguyen Van C'),
												(4, 12348, 'VIETTINKNBANK', 'Ha Noi', '234543223', 'Nguyen Van D'),
												(5, 12345, 'ARIBANK', 'Ha Noi', '23453453', 'Nguyen Van A'),
												(6, 123410, 'TPBANK', 'Hoai Duc', '423562312', 'Tran Van C'),
												(7, 123411, 'VIETCOMBANK', 'Hoai Duc', '45363423', 'Tran Van D'),
												(8, 123415, 'MBBANK', 'Ha Dong', '7567323442', 'Nguyen Van A'),
												(9, 123412, 'TPBANK', 'Thank Xuan', '235456764', 'Nguyen Van A'),
												(10, 12348, 'SACOMBANK', 'Nguyen Trai', '775854343', 'Nguyen Van C'),
												(11, 12349, 'TECHCOMBANK', 'Ha Dong', '56853243545', 'Nguyen Van D'),
												(12, 123410, 'MBBANK', 'Tay Ho', '0757656789', 'Nguyen Van F'),
												(13, 123412, 'TPBANK', 'Ha Noi', '9578473456', 'Nguyen Van G'),
												(14, 123415, 'MBBANK', 'Hoai Duc', '53457859', 'Nguyen Van H'),
												(15, 12345, 'VIETCOMBANK', 'Ha Noi', '4234255453', 'Nguyen Van B')
												go	

insert into taikhoan(tentaikhoan, matkhau, capquyen) values (12345, '123', 3),
															(12346, '123', 3),
															(12347, '123', 3),
															(12348, '123', 3),
															(12349, '123', 3),
															(123410, '123', 3),
															(123411, '123', 3),
															(123412, '123', 3),
															(123413, '123', 3),
															(123414, '123', 3),
															(123415, '123', 3),
															(12341, '123', 3),
															(12342, '123', 3),
															(12343, '123', 3),
															(12344, '123', 3)
															go
insert into phieuthu(maphieuthu, msv, mamonhoc, tenkhoanthu, namhoc, hocky, sotien, hinhthuc, mataikhoannganhangSV, mataikhoannhantienHP) values (19, 12345, 211, 'Hoc Phi', 'Nam hoc 2022', 'Hoc Ky I' ,9000000, 'Online', 1, 1),
																																						  (20, 12346, 222, 'Hoc Phi', 'Nam hoc 2020', 'Hoc Ky II' ,9000000, 'Truc tiep', 12, 1),
																																						  (21, 12347, 212, 'Hoc Phi', 'Nam hoc 2021', 'Hoc Ky I' ,9000000, 'Truc tiep', 11, 1),
																																						  (22, 12348, 225, 'Hoc Phi', 'Nam hoc 2019', 'Hoc Ky II' ,9000000, 'Truc tiep', 10, 1),
																																						  (23, 12349, 216, 'Hoc Phi', 'Nam hoc 2018', 'Hoc Ky I' ,9000000, 'Online', 2, 1)
																																						  go
insert into taikhoannhantienHP(mataikhoannhantien, tennganhhang, tenchinhanh, sotaikhoanNT, tentaikhoanNT) values  (1, 'MBBANK', 'Hoai Duc', '932748233', 'Nguyen Van P') 
go	



SET IDENTITY_INSERT taikhoannhantienHP ON
GO
select * into dacbiet from sinhvien where madoituong = 1
-- Chia các sinh viên khóa 14 vào 1 bảng
select sinhvien.msv, hoten, madoituong, tenlop, khoahoc into khoa14 from sinhvien inner join lop on sinhvien.malop = lop.malop where lop.khoahoc like '%14'
select * from khoa14
-- Chia các sinh viên khóa 15 vào 1 bảng
select sinhvien.msv, hoten, madoituong, tenlop, khoahoc into khoa15 from sinhvien left join lop on sinhvien.malop = lop.malop where lop.khoahoc like '%15'

select * from lop
select * from sinhvien
select * from nganh
select * from khoa
select * from phieuthu
select * from taikhoan

-- Chia các sinh viên ngành công nghệ thông tin vào 1 bảng
select sinhvien.msv, sinhvien.hoten, sinhvien.diachi, sinhvien.gioitinh, lop.malop, lop.tenlop, nganh.manganh, nganh.tennganh into nganhCNTT from ((lop left join sinhvien on lop.malop = sinhvien.malop) left join nganh on nganh.manganh = lop.manganh) where nganh.makhoa = 113
select * from nganhCNTT

select sinhvien.msv, sinhvien.hoten, sinhvien.diachi, sinhvien.gioitinh, lop.malop, lop.tenlop, nganh.manganh, nganh.tennganh from ((lop left join sinhvien on lop.malop = sinhvien.malop) left join nganh on nganh.manganh = lop.manganh) where nganh.makhoa = 113

-- Chia các sinh viên không phải công nghệ thông tin vào 1 bảng, sử dụng toán tử "<>", toán tử "<>" nghĩa là không thuộc
select sinhvien.msv, sinhvien.hoten, sinhvien.diachi, sinhvien.gioitinh, lop.malop, lop.tenlop, nganh.manganh, nganh.tennganh into KhongPhaiCNTT from ((lop inner join sinhvien on lop.malop = sinhvien.malop) inner join nganh on nganh.manganh = lop.manganh) where nganh.makhoa <> 113
select * from KhongPhaiCNTT

-- Chia các sinh viên có trường hợp đặc biệt
select * into SinhVienDB from sinhvien where sinhvien.madoituong <> 2

Create proc timkiem(@timk nvarchar(50))
as
begin
	select * from sinhvien where hoten like '%@timk%'
end
go
exec timkiem N'NguyenVan A'
select * from sinhvien
drop proc timkiem

-- Lấy ra những sinh viên đã đóng học phí
select phieuthu.maphieuthu ,phieuthu.msv, phieuthu.mamonhoc, phieuthu.tenkhoanthu, phieuthu.namhoc, phieuthu.sotien, sinhvien.hoten, sinhvien.diachi into dadongHocPhi from phieuthu inner join sinhvien on phieuthu.msv = sinhvien.msv where sinhvien.msv in 
(select msv from phieuthu)
select * from dadongHocPhi

-- Lấy ra các sinh viên chưa đóng học phí
select phieuthu.maphieuthu ,phieuthu.msv, phieuthu.mamonhoc, phieuthu.tenkhoanthu, sinhvien.hoten, sinhvien.diachi into chuadongHocPhi from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv not in 
(select msv from phieuthu)
select * from chuadongHocPhi

select sinhvien.masvtt ,sinhvien.msv, sinhvien.madoituong, sinhvien.malop, sinhvien.hoten, sinhvien.ngaysinh, sinhvien.diachi, sinhvien.gioitinh into chuadongHocPhiss from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv not in 
(select msv from phieuthu)
select * from chuadongHocPhiss

-- Tìm kiếm sinh viên theo mã tài khoản ngân hàng
create proc timmkiemNH(@tk int)
as
begin
	select * from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv in (select msv from phieuthu where phieuthu.mataikhoannganhangSV = @tk)
end
go
exec timmkiemNH 12

create proc TKSV(@tk int)
as
begin
	select * into TKSINHVIEN from sinhvien where msv = @tk
	if exists(select * from TKSINHVIEN)
		select * from TKSINHVIEN
	else
		print N'Khong co'
end
go
exec TKSV 12345

-- Tính tổng số sinh viên đã đóng học phí, liên kết 2 bảng
create view PhieuThuS
as
select sinhvien.msv, COUNT(phieuthu.msv) as soluong from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv group by sinhvien.msv
go
select * from PhieuThuS

create view PhieuTHu1
as
	select phieuthu.msv ,COUNT(phieuthu.msv) as soluong from phieuthu group by phieuthu.msv
go
select * from PhieuTHu1

-- Chia các sinh viên K14
select * into SinhVienK14 from sinhvien where malop <= 4 or malop = 11 or malop = 10
select * from SinhVienK14
select * from sinhvien

-- Chia các sinh viên K15
select * into SinhVienK15 from sinhvien where malop = 5 or malop = 6 or malop = 8 or malop = 12
select * from SinhVienK15

-- Chia các sinh viên K16
select * into SinhVienK16 from sinhvien where malop = 7 or malop = 9 or malop = 15
select * from SinhVienK16

-- Chia các sinh viên K13
select * into SinhVienK13 from sinhvien where malop = 13
select * from SinhVienK13

-- Chia các sinh viên K12
select * into SinhVienK12 from sinhvien where malop = 14
select * from SinhVienK12

create proc Addsinhvien @msv int, @madoituong int, @malop int, @hocten nvarchar(50), @ngaysinh nvarchar(50), @diachi nvarchar(50), @gioitinh nvarchar(20)
as
begin
	if(@malop <= 4 or @malop = 10 or @malop = 11)
		insert into SinhVienK14(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@msv, @madoituong, @malop, @hocten, @ngaysinh, @diachi, @gioitinh)
	if(@malop = 5 or @malop = 6 or @malop = 8 or @malop = 12)
		insert into SinhVienK15(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@msv, @madoituong, @malop, @hocten, @ngaysinh, @diachi, @gioitinh)
	if(@malop = 7 or @malop = 9 or @malop = 15)
		insert into SinhVienK14(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@msv, @madoituong, @malop, @hocten, @ngaysinh, @diachi, @gioitinh)
	if(@malop = 13)
		insert into SinhVienK13(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@msv, @madoituong, @malop, @hocten, @ngaysinh, @diachi, @gioitinh)
	if(@malop = 14)
		insert into SinhVienK12(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@msv, @madoituong, @malop, @hocten, @ngaysinh, @diachi, @gioitinh)
end
go
exec Addsinhvien 123485, 2, 2, N'Nguyen Van AB', N'2002-10-02', N'Ha Noi', N'Nam'
select * from taikhoan

create function timkiemFunc(@tk int)
returns int
as
	begin
		return(select COUNT(*) as Tong from phieuthu inner join sinhvien on phieuthu.msv = sinhvien.msv where phieuthu.mamonhoc = @tk)
	end
go
print dbo.timkiemFunc (221)
print dbo.timkiemFunc (220)
print dbo.timkiemFunc (222)

select * from nganh
-- Chia các ngành CNTT
select * into nganhcntt1 from nganh where makhoa = 113
select * from nganhcntt1
-- Chia các ngành du lịch
select * into nganhdulich from nganh where makhoa = 114
-- Chia các ngành luật
select * into nganhluat from nganh where makhoa = 115
-- Chia các ngành quản trị kinh doanh
select * into nganhQTKD from nganh where makhoa = 116

create proc Addnganh @manganh int, @makhoa int, @tennganh nvarchar(100)
as
begin
	if(@makhoa = 113)
		insert into nganhcntt1(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)
	if(@makhoa = 114)
		insert into nganhdulich(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)
	if(@makhoa = 115)
		insert into nganhluat(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)
	if(@makhoa = 116)
		insert into nganhQTKD(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)
end
go
exec Addnganh 150, 113, N'Big Data'

-- Hiển thị học phí các ngành sử dụng liên kết 3 bảng và truy vấn con
select phieuthu.msv, phieuthu.maphieuthu, phieuthu.mamonhoc, phieuthu.tenkhoanthu, phieuthu.namhoc, phieuthu.hocky, phieuthu.ngaythu, phieuthu.sotien, phieuthu.hinhthuc into hocphinganh from ((sinhvien inner join lop on sinhvien.malop = lop.malop) inner join phieuthu on phieuthu.msv = sinhvien.msv) where lop.manganh = 125 and sinhvien.msv in (select msv from phieuthu where phieuthu.msv = sinhvien.msv)

select phieuthu.msv, phieuthu.maphieuthu, phieuthu.mamonhoc, phieuthu.tenkhoanthu, phieuthu.namhoc, phieuthu.hocky, phieuthu.ngaythu, phieuthu.sotien, phieuthu.hinhthuc into hocphinganh126 from ((sinhvien inner join lop on sinhvien.malop = lop.malop) inner join phieuthu on phieuthu.msv = sinhvien.msv) 
where lop.manganh = 126 and sinhvien.msv in (select msv from phieuthu where phieuthu.msv = sinhvien.msv)
select * from hocphinganh126
-- K14
update lop set tenlop = 'CNTT 14-01' where malop = 1 or malop = 11
update lop set tenlop = 'CNTT 14-02' where malop = 2
update lop set tenlop = 'CNTT 14-03' where malop = 3
update lop set tenlop = 'CNTT 14-04' where malop = 4
update lop set tenlop = 'CNTT 14-05' where malop = 10
-- K15
update lop set tenlop = 'CNTT 15-01' where malop = 5
update lop set tenlop = 'CNTT 15-02' where malop = 6
update lop set tenlop = 'CNTT 15-03' where malop = 8
update lop set tenlop = 'CNTT 15-04' where malop = 12
-- K16
update lop set tenlop = 'CNTT 16-01' where malop = 7
update lop set tenlop = 'CNTT 16-02' where malop = 9
update lop set tenlop = 'CNTT 16-03' where malop = 15
-- K12
update lop set tenlop = 'CNTT 12-01' where malop = 13
-- K13
update lop set tenlop = 'CNTT 13-01' where malop = 14

update taikhoan set capquyen = 1 where tentaikhoan = 12345
select * from taikhoan
select * from dacbiet
select * from SinhVienK14
select * from khoa
select * from phieuthu
select * from lop
select * from nganh
select * from sinhvien
select * from phieuthu

delete sinhvien where msv = 123418
select sinhvien.masvtt, sinhvien.msv, sinhvien.madoituong, sinhvien.malop, sinhvien.hoten, sinhvien.ngaysinh, sinhvien.diachi, sinhvien.gioitinh, phieuthu.maphieuthutt, phieuthu.maphieuthu, phieuthu.msv, phieuthu.mamonhoc, phieuthu.tenkhoanthu, phieuthu.namhoc, phieuthu.hocky, phieuthu.ngaythu, phieuthu.sotien, phieuthu.hinhthuc, phieuthu.mataikhoannganhangSV, phieuthu.mataikhoannhantienHP from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv = phieuthu.msv and sinhvien.msv in (select msv from phieuthu) 
select * from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv = phieuthu.msv and sinhvien.msv in (select msv from phieuthu)