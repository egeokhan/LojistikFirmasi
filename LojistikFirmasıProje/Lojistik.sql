USE [master]
GO
/****** Object:  Database [Lojistik]    Script Date: 30.05.2022 14:57:50 ******/
CREATE DATABASE [Lojistik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lojistik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Lojistik.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lojistik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Lojistik_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lojistik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lojistik] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lojistik] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lojistik] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lojistik] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lojistik] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lojistik] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lojistik] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lojistik] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lojistik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lojistik] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lojistik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lojistik] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lojistik] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lojistik] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lojistik] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lojistik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lojistik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lojistik] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lojistik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lojistik] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lojistik] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lojistik] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lojistik] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lojistik] SET  MULTI_USER 
GO
ALTER DATABASE [Lojistik] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lojistik] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lojistik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lojistik] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lojistik] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Lojistik]
GO
/****** Object:  Table [dbo].[GelirGider]    Script Date: 30.05.2022 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GelirGider](
	[GelirGiderId] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [nvarchar](50) NULL,
	[GelirGider] [int] NULL,
	[Tarih] [date] NULL,
	[Miktar] [money] NULL,
 CONSTRAINT [PK_GelirGider] PRIMARY KEY CLUSTERED 
(
	[GelirGiderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giris]    Script Date: 30.05.2022 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giris](
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gorusmeler]    Script Date: 30.05.2022 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gorusmeler](
	[GorusmeId] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [nchar](10) NULL,
	[Tarih] [nchar](10) NULL,
	[Konu] [nchar](10) NULL,
	[Onem] [int] NULL,
 CONSTRAINT [PK_Gorusmeler] PRIMARY KEY CLUSTERED 
(
	[GorusmeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seferler]    Script Date: 30.05.2022 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seferler](
	[SeferId] [int] IDENTITY(1,1) NOT NULL,
	[Yer] [nvarchar](50) NULL,
	[Kategori] [nvarchar](50) NULL,
	[Tarih] [date] NULL,
	[Sofor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Seferler] PRIMARY KEY CLUSTERED 
(
	[SeferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 30.05.2022 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](50) NULL,
	[Departman] [nvarchar](50) NULL,
	[Iletisim] [nvarchar](50) NULL,
	[Maas] [money] NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GelirGider] ON 
GO
INSERT [dbo].[GelirGider] ([GelirGiderId], [Tur], [GelirGider], [Tarih], [Miktar]) VALUES (1, N'Toplu Maaş', 1, CAST(N'2022-05-09' AS Date), 2123.1700)
GO
INSERT [dbo].[GelirGider] ([GelirGiderId], [Tur], [GelirGider], [Tarih], [Miktar]) VALUES (7, N'Deneme', 0, CAST(N'2022-05-30' AS Date), 100.0000)
GO
SET IDENTITY_INSERT [dbo].[GelirGider] OFF
GO
INSERT [dbo].[Giris] ([KullaniciAdi], [Sifre]) VALUES (N'ege', N'123')
GO
INSERT [dbo].[Giris] ([KullaniciAdi], [Sifre]) VALUES (N'admin', N'12345')
GO
SET IDENTITY_INSERT [dbo].[Gorusmeler] ON 
GO
INSERT [dbo].[Gorusmeler] ([GorusmeId], [Tur], [Tarih], [Konu], [Onem]) VALUES (1, N'Şirket    ', N'29.08.2022', N'Yakıt     ', 1)
GO
SET IDENTITY_INSERT [dbo].[Gorusmeler] OFF
GO
SET IDENTITY_INSERT [dbo].[Seferler] ON 
GO
INSERT [dbo].[Seferler] ([SeferId], [Yer], [Kategori], [Tarih], [Sofor]) VALUES (6, N'İzmir', N'Görüşme', CAST(N'2022-05-26' AS Date), N'1')
GO
SET IDENTITY_INSERT [dbo].[Seferler] OFF
GO
SET IDENTITY_INSERT [dbo].[Uyeler] ON 
GO
INSERT [dbo].[Uyeler] ([MemberId], [AdSoyad], [Departman], [Iletisim], [Maas]) VALUES (3, N'Ege Okhan', N'İstanbul Beylikdüzü', N'05555214', 1210.0000)
GO
INSERT [dbo].[Uyeler] ([MemberId], [AdSoyad], [Departman], [Iletisim], [Maas]) VALUES (6, N'Ali Çelik', N'Isparta', N'ali.celik@gmail.com', 1000.0000)
GO
SET IDENTITY_INSERT [dbo].[Uyeler] OFF
GO
USE [master]
GO
ALTER DATABASE [Lojistik] SET  READ_WRITE 
GO
