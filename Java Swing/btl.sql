create database btl;

use btl; 
select * from giuongngu
select * from nhanvien
select * from nhataitro
select * from nhommau order by ten desc
update taikhoan set phanquyen = 1 where tentaikhoan = 12345
select * from taikhoan
select * from doituong
select * from chucvu as cv inner join nhanvien as nv on cv.machucvu = nv.chucvu_id inner join tienluong as tl on tl.matienluong = cv.tienluong_id where nv.chucvu_id = 12345
select * from kho as k left join sanpham as sp on sp.id = k.sanppham_id where k.sanppham_id = 1

select * from taikhoan as tk 
left join nhanvien as nv on tk.tentaikhoan = nv.manhanvien
left join benhnhan as bn on tk.tentaikhoan =  bn.mabenhnhan 
where tk.tentaikhoan = 12345678 and tk.matkhau = '12345'
 
select * from benhnhan right join doituong on benhnhan.doituong_id = doituong.madoituong where doituong.madoituong = 2
select * from benhnhan
select * from benhnhan left join hoadon on benhnhan.mabenhnhan = hoadon.mabenhnhan where benhnhan.mabenhnhan not in (select mabenhnhan from hoadon)

drop database btl

create table doituong(
	id int auto_increment unique,
    madoituong int primary key,
    tendoituong nvarchar(50),
    ngaythem datetime
);

select * from doituong

create table loaisanpham(
	id int primary key auto_increment,
    tenloai nvarchar(50),
    ngaytao date
);

create table taikhoan(
	id int auto_increment unique,
    tentaikhoan int primary key,
    matkhau nvarchar(50),
    phanquyen int
);

create table nhommau(
	id int auto_increment unique,
    ten nvarchar(100) primary key,
    ngaytao date
);

select * from nhommau



create table tienluong(
	id int auto_increment unique,
    matienluong int primary key,
    tienluong int,
    ngaycong int,
    ngaytao date
);

create table chucvu(
	id int auto_increment unique,
    machucvu int primary key,
    tenchucvu nvarchar(100),
    ngaytao datetime,
    tienluong_id int,
    foreign key (tienluong_id) references tienluong(matienluong),
    khenthuong int
);
drop table chucvu

create table nhanvien(
	id int auto_increment unique,
    manhanvien int primary key,
    foreign key (manhanvien) references taikhoan(tentaikhoan),
    hoten nvarchar(50),
    ngaysinh date,
    diachi nvarchar(200),
    email nvarchar(200),
    gioitinh int,
    thanhtich nvarchar(100),
    noicongtac nvarchar(200),
    chucvu_id int,
    foreign key (chucvu_id) references chucvu(machucvu),
    ngayvao date
);
select * from taikhoan
drop table nhanvien
insert into bacsi select * from nhanvien where chucvu_id = 5 and chucvu_id = 6
drop table bacsi
create table bacsi(
	id int auto_increment unique,
    manhanvien int primary key,
    foreign key (manhanvien) references taikhoan(tentaikhoan),
    hoten nvarchar(50),
    ngaysinh date,
    diachi nvarchar(200),
    email nvarchar(200),
    gioitinh int,
    thanhtich nvarchar(100),
    noicongtac nvarchar(200),
    chucvu_id int,
    foreign key (chucvu_id) references chucvu(machucvu),
    ngayvao date
);
insert into yta select * from nhanvien where chucvu_id = 1 and chucvu_id = 2
drop table yta
create table yta(
	id int auto_increment unique,
    manhanvien int primary key,
    foreign key (manhanvien) references taikhoan(tentaikhoan),
    hoten nvarchar(50),
    ngaysinh date,
    diachi nvarchar(200),
    email nvarchar(200),
    gioitinh int,
    thanhtich nvarchar(100),
    noicongtac nvarchar(200),
    chucvu_id int,
    foreign key (chucvu_id) references chucvu(machucvu),
    ngayvao date
);

drop table yta
drop table bacsi
drop table nhanvien

create table benhnhan(
	id int auto_increment unique,
    mabenhnhan int primary key,
    foreign key (mabenhnhan) references taikhoan(tentaikhoan),
    hoten nvarchar(50),
    ngaysinh date,
    diachi varchar(200),
    gioitinh int,
    nhommau nvarchar(100),
    foreign key (nhommau) references nhommau(ten),
    tinhtrang nvarchar(200),
    chucvu_id int,
    foreign key(chucvu_id) references chucvu(machucvu),
    doituong_id int,
    foreign key (doituong_id) references doituong(madoituong),
    ngayvao date
);
drop table benhnhan
create table tienluong(
	id int auto_increment unique,
    matienluong int primary key,
    tienluong int,
    ngaycong int,
    ngaytao date
);
insert into tienluong(matienluong, tienluong, ngaycong, ngaytao) values (1, 9000000, 30, '2022-10-10')
create table sanpham(
	id int primary key auto_increment,
    tensanpham nvarchar(50),
    loaisanpham_id int,
    foreign key (loaisanpham_id) references loaisanpham(id),
    mieuta nvarchar(100),
    giaban int,
    ngaytao date
);
drop table sanpham
create table hoadon(
	id int primary key auto_increment,
    mabenhnhan int,
    foreign key (mabenhnhan) references benhnhan(mabenhnhan),
    ngayra datetime,
    phuongphapdieutri nvarchar(100),
    mieuta nvarchar(200),
    thuoc_id int,
    foreign key (thuoc_id) references sanpham(id),
    soluong int,
    tongtienthuoc int,
    tongtien int,
    ngaytao date
);

drop table hoadon

create table kho(
	id int primary key auto_increment,
    sanppham_id int,
    foreign key (sanppham_id) references sanpham(id),
    soluong int,
    soluongnhap int,
    daban int,
    tonkho int,
    ngaytao date
);

drop table kho

create table loaigiuong(
	id int primary key auto_increment,
    tengiuong nvarchar(100),
    soluong int,
    ngaytao date
);

create table giuongngu(
	id int primary key auto_increment,
    giuong_id int,
    foreign key (giuong_id) references loaigiuong(id),
    benhnhan_id int,
    foreign key(benhnhan_id) references benhnhan(mabenhnhan),
    thoigiannam date,
    thoigianra date
);
drop table giuongngu
create table cuochen(
	id int primary key auto_increment,
    bacsi nvarchar(100),
    benhnhan nvarchar(100),
    noidung nvarchar(200),
    thoigian datetime
);

create table nhataitro(
	id int auto_increment unique,
    manhataitro int primary key,
    foreign key (manhataitro) references taikhoan(tentaikhoan),
    hoten nvarchar(50),
    ngaysinh date,
    diachi nvarchar(200),
    email nvarchar(200),
    gioitinh int,
    sodienthoai nvarchar(20),
    tinhtrangbenh nvarchar(50),
    taitro nvarchar(50),
    foreign key (taitro)references nhommau(ten),
    ngaytao date
);

create table hoadonnhap(
	id int primary key auto_increment,
    tensanpham nvarchar(100),
    maloai int,
    foreign key (maloai) references loaisanpham(id),
    gianhap int,
    soluong int,
    makho int,
    foreign key (makho) references kho(id),
    nhanvien_id int,
    foreign key (nhanvien_id) references nhanvien(manhanvien),
    ngaytao date
);
drop table nhataitro
insert into doituong(madoituong ,tendoituong, ngaythem) values (1, 'dac biet', '2022-10-10');
select * from doituong;

create table thacmac(
	id int primary key auto_increment,
    nguoigui_id int,
    foreign key (nguoigui_id) references taikhoan(tentaikhoan),
    tieude nvarchar(50),
    sodienthoai nvarchar(20),
    email nvarchar(200),
    diachi nvarchar(200),
    noidung nvarchar(200),
    trangthai nvarchar(50),
    ngaygui date
);

create table phanhoi(
	id int primary key auto_increment,
    nguoigui_id int,
    foreign key (nguoigui_id) references taikhoan(tentaikhoan),
    nguoinhan_id int,
    foreign key (nguoinhan_id) references taikhoan(tentaikhoan),
    tieude nvarchar(50),
    chucvu nvarchar(50),
    noidung nvarchar(200),
    ngaygui date
);
drop table thacmac
select * from thacmac
select * from phanhoi where id = 1
