USE [master]
GO
/****** Object:  Database [PhanMemQLNS]    Script Date: 07/02/2018 6:00:51 CH ******/
CREATE DATABASE [PhanMemQLNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhanMemQLNS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PhanMemQLNS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PhanMemQLNS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PhanMemQLNS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PhanMemQLNS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhanMemQLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhanMemQLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhanMemQLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhanMemQLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PhanMemQLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhanMemQLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PhanMemQLNS] SET  MULTI_USER 
GO
ALTER DATABASE [PhanMemQLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhanMemQLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhanMemQLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhanMemQLNS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PhanMemQLNS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PhanMemQLNS]
GO
/****** Object:  User [trinh]    Script Date: 07/02/2018 6:00:51 CH ******/
CREATE USER [trinh] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[BangCong]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCong](
	[MaTinhCong] [nchar](10) NOT NULL,
	[CheDoCong] [nvarchar](50) NULL,
	[SoCongNghi] [nvarchar](50) NULL,
	[SoCongTangCa] [nvarchar](50) NULL,
	[MaTinhLuong] [nchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangCong] PRIMARY KEY CLUSTERED 
(
	[MaTinhCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MaTinhLuong] [nchar](10) NOT NULL,
	[HeSoLuong] [nvarchar](50) NULL,
	[LuongCoBan/Ngay] [nvarchar](50) NULL,
	[Thuong] [nvarchar](50) NULL,
	[TamUng] [nvarchar](50) NULL,
	[NgayTao] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[MaTinhLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHĐ]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHĐ](
	[MaNV] [nchar](10) NOT NULL,
	[MaHĐ] [nchar](10) NOT NULL,
	[NgayKyHĐ] [datetime] NULL,
	[NgayKetThucHĐ] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietHĐ] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaHĐ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TenCV] [nvarchar](50) NULL,
	[PhuCapCV] [nvarchar](50) NULL,
	[QuyenHan] [nvarchar](50) NULL,
	[NhiemVu] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Username] [varchar](10) NOT NULL,
	[Password] [nchar](10) NULL,
	[Ghi chu] [nchar](10) NULL,
 CONSTRAINT [PK_Dang nhap] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHĐ] [nchar](10) NOT NULL,
	[TenHĐ] [nvarchar](50) NULL,
	[LoaiHĐ] [nvarchar](50) NULL,
	[ThoiHan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHĐ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[HoNV] [nvarchar](50) NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SĐT] [nchar](10) NULL,
	[MaTinhLuong] [nchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 07/02/2018 6:00:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TenPB] [nvarchar](50) NULL,
	[LoaiPB] [nvarchar](50) NULL,
	[SĐT] [int] NULL,
	[EmailPB] [nvarchar](50) NULL,
	[ChiNhanhPB] [nvarchar](50) NULL,
	[DiaChiPB] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BangCong] ([MaTinhCong], [CheDoCong], [SoCongNghi], [SoCongTangCa], [MaTinhLuong], [GhiChu]) VALUES (N'MC1       ', N'CDC1', N'2', N'3', N'ML1       ', NULL)
INSERT [dbo].[BangCong] ([MaTinhCong], [CheDoCong], [SoCongNghi], [SoCongTangCa], [MaTinhLuong], [GhiChu]) VALUES (N'MC2       ', N'CDC2', N'4', N'3', N'ML2       ', NULL)
INSERT [dbo].[BangCong] ([MaTinhCong], [CheDoCong], [SoCongNghi], [SoCongTangCa], [MaTinhLuong], [GhiChu]) VALUES (N'MC3       ', N'CDC3', N'2', N'1', N'ML3       ', NULL)
INSERT [dbo].[BangLuong] ([MaTinhLuong], [HeSoLuong], [LuongCoBan/Ngay], [Thuong], [TamUng], [NgayTao], [GhiChu]) VALUES (N'ML1       ', N'HSL1', N'120000', N'500000', N'800000', CAST(N'2018-02-07 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[BangLuong] ([MaTinhLuong], [HeSoLuong], [LuongCoBan/Ngay], [Thuong], [TamUng], [NgayTao], [GhiChu]) VALUES (N'ML2       ', N'HSL2', N'120000', N'800000', N'600000', CAST(N'2018-02-08 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[BangLuong] ([MaTinhLuong], [HeSoLuong], [LuongCoBan/Ngay], [Thuong], [TamUng], [NgayTao], [GhiChu]) VALUES (N'ML3       ', N'HSL3', N'120000', N'900000', N'700000', CAST(N'2018-02-09 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ChiTietHĐ] ([MaNV], [MaHĐ], [NgayKyHĐ], [NgayKetThucHĐ], [GhiChu]) VALUES (N'NV1       ', N'HĐ1       ', CAST(N'2017-05-06 00:00:00.000' AS DateTime), CAST(N'2017-07-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ChiTietHĐ] ([MaNV], [MaHĐ], [NgayKyHĐ], [NgayKetThucHĐ], [GhiChu]) VALUES (N'NV2       ', N'HĐ2       ', CAST(N'2017-03-22 00:00:00.000' AS DateTime), CAST(N'2017-05-22 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ChiTietHĐ] ([MaNV], [MaHĐ], [NgayKyHĐ], [NgayKetThucHĐ], [GhiChu]) VALUES (N'NV3       ', N'HĐ3       ', CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-01 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ChucVu] ([MaCV], [MaNV], [TenCV], [PhuCapCV], [QuyenHan], [NhiemVu], [GhiChu]) VALUES (N'CV1       ', N'NV1       ', N'Giám đốc', N'PC chuyên môn', N'Full quyền', N'Quản lý nhân viên', NULL)
INSERT [dbo].[ChucVu] ([MaCV], [MaNV], [TenCV], [PhuCapCV], [QuyenHan], [NhiemVu], [GhiChu]) VALUES (N'CV2       ', N'NV2       ', N'Trưởng phòng', N'PC trách nhiệm', N'Full quyền team', N'Quản lý team', NULL)
INSERT [dbo].[ChucVu] ([MaCV], [MaNV], [TenCV], [PhuCapCV], [QuyenHan], [NhiemVu], [GhiChu]) VALUES (N'CV3       ', N'NV3       ', N'Nhân viên', N'PC ưu đãi', N'Không quyền', N'Hoàn thành nhiệm vụ', NULL)
INSERT [dbo].[DangNhap] ([Username], [Password], [Ghi chu]) VALUES (N'Hanh', N'040       ', NULL)
INSERT [dbo].[DangNhap] ([Username], [Password], [Ghi chu]) VALUES (N'Thuy', N'140       ', NULL)
INSERT [dbo].[DangNhap] ([Username], [Password], [Ghi chu]) VALUES (N'Trinh', N'123       ', NULL)
INSERT [dbo].[HopDong] ([MaHĐ], [TenHĐ], [LoaiHĐ], [ThoiHan], [GhiChu]) VALUES (N'HĐ1       ', N'Thực tập B', N'Thực tập', N'3 tháng', NULL)
INSERT [dbo].[HopDong] ([MaHĐ], [TenHĐ], [LoaiHĐ], [ThoiHan], [GhiChu]) VALUES (N'HĐ2       ', N'Thử việc A', N'Thử việc', N'2 tháng', NULL)
INSERT [dbo].[HopDong] ([MaHĐ], [TenHĐ], [LoaiHĐ], [ThoiHan], [GhiChu]) VALUES (N'HĐ3       ', N'Chính thức vô thời hạn', N'Chính thức', N'3 năm', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [TenNV], [DiaChi], [GioiTinh], [SĐT], [MaTinhLuong], [GhiChu]) VALUES (N'NV1       ', N'Nguyễn', N'Lam', N'Hồng Bàng', N'Nữ', N'099158029 ', N'ML1       ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [TenNV], [DiaChi], [GioiTinh], [SĐT], [MaTinhLuong], [GhiChu]) VALUES (N'NV2       ', N'Lâm', N'Dũng', N'Thủ Đức', N'Nam', N'092559064 ', N'ML2       ', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [TenNV], [DiaChi], [GioiTinh], [SĐT], [MaTinhLuong], [GhiChu]) VALUES (N'NV3       ', N'La', N'Phúc', N'Long Bình', N'Nam', N'092536682 ', N'ML3       ', NULL)
INSERT [dbo].[PhongBan] ([MaPB], [MaNV], [TenPB], [LoaiPB], [SĐT], [EmailPB], [ChiNhanhPB], [DiaChiPB], [GhiChu]) VALUES (N'PB1       ', N'NV1       ', N'Nhân sự A', N'Nhân sự', 112, N'nhansu@gmail', N'CN1', N'Thủ Đức', NULL)
INSERT [dbo].[PhongBan] ([MaPB], [MaNV], [TenPB], [LoaiPB], [SĐT], [EmailPB], [ChiNhanhPB], [DiaChiPB], [GhiChu]) VALUES (N'PB2       ', N'NV2       ', N'BA', N'Phân tích thiết kế', 891, N'ba@gmail', N'CN2', N'Gò Vấp', NULL)
INSERT [dbo].[PhongBan] ([MaPB], [MaNV], [TenPB], [LoaiPB], [SĐT], [EmailPB], [ChiNhanhPB], [DiaChiPB], [GhiChu]) VALUES (N'PB3       ', N'NV3       ', N'PE', N'Triển khai', 117, N'pe@gmail', N'CN3', N'Phú Nhuận', NULL)
ALTER TABLE [dbo].[BangCong]  WITH CHECK ADD  CONSTRAINT [FK_BangCong_BangLuong] FOREIGN KEY([MaTinhLuong])
REFERENCES [dbo].[BangLuong] ([MaTinhLuong])
GO
ALTER TABLE [dbo].[BangCong] CHECK CONSTRAINT [FK_BangCong_BangLuong]
GO
ALTER TABLE [dbo].[ChiTietHĐ]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHĐ_HopDong] FOREIGN KEY([MaHĐ])
REFERENCES [dbo].[HopDong] ([MaHĐ])
GO
ALTER TABLE [dbo].[ChiTietHĐ] CHECK CONSTRAINT [FK_ChiTietHĐ_HopDong]
GO
ALTER TABLE [dbo].[ChiTietHĐ]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHĐ_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChiTietHĐ] CHECK CONSTRAINT [FK_ChiTietHĐ_NhanVien]
GO
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_ChucVu_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_ChucVu_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BangLuong] FOREIGN KEY([MaTinhLuong])
REFERENCES [dbo].[BangLuong] ([MaTinhLuong])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BangLuong]
GO
ALTER TABLE [dbo].[PhongBan]  WITH CHECK ADD  CONSTRAINT [FK_PhongBan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhongBan] CHECK CONSTRAINT [FK_PhongBan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [PhanMemQLNS] SET  READ_WRITE 
GO
