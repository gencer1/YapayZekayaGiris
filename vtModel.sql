USE [YZekaDb]
GO
/****** Object:  Table [dbo].[TblCmd]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCmd](
	[cmdId] [int] IDENTITY(1,1) NOT NULL,
	[cmdKomutText] [nvarchar](60) NULL,
	[yapilacakIslemIndex] [int] NULL,
 CONSTRAINT [PK_TblCmd] PRIMARY KEY CLUSTERED 
(
	[cmdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDiyalog]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDiyalog](
	[diyalogId] [int] IDENTITY(1,1) NOT NULL,
	[diyalogText] [nvarchar](70) NULL,
	[diyalogMutluluk] [decimal](1, 1) NULL,
	[diyalogIyilik] [decimal](1, 1) NULL,
	[diyalogMizah] [decimal](1, 1) NULL,
	[diyalogOnay] [bit] NULL,
 CONSTRAINT [PK_TblDiyalog] PRIMARY KEY CLUSTERED 
(
	[diyalogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblIstatistik]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblIstatistik](
	[istatistikId] [int] IDENTITY(1,1) NOT NULL,
	[istatistikTabloIsmi] [nvarchar](40) NULL,
	[istatistikPuani] [int] NULL,
	[istatistikVeriId] [int] NULL,
 CONSTRAINT [PK_TblIstatistik] PRIMARY KEY CLUSTERED 
(
	[istatistikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKaliplar]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKaliplar](
	[kalipId] [int] IDENTITY(1,1) NOT NULL,
	[kalipText] [nvarchar](50) NULL,
	[kalipTablosu] [nvarchar](60) NULL,
	[kalipOnay] [bit] NULL,
	[kalipVeriSatiri] [nvarchar](40) NULL,
	[kalipVeriIdText] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblKaliplar] PRIMARY KEY CLUSTERED 
(
	[kalipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKimdir]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKimdir](
	[kimdirId] [int] IDENTITY(1,1) NOT NULL,
	[adiSoyadi] [nvarchar](100) NULL,
	[isi] [nvarchar](40) NULL,
	[hakkinda] [nvarchar](max) NULL,
	[ek] [nvarchar](max) NULL,
 CONSTRAINT [PK_TblKimdir] PRIMARY KEY CLUSTERED 
(
	[kimdirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKomutDiyaloglari]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKomutDiyaloglari](
	[komutDiyalogId] [int] IDENTITY(1,1) NOT NULL,
	[diyalogText] [nvarchar](80) NULL,
	[diyalogReplaceText] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblKomutDiyaloglari] PRIMARY KEY CLUSTERED 
(
	[komutDiyalogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKomutlar]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKomutlar](
	[komutId] [int] IDENTITY(1,1) NOT NULL,
	[komutText] [nvarchar](20) NULL,
	[komutKod] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblKomutlar] PRIMARY KEY CLUSTERED 
(
	[komutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKomutToDiyalog]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKomutToDiyalog](
	[recordId] [int] IDENTITY(1,1) NOT NULL,
	[komutId] [int] NULL,
	[komutDiyalogId] [int] NULL,
 CONSTRAINT [PK_TblKomutToDiyalog] PRIMARY KEY CLUSTERED 
(
	[recordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKullanici]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKullanici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [nvarchar](30) NULL,
	[sifre] [nvarchar](30) NULL,
 CONSTRAINT [PK_TblKullanici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNedir]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNedir](
	[nedirId] [int] IDENTITY(1,1) NOT NULL,
	[isim] [nvarchar](30) NULL,
	[hakkinda] [nvarchar](max) NULL,
 CONSTRAINT [PK_TblNedir] PRIMARY KEY CLUSTERED 
(
	[nedirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblToDiyalog]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblToDiyalog](
	[diyalogToId] [int] IDENTITY(1,1) NOT NULL,
	[diyalogId] [int] NULL,
	[toDiyalogId] [int] NULL,
	[toDiyalogPuan] [decimal](2, 1) NULL,
 CONSTRAINT [PK_TblToDiyalog] PRIMARY KEY CLUSTERED 
(
	[diyalogToId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYapilamayanIslemler]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYapilamayanIslemler](
	[islemId] [int] IDENTITY(1,1) NOT NULL,
	[islemMetni] [nvarchar](max) NULL,
	[islemKategorisi] [nvarchar](20) NULL,
 CONSTRAINT [PK_TblYapilamayanIslemler] PRIMARY KEY CLUSTERED 
(
	[islemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYardimciOgeKategori]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYardimciOgeKategori](
	[kategoriId] [int] IDENTITY(1,1) NOT NULL,
	[kategoriText] [nvarchar](60) NULL,
 CONSTRAINT [PK_TblYardimciOgeKategori] PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYardimciOgeler]    Script Date: 20.05.2019 05:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYardimciOgeler](
	[ogeId] [int] IDENTITY(1,1) NOT NULL,
	[ogeText] [nvarchar](50) NULL,
	[degeri] [bit] NULL,
	[ogeKategoriId] [int] NULL,
 CONSTRAINT [PK_TblYardimciOgeler] PRIMARY KEY CLUSTERED 
(
	[ogeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblDiyalog] ON 

INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1, N'merhaba', CAST(0.1 AS Decimal(1, 1)), CAST(0.1 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (2, N'selam', CAST(0.2 AS Decimal(1, 1)), CAST(0.3 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (4, N'naber', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (6, N'iyilik senden', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (7, N'iyilik', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (8, N'buna sevindim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (9, N'mutlu olmak önemli tabi', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (10, N'haklısın', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (11, N'teşekkür ederim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (15, N':)', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (16, N'gülücük', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (20, N'güzel', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (21, N'rica ederim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (22, N'nasılsın', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (23, N'iyiyim sen', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (24, N'iyiyim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (25, N'kötüyüm', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (26, N'neden kötüsün?', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (27, N'Çünkü kodlarım düzgün çalışmıyor', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (28, N'üzüldüm', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (29, N'üzülme', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (30, N'iyi', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (31, N'zoruma gidiyor', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (32, N'sevindim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (33, N'deneme', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (34, N'Sattın lan beni', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (36, N'neyin var', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1030, N'naptın', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1031, N'sıkıldım', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1032, N'sigara içtim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1033, N'neden', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1034, N'sigara içemezsin', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1035, N'çünkü öyle', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 1)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (1036, N'içerim', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 0)
INSERT [dbo].[TblDiyalog] ([diyalogId], [diyalogText], [diyalogMutluluk], [diyalogIyilik], [diyalogMizah], [diyalogOnay]) VALUES (2030, N'öğrenmek için uygun değildir', CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), CAST(0.0 AS Decimal(1, 1)), 0)
SET IDENTITY_INSERT [dbo].[TblDiyalog] OFF
SET IDENTITY_INSERT [dbo].[TblKaliplar] ON 

INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (1, N'kimdir', N'TblKimdir', 1, N'adiSoyadi', N'kimdirId')
INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (2, N'kim', N'TblKimdir', 1, N'adiSoyadi', N'kimdirId')
INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (3, N'ne', N'TblNedir', 1, N'isim', N'nedirId')
INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (4, N'nedir', N'TblNedir', 1, N'isim', N'nedirId')
INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (12, N'kimim', N'TblKimdir', 1, N'adiSoyadi', N'kimdirId')
INSERT [dbo].[TblKaliplar] ([kalipId], [kalipText], [kalipTablosu], [kalipOnay], [kalipVeriSatiri], [kalipVeriIdText]) VALUES (15, N'kimsin', N'TblKimdir', 1, N'adiSoyadi', N'kimdirId')
SET IDENTITY_INSERT [dbo].[TblKaliplar] OFF
SET IDENTITY_INSERT [dbo].[TblKimdir] ON 

INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (1, N'gencer ger', N'Program Yazarı', N'1996 yılında doğmuştur. Küçük yaşlarda elektrikle ilgilenmiş lise yıllarının sonuna doğru yazılıma yönelmiştir.', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (2, N'hüseyin başdağ', NULL, N'MSKÜ MYO veritabanıII öğretmeni ve promram yazarının danışman hocasıdır', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (5, N'ercep', NULL, N'Hayali bir üründür', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (7, N'atatürk', NULL, N'Mustafa Kemal Atatürk, Türkiye Cumhuriyeti''nin kurucusu ve ilk cumhurbaşkanıdır. Laik ve milliyetçi bir ideolojisi olan Atatürk''ün politika ve teorileri Kemalizm olarak adlandırılır.', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (8, N'gen', NULL, N'bu deneme yazısıdır', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (9, N'ben', NULL, N'Bu çok felsefik bir sorudur. Benden önce biz diye mi sormalıyız?', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (12, N'deneme', NULL, N'deneme bu projenin deneme yazısıdır', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (13, N'Okan bayülgen', NULL, N'Türkiye''nin önde gelen gösteri sanatçılarındandır.', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (14, N'sıtkı koçman', NULL, N'Büyük adamdır', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (15, N'sen', NULL, N'Ben Ercep. Program yazarı Gencer Ger''in hayali bir karakteriyim.', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (16, N'süleyman', NULL, N'1', NULL)
INSERT [dbo].[TblKimdir] ([kimdirId], [adiSoyadi], [isi], [hakkinda], [ek]) VALUES (17, N'polat alemdar', NULL, N'İsviçre çakısı gibi adamdır. Her bir şeyi yapar. severim kendisini.', NULL)
SET IDENTITY_INSERT [dbo].[TblKimdir] OFF
SET IDENTITY_INSERT [dbo].[TblKomutDiyaloglari] ON 

INSERT [dbo].[TblKomutDiyaloglari] ([komutDiyalogId], [diyalogText], [diyalogReplaceText]) VALUES (1, N'Koşulunuz Nedir', N'--Kosul--')
INSERT [dbo].[TblKomutDiyaloglari] ([komutDiyalogId], [diyalogText], [diyalogReplaceText]) VALUES (2, N'Koşul Komutları', N'--Komut--')
SET IDENTITY_INSERT [dbo].[TblKomutDiyaloglari] OFF
SET IDENTITY_INSERT [dbo].[TblKomutlar] ON 

INSERT [dbo].[TblKomutlar] ([komutId], [komutText], [komutKod]) VALUES (1, N'eğer', N'if(--Kosul--):
	--Komut--')
SET IDENTITY_INSERT [dbo].[TblKomutlar] OFF
SET IDENTITY_INSERT [dbo].[TblKomutToDiyalog] ON 

INSERT [dbo].[TblKomutToDiyalog] ([recordId], [komutId], [komutDiyalogId]) VALUES (1, 1, 1)
INSERT [dbo].[TblKomutToDiyalog] ([recordId], [komutId], [komutDiyalogId]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[TblKomutToDiyalog] OFF
SET IDENTITY_INSERT [dbo].[TblKullanici] ON 

INSERT [dbo].[TblKullanici] ([id], [kullaniciAdi], [sifre]) VALUES (1, N'gencer', N'123')
SET IDENTITY_INSERT [dbo].[TblKullanici] OFF
SET IDENTITY_INSERT [dbo].[TblNedir] ON 

INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (1, N'bardak', N'çeşitli şekillerde bulunabilen katı cisimdir. Genellikle içerisinde sıvı saklamak için kullanılır.')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (2, N'defter', N'çoğunlukla karton ya da plastik bir kapak içinde ve formalar halinde tutturulmuş bulunan kâğıt yapraklarından oluşan ve sayfalarına yazı yazılan, resim yapılan nesne.')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (3, N'bilgisayar', N'Bilgi sayan alet')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (4, N'masa', N'Masa dört ayağı olan üzerinde çeşitli işlemler yapılabilen objedir.')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (5, N'yüzyüzeyken konuşuruz', N'Türkiye''nin güzel müzik yapan gruplarından biridir')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (6, N'son feci bisiklet', N'Son feci bisiklettir. Gülücük. Güzel bir gruptur')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (7, N'muğla', N'Muğla Türkiye''nin bir ilidir')
INSERT [dbo].[TblNedir] ([nedirId], [isim], [hakkinda]) VALUES (8, N'transkripsiyon', N'DNA''dan mRNA sentezi')
SET IDENTITY_INSERT [dbo].[TblNedir] OFF
SET IDENTITY_INSERT [dbo].[TblToDiyalog] ON 

INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1, 1, 1, CAST(1.1 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2, 2, 2, CAST(1.2 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (3, 1, 2, CAST(0.5 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1002, 4, 6, CAST(0.2 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1003, 6, 7, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1004, 7, 8, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1005, 8, 9, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1006, 9, 10, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1007, 10, 11, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1008, 11, 21, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1009, 15, 16, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1010, 20, 15, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1011, 21, 15, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1012, 22, 23, CAST(0.2 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1013, 23, 24, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1014, 24, 8, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1015, 25, 26, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1016, 26, 27, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1017, 27, 28, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1018, 28, 29, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1019, 29, 31, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1020, 30, 32, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1021, 31, 35, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1022, 32, 35, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1023, 33, 34, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (1024, 34, 36, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2019, 36, 1031, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2020, 1030, 1032, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2021, 1031, 1033, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2022, 1032, 1034, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2023, 1033, 1035, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (2024, 1034, 1036, CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[TblToDiyalog] ([diyalogToId], [diyalogId], [toDiyalogId], [toDiyalogPuan]) VALUES (3019, 1035, 2030, CAST(0.0 AS Decimal(2, 1)))
SET IDENTITY_INSERT [dbo].[TblToDiyalog] OFF
SET IDENTITY_INSERT [dbo].[TblYardimciOgeKategori] ON 

INSERT [dbo].[TblYardimciOgeKategori] ([kategoriId], [kategoriText]) VALUES (1, N'Onay Cümleleri')
SET IDENTITY_INSERT [dbo].[TblYardimciOgeKategori] OFF
SET IDENTITY_INSERT [dbo].[TblYardimciOgeler] ON 

INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (1, N'evet', 1, 1)
INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (2, N'tabi', 1, 1)
INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (3, N'olur', 1, 1)
INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (4, N'buyur', 1, 1)
INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (5, N'yes', 1, 1)
INSERT [dbo].[TblYardimciOgeler] ([ogeId], [ogeText], [degeri], [ogeKategoriId]) VALUES (6, N'hayır', 0, 1)
SET IDENTITY_INSERT [dbo].[TblYardimciOgeler] OFF
ALTER TABLE [dbo].[TblDiyalog] ADD  CONSTRAINT [DF_TblDiyalog_diyalogMutluluk]  DEFAULT ((0)) FOR [diyalogMutluluk]
GO
ALTER TABLE [dbo].[TblDiyalog] ADD  CONSTRAINT [DF_TblDiyalog_diyalogIyilik]  DEFAULT ((0)) FOR [diyalogIyilik]
GO
ALTER TABLE [dbo].[TblDiyalog] ADD  CONSTRAINT [DF_TblDiyalog_diyalogMizah]  DEFAULT ((0)) FOR [diyalogMizah]
GO
ALTER TABLE [dbo].[TblDiyalog] ADD  CONSTRAINT [DF_TblDiyalog_diyalogOnay]  DEFAULT ((0)) FOR [diyalogOnay]
GO
ALTER TABLE [dbo].[TblKaliplar] ADD  CONSTRAINT [DF_TblKaliplar_kalipOnay]  DEFAULT ((0)) FOR [kalipOnay]
GO
ALTER TABLE [dbo].[TblToDiyalog] ADD  CONSTRAINT [DF_TblToDiyalog_toDiyalogPuan]  DEFAULT ((0)) FOR [toDiyalogPuan]
GO
