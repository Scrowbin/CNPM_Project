/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     06/04/2025 3:55:37 CH                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAN_HO') and o.name = 'FK_CAN_HO_SO_HUU_CHU_NHA')
alter table CAN_HO
   drop constraint FK_CAN_HO_SO_HUU_CHU_NHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOA_DON') and o.name = 'FK_HOA_DON_THANH_TOA_HOP_DONG')
alter table HOA_DON
   drop constraint FK_HOA_DON_THANH_TOA_HOP_DONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOP_DONG') and o.name = 'FK_HOP_DONG_KY_KET_NGUOI_TH')
alter table HOP_DONG
   drop constraint FK_HOP_DONG_KY_KET_NGUOI_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOP_DONG') and o.name = 'FK_HOP_DONG_QUAN_LY_CAN_HO')
alter table HOP_DONG
   drop constraint FK_HOP_DONG_QUAN_LY_CAN_HO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAN_HO')
            and   name  = 'SO_HUU_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAN_HO.SO_HUU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAN_HO')
            and   type = 'U')
   drop table CAN_HO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHU_NHA')
            and   type = 'U')
   drop table CHU_NHA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOA_DON')
            and   name  = 'THANH_TOAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOA_DON.THANH_TOAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOA_DON')
            and   type = 'U')
   drop table HOA_DON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOP_DONG')
            and   name  = 'KY_KET_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOP_DONG.KY_KET_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOP_DONG')
            and   name  = 'QUAN_LY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOP_DONG.QUAN_LY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOP_DONG')
            and   type = 'U')
   drop table HOP_DONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NGUOI_THUE_NHA')
            and   type = 'U')
   drop table NGUOI_THUE_NHA
go

/*==============================================================*/
/* Table: CAN_HO                                                */
/*==============================================================*/
create table CAN_HO (
   MA_CAN_HO            char(10)             not null,
   MA_CHU_NHA           char(50)             not null,
   TEN_CAN_HO           varchar(50)          not null,
   DIA_CHI              varchar(100)         not null,
   LOAI_CAN_HO          varchar(50)          null,
   DIEN_TICH            float                null,
   GIA_THUE_DAI_HAN     int                  not null,
   GIA_THUE_NGAN_HAN    int                  not null,
   constraint PK_CAN_HO primary key nonclustered (MA_CAN_HO)
)
go

/*==============================================================*/
/* Index: SO_HUU_FK                                             */
/*==============================================================*/
create index SO_HUU_FK on CAN_HO (
MA_CHU_NHA ASC
)
go

/*==============================================================*/
/* Table: CHU_NHA                                               */
/*==============================================================*/
create table CHU_NHA (
   MA_CHU_NHA           char(50)             not null,
   HO_TEN               varchar(50)          not null,
   SDT                  numeric(10)          null,
   CCCD                 char(10)             not null,
   EMAIL                char(50)             null,
   constraint PK_CHU_NHA primary key nonclustered (MA_CHU_NHA)
)
go

/*==============================================================*/
/* Table: HOA_DON                                               */
/*==============================================================*/
create table HOA_DON (
   MA_CAN_HO            char(10)             not null,
   MA_KHACH_HANG        char(50)             not null,
   MA_HOP_DONG          char(10)             not null,
   MA_HOA_DON           char(20)             not null,
   NGAY_THANH_TOAN      datetime             null,
   TIEN_NHA             int                  not null,
   TIEN_DIEN            int                  null,
   TIEN_NUOC            int                  null,
   PHI_DICH_VU          int                  null,
   TONG_TIEN            int                  null,
   constraint PK_HOA_DON primary key nonclustered (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG, MA_HOA_DON)
)
go

/*==============================================================*/
/* Index: THANH_TOAN_FK                                         */
/*==============================================================*/
create index THANH_TOAN_FK on HOA_DON (
MA_CAN_HO ASC,
MA_KHACH_HANG ASC,
MA_HOP_DONG ASC
)
go

/*==============================================================*/
/* Table: HOP_DONG                                              */
/*==============================================================*/
create table HOP_DONG (
   MA_CAN_HO            char(10)             not null,
   MA_KHACH_HANG        char(50)             not null,
   MA_HOP_DONG          char(10)             not null,
   NGAY_BAT_DAU         datetime             null,
   NGAY_KET_THUC        datetime             null,
   NGAY_LAM_HOP_DONG    datetime             null,
   TIEN_COC             int                  null,
   constraint PK_HOP_DONG primary key nonclustered (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG)
)
go

/*==============================================================*/
/* Index: QUAN_LY_FK                                            */
/*==============================================================*/
create index QUAN_LY_FK on HOP_DONG (
MA_CAN_HO ASC
)
go

/*==============================================================*/
/* Index: KY_KET_FK                                             */
/*==============================================================*/
create index KY_KET_FK on HOP_DONG (
MA_KHACH_HANG ASC
)
go

/*==============================================================*/
/* Table: NGUOI_THUE_NHA                                        */
/*==============================================================*/
create table NGUOI_THUE_NHA (
   MA_KHACH_HANG        char(50)             not null,
   HO_TEN               varchar(50)          not null,
   SDT                  numeric(10)          null,
   CCCD_PASSPORT        char(12)             not null,
   EMAIL                char(50)             null,
   QUOC_TICH            varchar(55)          null,
   DIA_CHI              varchar(100)         null,
   constraint PK_NGUOI_THUE_NHA primary key nonclustered (MA_KHACH_HANG)
)
go

alter table CAN_HO
   add constraint FK_CAN_HO_SO_HUU_CHU_NHA foreign key (MA_CHU_NHA)
      references CHU_NHA (MA_CHU_NHA)
go

alter table HOA_DON
   add constraint FK_HOA_DON_THANH_TOA_HOP_DONG foreign key (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG)
      references HOP_DONG (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG)
go

alter table HOP_DONG
   add constraint FK_HOP_DONG_KY_KET_NGUOI_TH foreign key (MA_KHACH_HANG)
      references NGUOI_THUE_NHA (MA_KHACH_HANG)
go

alter table HOP_DONG
   add constraint FK_HOP_DONG_QUAN_LY_CAN_HO foreign key (MA_CAN_HO)
      references CAN_HO (MA_CAN_HO)
go


-- 1. Nhập dữ liệu cho bảng CHU_NHA (2 chủ nhà)
INSERT INTO CHU_NHA (MA_CHU_NHA, HO_TEN, SDT, CCCD, EMAIL)
VALUES 
('CN001', 'Nguyễn Văn A', '0912345678', '1234567890', 'nguyenvana@email.com'),
('CN002', 'Trần Thị B', '0987654321', '0987654321', 'tranthib@email.com');

-- 2. Nhập dữ liệu cho bảng NGUOI_THUE_NHA (10 người thuê)
INSERT INTO NGUOI_THUE_NHA (MA_KHACH_HANG, HO_TEN, SDT, CCCD_PASSPORT, EMAIL, QUOC_TICH, DIA_CHI)
VALUES
('KH001', 'Lê Văn C', '0901122334', '112233445566', 'levanc@email.com', 'Việt Nam', '123 Đường ABC, Q1, TP.HCM'),
('KH002', 'Phạm Thị D', '0902233445', '223344556677', 'phamthid@email.com', 'Việt Nam', '456 Đường XYZ, Q2, TP.HCM'),
('KH003', 'Hoàng Văn E', '0903344556', '334455667788', 'hoangve@email.com', 'Việt Nam', '789 Đường DEF, Q3, TP.HCM'),
('KH004', 'Vũ Thị F', '0904455667', '445566778899', 'vuthif@email.com', 'Việt Nam', '321 Đường GHI, Q4, TP.HCM'),
('KH005', 'Đặng Văn G', '0905566778', '556677889900', 'dangvangg@email.com', 'Việt Nam', '654 Đường KLM, Q5, TP.HCM'),
('KH006', 'Bùi Thị H', '0906677889', '667788990011', 'buithih@email.com', 'Việt Nam', '987 Đường NOP, Q6, TP.HCM'),
('KH007', 'Mai Văn I', '0907788990', '778899001122', 'maivanii@email.com', 'Việt Nam', '159 Đường QRS, Q7, TP.HCM'),
('KH008', 'Lý Thị K', '0908899001', '889900112233', 'lythik@email.com', 'Việt Nam', '753 Đường TUV, Q8, TP.HCM'),
('KH009', 'Chu Văn L', '0909900112', '990011223344', 'chuvanl@email.com', 'Việt Nam', '852 Đường WXY, Q9, TP.HCM'),
('KH010', 'Hồ Thị M', '0900011223', '001122334455', 'hothim@email.com', 'Việt Nam', '963 Đường ZYX, Q10, TP.HCM');

-- 3. Nhập dữ liệu cho bảng CAN_HO (10 căn hộ)
INSERT INTO CAN_HO (MA_CAN_HO, MA_CHU_NHA, TEN_CAN_HO, DIA_CHI, LOAI_CAN_HO, DIEN_TICH, GIA_THUE_DAI_HAN, GIA_THUE_NGAN_HAN)
VALUES
('CH001', 'CN001', 'Căn hộ A1', '123 Đường ABC, Q1, TP.HCM', 'Căn hộ 1 phòng ngủ', 45.5, 5000000, 6000000),
('CH002', 'CN001', 'Căn hộ A2', '456 Đường ABC, Q1, TP.HCM', 'Căn hộ studio', 30.2, 4000000, 5000000),
('CH003', 'CN001', 'Căn hộ A3', '789 Đường ABC, Q1, TP.HCM', 'Căn hộ 2 phòng ngủ', 65.0, 7000000, 8000000),
('CH004', 'CN002', 'Căn hộ B1', '123 Đường XYZ, Q2, TP.HCM', 'Căn hộ 1 phòng ngủ', 48.0, 5500000, 6500000),
('CH005', 'CN002', 'Căn hộ B2', '456 Đường XYZ, Q2, TP.HCM', 'Căn hộ studio', 32.5, 4500000, 5500000),
('CH006', 'CN002', 'Căn hộ B3', '789 Đường XYZ, Q2, TP.HCM', 'Căn hộ 2 phòng ngủ', 68.0, 7500000, 8500000),
('CH007', 'CN001', 'Căn hộ A4', '101 Đường ABC, Q1, TP.HCM', 'Căn hộ 3 phòng ngủ', 85.0, 9000000, 10000000),
('CH008', 'CN002', 'Căn hộ B4', '202 Đường XYZ, Q2, TP.HCM', 'Căn hộ 1 phòng ngủ', 50.0, 6000000, 7000000),
('CH009', 'CN001', 'Căn hộ A5', '303 Đường ABC, Q1, TP.HCM', 'Căn hộ studio', 35.0, 5000000, 6000000),
('CH010', 'CN002', 'Căn hộ B5', '404 Đường XYZ, Q2, TP.HCM', 'Căn hộ 2 phòng ngủ', 70.0, 8000000, 9000000);

-- 4. Nhập dữ liệu cho bảng HOP_DONG (10 hợp đồng)
INSERT INTO HOP_DONG (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG, NGAY_BAT_DAU, NGAY_KET_THUC, NGAY_LAM_HOP_DONG, TIEN_COC)
VALUES
('CH001', 'KH001', 'HD001', '2024-01-01', '2024-12-31', '2023-12-15', 10000000),
('CH002', 'KH002', 'HD002', '2024-02-01', '2024-11-30', '2024-01-20', 8000000),
('CH003', 'KH003', 'HD003', '2024-03-01', '2024-10-31', '2024-02-15', 14000000),
('CH004', 'KH004', 'HD004', '2024-04-01', '2024-09-30', '2024-03-10', 11000000),
('CH005', 'KH005', 'HD005', '2024-05-01', '2024-08-31', '2024-04-05', 9000000),
('CH006', 'KH006', 'HD006', '2024-01-15', '2024-12-15', '2024-01-01', 15000000),
('CH007', 'KH007', 'HD007', '2024-02-15', '2024-11-15', '2024-02-01', 18000000),
('CH008', 'KH008', 'HD008', '2024-03-15', '2024-10-15', '2024-03-01', 12000000),
('CH009', 'KH009', 'HD009', '2024-04-15', '2024-09-15', '2024-04-01', 10000000),
('CH010', 'KH010', 'HD010', '2024-05-15', '2024-08-15', '2024-05-01', 16000000);

-- 5. Nhập dữ liệu cho bảng HOA_DON (20 hóa đơn)
INSERT INTO HOA_DON (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG, MA_HOA_DON, NGAY_THANH_TOAN, TIEN_NHA, TIEN_DIEN, TIEN_NUOC, PHI_DICH_VU, TONG_TIEN)
VALUES
-- Hóa đơn cho hợp đồng HD001 (6 tháng)
('CH001', 'KH001', 'HD001', 'HD001001', '2024-01-05', 5000000, 300000, 100000, 200000, 5600000),
('CH001', 'KH001', 'HD001', 'HD001002', '2024-02-05', 5000000, 350000, 120000, 200000, 5670000),
('CH001', 'KH001', 'HD001', 'HD001003', '2024-03-05', 5000000, 400000, 150000, 200000, 5750000),

-- Hóa đơn cho hợp đồng HD002 (4 tháng)
('CH002', 'KH002', 'HD002', 'HD002001', '2024-02-05', 4000000, 250000, 80000, 150000, 4480000),
('CH002', 'KH002', 'HD002', 'HD002002', '2024-03-05', 4000000, 300000, 90000, 150000, 4540000),

-- Hóa đơn cho hợp đồng HD003 (3 tháng)
('CH003', 'KH003', 'HD003', 'HD003001', '2024-03-05', 7000000, 500000, 200000, 300000, 8000000),

-- Hóa đơn cho hợp đồng HD004 (2 tháng)
('CH004', 'KH004', 'HD004', 'HD004001', '2024-04-05', 5500000, 350000, 120000, 250000, 6220000),

-- Hóa đơn cho hợp đồng HD005 (1 tháng)
('CH005', 'KH005', 'HD005', 'HD005001', '2024-05-05', 4500000, 300000, 100000, 200000, 5100000),

-- Hóa đơn cho hợp đồng HD006 (6 tháng)
('CH006', 'KH006', 'HD006', 'HD006001', '2024-01-20', 7500000, 600000, 250000, 350000, 8700000),
('CH006', 'KH006', 'HD006', 'HD006002', '2024-02-20', 7500000, 650000, 300000, 350000, 8800000),
('CH006', 'KH006', 'HD006', 'HD006003', '2024-03-20', 7500000, 700000, 350000, 350000, 8900000),

-- Hóa đơn cho hợp đồng HD007 (5 tháng)
('CH007', 'KH007', 'HD007', 'HD007001', '2024-02-20', 9000000, 800000, 400000, 500000, 10700000),
('CH007', 'KH007', 'HD007', 'HD007002', '2024-03-20', 9000000, 850000, 450000, 500000, 10800000),

-- Hóa đơn cho hợp đồng HD008 (4 tháng)
('CH008', 'KH008', 'HD008', 'HD008001', '2024-03-20', 6000000, 400000, 150000, 300000, 6850000),

-- Hóa đơn cho hợp đồng HD009 (3 tháng)
('CH009', 'KH009', 'HD009', 'HD009001', '2024-04-20', 5000000, 350000, 120000, 250000, 5720000),

-- Hóa đơn cho hợp đồng HD010 (2 tháng)
('CH010', 'KH010', 'HD010', 'HD010001', '2024-05-20', 8000000, 700000, 300000, 400000, 9400000),
('CH010', 'KH010', 'HD010', 'HD010002', '2024-06-20', 8000000, 750000, 350000, 400000, 9500000);
