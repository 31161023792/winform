create database QLKho
go
USE [QLKho]
GO
/****** Object:  Table [dbo].[ChitietDonHang]    Script Date: 5/6/2019 9:12:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChitietDonHang](
	[IdChitiet] [int] NOT NULL,
	[MaDH] [varchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[Soluong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChitietDH] PRIMARY KEY CLUSTERED 
(
	[IdChitiet] ASC,
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChitietPhieuNhap]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChitietPhieuNhap](
	[IdChitiet] [varchar](50) NOT NULL,
	[MaPN] [varchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[Soluong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_ChitietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[IdChitiet] ASC,
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChitietPhieuXuat]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChitietPhieuXuat](
	[IdChitiet] [varchar](50) NOT NULL,
	[MaPX] [varchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[Soluong] [int] NOT NULL,
 CONSTRAINT [PK_ChitietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[IdChitiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [varchar](50) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [varchar](50) NOT NULL,
	[TenHangHoa] [nvarchar](100) NOT NULL,
	[DonViTinh] [varchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[MaLoai] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SoDT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[MaLoai] [varchar](50) NOT NULL,
	[TenLoai] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](300) NOT NULL,
	[SoDienThoai] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[SoDT] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [varchar](50) NOT NULL,
	[MaDH] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[ThoiGian] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/6/2019 9:12:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserID] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChitietDonHang] ([IdChitiet], [MaDH], [MaHH], [Soluong], [ThanhTien], [TinhTrang]) VALUES (1, N'DH001', N'BD001', 12000, 120000, N'Chưa giao')
INSERT [dbo].[ChitietDonHang] ([IdChitiet], [MaDH], [MaHH], [Soluong], [ThanhTien], [TinhTrang]) VALUES (1, N'DH002', N'BD001', 10, 120000, N'Chưa giao')
INSERT [dbo].[ChitietDonHang] ([IdChitiet], [MaDH], [MaHH], [Soluong], [ThanhTien], [TinhTrang]) VALUES (2, N'DH001', N'QM001', 50, 110000, N'Chưa giao')
INSERT [dbo].[ChitietPhieuNhap] ([IdChitiet], [MaPN], [MaHH], [Soluong], [ThanhTien]) VALUES (N'1', N'1', N'BD001', 10, 120000)
INSERT [dbo].[ChitietPhieuNhap] ([IdChitiet], [MaPN], [MaHH], [Soluong], [ThanhTien]) VALUES (N'1', N'2', N'BD001', 10, 120000)
INSERT [dbo].[DonHang] ([MaDH], [ThoiGian], [DiaChi], [TrangThai], [MaKH]) VALUES (N'DH001', CAST(N'2019-04-11 12:00:00.000' AS DateTime), N'25 đường phạm ngũ lão', N'Chưa giao', N'KH001')
INSERT [dbo].[DonHang] ([MaDH], [ThoiGian], [DiaChi], [TrangThai], [MaKH]) VALUES (N'DH002', CAST(N'2019-05-02 00:00:00.000' AS DateTime), N'26 đường trường sơ', N'Chưa giao', N'KH002')
INSERT [dbo].[HangHoa] ([MaHH], [TenHangHoa], [DonViTinh], [DonGia], [Soluong], [MaLoai]) VALUES (N'BD001', N'Bóng đèn điện quang', N'thùng', 250000, 160, N'BD')
INSERT [dbo].[HangHoa] ([MaHH], [TenHangHoa], [DonViTinh], [DonGia], [Soluong], [MaLoai]) VALUES (N'BD002', N'Bóng đèn rạng đông', N'thùng', 275000, 40, N'BD')
INSERT [dbo].[HangHoa] ([MaHH], [TenHangHoa], [DonViTinh], [DonGia], [Soluong], [MaLoai]) VALUES (N'BD003', N'Bóng đèn Philip', N'thùng', 300000, 2, N'BD')
INSERT [dbo].[HangHoa] ([MaHH], [TenHangHoa], [DonViTinh], [DonGia], [Soluong], [MaLoai]) VALUES (N'QM001', N'Quạt treo', N'cái', 120000, 208, N'QM')
INSERT [dbo].[HangHoa] ([MaHH], [TenHangHoa], [DonViTinh], [DonGia], [Soluong], [MaLoai]) VALUES (N'QM002', N'Quạt bàn', N'cái', 110000, 20, N'QM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SoDT]) VALUES (N'KH001', N'Công ty Ngọc Núi', N'28 đường phạm ngũ lão', N'0557775545')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SoDT]) VALUES (N'KH002', N'Công ty Đạt 09', N'29 đường phạm ngũ lão', N'0557775546')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'BD', N'Bóng đèn')
INSERT [dbo].[LoaiHangHoa] ([MaLoai], [TenLoai]) VALUES (N'QM', N'Quạt máy')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai], [Fax]) VALUES (N'NCC001', N'Điện Quang', N'125 Hàm Nghi, Quận1, TP.Hồ Chí Minh', N'19001257', N'84.8.38251518')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai], [Fax]) VALUES (N'NCC002', N'Rạng Đông', N' Số 87-89, Phố Hạ Đình, Phường Thanh Xuân Trung, Quận Thanh Xuân, Hà Nội', N'3 858 4165', N'Không có')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai], [Fax]) VALUES (N'NCC003', N'DaPhaCo', N'41/70 Đường số 3, Phường 9, Quận Gò Vấp, Thành phố Hồ Chí Minh', N'08-62579315', N'08-62575105')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai], [Fax]) VALUES (N'NCC004', N'CaDiVi', N'70-72 Nam Kỳ Khởi Nghĩa, Phường Nguyễn Thái Bình, Quận 1, TP.Hồ Chí Minh', N'(84.28) 3829 9437', N'3829 2972')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SoDienThoai], [Fax]) VALUES (N'NCC005', N'Lion', N'333 Phạm Ngũ Lão', N'077555888', N'')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [SoDT], [Email]) VALUES (N'001', N'Chung Hoàng Khánh', CAST(N'1998-03-15' AS Date), N'TP.HCM', N'xxx-xxx-xxxx', N'khanh@gmail.com')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [SoDT], [Email]) VALUES (N'002', N'Lê Thành Đạt', CAST(N'1998-10-06' AS Date), N'TP.HCM', N'xxx-xxx-xxxx', N'dat@gmail.com')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [SoDT], [Email]) VALUES (N'003', N'Nguyễn Xuân Ngọc', CAST(N'1998-10-11' AS Date), N'Khu ổ chuột', N'xxx-xxx-xxxx', N'ngoc@gmail.com')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [SoDT], [Email]) VALUES (N'004', N'Nguyễn Hoàng Nam', CAST(N'1998-03-04' AS Date), N'Đối diện khu ổ chuột', N'xxx-xxx-xxxx', N'nam@gmail.com')
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [ThoiGian]) VALUES (N'1', N'001', N'NCC001', CAST(N'2019-05-05 18:43:18.863' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [ThoiGian]) VALUES (N'2', N'001', N'NCC001', CAST(N'2019-05-05 18:01:50.373' AS DateTime))
INSERT [dbo].[TaiKhoan] ([UserID], [MaNV], [MatKhau], [Admin]) VALUES (N'001', N'001', N'khanh', 1)
INSERT [dbo].[TaiKhoan] ([UserID], [MaNV], [MatKhau], [Admin]) VALUES (N'003', N'003', N'ngoc', 0)
ALTER TABLE [dbo].[ChitietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChitietDonHang_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[ChitietDonHang] CHECK CONSTRAINT [FK_ChitietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChitietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChitietDonHang_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChitietDonHang] CHECK CONSTRAINT [FK_ChitietDonHang_HangHoa]
GO
ALTER TABLE [dbo].[ChitietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuNhap_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChitietPhieuNhap] CHECK CONSTRAINT [FK_ChitietPhieuNhap_HangHoa]
GO
ALTER TABLE [dbo].[ChitietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChitietPhieuNhap] CHECK CONSTRAINT [FK_ChitietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChitietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuXuat_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChitietPhieuXuat] CHECK CONSTRAINT [FK_ChitietPhieuXuat_HangHoa]
GO
ALTER TABLE [dbo].[ChitietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPhieuXuat_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChitietPhieuXuat] CHECK CONSTRAINT [FK_ChitietPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHangHoa] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHangHoa] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHangHoa]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_DonHang1] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_DonHang1]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
