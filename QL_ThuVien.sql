/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     28/05/2022 9:34:23 PM                        */
/*==============================================================*/
create database QL_ThuVien
go

use QL_ThuVien
go

SET DATEFORMAT DMY
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHITIETMUONTRA') and o.name = 'FK_CHITIETM_CHI_TIET_MUONTRA')
alter table CHITIETMUONTRA
   drop constraint FK_CHITIETM_CHI_TIET_MUONTRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHITIETMUONTRA') and o.name = 'FK_CHITIETM_CHO_MUON_SACH')
alter table CHITIETMUONTRA
   drop constraint FK_CHITIETM_CHO_MUON_SACH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MUONTRA') and o.name = 'FK_MUONTRA_MUON_SACH_THETHUVI')
alter table MUONTRA
   drop constraint FK_MUONTRA_MUON_SACH_THETHUVI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MUONTRA') and o.name = 'FK_MUONTRA_THUC_HIEN_NHANVIEN')
alter table MUONTRA
   drop constraint FK_MUONTRA_THUC_HIEN_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SACH') and o.name = 'FK_SACH_THUOC_THELOAI')
alter table SACH
   drop constraint FK_SACH_THUOC_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SACH') and o.name = 'FK_SACH_VIET_TACGIA')
alter table SACH
   drop constraint FK_SACH_VIET_TACGIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SACH') and o.name = 'FK_SACH_XUAT_BAN_NHAXUATB')
alter table SACH
   drop constraint FK_SACH_XUAT_BAN_NHAXUATB
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('THETHUVIEN') and o.name = 'FK_THETHUVI_CAP_DOCGIA')
alter table THETHUVIEN
   drop constraint FK_THETHUVI_CAP_DOCGIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHITIETMUONTRA')
            and   name  = 'CHI_TIET_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHITIETMUONTRA.CHI_TIET_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHITIETMUONTRA')
            and   name  = 'CHO_MUON_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHITIETMUONTRA.CHO_MUON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHITIETMUONTRA')
            and   type = 'U')
   drop table CHITIETMUONTRA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCGIA')
            and   type = 'U')
   drop table DOCGIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MUONTRA')
            and   name  = 'THUC_HIEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index MUONTRA.THUC_HIEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MUONTRA')
            and   name  = 'MUON_SACH_FK'
            and   indid > 0
            and   indid < 255)
   drop index MUONTRA.MUON_SACH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MUONTRA')
            and   type = 'U')
   drop table MUONTRA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHAXUATBAN')
            and   type = 'U')
   drop table NHAXUATBAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SACH')
            and   name  = 'XUAT_BAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index SACH.XUAT_BAN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SACH')
            and   name  = 'VIET_FK'
            and   indid > 0
            and   indid < 255)
   drop index SACH.VIET_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SACH')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index SACH.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SACH')
            and   type = 'U')
   drop table SACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TACGIA')
            and   type = 'U')
   drop table TACGIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THELOAI')
            and   type = 'U')
   drop table THELOAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('THETHUVIEN')
            and   name  = 'CAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index THETHUVIEN.CAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THETHUVIEN')
            and   type = 'U')
   drop table THETHUVIEN
go

/*==============================================================*/
/* Table: CHITIETMUONTRA                                        */
/*==============================================================*/
create table CHITIETMUONTRA (
   MASACH               varchar(10)             not null,
   MAMUONTRA            varchar(10)             not null,
   GHICHU               nvarchar(100)            null,
   TINHTRANG            nvarchar(100)            null,
   NGAYTRA              date             null,
   SOLUONG				int				null,
   constraint PK_CHITIETMUONTRA primary key (MASACH, MAMUONTRA)
)
go

/*==============================================================*/
/* Index: CHO_MUON_FK                                           */
/*==============================================================*/




create nonclustered index CHO_MUON_FK on CHITIETMUONTRA (MASACH ASC)
go

/*==============================================================*/
/* Index: CHI_TIET_FK                                           */
/*==============================================================*/




create nonclustered index CHI_TIET_FK on CHITIETMUONTRA (MAMUONTRA ASC)
go

/*==============================================================*/
/* Table: DOCGIA                                                */
/*==============================================================*/
create table DOCGIA (
   MADOCGIA             varchar(10)             not null,
   TENDOCGIA            nvarchar(50)             null,
   GIOITINH             nvarchar(10)             null,
   NGAYSINHDG           date             null,
   DIACHI               nvarchar(150)            null,
   SDT                  varchar(15)             null,
   constraint PK_DOCGIA primary key (MADOCGIA)
)
go

/*==============================================================*/
/* Table: MUONTRA                                               */
/*==============================================================*/
create table MUONTRA (
   MAMUONTRA            varchar(10)             not null,
   SOTHE                varchar(10)             not null,
   MANV                 varchar(10)             not null,
   NGAYMUON             date             null,
   constraint PK_MUONTRA primary key (MAMUONTRA)
)
go

/*==============================================================*/
/* Index: MUON_SACH_FK                                          */
/*==============================================================*/




create nonclustered index MUON_SACH_FK on MUONTRA (SOTHE ASC)
go

/*==============================================================*/
/* Index: THUC_HIEN_FK                                          */
/*==============================================================*/




create nonclustered index THUC_HIEN_FK on MUONTRA (MANV ASC)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 varchar(10)             not null,
   HOTEN                nvarchar(50)             null,
   NGAYSINH             date             null,
   SODIENTHOAI          varchar(20)             null,
   constraint PK_NHANVIEN primary key (MANV)
)
go

/*==============================================================*/
/* Table: NHAXUATBAN                                            */
/*==============================================================*/
create table NHAXUATBAN (
   MANXB                varchar(10)             not null,
   TENNXB               nvarchar(200)            null,
   DIACHINXB            nvarchar(200)            null,
   EMAIL                varchar(100)             null,
   SDT_NXB              varchar(15)             null,
   constraint PK_NHAXUATBAN primary key (MANXB)
)
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH (
   MASACH               varchar(10)             not null,
   MATHELOAI            varchar(10)             not null,
   MATACGIA             varchar(10)             not null,
   MANXB                varchar(10)             not null,
   TENSACH              nvarchar(100)            null,
   NAMXUATBAN           date             null,
   SOLUONG				int				null,
   constraint PK_SACH primary key (MASACH)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/


create nonclustered index THUOC_FK on SACH (MATHELOAI ASC)
go

/*==============================================================*/
/* Index: VIET_FK                                               */
/*==============================================================*/


create nonclustered index VIET_FK on SACH (MATACGIA ASC)
go

/*==============================================================*/
/* Index: XUAT_BAN_FK                                           */
/*==============================================================*/


create nonclustered index XUAT_BAN_FK on SACH (MANXB ASC)
go

/*==============================================================*/
/* Table: TACGIA                                                */
/*==============================================================*/
create table TACGIA (
   MATACGIA             varchar(10)             not null,
   TENTACGIA            nvarchar(100)            null,
   DIACHITG             nvarchar(200)            null,
   constraint PK_TACGIA primary key (MATACGIA)
)
go

/*==============================================================*/
/* Table: THELOAI                                               */
/*==============================================================*/
create table THELOAI (
   MATHELOAI            varchar(10)             not null,
   TENTHELOAI           nvarchar(50)             null,
   VITRI				nvarchar(100)			null
   constraint PK_THELOAI primary key (MATHELOAI)
)
go

/*==============================================================*/
/* Table: THETHUVIEN                                            */
/*==============================================================*/
create table THETHUVIEN (
   SOTHE                varchar(10)             not null,
   MADOCGIA             varchar(10)             not null,
   NGAYBATDAU           date             null,
   NGAYHETHAN           date             null,
   GHICHUTHE            nvarchar(100)            null,
   constraint PK_THETHUVIEN primary key (SOTHE)
)
go

/*==============================================================*/
/* Index: CAP_FK                                                */
/*==============================================================*/

create nonclustered index CAP_FK on THETHUVIEN (MADOCGIA ASC)
go

alter table CHITIETMUONTRA
   add constraint FK_CHITIETM_CHI_TIET_MUONTRA foreign key (MAMUONTRA)
      references MUONTRA (MAMUONTRA)
go

alter table CHITIETMUONTRA
   add constraint FK_CHITIETM_CHO_MUON_SACH foreign key (MASACH)
      references SACH (MASACH)
go

alter table MUONTRA
   add constraint FK_MUONTRA_MUON_SACH_THETHUVI foreign key (SOTHE)
      references THETHUVIEN (SOTHE)
go

alter table MUONTRA
   add constraint FK_MUONTRA_THUC_HIEN_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table SACH
   add constraint FK_SACH_THUOC_THELOAI foreign key (MATHELOAI)
      references THELOAI (MATHELOAI)
go

alter table SACH
   add constraint FK_SACH_VIET_TACGIA foreign key (MATACGIA)
      references TACGIA (MATACGIA)
go

alter table SACH
   add constraint FK_SACH_XUAT_BAN_NHAXUATB foreign key (MANXB)
      references NHAXUATBAN (MANXB)
go

alter table THETHUVIEN
   add constraint FK_THETHUVI_CAP_DOCGIA foreign key (MADOCGIA)
      references DOCGIA (MADOCGIA)
go


--CHECK
--SỐ LƯỢNG SÁCH TRONG THƯ VIỆN PHẢI >= 0
Alter table SACH
add constraint CHECK_SOLUONG check (SOLUONG >=0)
go

--SỐ LƯỢNG SÁCH CHO MƯỢN CHỈ TỐI ĐA LÀ 5 CUỐN
Alter table CHITIETMUONTRA
add constraint CHECK_SLMUON check (SOLUONG <= 5)
go

--TÌNH TRẠNG SÁCH CHỈ THUỘC 2 TÌNH TRẠNG 'Đã trả' HOẶC 'Chưa trả'
Alter table CHITIETMUONTRA
add constraint CHECK_TINHTRANG check (TINHTRANG = N'Đã trả' or TINHTRANG = N'Chưa trả')
go

--RÀNG BUỘC VỀ GIỚI TÍNH
 Alter table DOCGIA
 add constraint CHECK_GIOITINH check (GIOITINH = N'Nam' or GIOITINH = N'NỮ')
 go

--UNIQUE
--RÀNG BUỘC KIỂM TRA DUY NHẤT CÁC CỘT 'TENTHELOAI','TENNXB','TENSACH'.
Alter table THELOAI
add constraint UNIQUE_TENTHELOAI unique (TENTHELOAI)
go

Alter table NHAXUATBAN
add constraint UNIQUE_TENNXB unique (TENNXB)
go

--Alter table SACH
--add constraint UNIQUE_TENSACH unique (TENSACH)

--DEFAULT
--MẶC ĐỊNH ĐỊA CHỈ CỦA ĐỘC GIẢ LÀ 'CHƯA XÁC ĐỊNH'
Alter table DOCGIA
add constraint DF_DIACHI default N'Chưa xác định' for DIACHI
go

--MẶC ĐỊNH GHI CHÚ THẺ THƯ VIỆN LÀ LOẠI Mới
Alter table THETHUVIEN
add constraint DF_GHICHUTHE default N'Mới' for GHICHUTHE
go

--MẶC ĐỊNH GHI CHÚ SÁCH TRẢ CỦA KHÁCH LÀ CÒN 'Nguyên vẹn'
Alter table CHITIETMUONTRA
add constraint DF_GHICHU default N'Nguyên vẹn' for GHICHU
go

--GHI CHÚ THẺ CHỈ CÓ 4 LOẠI 'THƯỜNG', 'VIP','MỚI','ĐẶT BIỆT'
Alter table THETHUVIEN
add constraint CHECK_GHICHUTHE check ((GHICHUTHE =N'Thường') OR (GHICHUTHE =N'VIP') OR (GHICHUTHE =N'Mới') OR (GHICHUTHE =N'Đặc biệt'))
go

--TRIGGER
--NHÂN VIÊN PHẢI ĐỦ TỪ 18 TUỔI TRỞ LÊN
CREATE TRIGGER KT_TUOI ON NHANVIEN
FOR INSERT 
AS
	IF (YEAR(GETDATE()) - (SELECT YEAR(NGAYSINH) FROM inserted)) < 18
	BEGIN
		PRINT 'Nhân viên ở đây phải lớn hơn 18 tuổi nhé!!!'
		ROLLBACK tran
	END
go


--KHÔNG THỂ THAY ĐỔI MÃ NHÂN VIÊN
CREATE TRIGGER CHECK_MANV ON NHANVIEN FOR UPDATE 
AS
	IF UPDATE(MANV)
	BEGIN
		PRINT 'không thể thay đổi mã nhân viên'
		ROLLBACK tran
	END
go


--
--kiem tra ngay cap va ngay het hang the: NGAYBATDAU < NGAYHETHANG
create trigger KT_THE on THETHUVIEN
for insert, update
as
if(select NGAYBATDAU from inserted) > (select NGAYHETHAN from inserted)
	begin
		print 'NGAY BAT DAU CAP THE PHAI < NGAY HET HANG!'
		rollback tran
	end
go

--
--kiem tra chi tiet muon tra: NGAYTRA > NGAYMUON cua bang MUONTRA
create trigger KT_CHITIETMUONTRA on CHITIETMUONTRA
for insert, update
as
if(select NGAYTRA from inserted) < (select NGAYMUON from MUONTRA where MAMUONTRA in (select MAMUONTRA from inserted))
	begin
		print 'NGAY MUON PHAI < NGAY TRA!'
		rollback tran
	end	
go

--kiem tra so luong
create trigger KT_SOLUONGMUON on CHITIETMUONTRA
for insert
as
if(select SOLUONG from inserted) >= (select SOLUONG from SACH where MASACH in (select MASACH from inserted))
	begin
		print 'SO LUONG SACH MUON PHAI <= SO LUONG SACH HIEN CO!'
		rollback tran
	end
go

--tu dong tang giam so luong sach
create trigger UPDATE_SOLUONGSACH on CHITIETMUONTRA
for insert
as
if(select TINHTRANG from inserted) = N'Chưa trả'
	begin
		update SACH
		set SOLUONG -= (select SOLUONG from inserted)
		where MASACH = (select MASACH from inserted)
	end
go

create trigger UPDATE_SLSACH_CTMUON on CHITIETMUONTRA
for update
as
if(select TINHTRANG from inserted) = N'Chưa trả'
	begin
		if(select SOLUONG from deleted) < (select SOLUONG from inserted)
			begin
				update SACH
				set SOLUONG -= ((select SOLUONG from inserted) - (select SOLUONG from deleted))
				where MASACH = (select MASACH from inserted)
			end
		else if(select SOLUONG from deleted) > (select SOLUONG from inserted)
			begin
				update SACH
				set SOLUONG += ((select SOLUONG from deleted) - (select SOLUONG from inserted))
				where MASACH = (select MASACH from inserted)
			end
	end
else if(select TINHTRANG from inserted) = N'Đã trả'
	begin
		update SACH
		set SOLUONG += (select SOLUONG from inserted)
		where MASACH = (select MASACH from inserted)
	end
go

insert into TACGIA
values('TG001', N'Tô Hoài', N'Bình Thạnh, TP.HCM')
insert into TACGIA
values('TG002', N'Nguyễn Nhật Ánh', N'Tân Phú, TP.HCM')
insert into TACGIA
values('TG003', N'Trang Hạ', N'Cầu Giấy, Hà Nội')
insert into TACGIA
values('TG004', N'Nguyễn Phong Việt', N'Quận 2, TP.HCM')
insert into TACGIA
values('TG005', N'Tố Hữu', N'Bình Tân, TP.HCM')
 insert into TACGIA
values('TG006', N'Anh Khang', N'Hoàn Kiếm, Hà Nội')
insert into TACGIA
values('TG007', N'Nguyễn Ngọc Thạch', N'Long Biên, Hà Nội')
insert into TACGIA
values('TG008', N'Đỗ Nhật Nam', N'Bình Thạnh, TP.HCM')
insert into TACGIA
values('TG009', N'Nguyễn Ngọc Sơn', N'Hai Bà Trưng, Hà Nội')
go

insert into NHAXUATBAN
values('NXB001', N'Nhi Đồng', N'Quận 10, TP. HCM', 'nhidong@gmail.com', '1900108800')
insert into NHAXUATBAN
values('NXB002', N'Chính Trị Quốc Gia', N'Quận 1, TP. HCM', 'chinhtriquocgia@gmail.com', '08.76574667')
insert into NHAXUATBAN
values('NXB003', N'Tư Pháp', N'Quận 2, TP. HCM', 'tuphap@gmail.com', '02.22211222')
insert into NHAXUATBAN
values('NXB004', N'Hồng Đức', N'Quận 3, TP. HCM', 'hongduc@gmail.com', '08.77722333')
insert into NHAXUATBAN
values('NXB005', N'Quân Đội', N'Long Biên, Hà Nội', 'quandoi@gmail.com', '08.42424242')
insert into NHAXUATBAN
values('NXB006', N'Kim Đồng', N'Cầu Giấy, Hà Nội', 'kimdong@gmail.com', '08.12345678')
insert into NHAXUATBAN
values('NXB007', N'Lao Động', N'Quận 6, TP. HCM', 'laodong@gmail.com', '08.88888888')
insert into NHAXUATBAN
values('NXB008', N'Thanh Niên', N'Quận 7, TP. HCM', 'thanhnien@gmail.com', '08.49494949')
insert into NHAXUATBAN
values('NXB009', N'Phụ Nữ', N'Hai Bà Trưng, Hà Nội', 'phunu@gmail.com', '03.22223333')
insert into NHAXUATBAN
values('NXB010', N'Khoa Học Xã Hội', N'Quận 9, TP. HCM', 'khoahocxahoi@gmail.com', '08.12341234')
go

insert into THELOAI
values('TL001', N'Truyện Tranh', N'Tầng 1, kệ 1')
insert into THELOAI
values('TL002', N'Tiểu Thuyết', N'Tầng 1, kệ 2')
insert into THELOAI
values('TL003', N'Sách Tham Khảo', N'Tầng 1, kệ 3')
insert into THELOAI
values('TL004', N'Sách Tiếng Anh', N'Tầng 2, kệ 1')
insert into THELOAI
values('TL005', N'Sách Giáo Khoa', N'Tầng 2, kệ 2')
insert into THELOAI
values('TL006', N'Sách Giáo Viên', N'Tầng 2, kệ 3')
go


insert into SACH
values('SH001', 'TL001', 'TG001', 'NXB001', N'Truyện Tranh', '02/03/2000', 10)
insert into SACH
values('SH002', 'TL001', 'TG002', 'NXB002', N'Truyện Ngắn', '12/04/2001', 20)
insert into SACH
values('SH003', 'TL001', 'TG002', 'NXB003', N'Chiếc Lược Ngà', '05/06/2002', 34)
insert into SACH
values('SH004', 'TL002', 'TG003', 'NXB004', N'Những Ngôi Sao Xa Sôi', '07/01/2001', 23)
insert into SACH
values('SH005', 'TL002', 'TG003', 'NXB005', N'Lão Hạc', '15/05/2000', 14)
insert into SACH
values('SH006', 'TL002', 'TG004', 'NXB006', N'Tắt Đèn', '21/07/2000', 45)
insert into SACH
values('SH007', 'TL003', 'TG005', 'NXB007', N'Sách Tham Khảo 1', '30/08/2004', 55)
insert into SACH
values('SH008', 'TL003', 'TG006', 'NXB008', N'Sách Tham Khảo 1', '26/08/2003', 27)
insert into SACH
values('SH009', 'TL003', 'TG001', 'NXB009', N'Sách Tham Khảo 1', '14/09/2005', 107)
insert into SACH
values('SH010', 'TL004', 'TG002', 'NXB010', N'Tài lIệu Tiếng Anh A1', '15/1/2006', 85)
insert into SACH
values('SH011', 'TL004', 'TG007', 'NXB010', N'Tài lIệu Tiếng Anh A2', '19/11/2007', 67)
insert into SACH
values('SH012', 'TL004', 'TG008', 'NXB001', N'Tài lIệu Tiếng Anh B1', '21/10/2008', 99)
insert into SACH
values('SH013', 'TL005', 'TG009', 'NXB002', N'Sách Giáo Khao Năm Nhất', '22/12/2010', 143)
insert into SACH
values('SH014', 'TL005', 'TG009', 'NXB003', N'Sách Giáo Khao Năm Hai', '27/07/2012', 58)
insert into SACH
values('SH015', 'TL005', 'TG008', 'NXB004', N'Sách Giáo Khao Năm Ba', '02/09/2015', 76)
insert into SACH
values('SH016', 'TL006', 'TG001', 'NXB005', N'Truyện Cười Dân Gian', '22/03/2016', 83)
insert into SACH
values('SH017', 'TL006', 'TG002', 'NXB006', N'Sách Giáo Viên Tin Học', '12/03/2016', 26)
insert into SACH
values('SH018', 'TL006', 'TG003', 'NXB007', N'Sách Giáo Viên 1', '14/02/2019', 34)
insert into SACH
values('SH019', 'TL002', 'TG004', 'NXB008', N'Tài lIệu Tiếng Anh B2', '22/04/2020', 25)
insert into SACH
values('SH020', 'TL003', 'TG008', 'NXB009', N'Truyện Tham KHảo', '17/07/2021', 87)
go

insert into DOCGIA
values('DG001', N'Nguyễn Văn A', N'Nam', '11/01/2000', N'Q3, TP.HCM', '0983627846')
insert into DOCGIA
values('DG002', N'Nguyễn Ngọc Ánh', N'Nữ', '12/02/2000', N'Q1, TP.HCM', '09745234')
insert into DOCGIA
values('DG003', N'Dương Tôn Bảo', N'Nam', '05/03/2000', N'Q2, TP.HCM', '0981234122')
insert into DOCGIA
values('DG004', N'Đỗ Phú Cường', N'Nam', '03/04/2000', N'Q6, TP.HCM', '0945455454')
insert into DOCGIA
values('DG005', N'Huỳnh Công Danh', N'Nam', '02/05/2000', N'Q7, TP.HCM', '0822233322')
insert into DOCGIA
values('DG006', N'Lê Hùng Đức', N'Nam', '07/06/2000', N'Q8, TP.HCM', '0912322212')
insert into DOCGIA
values('DG007', N'Phạm Tấn Đạt', N'Nam', '08/07/2000', N'Q9, TP.HCM', '0309875674')
insert into DOCGIA
values('DG008', N'Phạm Thúy Hồng', N'Nữ', '17/08/2000', N'Q10, TP.HCM', '0216789431')
insert into DOCGIA
values('DG009', N'Lê Thị Mỹ Lệ', N'Nữ', '22/09/2000', N'QTân Phú, TP.HCM', '0983627846')
insert into DOCGIA
values('DG010', N'Nguyễn Xuân Mai', N'Nữ', '29/10/2000', N'QBình Chánh, TP.HCM', '0983621236')
go

insert into THETHUVIEN
values('TH001', 'DG001', '12/01/2012', '12/01/2019', N'VIP')
insert into THETHUVIEN
values('TH002', 'DG002', '12/02/2013', '12/02/2020', N'Thường')
insert into THETHUVIEN
values('TH003', 'DG003', '12/03/2010', '12/03/2017', N'Mới')
insert into THETHUVIEN
values('TH004', 'DG004', '12/04/2015', '12/04/2022', N'VIP')
insert into THETHUVIEN
values('TH005', 'DG005', '12/05/2016', '12/05/2023', N'Đặc biệt')
insert into THETHUVIEN
values('TH006', 'DG006', '22/06/2017', '22/06/2029', N'Thường')
insert into THETHUVIEN
values('TH007', 'DG007', '20/07/2012', '20/07/2019', N'Đặc biệt')
insert into THETHUVIEN
values('TH008', 'DG008', '10/08/2015', '10/08/2022', N'VIP')
insert into THETHUVIEN
values('TH009', 'DG009', '05/09/2012', '05/09/2019', N'Thường')
insert into THETHUVIEN
values('TH010', 'DG010', '15/10/2015', '15/10/2025', N'VIP')
go

insert into NHANVIEN
values('NV001', N'Trần văn Chiến', '14/11/1999', '0927463874')
insert into NHANVIEN
values('NV002', N'Nguyễn Ngọc Sơn', '24/01/1989', '0912341234')
insert into NHANVIEN
values('NV003', N'Lê Tú Tài', '16/04/1982', '07123451234')
insert into NHANVIEN
values('NV004', N'Nguyễn Lê Thành Công', '14/06/1994', '0323124921')
insert into NHANVIEN
values('NV005', N'Dương Văn Dũng', '17/07/2000', '0812341234123')
go

insert into MUONTRA
values('MT001', 'TH001', 'NV001', '21/02/2013')
insert into MUONTRA
values('MT002', 'TH002', 'NV001', '22/03/2014')
insert into MUONTRA
values('MT003', 'TH003', 'NV002', '12/04/2013')
insert into MUONTRA
values('MT004', 'TH004', 'NV002', '13/02/2016')
insert into MUONTRA
values('MT005', 'TH005', 'NV003', '15/01/2017')
insert into MUONTRA
values('MT006', 'TH006', 'NV003', '17/06/2018')
insert into MUONTRA
values('MT007', 'TH007', 'NV004', '18/07/2013')
insert into MUONTRA
values('MT008', 'TH008', 'NV004', '16/09/2014')
insert into MUONTRA
values('MT009', 'TH009', 'NV005', '15/05/2013')
insert into MUONTRA
values('MT010', 'TH010', 'NV005', '27/06/2014')
go

insert into CHITIETMUONTRA
values('SH001', 'MT001', N'Mất trang 13' ,N'Đã trả', '15/03/2013', 1)
insert into CHITIETMUONTRA
values('SH002', 'MT002', N'Nguyên Vẹn' ,N'Đã trả', '22/04/2014', 2)
insert into CHITIETMUONTRA
values('SH003', 'MT003', N'Nguyên Vẹn' ,N'Đã trả', '12/05/2013', 1)
insert into CHITIETMUONTRA
values('SH004', 'MT004', N'Nguyên Vẹn' ,N'Đã trả', '13/03/2016', 3)
insert into CHITIETMUONTRA
values('SH005', 'MT005', N'Nguyên Vẹn' ,N'Chưa trả', '15/02/2017', 2)
insert into CHITIETMUONTRA
values('SH006', 'MT006', N'Mất Bìa' ,N'Đã trả', '17/07/2018', 4)
insert into CHITIETMUONTRA
values('SH007', 'MT007', N'Nguyên Vẹn' ,N'Đã trả', '18/08/2013', 1)
insert into CHITIETMUONTRA
values('SH008', 'MT008', N'Nguyên Vẹn' ,N'Đã trả', '16/10/2014', 2)
insert into CHITIETMUONTRA
values('SH009', 'MT009', N'Nguyên Vẹn' ,N'Đã trả', '15/06/2013', 3)
insert into CHITIETMUONTRA
values('SH010', 'MT010', N'Mất trang 101' ,N'Chưa trả', '27/07/2014', 2)
GO