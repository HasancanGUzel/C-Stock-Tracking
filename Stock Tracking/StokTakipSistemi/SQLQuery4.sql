CREATE DATABASE [StokTakip]

CREATE TABLE [dbo].[Satis](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UrunAdi] [varchar](50) NOT NULL,
	[Fiyat] [decimal](18, 0) NOT NULL,
	[SatisTarihi] [date] NOT NULL,
	[Durum] [smallint] NOT NULL,

);

CREATE TABLE [dbo].[Urun](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UrunAdi] [nvarchar](250) NOT NULL,
	[Marka] [nvarchar](250) NOT NULL,
	[Fiyat] [decimal](18, 0) NOT NULL,
	[SonKulTarih] [date] NOT NULL,
	[UrunCesit] [nvarchar](250) NOT NULL,
	[StokMiktar] [int] NOT NULL,

);

INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), 0)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (2, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-15' AS Date), 0)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (4, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (5, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), 0)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (6, N'marul', CAST(2 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), 0)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (7, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1002, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-11' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1003, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-11' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1004, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-11' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1005, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-11' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1006, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1007, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1008, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1009, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1010, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1011, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1012, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1013, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1014, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1015, N'elma', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)
INSERT [dbo].[Satis] ([Id], [UrunAdi], [Fiyat], [SatisTarihi], [Durum]) VALUES (1016, N'ceviz', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-12' AS Date), 1)


INSERT [dbo].[Urun] ([Id], [UrunAdi], [Marka], [Fiyat], [SonKulTarih], [UrunCesit], [StokMiktar]) VALUES (1029, N'elma123', N'torku', CAST(100 AS Decimal(18, 0)), CAST(N'2021-01-08' AS Date), N'345', 38)
INSERT [dbo].[Urun] ([Id], [UrunAdi], [Marka], [Fiyat], [SonKulTarih], [UrunCesit], [StokMiktar]) VALUES (2002, N'elma', N'adada', CAST(34 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), N'34', 26)
INSERT [dbo].[Urun] ([Id], [UrunAdi], [Marka], [Fiyat], [SonKulTarih], [UrunCesit], [StokMiktar]) VALUES (2005, N'marul', N'deneme', CAST(2 AS Decimal(18, 0)), CAST(N'2021-01-10' AS Date), N'sebze', 15)


