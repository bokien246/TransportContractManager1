create database TransportCompany;
-- =========================
-- 1. Danh mục quyền
-- =========================
CREATE TABLE dm_quyen (
    id INT PRIMARY KEY IDENTITY,
    ten_quyen NVARCHAR(50),
    trang_thai BIT
);

-- =========================
-- 2. Bảng tài khoản (Users)
-- =========================
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Role NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Id_Quyen INT FOREIGN KEY REFERENCES dm_quyen(id)
);
ALTER TABLE Users
ADD CONSTRAINT UQ_Username UNIQUE (Username);

-- 3. Danh mục loại khách hàng
CREATE TABLE dm_loaikhachhang (
    MaLoaiKH NVARCHAR(10) PRIMARY KEY,
    ten_loai_khach_hang NVARCHAR(100)
);

-- 4. Bảng khách hàng
CREATE TABLE ql_khachhang (
    MaKH NVARCHAR(10) PRIMARY KEY,
    ten_cty NVARCHAR(100),
    nguoi_dai_dien NVARCHAR(100),
    chuc_vu_dai_dien NVARCHAR(50),
    MaLoaiKH NVARCHAR(10) FOREIGN KEY REFERENCES dm_loaikhachhang(MaLoaiKH),
    ma_so_thue NVARCHAR(20),
    dia_chi NVARCHAR(200),
    sdt NVARCHAR(20),
    stk NVARCHAR(50),
    ngan_hang NVARCHAR(100)
);

-- 5. Danh mục phương thức thanh toán
CREATE TABLE dm_phuongthucthanhtoan (
    MaPTTT NVARCHAR(10) PRIMARY KEY,
    ten_phuong_thuc NVARCHAR(100)
);
INSERT INTO dm_phuongthucthanhtoan (MaPTTT, ten_phuong_thuc)
VALUES 
    ('PTTT01', N'Chuyển khoản'),
    ('PTTT02', N'Tiền mặt');
-- 6. Bảng hợp đồng
CREATE TABLE ql_hopdong (
    MaHD NVARCHAR(10) PRIMARY KEY,
    MaKH NVARCHAR(10) FOREIGN KEY REFERENCES ql_khachhang(MaKH),
    ngay_upload DATE,
    ngay_hieu_luc DATE,
    ngay_het_hieu_luc DATE,
    MaPTTT NVARCHAR(10) FOREIGN KEY REFERENCES dm_phuongthucthanhtoan(MaPTTT),
    link_tai_lieu NVARCHAR(255)
);

-- 7. Danh mục đơn vị đo
CREATE TABLE dm_donvido (
    MaDVD NVARCHAR(10) PRIMARY KEY,
    ten_don_vi_do NVARCHAR(50)
);

-- 8. Danh mục loại hàng
CREATE TABLE dm_loaihang (
    MaLoaiHang NVARCHAR(10) PRIMARY KEY,
    ten_loai_hang NVARCHAR(100)
);

-- 9. Bảng vận chuyển
CREATE TABLE ql_vanchuyen (
    MaVC NVARCHAR(10) PRIMARY KEY,
    MaHD NVARCHAR(10) FOREIGN KEY REFERENCES ql_hopdong(MaHD),
    bien_so_xe NVARCHAR(20),
    ten_hang NVARCHAR(100),
    MaLoaiHang NVARCHAR(10) FOREIGN KEY REFERENCES dm_loaihang(MaLoaiHang),
    diem_nhan NVARCHAR(200),
    thoi_gian_nhan DATETIME,
    diem_tra NVARCHAR(200),
    thoi_gian_tra DATETIME,
    MaDVD NVARCHAR(10) FOREIGN KEY REFERENCES dm_donvido(MaDVD),
    ghi_chu NVARCHAR(255),
    trong_luong_hang FLOAT,
    tl_xe FLOAT,
    khoi_luong_bi FLOAT,
    tl_tong FLOAT,
    don_gia MONEY,
    thanh_tien MONEY
);

-- 10. Bảng hóa đơn
CREATE TABLE ql_hoadon (
    MaHDon NVARCHAR(10) PRIMARY KEY,
    MaVC NVARCHAR(10) FOREIGN KEY REFERENCES ql_vanchuyen(MaVC),
    MaPTTT NVARCHAR(10) FOREIGN KEY REFERENCES dm_phuongthucthanhtoan(MaPTTT),
    link_tai_lieu NVARCHAR(255)
);

-- 11. Địa lý
CREATE TABLE dm_tinhthanh (
    MaTinh NVARCHAR(10) PRIMARY KEY,
    ten_tinh_thanh NVARCHAR(100)
);

CREATE TABLE dm_quanhuyen (
    MaHuyen NVARCHAR(10) PRIMARY KEY,
    ten_quan_huyen NVARCHAR(100),
    MaTinh NVARCHAR(10) FOREIGN KEY REFERENCES dm_tinhthanh(MaTinh)
);

CREATE TABLE dm_phuongxa (
    MaXa NVARCHAR(10) PRIMARY KEY,
    ten_phuong_xa NVARCHAR(100),
    MaHuyen NVARCHAR(10) FOREIGN KEY REFERENCES dm_quanhuyen(MaHuyen)
);
INSERT INTO dm_quyen (ten_quyen, trang_thai)
VALUES 
    (N'Quản trị viên', 1), -- id = 1
    (N'Người dùng', 1);     -- id = 2
INSERT INTO dm_loaikhachhang (MaLoaiKH, ten_loai_khach_hang)
VALUES
    ('LKH01', N'Khách hàng cá nhân'),
    ('LKH02', N'Khách hàng doanh nghiệp'),
    ('LKH03', N'Khách hàng VIP'),
    ('LKH04', N'Khách hàng thường xuyên');



select * from dm_loaikhachhang;
