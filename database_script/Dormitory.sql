USE [master]
GO
/****** Object:  Database [YurtKayitTakipSistemi]    Script Date: 21.04.2022 12:14:30 ******/
CREATE DATABASE [YurtKayitTakipSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtKayitTakipSistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\YurtKayitTakipSistemi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YurtKayitTakipSistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\YurtKayitTakipSistemi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtKayitTakipSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET QUERY_STORE = OFF
GO
USE [YurtKayitTakipSistemi]
GO
/****** Object:  Table [dbo].[Duyurular]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Duyurular](
	[Duyuruid] [int] IDENTITY(1,1) NOT NULL,
	[DuyuruYayinlanmaTarihi] [varchar](30) NULL,
	[DuyuruBaslangicTarih] [varchar](30) NULL,
	[DuyuruBitisTarih] [varchar](30) NULL,
	[DuyuruNot] [varchar](200) NULL,
 CONSTRAINT [PK_Duyurular_1] PRIMARY KEY CLUSTERED 
(
	[Duyuruid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giderler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giderler](
	[Giderid] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [varchar](30) NULL,
	[MutfakMalzeme] [varchar](30) NOT NULL,
	[TemizlikMalzeme] [varchar](30) NOT NULL,
	[Tamirat] [varchar](30) NOT NULL,
	[Su] [varchar](30) NOT NULL,
	[Elektrik] [varchar](30) NOT NULL,
	[İnternet] [varchar](30) NOT NULL,
	[Personel] [varchar](30) NOT NULL,
	[Diger] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Giderler] PRIMARY KEY CLUSTERED 
(
	[Giderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GirisCikis]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GirisCikis](
	[giriscikisid] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenciid] [int] NULL,
	[Tarih] [varchar](50) NULL,
	[GirisTarih] [varchar](50) NULL,
	[CikisTarih] [varchar](50) NULL,
 CONSTRAINT [PK_GirisCikis] PRIMARY KEY CLUSTERED 
(
	[giriscikisid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[İzinGirisCikis]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[İzinGirisCikis](
	[İzingiriscikisid] [int] IDENTITY(1,1) NOT NULL,
	[İzinid] [int] NULL,
	[GirisTarihi] [varchar](50) NULL,
	[CikisTarihi] [varchar](50) NULL,
 CONSTRAINT [PK_İzinKontrol] PRIMARY KEY CLUSTERED 
(
	[İzingiriscikisid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[İzinler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[İzinler](
	[İzinid] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenciid] [int] NULL,
	[Personelid] [int] NULL,
	[AlinanTarih] [varchar](50) NULL,
	[BaslangicTarih] [varchar](50) NULL,
	[BitisTarih] [varchar](50) NULL,
	[İzinSebebi] [varchar](100) NULL,
	[Gidilenil] [varchar](20) NULL,
 CONSTRAINT [PK_Ogrenciİzin] PRIMARY KEY CLUSTERED 
(
	[İzinid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menuler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menuler](
	[Menuid] [int] IDENTITY(1,1) NOT NULL,
	[MenuTarih] [varchar](20) NULL,
	[YemekAd1] [varchar](20) NULL,
	[YemekAd2] [varchar](20) NULL,
	[YemekAd3] [varchar](20) NULL,
	[İcecekAd] [varchar](20) NULL,
	[TatliAd] [varchar](20) NULL,
	[MeyveAd] [varchar](20) NULL,
 CONSTRAINT [PK_Menuler] PRIMARY KEY CLUSTERED 
(
	[Menuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda_ozellik]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda_ozellik](
	[Oda_ozellikid] [int] IDENTITY(1,1) NOT NULL,
	[Odaid] [int] NOT NULL,
	[Ozellik] [varchar](30) NULL,
	[BaslangicTarih] [varchar](50) NULL,
	[BitisTarih] [varchar](50) NULL,
	[Durum] [varchar](20) NULL,
 CONSTRAINT [PK_Oda_ozellik] PRIMARY KEY CLUSTERED 
(
	[Oda_ozellikid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[Odaid] [int] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](5) NOT NULL,
	[OdaKapasite] [char](2) NULL,
	[OdaAktif] [char](2) NULL,
	[OdaKat] [char](2) NULL,
 CONSTRAINT [PK_Odalar] PRIMARY KEY CLUSTERED 
(
	[Odaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odemeler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odemeler](
	[Odemeid] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenciid] [int] NULL,
	[OdenmesiGereken] [varchar](50) NULL,
	[OdemeTarih] [varchar](20) NULL,
	[Odenen] [varchar](50) NULL,
 CONSTRAINT [PK_Odemeler] PRIMARY KEY CLUSTERED 
(
	[Odemeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[Ogrenciid] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAd] [varchar](50) NULL,
	[OgrenciSoyad] [varchar](50) NULL,
	[OdaGirisTarihi] [varchar](30) NULL,
	[OgrenciTc] [char](11) NULL,
	[OgrenciTel] [varchar](15) NULL,
	[Ogrenciil] [varchar](30) NULL,
	[OgrenciMail] [varchar](30) NULL,
	[OgrenciDogumTarihi] [varchar](30) NULL,
	[OgrenciBolum] [varchar](30) NULL,
	[OgrenciVeliAd] [varchar](30) NULL,
	[OgrenciVeliSoyad] [varchar](30) NULL,
	[OgrenciVeliTel1] [varchar](25) NULL,
	[OgrenciVeliTel2] [varchar](25) NULL,
	[OgrenciVeliAdres] [varchar](100) NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[Ogrenciid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler_Odalar]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler_Odalar](
	[Ogrenciler_Odalar_id] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenciid] [int] NULL,
	[Odaid] [int] NULL,
	[Durum] [varchar](10) NULL,
 CONSTRAINT [PK_Ogrenciler_Odalar] PRIMARY KEY CLUSTERED 
(
	[Ogrenciler_Odalar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel_Gorev]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel_Gorev](
	[Gorevid] [int] IDENTITY(1,1) NOT NULL,
	[Personeller_Odalar_id] [int] NULL,
	[Tarih] [varchar](30) NULL,
	[GorevDurum] [varchar](30) NULL,
 CONSTRAINT [PK_Personel_Gorev] PRIMARY KEY CLUSTERED 
(
	[Gorevid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[Personelid] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [varchar](30) NULL,
	[PersonelSoyad] [varchar](30) NULL,
	[PersonelTc] [char](11) NULL,
	[PersonelMail] [varchar](30) NULL,
	[Personelİl] [varchar](20) NULL,
	[PersonelMaas] [nchar](10) NULL,
	[PersonelTel] [varchar](15) NULL,
	[PersonelDogum] [varchar](30) NULL,
	[PersonelCinsiyet] [varchar](15) NULL,
	[İseGirisTarih] [varchar](30) NULL,
	[İstenCikisTarih] [varchar](30) NULL,
	[PersonelDurum] [varchar](100) NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[Personelid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller_Odalar]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller_Odalar](
	[Personeller_Odalar_id] [int] IDENTITY(1,1) NOT NULL,
	[Personelid] [int] NULL,
	[Odaid] [int] NULL,
 CONSTRAINT [PK_Personeller_Odalar] PRIMARY KEY CLUSTERED 
(
	[Personeller_Odalar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sikayetler]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sikayetler](
	[Sikayetid] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenciid] [int] NULL,
	[SikayetTur] [varchar](100) NULL,
	[Sikayet] [varchar](300) NULL,
	[SikayetTarih] [varchar](30) NULL,
	[SonDurum] [varchar](200) NULL,
	[CozumTarih] [varchar](30) NULL,
 CONSTRAINT [PK_Sikayetler] PRIMARY KEY CLUSTERED 
(
	[Sikayetid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 21.04.2022 12:14:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[Yoneticiid] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](30) NULL,
	[YoneticiSifre] [varchar](30) NULL,
 CONSTRAINT [PK_Yonetici] PRIMARY KEY CLUSTERED 
(
	[Yoneticiid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Duyurular] ON 

INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1064, N'3 Ağustos 2021 Salı', N'11 Ağustos 2021 Çarşamba', N'17 Ağustos 2021 Salı', N'18 Ağustos Çarşamba günü Voleybol sahasında turnuva düzenlenecektir.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1065, N'11 Ağustos 2021 Çarşamba', N'18 Ağustos 2021 Çarşamba', N'24 Ağustos 2021 Salı', N'Çamaşırhane yeni saatleri artık 07:00-22:00 olacaktır.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1066, N'24 Ağustos 2021 Salı', N'26 Ağustos 2021 Perşembe', N'29 Ağustos 2021 Pazar', N'29 Ağustos Pazar günü Ebruli Kursu 14:00 olacaktır.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1067, N'26 Ağustos 2021 Perşembe', N'28 Ağustos 2021 Cumartesi', N'30 Ağustos 2021 Pazartesi', N'30 Ağustos Pazartesi günü 15:00 da kutlama yapılacaktır.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1068, N'1 Eylül 2021 Çarşamba', N'2 Eylül 2021 Perşembe', N'5 Eylül 2021 Pazar', N'5 eylül 16:00 da Satranç Turnuvası Santranç odasında düzenlenecektir.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1069, N'7 Eylül 2021 Salı', N'10 Eylül 2021 Cuma', N'15 Eylül 2021 Çarşamba', N'15 eylül 14:00 da  Gitar  Kursu düzenlenecektir.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1070, N'15 Eylül 2021 Çarşamba', N'16 Eylül 2021 Perşembe', N'22 Eylül 2021 Çarşamba', N'22 eylül 14:00 da Basketbol Turnuvası düzenlenecektir.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1071, N'21 Eylül 2021 Salı', N'22 Eylül 2021 Çarşamba', N'26 Eylül 2021 Pazar', N'27 eylül 15:00 da  Futbol Turnuvası düzenlenecektir.')
INSERT [dbo].[Duyurular] ([Duyuruid], [DuyuruYayinlanmaTarihi], [DuyuruBaslangicTarih], [DuyuruBitisTarih], [DuyuruNot]) VALUES (1072, N'23 Eylül 2021 Perşembe', N'29 Eylül 2021 Çarşamba', N'2 Ekim 2021 Cumartesi', N'2 ekim 16:00 da  Keman Kursu düzenlenecektir.')
SET IDENTITY_INSERT [dbo].[Duyurular] OFF
GO
SET IDENTITY_INSERT [dbo].[Giderler] ON 

INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (17, N'25.01.2021', N'500', N'400', N'700', N'300', N'900', N'350', N'1000', N'2000')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (18, N'25.02.2021', N'500', N'800', N'180', N'540', N'200', N'360', N'7000', N'1800')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (19, N'25.03.2021', N'500', N'750', N'450', N'400', N'300', N'450', N'2000', N'250')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (20, N'25.04.2021', N'1000', N'500', N'400', N'350', N'750', N'300', N'2000', N'350')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (21, N'25.05.2021', N'1000', N'500', N'350', N'300', N'250', N'450', N'1000', N'350')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (22, N'25.06.2021', N'450', N'500', N'300', N'450', N'850', N'600', N'750', N'350')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (23, N'25.07.2021', N'1000', N'800', N'600', N'350', N'400', N'350', N'750', N'600')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (24, N'25.08.2021', N'750', N'400', N'850', N'500', N'800', N'500', N'800', N'300')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (25, N'25.09.2021', N'920', N'950', N'350', N'400', N'600', N'550', N'350', N'400')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (26, N'25.10.2021', N'1200', N'1000', N'550', N'450', N'875', N'550', N'1000', N'450')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (27, N'25.11.2021', N'800', N'800', N'500', N'350', N'875', N'555', N'800', N'300')
INSERT [dbo].[Giderler] ([Giderid], [Tarih], [MutfakMalzeme], [TemizlikMalzeme], [Tamirat], [Su], [Elektrik], [İnternet], [Personel], [Diger]) VALUES (28, N'25.12.2021', N'900', N'400', N'550', N'600', N'800', N'400', N'1500', N'190')
SET IDENTITY_INSERT [dbo].[Giderler] OFF
GO
SET IDENTITY_INSERT [dbo].[GirisCikis] ON 

INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (80, 1055, N'1.11.2021', N'17:55', N'18:30')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (81, 1055, N'1.11.2021', N'20:30', N'21:30')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (82, 1055, N'1.11.2021', N'23:30', N'21:45')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (83, 1056, N'1.11.2021', N'14:00', N'15:35')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (84, 1056, N'1.11.2021', N'19:55', N'20:45')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (85, 1056, N'1.11.2021', N'23:30', N'21:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (86, 1057, N'1.11.2021', N'14:35', N'14:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (87, 1057, N'1.11.2021', N'15:35', N'20:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (88, 1057, N'1.11.2021', N'20:55', N'21:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (89, 1057, N'1.11.2021', N'21:45', N'23:45')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (90, 1058, N'1.11.2021', N'00:35', N'15:50')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (93, 1058, N'1.11.2021', N'22:30', N'22:25')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (94, 1059, N'1.11.2021', N'00:45', N'08:30')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (95, 1059, N'1.11.2021', N'10:00', N'08:45')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (96, 1060, N'1.11.2021', N'19:35', N'18:35')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (98, 1060, N'1.11.2021', N'23:35', N'21:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (101, 1061, N'1.11.2021', N'15:00', N'09:00')
INSERT [dbo].[GirisCikis] ([giriscikisid], [Ogrenciid], [Tarih], [GirisTarih], [CikisTarih]) VALUES (102, 1061, N'1.11.2021', N'21:00', N'23:55')
SET IDENTITY_INSERT [dbo].[GirisCikis] OFF
GO
SET IDENTITY_INSERT [dbo].[İzinGirisCikis] ON 

INSERT [dbo].[İzinGirisCikis] ([İzingiriscikisid], [İzinid], [GirisTarihi], [CikisTarihi]) VALUES (1078, 2013, N'15.08.2021 23:15:56', N'12.08.2021 09:05:07')
INSERT [dbo].[İzinGirisCikis] ([İzingiriscikisid], [İzinid], [GirisTarihi], [CikisTarihi]) VALUES (1079, 2014, N'18.08.2021 22:06:00', N'14.08.2021 04:06:00')
INSERT [dbo].[İzinGirisCikis] ([İzingiriscikisid], [İzinid], [GirisTarihi], [CikisTarihi]) VALUES (1080, 2015, N'21.08.2021 22:30:37', N'16.08.2021 05:06:37')
INSERT [dbo].[İzinGirisCikis] ([İzingiriscikisid], [İzinid], [GirisTarihi], [CikisTarihi]) VALUES (1081, 2016, N'29.08.2021 04:07:30', N'25.11.2021 09:07:30')
SET IDENTITY_INSERT [dbo].[İzinGirisCikis] OFF
GO
SET IDENTITY_INSERT [dbo].[İzinler] ON 

INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2007, NULL, 1025, N'1.08.2021', N'2.09.2021', N'5.09.2021', N'Seyehat', N' Çorum')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2008, NULL, 1026, N'5.08.2021', N'10.08.2021', N'14.08.2021', N'Seyehat', N' Gaziantep')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2009, NULL, 1027, N'8.10.2021', N'10.10.2021', N'15.10.2021', N'Hastalık', N'')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2010, NULL, 1028, N'7.10.2021', N'10.10.2021', N'12.10.2021', N'Hastalık', N'')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2011, NULL, 1029, N'15.10.2021', N'16.10.2021', N'20.10.2021', N'Hastalık', N'')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2012, NULL, 1030, N'7.10.2021', N'8.10.2021', N'15.10.2021', N'Seyehat', N' Çankırı')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2013, 1055, NULL, N'10.08.2021', N'12.08.2021 06:00 ', N'15.08.2021 23:00 ', N'Seyehat', N' Bilecik')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2014, 1056, NULL, N'01.08.2021', N'15.08.2021 06:00 ', N'18.08.2021 23:00 ', N'Seyehat', N' Sivas')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2015, 1057, NULL, N'15.08.2021', N'16.08.2021 06:00 ', N'21.08.2021 23:00 ', N'Seyehat', N' Iğdır')
INSERT [dbo].[İzinler] ([İzinid], [Ogrenciid], [Personelid], [AlinanTarih], [BaslangicTarih], [BitisTarih], [İzinSebebi], [Gidilenil]) VALUES (2016, 1058, NULL, N'20.08.2021', N'25.08.2021 06:00 ', N'28.08.2021 23:00 ', N'Seyehat', N' Çorum')
SET IDENTITY_INSERT [dbo].[İzinler] OFF
GO
SET IDENTITY_INSERT [dbo].[Menuler] ON 

INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (26, N'05.07.2021', N'Mercimek Çorba', N'Dolma', N'Pilav', N'Ayran', N'Triliçe', N'Elma')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (27, N'06.07.2021', N'Yoğurt Çorba', N'Sulu Patates', N'Pilav', N'Ayran', N'Islak Kek', N'Mandalina')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (28, N'07.07.2021', N'Ezogelin Çorba', N'Taze Fasulye', N'Pirinç Pilav', N'Kola', N'Puding', N'Elma')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (29, N'08.07.2021', N'Yayla Çorba', N'Etli Pide', N'Tavuk Sote', N'Ayran', N'Şekerpare', N'Portakal')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (30, N'09.07.2021', N'Kuru Fasulye', N'Pilav', N'Tavuk Kızartma', N'Soda', N'Tiramisu', N'Havuç')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (31, N'10.07.2021', N'Zeytinyağlı Pırasa', N'Orban Kebabı', N'Antep Ezme', N'Kola', N'Kemalpaşa Tatlısı', N'Mandalina')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (32, N'11.07.2021', N'Barbunya', N'Bulgur Pilavı', N'Mevsim Salata', N'Ayran', N'Revani', N'Kivi')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (33, N'12.07.2021', N'Mercimek Çorba', N'Lahana Sarma', N'Mevsim Salata', N'Soda', N'Kremalı Pasta', N'Greyfurt')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (34, N'13.07.2021', N'Patatesli Nuget', N'Pirinç Pilavı', N'Çoban Salata', N'Ayran', N'Çilekli Turta', N'Portakal')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (35, N'14.07.2021', N'Mercimek Çorba', N'Yoğurtlu Karnabahar', N'Tavuk Haşlama', N'Kola', N'Künefe', N'Kivi')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (36, N'15.07.2021', N'Yoğurt Çorba', N'Kuru Fasulye', N'Domatesli Pilav', N'Meyvesuyu', N'Turta', N'Mandalina')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (37, N'16.07.2021', N'Taze Fasulye', N'Domatesli Pilav', N'Mkarna Salatası', N'Ayran', N'Puding', N'Elma')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (38, N'17.07.2021', N'Yayla Çorba', N'Türlü', N'Soslu Makarna', N'Ayran', N'Triliçe', N'Elma')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (39, N'18.07.2021', N'Kızartma Tavuk', N'Pirinç Pilav', N'Havuç Tarator', N'Kola', N'Supangle', N'Mandalina')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (40, N'19.07.2021', N'Mercimek Çorba', N'Et Sote', N'Pilav', N'Kola', N'Revani', N'Kivi')
INSERT [dbo].[Menuler] ([Menuid], [MenuTarih], [YemekAd1], [YemekAd2], [YemekAd3], [İcecekAd], [TatliAd], [MeyveAd]) VALUES (41, N'20.07.2021', N'Ezogelin Çorba', N'Lahmacun', N'Mevsim Salata', N'Ayran', N'Şekerpare', N'Elma')
SET IDENTITY_INSERT [dbo].[Menuler] OFF
GO
SET IDENTITY_INSERT [dbo].[Oda_ozellik] ON 

INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (27, 1024, N'Tv', N'15.10.2020', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (28, 1024, N'Balkon', N'15.08.2020', N'15.09.2021', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (29, 1024, N'Banyo', N'09.10.2020', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (30, 1024, N'Çalışma Masası', N'15.08.2020', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (31, 1024, N'Kitaplık', N'15.09.2020', N'15.11.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (32, 1025, N'Tv', N'10.06.2021', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (33, 1025, N'Banyo', N'15.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (34, 1025, N'Ayna', N'10.10.2019', N'16.10.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (35, 1026, N'Tv', N'10.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (36, 1026, N'Kitaplık', N'10.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (37, 1026, N'Çalışma Masası', N'15.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (38, 1026, N'Balkon', N'10.08.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (39, 1027, N'Tv', N'10.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (40, 1027, N'Banyo', N'08.08.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (41, 1027, N'Ayna', N'05.07.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (42, 1027, N'Balkon', N'10.07.2019', N'15.07.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (43, 1028, N'Tv', N'15.10.2019', N'15.10.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (44, 1028, N'Banyo', N'10.08.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (45, 1029, N'Çalışma Masası', N'15.10.2018', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (46, 1029, N'Tv', N'10.09.2018', N'11.09.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (47, 1030, N'Tv', N'10.10.2018', N'10.10.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (48, 1030, N'Balkon', N'15.10.2018', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (49, 1031, N'Tv', N'10.10.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (50, 1031, N'Banyo', N'05.08.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (51, 1031, N'Ayna', N'03.04.2018', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (52, 1032, N'Tv', N'17.04.2017', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (53, 1032, N'Balkon', N'15.10.2017', N'16.10.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (54, 1033, N'Tv', N'06.08.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (55, 1033, N'Çalışma Masası', N'15.06.2019', N'  .  .', N'AKTİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (56, 1034, N'Tv', N'11.12.2019', N'12.06.2020', N'PASİF')
INSERT [dbo].[Oda_ozellik] ([Oda_ozellikid], [Odaid], [Ozellik], [BaslangicTarih], [BitisTarih], [Durum]) VALUES (57, 1044, N'Tv', N'20.10.2021', N'25.10.2021', N'PASİF')
SET IDENTITY_INSERT [dbo].[Oda_ozellik] OFF
GO
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1024, N'100  ', N'3 ', N'2 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1025, N'101  ', N'3 ', N'1 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1026, N'102  ', N'3 ', N'0 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1027, N'103  ', N'3 ', N'0 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1028, N'104  ', N'3 ', N'1 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1029, N'105  ', N'3 ', N'0 ', N'1 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1030, N'200  ', N'4 ', N'0 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1031, N'201  ', N'4 ', N'0 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1032, N'202  ', N'4 ', N'3 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1033, N'203  ', N'4 ', N'0 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1034, N'204  ', N'4 ', N'0 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1035, N'205  ', N'4 ', N'0 ', N'2 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1036, N'300  ', N'5 ', N'0 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1037, N'301  ', N'5 ', N'0 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1038, N'302  ', N'5 ', N'2 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1039, N'303  ', N'5 ', N'1 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1040, N'304  ', N'5 ', N'2 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1041, N'305  ', N'5 ', N'1 ', N'3 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1042, N'400  ', N'6 ', N'1 ', N'4 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1043, N'401  ', N'6 ', N'1 ', N'4 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1044, N'402  ', N'6 ', N'2 ', N'4 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1045, N'403  ', N'6 ', N'2 ', N'4 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1046, N'404  ', N'6 ', N'2 ', N'4 ')
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaKat]) VALUES (1047, N'405  ', N'6 ', N'1 ', N'4 ')
SET IDENTITY_INSERT [dbo].[Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Odemeler] ON 

INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1040, 1055, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1041, 1056, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1042, 1057, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1043, 1058, N'450', N'1.09.2021', N'450')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1044, 1059, N'550', N'1.09.2021', N'550')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1045, 1060, N'400', N'1.09.2021', N'400')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1046, 1061, N'400', N'1.09.2021', N'400')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1047, 1062, N'550', N'1.09.2021', N'550')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1048, 1063, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1049, 1064, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1050, 1065, N'600', N'1.09.2021', N'600')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1051, 1066, N'650', N'1.09.2021', N'650')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1052, 1067, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1053, 1068, N'450', N'1.09.2021', N'450')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1054, 1069, N'350', N'1.09.2021', N'350')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1055, 1070, N'650', N'1.09.2021', N'650')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1056, 1071, N'400', N'1.09.2021', N'400')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1057, 1072, N'350', N'1.09.2021', N'350')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1058, 1073, N'450', N'1.09.2021', N'450')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1059, 1074, N'500', N'1.09.2021', N'500')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1060, 1075, N'450', N'1.09.2021', N'450')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1061, 1076, N'450', N'1.09.2021', N'450')
INSERT [dbo].[Odemeler] ([Odemeid], [Ogrenciid], [OdenmesiGereken], [OdemeTarih], [Odenen]) VALUES (1062, 1077, N'550', N'1.09.2021', N'550')
SET IDENTITY_INSERT [dbo].[Odemeler] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 

INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1055, N'Rabia', N'Korkmaz', N'2.09.2021', N'43830211210', N'(543) 240-1418', N' Mersin', N'rabiakorkmaz02@gmail.com', N'05.04.2002', N'Psikoloji', N'Ayhan', N'Korkmaz', N'(545) 204-7342', N'(535) 302-4290', N'Mersin Alamur')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1056, N'Sevim', N'Aksaç', N'12.09.2021', N'11080588141', N'(506) 182-4554', N' Amasya', N'sevimaksac133@gmail.com', N'16.11.2003', N'Paramedik', N'Osman', N'Aksaç', N'(542) 216-4510', N'(532) 333-7556', N'Amasya Merkez Cumhuriyet Mahallesi')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1057, N'Tuba', N'Taşdemir', N'12.09.2021', N'10120621788', N'(552) 363-5799', N' Ağrı', N'tubatasdemir133@gmail.com', N'27.03.2001', N'Hemşirelik', N'Abdurrahman', N'Taşdemir', N'(552) 663-1275', N'(507) 603-2014', N'Cumhuriyet Mahallesi 1655.sokak No:26 Patnos/Ağrı')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1058, N'Deniz', N'Yıldırım', N'12.09.2021', N'12230268211', N'(542) 302-8872', N' Adana', N'denziyıildirim@gmail.com', N'27.06.2003', N'Fen Bilgisi Öğretmenliği', N'Ahmet', N'Yıldırım', N'(542) 492-1182', N'(053) 230-2403', N'Çukurova/ Adana')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1059, N'Şule', N'Toğrulca', N'12.09.2021', N'60212408612', N'(531) 602-8867', N' Mardin', N'suletogrulca01@gmail.com', N'11.10.1999', N'Eczacılık', N'Ramazan', N'Toğrulca', N'(552) 924-0785', N'(551) 302-1237', N'Midyat/Mardin')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1060, N'Ceren', N'Akyol', N'12.09.2021', N'78956312213', N'(546) 786-1253', N' Ankara', N'cerenakyol06@gmail.com', N'12.10.1998', N'Tarih', N'Mustafa', N'Akyol', N'(539) 319-1206', N'(539) 412-1544', N'Kızılay/Ankara')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1061, N'Merve', N'Bulak', N'12.09.2021', N'78302456879', N'(536) 302-7895', N' Elazığ', N'mervebulak@gmail.com', N'14.06.1996', N'Matematik', N'Mehmet', N'Bulak', N'(534) 587-9678', N'(541) 509-8645', N'Harput/Elazığ')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1062, N'Canan ', N'Kara', N'22.10.2021', N'49516165516', N'(554) 582-5964', N' Şanlıurfa', N'cnnkaram@gmail.com', N'16.05.2004', N'Resim Öğretmenliği', N'Ahmet ', N'Kara', N'(554) 621-6132', N'(554) 652-6256', N'Bağlarbaşı Mahallesi 6669.sokak no:31 Merkez
')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1063, N'Derya ', N'Hiltak', N'31.10.2021', N'55787989464', N'(553) 838-7311', N' Adana', N'Deryahiltak@gmail.com', N'11.04.2003', N'Resim Öğretmenliği', N'Ayşe', N'Hiltak', N'(551) 452-3303', N'(554) 812-1552', N'Adana Kiremithane 3214. Sokak no:29')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1064, N'Cemile', N'Ataman', N'15.09.2021', N'51248796305', N'(544) 212-7444', N' Malatya', N'cemileataman44@gmail.com', N'01.05.2001', N'Bilgisayar Mühendisliği', N'Özcan', N'Ataman', N'(546) 257-8997', N'(545) 896-3574', N'Ulutaş Mahallesi/Doğanyol/ Malatya')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1065, N'Lütfiye', N'Yıldız', N'14.09.2021', N'66428364578', N'(546) 879-2541', N'Artvin', N'lütfiyeyıldız@gmail.com', N'12.04.1998', N'Fizik', N'Azat', N'Yıldız', N'(548) 245-7836', N'(547) 635-4872', N'Gölbaşı/Artvin')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1066, N'Selda', N'Sarıçam', N'20.09.2021', N'12457863545', N'(543) 251-4678', N' İstanbul', N'seldesaricam@gmail.com', N'05.07.1990', N'Makine Mühendisliği', N'Berk', N'Sariçam', N'(542) 645-2976', N'(053) 596-4278', N'Kadıköy/İstanbul')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1067, N'Elifnur', N'Gülfida', N'12.09.2021', N'24533266633', N'(535) 963-2575', N'Artvin', N'elfgulfida@gmail.com', N'05.06.2000', N'Veterinerlik', N'Cengiz', N'Gülfida', N'(532) 425-5679', N'(535) 557-9685', N'Hopa/Artvin')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1068, N'Hayriye', N'Bal', N'12.09.2021', N'1326932244 ', N'(535) 624-8596', N' Hatay', N'hayriyebal@gmail.com', N'02.07.1995', N'Radyo Televizyon', N'Kahraman', N'Bal', N'(545) 669-3265', N'(553) 635-4896', N'Altınözü/Hatay')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1069, N'Elif', N'Akgün', N'12.09.2021', N'23562699663', N'(555) 636-9864', N' Adıyaman', N'elifakg@gmail.com', N'05.07.2000', N'Bilgisayar Mühendisliği', N'Süleyman', N'Akgün', N'(556) 323-6945', N'(535) 626-3548', N'Nemrut/Adıyaman')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1070, N'Çiçek', N'Kar', N'31.10.2021', N'23662356642', N'(532) 566-9322', N' Eskişehir', N'cicekkar@gmail.com', N'03.01.1995', N'Makine Mühendisliği', N'Emre', N'Kar', N'(552) 356-9622', N'(552) 569-8785', N'Eskişehir')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1071, N'Berivan', N'Solmaz', N'12.09.2021', N'23226335663', N'(552) 362-3562', N' Ardahan', N'berivansolmaz@gmail.com', N'02.09.1997', N'Veterinerlik', N'Yunus', N'Solmaz', N'(555) 636-8974', N'(553) 869-5641', N'Ardahan')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1072, N'Beril', N'Kurt', N'31.10.2021', N'52311248525', N'(555) 366-9662', N' Niğde', N'berilkurt@gmail.com', N'04.08.2002', N'Diş Hekimliği', N'Hakkı', N'Kurt', N'(553) 698-6457', N'(535) 678-8964', N'Niğde')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1073, N'Seda', N'Göktürk', N'31.10.2021', N'52633245896', N'(566) 322-4589', N' Edirne', N'sedagokturk@gmail.com', N'05.06.2001', N'Hemşirelik', N'Süleyman', N'Göktürk', N'(555) 369-6485', N'(554) 668-9578', N'Edirne Karakapı')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1074, N'Ayşe', N'Özen', N'12.09.2021', N'52363245896', N'(553) 632-4856', N' Aksaray', N'ayseozen@gmail.com', N'08.08.2000', N'Matematik Öğretmenliği', N'Yusuf', N'Özen', N'(553) 263-2563', N'(533) 263-3756', N'Sivrice')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1075, N'Aslı', N'Helin', N'12.09.2021', N'26325631242', N'(236) 244-2663', N' Ardahan', N'aysehelin@gmail.com', N'05.06.2000', N'Maliye', N'Abdulkadir', N'Helin', N'(533) 632-2459', N'(555) 339-6321', N'ardahan')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1076, N'Azra', N'Pelin', N'12.09.2021', N'22365321545', N'(553) 236-3964', N' Aksaray', N'aysepelin@gmail.com', N'01.02.1990', N'Hukuk', N'Ceyhun', N'Pelin', N'(553) 623-2333', N'(532) 266-893', N'aksaray')
INSERT [dbo].[Ogrenciler] ([Ogrenciid], [OgrenciAd], [OgrenciSoyad], [OdaGirisTarihi], [OgrenciTc], [OgrenciTel], [Ogrenciil], [OgrenciMail], [OgrenciDogumTarihi], [OgrenciBolum], [OgrenciVeliAd], [OgrenciVeliSoyad], [OgrenciVeliTel1], [OgrenciVeliTel2], [OgrenciVeliAdres]) VALUES (1077, N'HicraN', N'Demet', N'12.09.2021', N'42536278696', N'(555) 964-5782', N' Ardahan', N'hicrandemet@gmail.com', N'15.03.1990', N'Konservatuar', N'Sercan', N'Demet', N'(555) 368-9452', N'(553) 958-6647', N'Ardahan')
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler_Odalar] ON 

INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1062, 1055, 1047, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1063, 1056, 1046, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1064, 1057, 1045, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1065, 1058, 1024, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1066, 1059, 1024, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1067, 1060, 1025, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1068, 1061, 1028, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1069, 1062, 1032, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1070, 1063, 1038, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1071, 1064, 1039, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1072, 1065, 1032, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1073, 1066, 1032, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1074, 1067, 1040, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1075, 1068, 1044, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1076, 1069, 1043, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1077, 1070, 1044, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1078, 1071, 1042, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1079, 1072, 1041, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1080, 1073, 1045, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1081, 1074, 1046, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1082, 1075, 1040, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1083, 1076, 1038, NULL)
INSERT [dbo].[Ogrenciler_Odalar] ([Ogrenciler_Odalar_id], [Ogrenciid], [Odaid], [Durum]) VALUES (1084, 1077, 1034, NULL)
SET IDENTITY_INSERT [dbo].[Ogrenciler_Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel_Gorev] ON 

INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1068, 1068, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1069, 1069, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1070, 1070, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1071, 1071, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1072, 1072, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1073, 1073, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1074, 1074, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1075, 1075, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1076, 1076, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1077, 1077, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1078, 1078, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1079, 1079, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1080, 1080, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1081, 1081, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1082, 1082, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1083, 1083, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1084, 1084, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1085, 1085, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1086, 1086, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1087, 1087, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1088, 1088, N'1.09.2021', N'TAMAMLANDI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1089, 1089, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1090, 1090, N'1.09.2021', N'TAMAMLANMADI')
INSERT [dbo].[Personel_Gorev] ([Gorevid], [Personeller_Odalar_id], [Tarih], [GorevDurum]) VALUES (1091, 1091, N'1.09.2021', N'TAMAMLANDI')
SET IDENTITY_INSERT [dbo].[Personel_Gorev] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1025, N'Sibel', N'Dalkıran', N'74523694257', N'sibeldalkiran@gmail.com', N' Balıkesir', N'3750      ', N'05378963245', N'15.06.1993', N'Kadın', N'12.03.2019', N'12.03.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1026, N'Kadriye', N'Güler', N'10853687752', N'kadriyeguler@gmail.com', N' Bolu', N'4000      ', N'05558227456', N'27.08.1991', N'Kadın', N'25.07.2019', N'25.07.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1027, N'Fatma', N'Güleç', N'20364895786', N'fatmagulec@gmail.com', N' Bursa', N'2500      ', N'05537859624', N'01.09.1885', N'Kadın', N'13.05.2019', N'13.05.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1028, N'Hacer', N'Öz', N'14685235478', N'haceroz@gmail.com', N' Düzce', N'4250      ', N'05354438512', N'06.03.1987', N'Kadın', N'1.07.2021', N'1.07.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1029, N'Ahsen', N'Kaya', N'10578962475', N'ahsenkaya@gmail.com', N' Manisa', N'2100      ', N'053248596378', N'01.09.1993', N'Kadın', N'1.03.2018', N'1.03.2018', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1030, N'Medine', N'Su', N'15267485234', N'medinesu05@gmail.com', N' Trabzon', N'4300      ', N'05385247893', N'01.02.1989', N'Kadın', N'1.12.2018', N'1.12.2018', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1031, N'Zilan', N'Yıldız', N'14256385497', N'zilanyıldiz@gmail.com', N' Bilecik', N'5000      ', N'05537862514', N'05.08.1989', N'Kadın', N'4.08.2020', N'4.08.2020', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1032, N'Selin', N'Aksen', N'10245893145', N'selinaksen@gmail.com', N' Çankırı', N'4200      ', N'05362458932', N'07.06.1992', N'Kadın', N'12.01.2021', N'12.01.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1033, N'Zümrüt', N'Yakut', N'42158065504', N'zumrutyakut@gmail.com', N' Van', N'3000      ', N'05331852678', N'01.05.1991', N'Kadın', N'15.10.2019', N'15.10.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1034, N'Songül', N'Bayram', N'12596348579', N'songulbayram@gmail.com', N' Rize', N'3500      ', N'05368524697', N'01.07.1995', N'Kadın', N'18.09.2020', N'18.09.2020', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1035, N'Güneş', N'Yalın', N'24563295486', N'gunesyalin@gmail.com', N' Tokat', N'4700      ', N'05318549647', N'18.06.1983', N'Kadın', N'28.08.2021', N'28.08.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1036, N'Duru', N'Nesir', N'85496342578', N'durunesir@gmail.com', N' Nevşehir', N'4200      ', N'05521895426', N'01.07.1992', N'Kadın', N'31.10.2017', N'31.10.2017', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1037, N'Manolya', N'Kuş', N'85496324578', N'manolyakus@gmail.com', N' Mersin', N'5000      ', N'05364128547', N'22.03.1988', N'Kadın', N'31.07.2018', N'31.07.2018', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1038, N'Arife', N'Ayçiçek', N'28456395247', N'arifeaycicek@gmail.com', N' Samsun', N'2100      ', N'05348569662', N'22.10.1993', N'Kadın', N'15.10.2019', N'15.10.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1039, N'Ayten', N'İlkay', N'74536215279', N'aytenilkay@gmail.com', N' Sivas', N'4300      ', N'05384251725', N'27.08.1972', N'Kadın', N'15.06.2021', N'15.06.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1040, N'Hülya', N'Bozçam', N'5843692175 ', N'hulyabozcam@gmail.com', N' Muş', N'4250      ', N'05354124189', N'22.03.1975', N'Kadın', N'18.10.2019', N'18.10.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1041, N'Aysel', N'Gümüş', N'45736059621', N'ayselgumus@gmail.com', N' Sivas', N'4300      ', N'05386521475', N'28.08.1978', N'Kadın', N'25.08.2021', N'25.08.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1042, N'Leyla', N'Özden', N'56298432165', N'leylaozden@gmail.com', N' Kütahya', N'4200      ', N'05326518954', N'18.07.1980', N'Kadın', N'25.08.2021', N'25.08.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1043, N'İlknur', N'Aydın', N'32945278614', N'ilknuraydin@gmail.com', N' Muğla', N'2500      ', N'05457896214', N'02.09.1979', N'Kadın', N'31.07.2021', N'31.07.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1044, N'Gülsüm', N'Korkmaz', N'43296485219', N'gulsumkorkmaz@gmail.com', N' Manisa', N'2100      ', N'05337412515', N'23.06.1982', N'Kadın', N'18.10.2021', N'18.10.2020', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1045, N'İrem', N'Dağcı', N'74325618450', N'iremdagci@gmail.com', N' Tekirdağ', N'4250      ', N'05351962378', N'07.07.1985', N'Kadın', N'31.10.2021', N'31.10.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1046, N'Gamze', N'Dural', N'30625849612', N'gamzedural@gmail.com', N' Hatay', N'3750      ', N'05356624475', N'17.07.1977', N'Kadın', N'7.07.2019', N'7.07.2019', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1047, N'Latife', N'Özçelik', N'51502519645', N'gamzeozcelik@gmail.com', N' Ordu', N'4000      ', N'05354421583', N'01.04.1992', N'Kadın', N'31.10.2021', N'31.10.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1048, N'Asya', N'Yaşar', N'75124595128', N'asyayasar@gmail.com', N' Gümüşhane', N'4300      ', N'05381692415', N'10.10.1980', N'Kadın', N'31.10.2021', N'31.10.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1049, N'Necran', N'Geçer', N'84502160475', N'necrangecer@gmail.com', N' Malatya', N'4250      ', N'05327455491', N'15.10.1975', N'Kadın', N'31.10.2021', N'31.10.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1050, N'Merve', N'Tümkaya', N'10784623791', N'mervetumkaya@gmail.com', N' Adana', N'2700      ', N'05552123514', N'15.07.1970', N'Kadın', N'14.06.2017', N'14.06.2017', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1051, N'Aslı', N'Sevim', N'85324696752', N'aslisevim@gmail.com', N' Ankara', N'3500      ', N'75248963248', N'04.07.1995', N'Kadın', N'11.08.2020', N'11.08.2021', N'AKTİF')
INSERT [dbo].[Personeller] ([Personelid], [PersonelAd], [PersonelSoyad], [PersonelTc], [PersonelMail], [Personelİl], [PersonelMaas], [PersonelTel], [PersonelDogum], [PersonelCinsiyet], [İseGirisTarih], [İstenCikisTarih], [PersonelDurum]) VALUES (1052, N'Sedef', N'Parlak', N'2531245689 ', N'sedefparlak@gmail.com', N' Kütahya', N'4500      ', N'05353652489', N'09.08.1991', N'Kadın', N'16.03.2020', N'16.03.2021', N'AKTİF')
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller_Odalar] ON 

INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1068, 1025, 1024)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1069, 1025, 1025)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1070, 1026, 1026)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1071, 1026, 1027)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1072, 1027, 1028)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1073, 1028, 1029)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1074, 1029, 1030)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1075, 1030, 1031)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1076, 1031, 1032)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1077, 1032, 1033)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1078, 1033, 1034)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1079, 1034, 1035)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1080, 1035, 1036)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1081, 1036, 1037)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1082, 1037, 1038)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1083, 1038, 1039)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1084, 1039, 1040)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1085, 1040, 1041)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1086, 1041, 1042)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1087, 1042, 1043)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1088, 1043, 1044)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1089, 1044, 1045)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1090, 1045, 1046)
INSERT [dbo].[Personeller_Odalar] ([Personeller_Odalar_id], [Personelid], [Odaid]) VALUES (1091, 1046, 1047)
SET IDENTITY_INSERT [dbo].[Personeller_Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Sikayetler] ON 

INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (6, NULL, N'arıza', N'aaaaaa', N'19.08.2021', N'gfedvf', N'')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (8, NULL, N'arıza', N'bbbbbbbbb', N'19.08.2021', N'gfedvf', N'')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (9, NULL, N'arıza', N'cccc', N'19.08.2021', N'gfedvf', N'')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (10, NULL, N'jhgf', N'jhgfd', N'11.08.2021', N'gfds', N'ygtres')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (57, 1066, N'ARIZA', N'Musluk Arızalanmış', N'1.09.2021', N'ÇÖZÜLDÜ', N'03.09.2021')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (58, 1071, N'ARIZA', N'Yatak Baza Arızalanmış', N'3.09.2021', N'ÇÖZÜLDÜ', N'05.09.2021')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (59, 1060, N'SES', N'Yan Oda Sürekli ses yapıyor.', N'10.09.2021', N'ÇÖZÜLDÜ', N'12.09.2021')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (60, 1073, N'ARIZA', N'Ayakkabılık Arızalanmış', N'20.09.2021', N'ÇÖZÜLDÜ', N'25.09.2021')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (61, 1075, N'YEMEK', N'Yemek çeşitleri az.', N'12.09.2021', N'', N'')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (63, 1065, N'ÇAMAŞIRHANE', N'Çamaşır Makinesi sayısı yetersiz', N'26.09.2021', N'', N'')
INSERT [dbo].[Sikayetler] ([Sikayetid], [Ogrenciid], [SikayetTur], [Sikayet], [SikayetTarih], [SonDurum], [CozumTarih]) VALUES (64, 1062, N'YEMEK', N'Yemekler tuzsuz.', N'22.09.2021', N'ÇÖZÜLDÜ', N'23.09.2021')
SET IDENTITY_INSERT [dbo].[Sikayetler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yonetici] ON 

INSERT [dbo].[Yonetici] ([Yoneticiid], [YoneticiAd], [YoneticiSifre]) VALUES (1, N'Admin', N'123')
INSERT [dbo].[Yonetici] ([Yoneticiid], [YoneticiAd], [YoneticiSifre]) VALUES (2, N'Admin2', N'456')
SET IDENTITY_INSERT [dbo].[Yonetici] OFF
GO
ALTER TABLE [dbo].[İzinler] ADD  CONSTRAINT [DF_İzinler_BaslangicTarih]  DEFAULT ('06:00') FOR [BaslangicTarih]
GO
ALTER TABLE [dbo].[İzinler] ADD  CONSTRAINT [DF_İzinler_BitisTarih]  DEFAULT ('23:00') FOR [BitisTarih]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaKapasite]  DEFAULT ((0)) FOR [OdaKapasite]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaAktif]  DEFAULT ((0)) FOR [OdaAktif]
GO
ALTER TABLE [dbo].[Odemeler] ADD  CONSTRAINT [DF_Odemeler_OgrenciBorc]  DEFAULT ((4080)) FOR [Odenen]
GO
ALTER TABLE [dbo].[İzinGirisCikis]  WITH CHECK ADD  CONSTRAINT [FK_İzinGirisCikis_İzinler1] FOREIGN KEY([İzinid])
REFERENCES [dbo].[İzinler] ([İzinid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[İzinGirisCikis] CHECK CONSTRAINT [FK_İzinGirisCikis_İzinler1]
GO
ALTER TABLE [dbo].[Oda_ozellik]  WITH CHECK ADD  CONSTRAINT [FK_Oda_ozellik_Odalar] FOREIGN KEY([Odaid])
REFERENCES [dbo].[Odalar] ([Odaid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oda_ozellik] CHECK CONSTRAINT [FK_Oda_ozellik_Odalar]
GO
ALTER TABLE [dbo].[Odemeler]  WITH CHECK ADD  CONSTRAINT [FK_Odemeler_Ogrenciler] FOREIGN KEY([Ogrenciid])
REFERENCES [dbo].[Ogrenciler] ([Ogrenciid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Odemeler] CHECK CONSTRAINT [FK_Odemeler_Ogrenciler]
GO
ALTER TABLE [dbo].[Ogrenciler_Odalar]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenciler_Odalar_Odalar] FOREIGN KEY([Odaid])
REFERENCES [dbo].[Odalar] ([Odaid])
GO
ALTER TABLE [dbo].[Ogrenciler_Odalar] CHECK CONSTRAINT [FK_Ogrenciler_Odalar_Odalar]
GO
ALTER TABLE [dbo].[Personel_Gorev]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Gorev_Personeller_Odalar1] FOREIGN KEY([Personeller_Odalar_id])
REFERENCES [dbo].[Personeller_Odalar] ([Personeller_Odalar_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personel_Gorev] CHECK CONSTRAINT [FK_Personel_Gorev_Personeller_Odalar1]
GO
ALTER TABLE [dbo].[Personeller_Odalar]  WITH CHECK ADD  CONSTRAINT [FK_Personeller_Odalar_Odalar] FOREIGN KEY([Odaid])
REFERENCES [dbo].[Odalar] ([Odaid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personeller_Odalar] CHECK CONSTRAINT [FK_Personeller_Odalar_Odalar]
GO
ALTER TABLE [dbo].[Personeller_Odalar]  WITH CHECK ADD  CONSTRAINT [FK_Personeller_Odalar_Personeller] FOREIGN KEY([Personelid])
REFERENCES [dbo].[Personeller] ([Personelid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personeller_Odalar] CHECK CONSTRAINT [FK_Personeller_Odalar_Personeller]
GO
ALTER TABLE [dbo].[Sikayetler]  WITH CHECK ADD  CONSTRAINT [FK_Sikayetler_Ogrenciler] FOREIGN KEY([Ogrenciid])
REFERENCES [dbo].[Ogrenciler] ([Ogrenciid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sikayetler] CHECK CONSTRAINT [FK_Sikayetler_Ogrenciler]
GO
USE [master]
GO
ALTER DATABASE [YurtKayitTakipSistemi] SET  READ_WRITE 
GO
