 CREATE DATABASE QLHOCSINH
 GO

USE QLHOCSINH
GO
CREATE TABLE HSChoNhapHoc
(
	Ma CHAR(10) PRIMARY KEY,
	Ten NVARCHAR(50) NOT NULL,
	CCCD CHAR(12) NOT NULL UNIQUE,
	DiaChi NVARCHAR(50),
	SoDienThoai CHAR(10) UNIQUE
)
CREATE TABLE DSTrungTuyen
(
	MaTS CHAR(10) PRIMARY KEY,
	TenTS NVARCHAR(50) NOT NULL,
	CCCD CHAR(12) NOT NULL UNIQUE,
	DiaChi NVARCHAR(MAX),
	NgaySinh DATE NOT NULL,
	GioiTinh BIT NOT NULL,
	SoDienThoai CHAR(10) UNIQUE,
	DiemToan FLOAT NOT NULL,
	DiemLy FLOAT NOT NULL,
	DiemHoa FLOAT NOT NULL,
	DiemVan FLOAT NOT NULL,
	DiemAnh FLOAT NOT NULL,
)
CREATE TABLE LoaiNhanVien
(
    MaLoai CHAR(10) PRIMARY KEY,
    TenLoai NVARCHAR(50),
)
CREATE TABLE NhanVien
(
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(50) NOT NULL,
    MaLoai CHAR(10) FOREIGN KEY REFERENCES dbo.LoaiNhanVien(MaLoai)
)
CREATE TABLE HOCSINH
(
    MaHS CHAR(10) PRIMARY KEY,
    TenHS NVARCHAR(50) NOT NULL,
    CCCD CHAR(12) NOT NULL UNIQUE,
	DiaChi NVARCHAR(MAX),
	NgaySinh DATE NOT NULL,
	GioiTinh BIT NOT NULL,
    SoDienThoai CHAR(10) UNIQUE,
)
CREATE TABLE PhieuBienNhanHS
(
	MaPhieu CHAR(10) PRIMARY KEY,
	NgayNhan DATETIME NOT NULL,
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS),
	MaNV CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
)
CREATE TABLE HoSo
(
	MaHoSo CHAR(10) PRIMARY KEY,
	TenHoSo NVARCHAR(50),
	SoLuongToiDa INT,
	GhiChu NVARCHAR(100),
)
CREATE TABLE CTPhieuBienNhanHS
(
	MaPhieuBN CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.PhieuBienNhanHS(MaPhieu),
	MaHoSo CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HoSo(MaHoSo),
	SoLuong INT NOT NULL,
	GhiChu NVARCHAR(50),
	PRIMARY KEY(MaPhieuBN,MaHoSo),
)
CREATE TABLE MonHoc
(
	MaMon CHAR(10) PRIMARY KEY,
	TenMon NVARCHAR(50) NOT NULL,
)
CREATE TABLE NamHoc
(
	MaNamHoc CHAR(10) PRIMARY KEY,
	TenNamHoc NVARCHAR(50),
)
CREATE TABLE Khoi
(
	MaKhoi CHAR(10) PRIMARY KEY,
	TenKhoi NVARCHAR(50) NOT NULL,
)
CREATE TABLE HocKy
(
	MaHocKy CHAR(10) PRIMARY KEY,
	TenHocKy NVARCHAR(50) NOT NULL,
)
CREATE TABLE HocPhi
(
	MaHocPhi CHAR(10) PRIMARY KEY,
	SoTien MONEY NOT NULL,
	MaKhoi CHAR(10) NOT NULL FOREIGN KEY REFERENCES Khoi(MaKhoi),
	MaNamHoc CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NamHoc(MaNamHoc),
	HocKy CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HocKy(MaHocKy)
)

--Quan he ke thua voi nhanvIEN
CREATE TABLE GiaoVien
(
	MaNV CHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
	MaMon CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.MonHoc(MaMon)
)
CREATE TABLE LopHoc
(
	MaLop CHAR(10) PRIMARY KEY,
	TenLop NVARCHAR(50) NOT NULL,
	Khoi CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.Khoi(MaKhoi),
	NamHoc CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NamHoc(MaNamHoc),
	GiaoVienCN CHAR(10) FOREIGN KEY REFERENCES dbo.GiaoVien(MaNV)
)
CREATE TABLE HocSinh_LopHoc
(
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS),
	MaLop CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.LopHoc(MaLop),
	DiemHanhKiem INT NOT NULL DEFAULT 70,
	PRIMARY KEY(MaHS,MaLop)
)
CREATE TABLE LopHoc_MonHoc
(
	MaLop CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.LopHoc(MaLop),
	MaMon CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.MonHoc(MaMon),
	MaGV CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.GiaoVien(MaNV),
	PRIMARY KEY(MaLop,MaMon)
)
CREATE TABLE LoaiKiemTra
(
	MaLoai CHAR(10) PRIMARY KEY,
	TenLoai NVARCHAR(50) NOT NULL,
	HeSo FLOAT NOT NULL,
)
CREATE TABLE KetQua
(
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS),
	MaLoaiKT CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.LoaiKiemTra(MaLoai),
	MaHocKy CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HocKy(MaHocKy),
	MaLop CHAR(10) NOT NULL,
	MaMon CHAR(10) NOT NULL,
	FOREIGN KEY(MaLop,MaMon) REFERENCES dbo.LopHoc_MonHoc(MaLop,MaMon),
	Diem DECIMAL NOT NULL CHECK (Diem >= 0),

	PRIMARY KEY(MaHS,MaLoaiKT,MaLop,MaMon,MaHocKy)
)
CREATE TABLE HoaDon
(
	MaHD CHAR(10) NOT NULL PRIMARY KEY,
	MaNV CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS),
	MaHocPhi CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
	SoTien MONEY NOT NULL,
)
CREATE TABLE HanhKiem
(
	MaHanhKiem CHAR(10) PRIMARY KEY,
	TenHanhKiem NVARCHAR(100) NOT NULL,
	Diem INT DEFAULT 0 NOT NULL,
)
CREATE TABLE PhieuBienNhanBieuHien
(
	MaPhieu CHAR(10) NOT NULL PRIMARY KEY,
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS),
	MaGV CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.GiaoVien(MaNV),
	MaHanhKiem CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HanhKiem(MaHanhKiem),
	Diem INT NOT NULL,
	GhiChu NVARCHAR(50),

)
CREATE TABLE TaiKhoan
(
	TenTaiKhoan CHAR(20) PRIMARY KEY,
	MatKhau NVARCHAR(MAX) NOT NULL,
	MaNV CHAR(10) FOREIGN KEY REFERENCES dbo.NhanVien(MaNV)
)
CREATE TABLE GiayXacNhanNhapHoc
(
	MaHS CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.HOCSINH(MaHS) PRIMARY KEY,
	MaNV CHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
	NgayLap DATE DEFAULT GETDATE(),
)
SET DATEFORMAT DMY
GO
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS001', N'Đỗ Ngọc Hương An', '578654748137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','12/03/2008',0, '0911845967', 2, 8, 9, 10, 5 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS002', N'Lê Mỹ An', '489986894711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','15/03/2008',0, '0411825949',7,8,6,9,3 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS003', N'Lê Trương Thúy An', '691641972616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','16/02/2008',0, '0911825471',2,3,4,8,8)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS004', N'Lư Tiến An', '353428587428', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','16/04/2008',1, '0911824973', 8, 9, 5, 6, 2)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS005', N'Lưu Văn An', '485487646617', N'34 Hồ Đắc Mậu, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',1, '0911824488',2,3,4,5,2  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS006', N'Võ Ngọc Hoài An', '834428248254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',0, '0911184497',9,3,8,6,8  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS007', N'Võ Thị Mỹ An', '251249414765', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','7/9/2008',0, '0913182889',5,6,4,5,9 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS008', N'Đỗ Thị Hồng Thắm', '833001180848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',0, '0898882863',7,8,7,5,9  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS009', N'Lê Minh Khánh', '832001170023', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/10/2008',1, '0707888253',8,6,4,5,10 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS010', N'Phạm Thanh Hùng', '833001181729', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',1, '0934154469',10,6,8,8,9 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS011', N'Nguyễn Tấn Đạt', '832001160650', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','15/9/2008',1, '0835533637',5,6,9,10,10 )

INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS012', N'Đỗ Ngọc Hương An', '574554748137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','12/03/2008',0, '0911844967', 2, 8, 5, 10, 5 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS013', N'Lê Mỹ An', '489987324711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','15/03/2008',0, '0911445969',7,8,6,9,3 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS014', N'Lê Trương Thúy An', '791641932616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','16/02/2008',0, '0511825541',2,3,4,8,8)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS015', N'Lư Tiến An', '353428477428', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','16/04/2008',1, '0911855473', 5, 9, 5, 9, 2)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS016', N'Lưu Văn An', '485484146617', N'34 Hồ Đắc Mậu, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',1, '0911828458',2,3,4,5,2  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS017', N'Võ Ngọc Hoài An', '834448248254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',0, '0911182547',9,3,7,6,8  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS018', N'Võ Thị Mỹ An', '251249415721', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','7/9/2008',0, '0413185549',5,6,4,5,9 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS019', N'Đỗ Thị Hồng Thắm', '833041320848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',0, '0898444163',7,4,7,5,9  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS020', N'Lê Minh Khánh', '832041170213', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/10/2008',1, '0747054453',4,6,4,5,10 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS021', N'Phạm Thanh Hùng', '833502181729', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',1, '0934158444',10,6,8,8,9 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS022', N'Nguyễn Tấn Đạt', '832041123450', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','15/9/2008',1, '0835445637',5,4,4,10,10 )

INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS023', N'Đỗ Ngọc Hương An', '578554213137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','12/03/2008',0, '0944425967', 6, 4, 4, 10, 5 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS024', N'Lê Mỹ An', '482986894711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','15/03/2008',0, '0911965969',7,8,6,7,3 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS025', N'Lê Trương Thúy An', '491653322616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','16/02/2008',0, '0911824471',2,3,4,4,8)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS026', N'Lư Tiến An', '353428547334', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','16/04/2008',1, '0911824473', 8, 4, 5, 6, 2)
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS027', N'Lưu Văn An', '485482115617', N'34 Hồ Đắc Mậu, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',1, '0911828888',2,3,4,6,2  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS028', N'Võ Ngọc Hoài An', '844423468254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','17/05/2008',0, '0551182597',9,3,8,6,8  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS029', N'Võ Thị Mỹ An', '251241411465', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định','7/9/2008',0, '0913182459',5,6,4,5,9 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS030', N'Đỗ Thị Hồng Thắm', '833048580848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',0, '0898665463',7,9,7,4,9  )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS031', N'Lê Minh Khánh', '831001142123', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/10/2008',1, '0705558253',8,6,4,5,10 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS032', N'Phạm Thanh Hùng', '833044586429', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định','19/9/2008',1, '0934155469',10,5,8,8,8 )
INSERT INTO dbo.DSTrungTuyen ( MaTS, TenTS, CCCD, DiaChi, NgaySinh, GioiTinh, SoDienThoai, DiemToan, DiemLy, DiemHoa, DiemVan, DiemAnh ) VALUES ( 'TS033', N'Nguyễn Tấn Đạt', '832044445650', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định','15/9/2008',1, '0835443637',5,4,3,10,10 )


INSERT INTO dbo.LoaiNhanVien( MaLoai, TenLoai )VALUES( 'LNV001', N'Tài chính' )
INSERT INTO dbo.LoaiNhanVien( MaLoai, TenLoai )VALUES( 'LNV002', N'Giáo vụ' )
INSERT INTO dbo.LoaiNhanVien( MaLoai, TenLoai )VALUES( 'LNV003', N'Giáo viên' )

INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV001', N'Nguyễn Văn Tài', 'LNV001' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV002', N'Nguyễn Thị Minh Tuyết', 'LNV001' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV003', N'Huỳnh Văn Kiên', 'LNV003' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV004', N'Mai Kiến Văn', 'LNV003' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV005', N'Nguyễn Duy Hải', 'LNV002' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV006', N'Mai Huỳnh Văn', 'LNV003' )
INSERT INTO dbo.NhanVien( MaNV, TenNV, MaLoai )VALUES( 'NV007', N'Huỳnh Anh Thư', 'LNV003' )

INSERT INTO dbo.HoSo( MaHoSo, TenHoSo, SoLuongToiDa, GhiChu )VALUES( 'HS001', N'Học bạ cấp THCS (Bản chính)', 1, N'' )
INSERT INTO dbo.HoSo( MaHoSo, TenHoSo, SoLuongToiDa, GhiChu )VALUES( 'HS002', N'Bằng tốt nghiệp THCS (bản chính)', 1, N'' )
INSERT INTO dbo.HoSo( MaHoSo, TenHoSo, SoLuongToiDa, GhiChu )VALUES( 'HS003', N'Bằng tốt nghiệp THCS bản tạm thời', 1, N'' )
INSERT INTO dbo.HoSo( MaHoSo, TenHoSo, SoLuongToiDa, GhiChu )VALUES( 'HS004', N'Bản sao giấy khai sinh hợp lệ', 1, N'' )

INSERT INTO dbo.NamHoc( MaNamHoc, TenNamHoc )VALUES( 'NH21_22', N'2021-2022' )
INSERT INTO dbo.NamHoc( MaNamHoc, TenNamHoc )VALUES( 'NH22_23', N'2022-2023' )

INSERT INTO dbo.Khoi( MaKhoi, TenKhoi )VALUES( 'KH10', N'Khối 10' )
INSERT INTO dbo.Khoi( MaKhoi, TenKhoi )VALUES( 'KH11', N'Khối 11' )
INSERT INTO dbo.Khoi( MaKhoi, TenKhoi )VALUES( 'KH12', N'Khối 12' )

INSERT INTO dbo.HocKy( MaHocKy, TenHocKy )VALUES( 'HK1', N'Học kỳ 1' )
INSERT INTO dbo.HocKy( MaHocKy, TenHocKy )VALUES( 'HK2', N'Học kỳ 2' )

INSERT INTO dbo.HocPhi( MaHocPhi, SoTien, MaKhoi, MaNamHoc, HocKy )VALUES( 'HP001', 1000000, 'KH10', 'NH21_22', 'HK1' )
INSERT INTO dbo.HocPhi( MaHocPhi, SoTien, MaKhoi, MaNamHoc, HocKy )VALUES( 'HP002', 1500000, 'KH11', 'NH21_22', 'HK1' )
INSERT INTO dbo.HocPhi( MaHocPhi, SoTien, MaKhoi, MaNamHoc, HocKy )VALUES( 'HP003', 1320000, 'KH11', 'NH21_22', 'HK1' )
INSERT INTO dbo.HocPhi( MaHocPhi, SoTien, MaKhoi, MaNamHoc, HocKy )VALUES( 'HP004', 1320000, 'KH10', 'NH22_23', 'HK1' )

INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH001', N'Toán' )
INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH002', N'Vật lý' )
INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH003', N'Hoá học' )
INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH004', N'Tin học' )
INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH005', N'Văn học' )
INSERT INTO dbo.MonHoc( MaMon, TenMon )VALUES( 'MH006', N'TAnh văn' )

INSERT INTO dbo.GiaoVien( MaNV, MaMon )VALUES( 'NV003', 'MH004' )
INSERT INTO dbo.GiaoVien( MaNV, MaMon )VALUES( 'NV004', 'MH001' )
INSERT INTO dbo.GiaoVien( MaNV, MaMon )VALUES( 'NV006', 'MH002' )
INSERT INTO dbo.GiaoVien( MaNV, MaMon )VALUES( 'NV007', 'MH003' )

INSERT INTO dbo.LopHoc( MaLop, TenLop, Khoi, NamHoc, GiaoVienCN )VALUES( 'LH001', N'Lớp 10A1', 'KH10', 'NH22_23', 'NV003' )
INSERT INTO dbo.LopHoc( MaLop, TenLop, Khoi, NamHoc, GiaoVienCN )VALUES( 'LH002', N'Lớp 10A2', 'KH10', 'NH22_23', 'NV006' )
INSERT INTO dbo.LopHoc( MaLop, TenLop, Khoi, NamHoc, GiaoVienCN )VALUES( 'LH003', N'Lớp 10A3', 'KH10', 'NH22_23', 'NV004' )
INSERT INTO dbo.LopHoc( MaLop, TenLop, Khoi, NamHoc, GiaoVienCN )VALUES( 'LH004', N'Lớp 10A4', 'KH10', 'NH22_23', 'NV007' )
INSERT INTO dbo.LopHoc( MaLop, TenLop, Khoi, NamHoc, GiaoVienCN )VALUES( 'LH005', N'Lớp 11A2', 'KH11', 'NH21_22', 'NV004' )


INSERT INTO dbo.TaiKhoan( TenTaiKhoan, MatKhau, MaNV )VALUES( 'nguyenhai', N'nguyenhai', 'NV005' )
GO

ALTER PROC PROC_CreateDataNhapHoc
AS
BEGIN
	
	DELETE GiayXacNhanNhapHoc
	DELETE HocSinh_LopHoc
	DELETE  HOCSINH

	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS001     ', N'Đỗ Ngọc Hương An', N'578654748137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-12' AS Date), 0, N'0911845967')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS002     ', N'Lê Mỹ An', N'489986894711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-15' AS Date), 0, N'0411825949')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS003     ', N'Lê Trương Thúy An', N'691641972616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-02-16' AS Date), 0, N'0911825471')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS004     ', N'Lư Tiến An', N'353428587428', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-04-16' AS Date), 1, N'0911824973')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS005     ', N'Lưu Văn An', N'485487646617', N'34 Hồ Đắc Mậu, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-05-17' AS Date), 1, N'0911824488')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS006     ', N'Võ Ngọc Hoài An', N'834428248254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-05-17' AS Date), 0, N'0911184497')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS007     ', N'Võ Thị Mỹ An', N'251249414765', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-07' AS Date), 0, N'0913182889')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS008     ', N'Đỗ Thị Hồng Thắm', N'833001180848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 0, N'0898882863')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS009     ', N'Lê Minh Khánh', N'832001170023', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-10-19' AS Date), 1, N'0707888253')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS010     ', N'Phạm Thanh Hùng', N'833001181729', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 1, N'0934154469')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS011     ', N'Nguyễn Tấn Đạt', N'832001160650', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-15' AS Date), 1, N'0835533637')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS012     ', N'Đỗ Ngọc Hương An', N'574554748137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-12' AS Date), 0, N'0911844967')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS013     ', N'Lê Mỹ An', N'489987324711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-15' AS Date), 0, N'0911445969')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS014     ', N'Lê Trương Thúy An', N'791641932616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-02-16' AS Date), 0, N'0511825541')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS015     ', N'Lư Tiến An', N'353428477428', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-04-16' AS Date), 1, N'0911855473')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS016     ', N'Võ Ngọc Hoài An', N'834448248254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-05-17' AS Date), 0, N'0911182547')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS017     ', N'Võ Thị Mỹ An', N'251249415721', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-07' AS Date), 0, N'0413185549')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS018     ', N'Đỗ Thị Hồng Thắm', N'833041320848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 0, N'0898444163')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS019     ', N'Phạm Thanh Hùng', N'833502181729', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 1, N'0934158444')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS020     ', N'Lê Minh Khánh', N'832041170213', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-10-19' AS Date), 1, N'0747054453')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS021     ', N'Nguyễn Tấn Đạt', N'832041123450', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-15' AS Date), 1, N'0835445637')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS022     ', N'Đỗ Ngọc Hương An', N'578554213137', N'100 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-12' AS Date), 0, N'0944425967')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS023     ', N'Lê Mỹ An', N'482986894711', N'232 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-03-15' AS Date), 0, N'0911965969')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS024     ', N'Lê Trương Thúy An', N'491653322616', N'243 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-02-16' AS Date), 0, N'0911824471')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS025     ', N'Lư Tiến An', N'353428547334', N'100 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-04-16' AS Date), 1, N'0911824473')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS026     ', N'Lưu Văn An', N'485482115617', N'34 Hồ Đắc Mậu, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-05-17' AS Date), 1, N'0911828888')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS027     ', N'Võ Ngọc Hoài An', N'844423468254', N'33 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-05-17' AS Date), 0, N'0551182597')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS028     ', N'Võ Thị Mỹ An', N'251241411465', N'222 Âu Cơ, Phường Nhơn Bình, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-07' AS Date), 0, N'0913182459')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS029     ', N'Đỗ Thị Hồng Thắm', N'833048580848', N'76 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 0, N'0898665463')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS030     ', N'Lê Minh Khánh', N'831001142123', N'198 Huỳnh Văn Nghĩa, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-10-19' AS Date), 1, N'0705558253')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS031     ', N'Phạm Thanh Hùng', N'833044586429', N'77 Quang Trung, Phường Bùi Thị Xuân, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-19' AS Date), 1, N'0934155469')
	INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [CCCD], [DiaChi], [NgaySinh], [GioiTinh], [SoDienThoai]) VALUES (N'HS032     ', N'Nguyễn Tấn Đạt', N'832044445650', N'432 Lạc Long Quân, Phường Trần Quang Diệu, Thành phố Quy Nhơn, Tỉnh Bình Định', CAST(N'2008-09-15' AS Date), 1, N'0835443637')
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS001     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS002     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS003     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS004     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS005     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS006     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS007     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS008     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS009     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS010     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS011     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS012     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS013     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS014     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS015     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS016     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS017     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS018     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS019     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS020     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS021     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS022     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS023     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS024     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS025     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS026     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS027     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS028     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS029     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS030     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS031     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
	INSERT [dbo].[GiayXacNhanNhapHoc] ([MaHS], [MaNV], [NgayLap]) VALUES (N'HS032     ', N'NV005     ', CAST(N'2022-06-07' AS Date))
END
GO

ALTER PROC PROC_XemKetQuaPhanLop
AS
BEGIN
	SELECT HocSinh.*,LopHoc.MaLop,TenLop, TS.DiemToan, TS.DiemLy, TS.DiemHoa, TS.DiemVan, TS.DiemAnh  FROM HocSinh
	JOIN HocSinh_LopHoc ON HocSinh.MaHS = HocSinh_LopHoc.MaHS
	JOIN LopHoc ON LopHoc.MaLop = HocSinh_LopHoc.MaLop
	JOIN DSTrungTuyen  TS ON HocSinh.CCCD = TS.CCCD
	ORDER BY LopHoc.MaLop ASC

	SELECT LopHoc.MaLop, LopHoc.TenLop, 
	SUM(ts.DiemToan) / COUNT(LopHoc.MaLop) AS 'DTB TOAN', 
	SUM(ts.DiemLy) / COUNT(LopHoc.MaLop) AS 'DTB LY', 
	SUM(ts.DiemHoa) / COUNT(LopHoc.MaLop) AS 'DTB HOA', 
	SUM(ts.DiemVan) / COUNT(LopHoc.MaLop) AS 'DTB VAN', 
	SUM(ts.DiemAnh) / COUNT(LopHoc.MaLop) AS 'DTB ANH', 
	COUNT(LopHoc.MaLop) AS 'si so', 
	SUM(CASE WHEN HOCSINH.GioiTinh = 1 THEN 1 END) / CAST(COUNT(LopHoc.MaLop) AS FLOAT) AS 'Ti le nam'  FROM HocSinh
	JOIN HocSinh_LopHoc ON HocSinh.MaHS = HocSinh_LopHoc.MaHS
	JOIN LopHoc ON LopHoc.MaLop = HocSinh_LopHoc.MaLop
	JOIN DSTrungTuyen  TS ON HocSinh.CCCD = TS.CCCD
	GROUP BY LopHoc.MaLop, LopHoc.TenLop
	ORDER BY LopHoc.MaLop ASC
	
END
GO


EXEC PROC_CreateDataNhapHoc
GO

EXEC PROC_XemKetQuaPhanLop
GO
