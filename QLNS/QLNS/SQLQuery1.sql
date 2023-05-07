create database QLNS
create table DangNhap(
	Tendn char(250),
	Matkhau char(10),
	Quyen char(50)
)
insert into DangNhap values('Admin','123','admin')
insert into DangNhap values('User','123','user')
drop table DangNhap
--------------------

create table NhanVien(
	MaNV char(10),
	TenNV nvarchar(250),
	Gioitinh nvarchar(5),
	Diachi nvarchar(250),
	Quequan nvarchar(250),
	Ngaysinh date,
	SDT char(10),
	TrinhdoHV char(50),
	MaCV char(10),
	MaPB char(10),
	MaBH char(10),
	Luong float,
	primary key(MaNV)
)
ALTER TABLE NhanVien
ADD CONSTRAINT FK_MaCV
FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV);

create table ChucVu(
	MaCV char(10),
	TenCV nvarchar(250),
	primary key(MaCV)
)
create table TrinhDoHV(
	MaTDHV char(50),
	TenTDHV nvarchar(250),
	ChuyenNganh nvarchar(250),
	primary key(MaTDHV)
)
ALTER TABLE NhanVien
ADD CONSTRAINT FK_MaTDHV
FOREIGN KEY (TrinhdoHV) REFERENCES TrinhDoHV(MaTDHV);

create table BaoHiem(
	MaBH char(10),
	TenBH nvarchar(250),
	Ngaylap date,
	Thoihan nvarchar(250),
	primary key(MaBH)
)
ALTER TABLE NhanVien
ADD CONSTRAINT FK_MaBH
FOREIGN KEY (MaBH) REFERENCES BaoHiem(MaBH);

create table HopDong(
	SoHD char(50),
	Maloai char(10),
	Ngaylap date,
	Noidung nvarchar(250),
	primary key(SoHD)
)
create table LoaiHopDong(
	Maloai char(10),
	TenHD nvarchar(250),
	ThoihanHD nvarchar(250),
	primary key(Maloai)
)
ALTER TABLE HopDong
ADD CONSTRAINT FK_MaLoai
FOREIGN KEY (Maloai) REFERENCES LoaiHopDong(Maloai);

create table PhongBan(
	MaPB char(10),
	TenPB nvarchar(250),
	primary key(MaPB)
)
ALTER TABLE NhanVien
ADD CONSTRAINT FK_MaPB
FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB);

create table QuyetDinhKhenThuong(
	SoQDKT char(10),
	NgayQD date,
	Noidung nvarchar(250),
	Sotienthuong float,
	MaNV char(10),
	MaPB char(10),
	primary key(SoQDKT)
)
ALTER TABLE QuyetDinhKhenThuong
ADD CONSTRAINT FK_MaPB2
FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB);

ALTER TABLE QuyetDinhKhenThuong
ADD CONSTRAINT FK_MaNV2
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

insert into ChucVu values('NV001', N'Nhân Viên')

insert into PhongBan values('NS001', N'Nhân Sự')

insert into HopDong values('HD001', 'HDLD001', '01-01-2020', N'Hợp đồng lao động')

insert into LoaiHopDong values('HDLD001', N'Hợp đồng lao động', '1 năm')

insert into NhanVien values('NVM001',N'Dương Thái Tín', N'Nam', N'Nha Trang', N'Phú Yên', '01-07-2003' , '0868814302', 'HV001' , 'NV001','NS001', 'BH001', 10000000)

insert into QuyetDinhKhenThuong values('KT001', '01-01-2020', N'Khen thưởng', 1500000, 'NVM001', 'NS001')

insert into BaoHiem values('BH001', N'Bảo hiểm lao động', '10-10-2020', '1 năm')

insert into TrinhDoHV values('HV001', N'12 trên 12', N'Quản lý nhà hàng khách sạn')

select * from NhanVien
--Chuc vu


-- change pass
Create proc [dbo].[SP_Update_Pass]
@User char(250),
@OldPass char(10),
@NewPass char(10)
as
begin
    if exists (select * from DangNhap where Tendn = @User and Matkhau = @OldPass)
    begin
        update DangNhap set MatKhau = @NewPass where Tendn = @User
        select 1 as code, N'Thay doi mat khau thanh cong !!' as MSG
    end
    else
        select 0 as code, N'Tai khoan hoac mat khau sai !!' as MSG
end
create table Luong(
	MaNV char(10),
	GioiTinh char(5),
	Hoten nvarchar(250),
	Phong nvarchar(250),
	ChucVu nvarchar(250),
	BoPhan nvarchar(250),
	SoNgayLam char(5),
	Thang char(2),
	HeSoLuong float,
	LuongCoBan char(20),
	UngLuong char(20),
	LuongPhuCap char(20),
	Tong char(20)
	primary key(MaNV)
)
drop table Luong
ALTER TABLE Luong
ADD CONSTRAINT FK_MaNV
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);
CREATE PROCEDURE SP_Luong(@MaNV char(10),
	@GioiTinh char(5),
	@Hoten nvarchar(250),
	@Phong nvarchar(250),
	@ChucVu nvarchar(250),
	@BoPhan nvarchar(250),
	@SoNgayLam char(5),
	@Thang char(2),
	@HeSoLuong float,
	@LuongCoBan char(20),
	@UngLuong char(20),
	@LuongPhuCap char(20),
	@Tong char)
AS
 INSERT INTO Luong
 VALUES(@MaNV, @GioiTinh, @Hoten, @Phong , @ChucVu, @BoPhan, @SoNgayLam , @Thang, @HeSoLuong , @LuongCoBan, @UngLuong, @LuongPhuCap, @Tong)

drop proc SP_Luong
select * from DangNhap