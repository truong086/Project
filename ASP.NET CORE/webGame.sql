create database webGame

use webGame

create table theloai(
	id int primary key identity(1,1),
	ten nvarchar(50),
	ngaytao datetime
)
go

create table sanpham(
	id int primary key identity(1,1),
	ten nvarchar(50),
	noidung nvarchar(200),
	solanclick int,
	gia int,
	ngaytao datetime
)
go
alter table sanpham
add hinhanh nvarchar(500)
add theloai_id int references theloai(id)
create table orders(
	id int primary key identity(1,1),
	ten nvarchar(100),
	statuc int,
	ngaytao datetime
)
go
select * from orders
alter table orders
add users_id int references takhoan(id)
select * from orders
create table orderDetais(
	id int primary key identity(1,1),
	order_id int references orders(id),
	sanpham_id int references sanpham(id),
	soluong int
)
go
select * from orderDetais
alter table orderDetais
add tongtien int


create table takhoan(
	id int primary key identity(1,1),
	tentaikhoan nvarchar(50) unique,
	matkhau nvarchar(50),
	fullname nvarchar(50),
	email nvarchar(200) unique,
	phanquyen int
)
go
drop table takhoan
select * from takhoan
insert into takhoan(tentaikhoan, matkhau, fullname, email, phanquyen) values ('A123', '123', 'A', 'a@gmail.com', 1)