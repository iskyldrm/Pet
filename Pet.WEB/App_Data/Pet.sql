USE [Pet]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NOT NULL,
	[DistrictId] [int] NOT NULL,
	[FullAdsress] [nvarchar](max) NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adverts]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adverts](
	[Id] [uniqueidentifier] NOT NULL,
	[AdvertNo] [nvarchar](max) NOT NULL,
	[AdvertType] [int] NOT NULL,
	[PetState] [nvarchar](max) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[AddressId] [int] NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[LivingId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Adverts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Age] [datetime2](7) NOT NULL,
	[AddressId] [int] NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityNumber] [tinyint] NOT NULL,
	[CityName] [nvarchar](max) NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistrictName] [nvarchar](max) NOT NULL,
	[CityId] [int] NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Districts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favorites]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favorites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Discription] [nvarchar](max) NOT NULL,
	[AdvertId] [uniqueidentifier] NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Favorites] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FavoriteUser]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FavoriteUser](
	[FavoritesId] [int] NOT NULL,
	[UsersId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_FavoriteUser] PRIMARY KEY CLUSTERED 
(
	[FavoritesId] ASC,
	[UsersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genus]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenusName] [nvarchar](max) NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[GenusType] [bit] NOT NULL,
 CONSTRAINT [PK_Genus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [uniqueidentifier] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NOT NULL,
	[ImageDescription] [nvarchar](max) NULL,
	[LivingId] [uniqueidentifier] NULL,
	[AdvertId] [uniqueidentifier] NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[ImageUserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kinds]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kinds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[Team] [int] NOT NULL,
	[Familya] [int] NOT NULL,
	[KindName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Kinds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livings]    Script Date: 18.07.2022 17:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livings](
	[Id] [uniqueidentifier] NOT NULL,
	[LivingName] [nvarchar](max) NOT NULL,
	[LivingGender] [bit] NOT NULL,
	[LivingAge] [tinyint] NOT NULL,
	[KindId] [int] NOT NULL,
	[GenusId] [int] NOT NULL,
	[CreateTime] [datetime2](7) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Livings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617140133_InitDb', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617141536_Initdb2', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617151142_Initdb3', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617183638_GenusAdded', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617184322_DeRacial', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617190733_GenusOfDogAdded', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617190939_GenusLast', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220617192622_Kindadded', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623125833_Update-Kind', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623191043_AddedUserToLivingClass', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623193201_AddedUserToLivingClass1', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623194401_AddedUserToLivingClass3', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624191730_Imageaddedtouser', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624193210_Imageaddedtouser2', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625193838_Livingaddpropaddedadvert', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625195848_oldstate', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625203928_newmigraiton', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (16, 24, 312, N'Cumhuriyet Mahallesi Özge Sokak No:9/4', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-26T00:32:34.6556812' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (17, 34, 845, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-26T00:36:10.3641831' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (18, 9, 123, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-26T14:50:20.5244226' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (19, 12, 210, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T17:04:54.3340922' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (20, 14, 166, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T17:15:43.3621800' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (21, 11, 202, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T17:27:14.9357766' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (22, 49, 597, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T17:42:04.6111496' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (23, 10, 146, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T17:51:48.5996202' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (24, 14, 168, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T20:44:29.3619982' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (25, 24, 312, N'Özge sokak', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T22:34:54.7940671' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (26, 34, 845, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T22:37:27.9505058' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (27, 67, 795, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T22:38:30.4572906' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (28, 15, 175, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T23:37:59.2911732' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (29, 13, 221, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T23:38:14.3854552' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (30, 11, 203, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T23:38:27.8225416' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (31, 12, 213, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-27T23:38:37.5670478' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (32, 6, 67, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-28T16:07:05.0715501' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (33, 7, 89, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-28T22:23:57.5652660' AS DateTime2))
INSERT [dbo].[Addresses] ([Id], [CityId], [DistrictId], [FullAdsress], [CreateTime], [UpdateTime]) VALUES (34, 13, 220, N' ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-30T15:11:42.0394509' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'515536f6-b0e9-46de-d63e-08da58747807', N'Halleyin ilk ilanı', 1, N'İlerisi için', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 26, CAST(N'2022-06-27T22:37:27.9506223' AS DateTime2), CAST(N'2022-06-27T22:37:27.9506574' AS DateTime2), N'4c7016c2-840b-458c-5ca7-08da587460b4')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'62122537-c614-4f6b-7489-08da587cec7a', N'sdasdasdsad', 1, N'Zamanı var', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 28, CAST(N'2022-06-27T23:37:59.2913200' AS DateTime2), CAST(N'2022-06-27T23:37:59.2913658' AS DateTime2), N'2c1e963a-b241-4fa1-679b-08da587cbca3')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'0b767971-ba27-42f8-748a-08da587cec7a', N'dsadasdasd', 1, N'Zamanı var', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 29, CAST(N'2022-06-27T23:38:14.3854555' AS DateTime2), CAST(N'2022-06-27T23:38:14.3854558' AS DateTime2), N'e6a85426-cce1-464b-679c-08da587cbca3')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'2a512e6b-fa70-454a-748b-08da587cec7a', N'ewqedwqe', 1, N'Zamanı var', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 30, CAST(N'2022-06-27T23:38:27.8225418' AS DateTime2), CAST(N'2022-06-27T23:38:27.8225418' AS DateTime2), N'4bd0e44b-9bd2-4fef-679d-08da587cbca3')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'499e9efb-a366-448f-748c-08da587cec7a', N'2efdsfsad', 1, N'İlerisi için', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 31, CAST(N'2022-06-27T23:38:37.5670483' AS DateTime2), CAST(N'2022-06-27T23:38:37.5670484' AS DateTime2), N'057ef613-30b1-4bde-679e-08da587cbca3')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'92254316-047a-483d-50e7-08da59071952', N'Bu yakışıklı sbdjasd kjasbdjba jsabdjasb jdskjadbjksabd kj', 1, N'İlerisi için', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 32, CAST(N'2022-06-28T16:07:05.0717533' AS DateTime2), CAST(N'2022-06-28T16:07:05.0717987' AS DateTime2), N'6b2f4bb1-1de1-4660-fa7b-08da59070ce0')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'98d8b5ce-a279-44fc-ad52-08da593bbf6a', N'Güzel ilan', 1, N'Zamanı var', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 33, CAST(N'2022-06-28T22:23:57.5653764' AS DateTime2), CAST(N'2022-06-28T22:23:57.5654180' AS DateTime2), N'7e815042-1e12-4167-247f-08da593bb2d2')
INSERT [dbo].[Adverts] ([Id], [AdvertNo], [AdvertType], [PetState], [UserId], [AddressId], [CreateTime], [UpdateTime], [LivingId]) VALUES (N'06e1e7ed-c3b8-4d71-4c4c-08da5a91b178', N'dsadsadsa', 1, N'Zamanı var', N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', 34, CAST(N'2022-06-30T15:11:42.0396442' AS DateTime2), CAST(N'2022-06-30T15:11:42.0397120' AS DateTime2), N'a5c88557-43d8-4c9a-aa9c-08da5a91813b')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3ffb0003-45e4-4af3-a96b-66170449a20d', N'UserRole', N'Editor', NULL, N'3a157a4a-78c8-4dba-b8c8-71788fca6eb6')
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4e885d36-ff22-4f78-8721-12f94c935956', N'UserRole', N'MidUser', NULL, N'520dce82-3683-486e-8888-c1effd99d0a0')
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5509bc30-74c6-4240-95e3-263ac6abdaf1', N'UserRole', N'HighUser', NULL, N'e0c190b0-4f72-49c6-9ae0-e6308bb4c5e3')
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'672e30f7-fab4-4f34-8015-014921e05ed8', N'UserRole', N'Admin', NULL, N'a6193ea9-bdac-4b38-9526-8ca3b9ba07bf')
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'75b56726-8dcd-4a29-8041-59656057b4b4', N'UserRole', N'BasicUser', NULL, N'30d8de55-604c-48d1-ad61-0784488c350c')
INSERT [dbo].[AspNetRoles] ([Id], [Discriminator], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8bfc911d-b7ad-4622-b265-7c59111775ee', N'UserRole', N'Creator', NULL, N'e383ffdc-ba2e-4e9b-8ebe-3547e9a4dbd3')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Name], [LastName], [Gender], [Age], [AddressId], [CreateTime], [UpdateTime], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94', N'isak', N'yıldırım', 0, CAST(N'2022-06-27T22:34:54.7941824' AS DateTime2), 25, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'iskyldrm', N'ISKYLDRM', N'm.isakyildirim@gmail.com', N'M.ISAKYILDIRIM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEiHiiLcQJIhNCSS0w5f6qELCtGnK64fWGsZfCBxS5amzbC/I0DIt8ZdgVnXcuUxvg==', N'ZQ66XTDKHZS52JIAR6VC5NRJA6LKWBOR', N'bba843f6-97b1-4ede-ade2-bb816f2e3a2b', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (1, 1, N'ADANA', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (2, 2, N'ADIYAMAN', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (3, 3, N'AFYON', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (4, 4, N'AĞRI', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (5, 5, N'AMASYA', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (6, 6, N'ANKARA', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (7, 7, N'ANTALYA', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (8, 8, N'ARTVİN', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (9, 9, N'AYDIN', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (10, 10, N'BALIKESİR', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (11, 11, N'BİLECİK', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (12, 12, N'BİNGÖL', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (13, 13, N'BİTLİS', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (14, 14, N'BOLU', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (15, 15, N'BURDUR', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (16, 16, N'BURSA', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (17, 17, N'ÇANAKKALE', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (18, 18, N'ÇANKIRI', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (19, 19, N'ÇORUM', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (20, 20, N'DENİZLİ', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (21, 21, N'DİYARBAKIR', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (22, 22, N'EDİRNE', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (23, 23, N'ELAZIĞ', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (24, 24, N'ERZİNCAN', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (25, 25, N'ERZURUM', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (26, 26, N'ESKİŞEHİR', CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2), CAST(N'2022-06-17T17:11:10.9833333' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (27, 27, N'GAZİANTEP', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (28, 28, N'GİRESUN', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (29, 29, N'GÜMÜŞHANE', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (30, 30, N'HAKKARİ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (31, 31, N'HATAY', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (32, 32, N'ISPARTA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (33, 33, N'İÇEL', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (34, 34, N'İSTANBUL', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (35, 35, N'İZMİR', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (36, 36, N'KARS', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (37, 37, N'KASTAMONU', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (38, 38, N'KAYSERİ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (39, 39, N'KIRKLARELİ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (40, 40, N'KIRŞEHİR', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (41, 41, N'KOCAELİ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (42, 42, N'KONYA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (43, 43, N'KÜTAHYA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (44, 44, N'MALATYA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (45, 45, N'MANİSA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (46, 46, N'KAHRAMANMARAŞ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (47, 47, N'MARDİN', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (48, 48, N'MUĞLA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (49, 49, N'MUŞ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (50, 50, N'NEVŞEHİR', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (51, 51, N'NİĞDE', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (52, 52, N'ORDU', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (53, 53, N'RİZE', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (54, 54, N'SAKARYA', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (55, 55, N'SAMSUN', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (56, 56, N'SİİRT', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (57, 57, N'SİNOP', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (58, 58, N'SİVAS', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (59, 59, N'TEKİRDAĞ', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (60, 60, N'TOKAT', CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2), CAST(N'2022-06-17T17:11:10.9866667' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (61, 61, N'TRABZON', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (62, 62, N'TUNCELİ', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (63, 63, N'ŞANLIURFA', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (64, 64, N'UŞAK', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (65, 65, N'VAN', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (66, 66, N'YOZGAT', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (67, 67, N'ZONGULDAK', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (68, 68, N'AKSARAY', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (69, 69, N'BAYBURT', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (70, 70, N'KARAMAN', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (71, 71, N'KIRIKKALE', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (72, 72, N'BATMAN', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (73, 73, N'ŞIRNAK', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (74, 74, N'BARTIN', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (75, 75, N'ARDAHAN', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (76, 76, N'IĞDIR', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (77, 77, N'YALOVA', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (78, 78, N'KARABÜK', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (79, 79, N'KİLİS', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (80, 80, N'OSMANİYE', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
INSERT [dbo].[Cities] ([Id], [CityNumber], [CityName], [CreateTime], [UpdateTime]) VALUES (81, 81, N'DÜZCE', CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2), CAST(N'2022-06-17T17:11:10.9900000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (1, N'SEYHAN', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (2, N'CEYHAN', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (3, N'FEKE', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (4, N'KARAİSALI', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (5, N'KARATAŞ', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (6, N'KOZAN', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (7, N'POZANTI', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (8, N'SAİMBEYLİ', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (9, N'TUFANBEYLİ', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (10, N'YUMURTALIK', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (11, N'YÜREĞİR', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (12, N'ALADAĞ', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (13, N'İMAMOĞLU', 1, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (14, N'ADIYAMAN MERKEZ', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (15, N'BESNİ', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (16, N'ÇELİKHAN', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (17, N'GERGER', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (18, N'GÖLBAŞI', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (19, N'KAHTA', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (20, N'SAMSAT', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (21, N'SİNCİK', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (22, N'TUT', 2, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (23, N'AFYONMERKEZ', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (24, N'BOLVADİN', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (25, N'ÇAY', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (26, N'DAZKIRI', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (27, N'DİNAR', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (28, N'EMİRDAĞ', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (29, N'İHSANİYE', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (30, N'SANDIKLI', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (31, N'SİNANPAŞA', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (32, N'SULDANDAĞI', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (33, N'ŞUHUT', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (34, N'BAŞMAKÇI', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (35, N'BAYAT', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (36, N'İŞCEHİSAR', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (37, N'ÇOBANLAR', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (38, N'EVCİLER', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (39, N'HOCALAR', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (40, N'KIZILÖREN', 3, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (41, N'AKSARAY MERKEZ', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (42, N'ORTAKÖY', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (43, N'AĞAÇÖREN', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (44, N'GÜZELYURT', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (45, N'SARIYAHŞİ', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (46, N'ESKİL', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (47, N'GÜLAĞAÇ', 68, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (48, N'AMASYA MERKEZ', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (49, N'GÖYNÜÇEK', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (50, N'GÜMÜŞHACIKÖYÜ', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (51, N'MERZİFON', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (52, N'SULUOVA', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (53, N'TAŞOVA', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (54, N'HAMAMÖZÜ', 5, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (55, N'ALTINDAĞ', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (56, N'AYAS', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (57, N'BALA', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (58, N'BEYPAZARI', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (59, N'ÇAMLIDERE', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (60, N'ÇANKAYA', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (61, N'ÇUBUK', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (62, N'ELMADAĞ', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (63, N'GÜDÜL', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (64, N'HAYMANA', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (65, N'KALECİK', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (66, N'KIZILCAHAMAM', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (67, N'NALLIHAN', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (68, N'POLATLI', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (69, N'ŞEREFLİKOÇHİSAR', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (70, N'YENİMAHALLE', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (71, N'GÖLBAŞI', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (72, N'KEÇİÖREN', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (73, N'MAMAK', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (74, N'SİNCAN', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (75, N'KAZAN', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (76, N'AKYURT', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (77, N'ETİMESGUT', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (78, N'EVREN', 6, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (79, N'ANSEKİ', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (80, N'ALANYA', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (81, N'ANTALYA MERKEZİ', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (82, N'ELMALI', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (83, N'FİNİKE', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (84, N'GAZİPAŞA', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (85, N'GÜNDOĞMUŞ', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (86, N'KAŞ', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (87, N'KORKUTELİ', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (88, N'KUMLUCA', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (89, N'MANAVGAT', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (90, N'SERİK', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (91, N'DEMRE', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (92, N'İBRADI', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (93, N'KEMER', 7, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (94, N'ARDAHAN MERKEZ', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (95, N'GÖLE', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (96, N'ÇILDIR', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (97, N'HANAK', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (98, N'POSOF', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (99, N'DAMAL', 75, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (100, N'ARDANUÇ', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (101, N'ARHAVİ', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (102, N'ARTVİN MERKEZ', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (103, N'BORÇKA', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (104, N'HOPA', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (105, N'ŞAVŞAT', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (106, N'YUSUFELİ', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (107, N'MURGUL', 8, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (108, N'AYDIN MERKEZ', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (109, N'BOZDOĞAN', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (110, N'ÇİNE', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (111, N'GERMENCİK', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (112, N'KARACASU', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (113, N'KOÇARLI', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (114, N'KUŞADASI', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (115, N'KUYUCAK', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (116, N'NAZİLLİ', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (117, N'SÖKE', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (118, N'SULTANHİSAR', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (119, N'YENİPAZAR', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (120, N'BUHARKENT', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (121, N'İNCİRLİOVA', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (122, N'KARPUZLU', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (123, N'KÖŞK', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (124, N'DİDİM', 9, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (125, N'AĞRI MERKEZ', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (126, N'DİYADİN', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (127, N'DOĞUBEYAZIT', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (128, N'ELEŞKİRT', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (129, N'HAMUR', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (130, N'PATNOS', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (131, N'TAŞLIÇAY', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (132, N'TUTAK', 4, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (133, N'AYVALIK', 10, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (134, N'BALIKESİR MERKEZ', 10, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (135, N'BALYA', 10, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (136, N'BANDIRMA', 10, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (137, N'BİGADİÇ', 10, CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0833333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (138, N'BURHANİYE', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (139, N'DURSUNBEY', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (140, N'EDREMİT', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (141, N'ERDEK', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (142, N'GÖNEN', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (143, N'HAVRAN', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (144, N'İVRİNDİ', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (145, N'KEPSUT', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (146, N'MANYAS', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (147, N'SAVAŞTEPE', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (148, N'SINDIRGI', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (149, N'SUSURLUK', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (150, N'MARMARA', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (151, N'GÖMEÇ', 10, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (152, N'BARTIN MERKEZ', 74, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (153, N'KURUCAŞİLE', 74, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (154, N'ULUS', 74, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (155, N'AMASRA', 74, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (156, N'BATMAN MERKEZ', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (157, N'BEŞİRİ', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (158, N'GERCÜŞ', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (159, N'KOZLUK', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (160, N'SASON', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (161, N'HASANKEYF', 72, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (162, N'BAYBURT MERKEZ', 69, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (163, N'AYDINTEPE', 69, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (164, N'DEMİRÖZÜ', 69, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (165, N'BOLU MERKEZ', 14, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (166, N'GEREDE', 14, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (167, N'GÖYNÜK', 14, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (168, N'KIBRISCIK', 14, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (169, N'MENGEN', 14, CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0866667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (170, N'MUDURNU', 14, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (171, N'SEBEN', 14, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (172, N'DÖRTDİVAN', 14, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (173, N'YENİÇAĞA', 14, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (174, N'AĞLASUN', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (175, N'BUCAK', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (176, N'BURDUR MERKEZ', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (177, N'GÖLHİSAR', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (178, N'TEFENNİ', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (179, N'YEŞİLOVA', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (180, N'KARAMANLI', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (181, N'KEMER', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (182, N'ALTINYAYLA', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (183, N'ÇAVDIR', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (184, N'ÇELTİKÇİ', 15, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (185, N'GEMLİK', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (186, N'İNEGÖL', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (187, N'İZNİK', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (188, N'KARACABEY', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (189, N'KELES', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (190, N'MUDANYA', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (191, N'MUSTAFA K. PAŞA', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (192, N'ORHANELİ', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (193, N'ORHANGAZİ', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (194, N'YENİŞEHİR', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (195, N'BÜYÜK ORHAN', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (196, N'HARMANCIK', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (197, N'NÜLİFER', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (198, N'OSMAN GAZİ', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (199, N'YILDIRIM', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (200, N'GÜRSU', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (201, N'KESTEL', 16, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (202, N'BİLECİK MERKEZ', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (203, N'BOZÜYÜK', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (204, N'GÖLPAZARI', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (205, N'OSMANELİ', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (206, N'PAZARYERİ', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (207, N'SÖĞÜT', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (208, N'YENİPAZAR', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (209, N'İNHİSAR', 11, CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2), CAST(N'2022-06-17T17:11:11.0900000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (210, N'BİNGÖL MERKEZ', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (211, N'GENÇ', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (212, N'KARLIOVA', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (213, N'KİGI', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (214, N'SOLHAN', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (215, N'ADAKLI', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (216, N'YAYLADERE', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (217, N'YEDİSU', 12, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (218, N'ADİLCEVAZ', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (219, N'AHLAT', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (220, N'BİTLİS MERKEZ', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (221, N'HİZAN', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (222, N'MUTKİ', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (223, N'TATVAN', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (224, N'GÜROYMAK', 13, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (225, N'DENİZLİ MERKEZ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (226, N'ACIPAYAM', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (227, N'BULDAN', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (228, N'ÇAL', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (229, N'ÇAMELİ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (230, N'ÇARDAK', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (231, N'ÇİVRİL', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (232, N'GÜNEY', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (233, N'KALE', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (234, N'SARAYKÖY', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (235, N'TAVAS', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (236, N'BABADAĞ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (237, N'BEKİLLİ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (238, N'HONAZ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (239, N'SERİNHİSAR', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (240, N'AKKÖY', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (241, N'BAKLAN', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (242, N'BEYAĞAÇ', 20, CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2), CAST(N'2022-06-17T17:11:11.0933333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (243, N'BOZKURT', 20, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (244, N'DÜZCE MERKEZ', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (245, N'AKÇAKOCA', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (246, N'YIĞILCA', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (247, N'CUMAYERİ', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (248, N'GÖLYAKA', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (249, N'ÇİLİMLİ', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (250, N'GÜMÜŞOVA', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (251, N'KAYNAŞLI', 81, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (252, N'DİYARBAKIR MERKEZ', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (253, N'BİSMİL', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (254, N'ÇERMİK', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (255, N'ÇINAR', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (256, N'ÇÜNGÜŞ', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (257, N'DİCLE', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (258, N'ERGANİ', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (259, N'HANİ', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (260, N'HAZRO', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (261, N'KULP', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (262, N'LİCE', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (263, N'SİLVAN', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (264, N'EĞİL', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (265, N'KOCAKÖY', 21, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (266, N'EDİRNE MERKEZ', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (267, N'ENEZ', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (268, N'HAVSA', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (269, N'İPSALA', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (270, N'KEŞAN', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (271, N'LALAPAŞA', 22, CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2), CAST(N'2022-06-17T17:11:11.0966667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (272, N'MERİÇ', 22, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (273, N'UZUNKÖPRÜ', 22, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (274, N'SÜLOĞLU', 22, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (275, N'ELAZIĞ MERKEZ', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (276, N'AĞIN', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (277, N'BASKİL', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (278, N'KARAKOÇAN', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (279, N'KEBAN', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (280, N'MADEN', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (281, N'PALU', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (282, N'SİVRİCE', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (283, N'ARICAK', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (284, N'KOVANCILAR', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (285, N'ALACAKAYA', 23, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (286, N'ERZURUM MERKEZ', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (287, N'PALANDÖKEN', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (288, N'AŞKALE', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (289, N'ÇAT', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (290, N'HINIS', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (291, N'HORASAN', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (292, N'OLTU', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (293, N'İSPİR', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (294, N'KARAYAZI', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (295, N'NARMAN', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (296, N'OLUR', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (297, N'PASİNLER', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (298, N'ŞENKAYA', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (299, N'TEKMAN', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (300, N'TORTUM', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (301, N'KARAÇOBAN', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (302, N'UZUNDERE', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (303, N'PAZARYOLU', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (304, N'ILICA', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (305, N'KÖPRÜKÖY', 25, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (306, N'ÇAYIRLI', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (307, N'ERZİNCAN MERKEZ', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (308, N'İLİÇ', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (309, N'KEMAH', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (310, N'KEMALİYE', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (311, N'REFAHİYE', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (312, N'TERCAN', 24, CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1000000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (313, N'OTLUKBELİ', 24, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (314, N'ESKİŞEHİR MERKEZ', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (315, N'ÇİFTELER', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (316, N'MAHMUDİYE', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (317, N'MİHALIÇLIK', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (318, N'SARICAKAYA', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (319, N'SEYİTGAZİ', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (320, N'SİVRİHİSAR', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (321, N'ALPU', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (322, N'BEYLİKOVA', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (323, N'İNÖNÜ', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (324, N'GÜNYÜZÜ', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (325, N'HAN', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (326, N'MİHALGAZİ', 26, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (327, N'ARABAN', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (328, N'İSLAHİYE', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (329, N'NİZİP', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (330, N'OĞUZELİ', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (331, N'YAVUZELİ', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (332, N'ŞAHİNBEY', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (333, N'ŞEHİT KAMİL', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (334, N'KARKAMIŞ', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (335, N'NURDAĞI', 27, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (336, N'GÜMÜŞHANE MERKEZ', 29, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (337, N'KELKİT', 29, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (338, N'ŞİRAN', 29, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (339, N'TORUL', 29, CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1033333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (340, N'KÖSE', 29, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (341, N'KÜRTÜN', 29, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (342, N'ALUCRA', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (343, N'BULANCAK', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (344, N'DERELİ', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (345, N'ESPİYE', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (346, N'EYNESİL', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (347, N'GİRESUN MERKEZ', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (348, N'GÖRELE', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (349, N'KEŞAP', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (350, N'ŞEBİNKARAHİSAR', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (351, N'TİREBOLU', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (352, N'PİPAZİZ', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (353, N'YAĞLIDERE', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (354, N'ÇAMOLUK', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (355, N'ÇANAKÇI', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (356, N'DOĞANKENT', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (357, N'GÜCE', 28, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (358, N'HAKKARİ MERKEZ', 30, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (359, N'ÇUKURCA', 30, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (360, N'ŞEMDİNLİ', 30, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (361, N'YÜKSEKOVA', 30, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (362, N'ALTINÖZÜ', 31, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (363, N'DÖRTYOL', 31, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (364, N'HATAY MERKEZ', 31, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (365, N'HASSA', 31, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (366, N'İSKENDERUN', 31, CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1066667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (367, N'KIRIKHAN', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (368, N'REYHANLI', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (369, N'SAMANDAĞ', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (370, N'YAYLADAĞ', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (371, N'ERZİN', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (372, N'BELEN', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (373, N'KUMLU', 31, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (374, N'ISPARTA MERKEZ', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (375, N'ATABEY', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (376, N'KEÇİBORLU', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (377, N'EĞİRDİR', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (378, N'GELENDOST', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (379, N'SİNİRKENT', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (380, N'ULUBORLU', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (381, N'YALVAÇ', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (382, N'AKSU', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (383, N'GÖNEN', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (384, N'YENİŞAR BADEMLİ', 32, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (385, N'IĞDIR MERKEZ', 76, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (386, N'ARALIK', 76, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (387, N'TUZLUCA', 76, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (388, N'KARAKOYUNLU', 76, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (389, N'AFŞİN', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (390, N'ANDIRIN', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (391, N'ELBİSTAN', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (392, N'GÖKSUN', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (393, N'KAHRAMANMARAŞ MERKEZ', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (394, N'PAZARCIK', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (395, N'TÜRKOĞLU', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (396, N'ÇAĞLAYANCERİT', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (397, N'EKİNÖZÜ', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (398, N'NURHAK', 46, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (399, N'EFLANİ', 78, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (400, N'ESKİPAZAR', 78, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (401, N'KARABÜK MERKEZ', 78, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (402, N'OVACIK', 78, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (403, N'SAFRANBOLU', 78, CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1100000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (404, N'YENİCE', 78, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (405, N'ERMENEK', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (406, N'KARAMAN MERKEZ', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (407, N'AYRANCI', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (408, N'KAZIMKARABEKİR', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (409, N'BAŞYAYLA', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (410, N'SARIVELİLER', 70, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (411, N'KARS MERKEZ', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (412, N'ARPAÇAY', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (413, N'DİGOR', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (414, N'KAĞIZMAN', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (415, N'SARIKAMIŞ', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (416, N'SELİM', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (417, N'SUSUZ', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (418, N'AKYAKA', 36, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (419, N'ABANA', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (420, N'KASTAMONU MERKEZ', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (421, N'ARAÇ', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (422, N'AZDAVAY', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (423, N'BOZKURT', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (424, N'CİDE', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (425, N'ÇATALZEYTİN', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (426, N'DADAY', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (427, N'DEVREKANİ', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (428, N'İNEBOLU', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (429, N'KÜRE', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (430, N'TAŞKÖPRÜ', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (431, N'TOSYA', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (432, N'İHSANGAZİ', 37, CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1133333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (433, N'PINARBAŞI', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (434, N'ŞENPAZAR', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (435, N'AĞLI', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (436, N'DOĞANYURT', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (437, N'HANÖNÜ', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (438, N'SEYDİLER', 37, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (439, N'BÜNYAN', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (440, N'DEVELİ', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (441, N'FELAHİYE', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (442, N'İNCESU', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (443, N'PINARBAŞI', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (444, N'SARIOĞLAN', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (445, N'SARIZ', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (446, N'TOMARZA', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (447, N'YAHYALI', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (448, N'YEŞİLHİSAR', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (449, N'AKKIŞLA', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (450, N'TALAS', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (451, N'KOCASİNAN', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (452, N'MELİKGAZİ', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (453, N'HACILAR', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (454, N'ÖZVATAN', 38, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (455, N'DERİCE', 71, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (456, N'KESKİN', 71, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (457, N'KIRIKKALE MERKEZ', 71, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (458, N'SALAK YURT', 71, CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1166667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (459, N'BAHŞİLİ', 71, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (460, N'BALIŞEYH', 71, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (461, N'ÇELEBİ', 71, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (462, N'KARAKEÇİLİ', 71, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (463, N'YAHŞİHAN', 71, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (464, N'KIRKKLARELİ MERKEZ', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (465, N'BABAESKİ', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (466, N'DEMİRKÖY', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (467, N'KOFÇAY', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (468, N'LÜLEBURGAZ', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (469, N'VİZE', 39, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (470, N'KIRŞEHİR MERKEZ', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (471, N'ÇİÇEKDAĞI', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (472, N'KAMAN', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (473, N'MUCUR', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (474, N'AKPINAR', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (475, N'AKÇAKENT', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (476, N'BOZTEPE', 40, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (477, N'KOCAELİ MERKEZ', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (478, N'GEBZE', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (479, N'GÖLCÜK', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (480, N'KANDIRA', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (481, N'KARAMÜRSEL', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (482, N'KÖRFEZ', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (483, N'DERİNCE', 41, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (484, N'KONYA MERKEZ', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (485, N'AKŞEHİR', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (486, N'BEYŞEHİR', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (487, N'BOZKIR', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (488, N'CİHANBEYLİ', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (489, N'ÇUMRA', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (490, N'DOĞANHİSAR', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (491, N'EREĞLİ', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (492, N'HADİM', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (493, N'ILGIN', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (494, N'KADINHANI', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (495, N'KARAPINAR', 42, CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1200000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (496, N'KULU', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (497, N'SARAYÖNÜ', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (498, N'SEYDİŞEHİR', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (499, N'YUNAK', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (500, N'AKÖREN', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (501, N'ALTINEKİN', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (502, N'DEREBUCAK', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (503, N'HÜYÜK', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (504, N'KARATAY', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (505, N'MERAM', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (506, N'SELÇUKLU', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (507, N'TAŞKENT', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (508, N'AHIRLI', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (509, N'ÇELTİK', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (510, N'DERBENT', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (511, N'EMİRGAZİ', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (512, N'GÜNEYSINIR', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (513, N'HALKAPINAR', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (514, N'TUZLUKÇU', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (515, N'YALIHÜYÜK', 42, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (516, N'KÜTAHYA  MERKEZ', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (517, N'ALTINTAŞ', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (518, N'DOMANİÇ', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (519, N'EMET', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (520, N'GEDİZ', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (521, N'SİMAV', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (522, N'TAVŞANLI', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (523, N'ASLANAPA', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (524, N'DUMLUPINAR', 43, CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1233333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (525, N'HİSARCIK', 43, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (526, N'ŞAPHANE', 43, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (527, N'ÇAVDARHİSAR', 43, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (528, N'PAZARLAR', 43, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (529, N'KİLİS MERKEZ', 79, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (530, N'ELBEYLİ', 79, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (531, N'MUSABEYLİ', 79, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (532, N'POLATELİ', 79, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (533, N'MALATYA MERKEZ', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (534, N'AKÇADAĞ', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (535, N'ARAPGİR', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (536, N'ARGUVAN', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (537, N'DARENDE', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (538, N'DOĞANŞEHİR', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (539, N'HEKİMHAN', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (540, N'PÜTÜRGE', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (541, N'YEŞİLYURT', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (542, N'BATTALGAZİ', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (543, N'DOĞANYOL', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (544, N'KALE', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (545, N'KULUNCAK', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (546, N'YAZIHAN', 44, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (547, N'AKHİSAR', 45, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (548, N'ALAŞEHİR', 45, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (549, N'DEMİRCİ', 45, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (550, N'GÖRDES', 45, CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1266667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (551, N'KIRKAĞAÇ', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (552, N'KULA', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (553, N'MANİSA MERKEZ', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (554, N'SALİHLİ', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (555, N'SARIGÖL', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (556, N'SARUHANLI', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (557, N'SELENDİ', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (558, N'SOMA', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (559, N'TURGUTLU', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (560, N'AHMETLİ', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (561, N'GÖLMARMARA', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (562, N'KÖPRÜBAŞI', 45, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (563, N'DERİK', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (564, N'KIZILTEPE', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (565, N'MARDİN MERKEZ', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (566, N'MAZIDAĞI', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (567, N'MİDYAT', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (568, N'NUSAYBİN', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (569, N'ÖMERLİ', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (570, N'SAVUR', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (571, N'YEŞİLLİ', 47, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (572, N'MERSİN MERKEZ', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (573, N'ANAMUR', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (574, N'ERDEMLİ', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (575, N'GÜLNAR', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (576, N'MUT', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (577, N'SİLİFKE', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (578, N'TARSUS', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (579, N'AYDINCIK', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (580, N'BOZYAZI', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (581, N'ÇAMLIYAYLA', 33, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (582, N'BODRUM', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (583, N'DATÇA', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (584, N'FETHİYE', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (585, N'KÖYCEĞİZ', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (586, N'MARMARİS', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (587, N'MİLAS', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (588, N'MUĞLA MERKEZ', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (589, N'ULA', 48, CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1300000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (590, N'YATAĞAN', 48, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (591, N'DALAMAN', 48, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (592, N'KAVAKLI DERE', 48, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (593, N'ORTACA', 48, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (594, N'BULANIK', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (595, N'MALAZGİRT', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (596, N'MUŞ MERKEZ', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (597, N'VARTO', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (598, N'HASKÖY', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (599, N'KORKUT', 49, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (600, N'NEVŞEHİR MERKEZ', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (601, N'AVANOS', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (602, N'DERİNKUYU', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (603, N'GÜLŞEHİR', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (604, N'HACIBEKTAŞ', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (605, N'KOZAKLI', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (606, N'ÜRGÜP', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (607, N'ACIGÖL', 50, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (608, N'NİĞDE MERKEZ', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (609, N'BOR', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (610, N'ÇAMARDI', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (611, N'ULUKIŞLA', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (612, N'ALTUNHİSAR', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (613, N'ÇİFTLİK', 51, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (614, N'AKKUŞ', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (615, N'AYBASTI', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (616, N'FATSA', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (617, N'GÖLKÖY', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (618, N'KORGAN', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (619, N'KUMRU', 52, CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1333333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (620, N'MESUDİYE', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (621, N'ORDU MERKEZ', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (622, N'PERŞEMBE', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (623, N'ULUBEY', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (624, N'ÜNYE', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (625, N'GÜLYALI', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (626, N'GÜRGENTEPE', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (627, N'ÇAMAŞ', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (628, N'ÇATALPINAR', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (629, N'ÇAYBAŞI', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (630, N'İKİZCE', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (631, N'KABADÜZ', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (632, N'KABATAŞ', 52, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (633, N'BAHÇE', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (634, N'KADİRLİ', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (635, N'OSMANİYE MERKEZ', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (636, N'DÜZİÇİ', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (637, N'HASANBEYLİ', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (638, N'SUMBAŞ', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (639, N'TOPRAKKALE', 80, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (640, N'RİZE MERKEZ', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (641, N'ARDEŞEN', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (642, N'ÇAMLIHEMŞİN', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (643, N'ÇAYELİ', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (644, N'FINDIKLI', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (645, N'İKİZDERE', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (646, N'KALKANDERE', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (647, N'PAZAR', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (648, N'GÜNEYSU', 53, CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1366667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (649, N'DEREPAZARI', 53, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (650, N'HEMŞİN', 53, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (651, N'İYİDERE', 53, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (652, N'AKYAZI', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (653, N'GEYVE', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (654, N'HENDEK', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (655, N'KARASU', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (656, N'KAYNARCA', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (657, N'SAKARYA MERKEZ', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (658, N'PAMUKOVA', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (659, N'TARAKLI', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (660, N'FERİZLİ', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (661, N'KARAPÜRÇEK', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (662, N'SÖĞÜTLÜ', 54, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (663, N'ALAÇAM', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (664, N'BAFRA', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (665, N'ÇARŞAMBA', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (666, N'HAVZA', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (667, N'KAVAK', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (668, N'LADİK', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (669, N'SAMSUN MERKEZ', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (670, N'TERME', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (671, N'VEZİRKÖPRÜ', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (672, N'ASARCIK', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (673, N'ONDOKUZMAYIS', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (674, N'SALIPAZARI', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (675, N'TEKKEKÖY', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (676, N'AYVACIK', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (677, N'YAKAKENT', 55, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (678, N'AYANCIK', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (679, N'BOYABAT', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (680, N'SİNOP MERKEZ', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (681, N'DURAĞAN', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (682, N'ERGELEK', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (683, N'GERZE', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (684, N'TÜRKELİ', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (685, N'DİKMEN', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (686, N'SARAYDÜZÜ', 57, CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1400000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (687, N'DİVRİĞİ', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (688, N'GEMEREK', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (689, N'GÜRÜN', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (690, N'HAFİK', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (691, N'İMRANLI', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (692, N'KANGAL', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (693, N'KOYUL HİSAR', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (694, N'SİVAS MERKEZ', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (695, N'SU ŞEHRİ', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (696, N'ŞARKIŞLA', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (697, N'YILDIZELİ', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (698, N'ZARA', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (699, N'AKINCILAR', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (700, N'ALTINYAYLA', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (701, N'DOĞANŞAR', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (702, N'GÜLOVA', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (703, N'ULAŞ', 58, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (704, N'BAYKAN', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (705, N'ERUH', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (706, N'KURTALAN', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (707, N'PERVARİ', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (708, N'SİİRT MERKEZ', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (709, N'ŞİRVARİ', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (710, N'AYDINLAR', 56, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (711, N'TEKİRDAĞ MERKEZ', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (712, N'ÇERKEZKÖY', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (713, N'ÇORLU', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (714, N'HAYRABOLU', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (715, N'MALKARA', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (716, N'MURATLI', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (717, N'SARAY', 59, CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1433333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (718, N'ŞARKÖY', 59, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (719, N'MARAMARAEREĞLİSİ', 59, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (720, N'ALMUS', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (721, N'ARTOVA', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (722, N'TOKAT MERKEZ', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (723, N'ERBAA', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (724, N'NİKSAR', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (725, N'REŞADİYE', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (726, N'TURHAL', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (727, N'ZİLE', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (728, N'PAZAR', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (729, N'YEŞİLYURT', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (730, N'BAŞÇİFTLİK', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (731, N'SULUSARAY', 60, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (732, N'TRABZON MERKEZ', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (733, N'AKÇAABAT', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (734, N'ARAKLI', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (735, N'ARŞİN', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (736, N'ÇAYKARA', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (737, N'MAÇKA', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (738, N'OF', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (739, N'SÜRMENE', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (740, N'TONYA', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (741, N'VAKFIKEBİR', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (742, N'YOMRA', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (743, N'BEŞİKDÜZÜ', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (744, N'ŞALPAZARI', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (745, N'ÇARŞIBAŞI', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (746, N'DERNEKPAZARI', 61, CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1466667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (747, N'DÜZKÖY', 61, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (748, N'HAYRAT', 61, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (749, N'KÖPRÜBAŞI', 61, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (750, N'TUNCELİ MERKEZ', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (751, N'ÇEMİŞGEZEK', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (752, N'HOZAT', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (753, N'MAZGİRT', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (754, N'NAZİMİYE', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (755, N'OVACIK', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (756, N'PERTEK', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (757, N'PÜLÜMÜR', 62, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (758, N'BANAZ', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (759, N'EŞME', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (760, N'KARAHALLI', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (761, N'SİVASLI', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (762, N'ULUBEY', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (763, N'UŞAK MERKEZ', 64, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (764, N'BAŞKALE', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (765, N'VAN MERKEZ', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (766, N'EDREMİT', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (767, N'ÇATAK', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (768, N'ERCİŞ', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (769, N'GEVAŞ', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (770, N'GÜRPINAR', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (771, N'MURADİYE', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (772, N'ÖZALP', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (773, N'BAHÇESARAY', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (774, N'ÇALDIRAN', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (775, N'SARAY', 65, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (776, N'YALOVA MERKEZ', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (777, N'ALTINOVA', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (778, N'ARMUTLU', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (779, N'ÇINARCIK', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (780, N'ÇİFTLİKKÖY', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (781, N'TERMAL', 77, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (782, N'AKDAĞMADENİ', 66, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (783, N'BOĞAZLIYAN', 66, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (784, N'YOZGAT MERKEZ', 66, CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1500000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (785, N'ÇAYIRALAN', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (786, N'ÇEKEREK', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (787, N'SARIKAYA', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (788, N'SORGUN', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (789, N'ŞEFAATLI', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (790, N'YERKÖY', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (791, N'KADIŞEHRİ', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (792, N'SARAYKENT', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (793, N'YENİFAKILI', 66, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (794, N'ÇAYCUMA', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (795, N'DEVREK', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (796, N'ZONGULDAK MERKEZ', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (797, N'EREĞLİ', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (798, N'ALAPLI', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (799, N'GÖKÇEBEY', 67, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (800, N'ÇANAKKALE MERKEZ', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (801, N'AYVACIK', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (802, N'BAYRAMİÇ', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (803, N'BİGA', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (804, N'BOZCAADA', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (805, N'ÇAN', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (806, N'ECEABAT', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (807, N'EZİNE', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (808, N'LAPSEKİ', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (809, N'YENİCE', 17, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (810, N'ÇANKIRI MERKEZ', 18, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (811, N'ÇERKEŞ', 18, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (812, N'ELDİVAN', 18, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (813, N'ILGAZ', 18, CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1533333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (814, N'KURŞUNLU', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (815, N'ORTA', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (816, N'ŞABANÖZÜ', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (817, N'YAPRAKLI', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (818, N'ATKARACALAR', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (819, N'KIZILIRMAK', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (820, N'BAYRAMÖREN', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (821, N'KORGUN', 18, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (822, N'ALACA', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (823, N'BAYAT', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (824, N'ÇORUM MERKEZ', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (825, N'İKSİPLİ', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (826, N'KARGI', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (827, N'MECİTÖZÜ', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (828, N'ORTAKÖY', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (829, N'OSMANCIK', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (830, N'SUNGURLU', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (831, N'DODURGA', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (832, N'LAÇİN', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (833, N'OĞUZLAR', 19, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (834, N'ADALAR', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (835, N'BAKIRKÖY', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (836, N'BEŞİKTAŞ', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (837, N'BEYKOZ', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (838, N'BEYOĞLU', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (839, N'ÇATALCA', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (840, N'EMİNÖNÜ', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (841, N'EYÜP', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (842, N'FATİH', 34, CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2), CAST(N'2022-06-17T17:11:11.1566667' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (843, N'GAZİOSMANPAŞA', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (844, N'KADIKÖY', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (845, N'KARTAL', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (846, N'SARIYER', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (847, N'SİLİVRİ', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (848, N'ŞİLE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (849, N'ŞİŞLİ', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (850, N'ÜSKÜDAR', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (851, N'ZEYTİNBURNU', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (852, N'BÜYÜKÇEKMECE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (853, N'KAĞITHANE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (854, N'KÜÇÜKÇEKMECE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (855, N'PENDİK', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (856, N'ÜMRANİYE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (857, N'BAYRAMPAŞA', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (858, N'AVCILAR', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (859, N'BAĞCILAR', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (860, N'BAHÇELİEVLER', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (861, N'GÜNGÖREN', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (862, N'MALTEPE', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (863, N'SULTANBEYLİ', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (864, N'TUZLA', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (865, N'ESENLER', 34, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (866, N'ALİAĞA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (867, N'BAYINDIR', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (868, N'BERGAMA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (869, N'BORNOVA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (870, N'ÇEŞME', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (871, N'DİKİLİ', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (872, N'FOÇA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (873, N'KARABURUN', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (874, N'KARŞIYAKA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (875, N'KEMALPAŞA', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (876, N'KINIK', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (877, N'KİRAZ', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (878, N'MENEMEN', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (879, N'ÖDEMİŞ', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (880, N'SEFERİHİSAR', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (881, N'SELÇUK', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (882, N'TİRE', 35, CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2), CAST(N'2022-06-17T17:11:11.1600000' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (883, N'TORBALI', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (884, N'URLA', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (885, N'BEYDAĞ', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (886, N'BUCA', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (887, N'KONAK', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (888, N'MENDERES', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (889, N'BALÇOVA', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (890, N'ÇİGLİ', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (891, N'GAZİEMİR', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (892, N'NARLIDERE', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (893, N'GÜZELBAHÇE', 35, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (894, N'ŞANLIURFA MERKEZ', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (895, N'AKÇAKALE', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (896, N'BİRECİK', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (897, N'BOZOVA', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (898, N'CEYLANPINAR', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (899, N'HALFETİ', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
GO
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (900, N'HİLVAN', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (901, N'SİVEREK', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (902, N'SURUÇ', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (903, N'VİRANŞEHİR', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (904, N'HARRAN', 63, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (905, N'BEYTÜŞŞEBAP', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (906, N'ŞIRNAK MERKEZ', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (907, N'CİZRE', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (908, N'İDİL', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (909, N'SİLOPİ', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (910, N'ULUDERE', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
INSERT [dbo].[Districts] ([Id], [DistrictName], [CityId], [CreateTime], [UpdateTime]) VALUES (911, N'GÜÇLÜKONAK', 73, CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2), CAST(N'2022-06-17T17:11:11.1633333' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Districts] OFF
GO
SET IDENTITY_INSERT [dbo].[Genus] ON 

INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (1, N'Amerikan Shorthair', CAST(N'2022-06-25T23:39:28.0648987' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649002' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (2, N'American Curl', CAST(N'2022-06-25T23:39:28.0649004' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649004' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (3, N'Balinese', CAST(N'2022-06-25T23:39:28.0649006' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649006' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (4, N'California Spangled', CAST(N'2022-06-25T23:39:28.0649007' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649008' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (5, N'Chartreux', CAST(N'2022-06-25T23:39:28.0649009' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649010' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (6, N'Ragdoll Kedisi', CAST(N'2022-06-25T23:39:28.0649014' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649014' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (7, N'Mavi Rus kedisi', CAST(N'2022-06-25T23:39:28.0649015' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649016' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (8, N'Maine Coon', CAST(N'2022-06-25T23:39:28.0649017' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649018' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (9, N'İran kedisi', CAST(N'2022-06-25T23:39:28.0649019' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649019' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (10, N'British Shorthair', CAST(N'2022-06-25T23:39:28.0649021' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649021' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (11, N'California Spangled', CAST(N'2022-06-25T23:39:28.0649022' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649023' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (12, N'Munchkin', CAST(N'2022-06-25T23:39:28.0649024' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649025' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (13, N'Scottish Fold', CAST(N'2022-06-25T23:39:28.0649026' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649026' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (14, N'Norveç Orman Kedisi', CAST(N'2022-06-25T23:39:28.0649027' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649028' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (15, N'Sibirya Kedisi', CAST(N'2022-06-25T23:39:28.0649029' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649030' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (16, N'Savannah', CAST(N'2022-06-25T23:39:28.0649031' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649031' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (17, N'Amerikan Kedisi', CAST(N'2022-06-25T23:39:28.0649033' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649033' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (18, N'Exotic Shorthair', CAST(N'2022-06-25T23:39:28.0649034' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649035' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (19, N'Ankara kedisi', CAST(N'2022-06-25T23:39:28.0649036' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649036' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (20, N'Himalayan Kedisi', CAST(N'2022-06-25T23:39:28.0649037' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649038' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (21, N'Kısa Tüylü Kedi', CAST(N'2022-06-25T23:39:28.0649039' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649040' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (22, N'Birman Kedisi', CAST(N'2022-06-25T23:39:28.0649041' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649041' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (23, N'Habeş Kedisi', CAST(N'2022-06-25T23:39:28.0649094' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649095' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (24, N'Bombay Kedisi', CAST(N'2022-06-25T23:39:28.0649096' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649097' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (25, N'Kinkalow', CAST(N'2022-06-25T23:39:28.0649098' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649099' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (26, N'Oriental Shorthair', CAST(N'2022-06-25T23:39:28.0649100' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649101' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (27, N'Ragamuffin', CAST(N'2022-06-25T23:39:28.0649102' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649102' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (28, N'Somali Kedisi', CAST(N'2022-06-25T23:39:28.0649103' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649104' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (29, N'Singapura', CAST(N'2022-06-25T23:39:28.0649105' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649106' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (30, N'British Longhair', CAST(N'2022-06-25T23:39:28.0649107' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649107' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (31, N'Toyger', CAST(N'2022-06-25T23:39:28.0649108' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649109' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (32, N'Van Kedisi', CAST(N'2022-06-25T23:39:28.0649110' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649111' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (33, N'manks kedisi', CAST(N'2022-06-25T23:39:28.0649112' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649113' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (34, N'Donskoy Kedisi', CAST(N'2022-06-25T23:39:28.0649114' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649114' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (35, N'Havana kedisi', CAST(N'2022-06-25T23:39:28.0649115' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649116' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (36, N'Ocicat', CAST(N'2022-06-25T23:39:28.0649117' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649118' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (37, N'Balinese', CAST(N'2022-06-25T23:39:28.0649119' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649119' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (38, N'Laperm', CAST(N'2022-06-25T23:39:28.0649120' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649121' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (39, N'Selkirk Rex', CAST(N'2022-06-25T23:39:28.0649122' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649123' AS DateTime2), 1)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (40, N'Buldog', CAST(N'2022-06-25T23:39:28.0649124' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649124' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (41, N'Labrador retriever', CAST(N'2022-06-25T23:39:28.0649125' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649126' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (42, N'Alman çoban köpeği', CAST(N'2022-06-25T23:39:28.0649127' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649128' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (43, N'Kaniş', CAST(N'2022-06-25T23:39:28.0649129' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649130' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (44, N'Golden Retriever', CAST(N'2022-06-25T23:39:28.0649131' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649131' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (45, N'Chihuahua', CAST(N'2022-06-25T23:39:28.0649132' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649133' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (46, N'Fransız buldoğu', CAST(N'2022-06-25T23:39:28.0649134' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649135' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (47, N'Bişon çuha köpeği', CAST(N'2022-06-25T23:39:28.0649136' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649136' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (48, N'Boksör', CAST(N'2022-06-25T23:39:28.0649137' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649138' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (49, N'Border collie', CAST(N'2022-06-25T23:39:28.0649139' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649140' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (50, N'Sibirya kurdu', CAST(N'2022-06-25T23:39:28.0649141' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649142' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (51, N'Pug', CAST(N'2022-06-25T23:39:28.0649143' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649143' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (52, N'Amerikan Staffordshire teriyeri', CAST(N'2022-06-25T23:39:28.0649144' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649145' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (53, N'Boston Terrier', CAST(N'2022-06-25T23:39:28.0649146' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649147' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (54, N'Cavalier King Charles Spaniel', CAST(N'2022-06-25T23:39:28.0649148' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649149' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (55, N'Pomeranian', CAST(N'2022-06-25T23:39:28.0649150' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649150' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (56, N'Yorkshire teriyeri', CAST(N'2022-06-25T23:39:28.0649151' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649152' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (57, N'Bull teriyer', CAST(N'2022-06-25T23:39:28.0649153' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649154' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (58, N'İngiliz Cocker Spaniel', CAST(N'2022-06-25T23:39:28.0649155' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649156' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (59, N'Amerikan Eskimo Köpeği', CAST(N'2022-06-25T23:39:28.0649157' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649158' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (60, N'Danua', CAST(N'2022-06-25T23:39:28.0649159' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649160' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (61, N'Malta köpeği', CAST(N'2022-06-25T23:39:28.0649161' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649161' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (62, N'Çov-çov', CAST(N'2022-06-25T23:39:28.0649162' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649163' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (63, N'Affenpinscher', CAST(N'2022-06-25T23:39:28.0649164' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649165' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (64, N'Basenji', CAST(N'2022-06-25T23:39:28.0649166' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649167' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (65, N'Dakhund', CAST(N'2022-06-25T23:39:28.0649168' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649168' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (66, N'Bretonya epanyölü', CAST(N'2022-06-25T23:39:28.0649169' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649170' AS DateTime2), 0)
INSERT [dbo].[Genus] ([Id], [GenusName], [CreateTime], [UpdateTime], [GenusType]) VALUES (67, N'Bulmastif', CAST(N'2022-06-25T23:39:28.0649171' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649172' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Genus] OFF
GO
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'ec7a7f98-3a14-494f-4b97-08da58741ce1', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656358493/xjfjkucyzbetc1qqoxnw.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656358493/xjfjkucyzbetc1qqoxnw.jpg', N'Deneme', NULL, NULL, CAST(N'2022-06-27T22:34:54.7937969' AS DateTime2), CAST(N'2022-06-27T22:34:54.7938317' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'e315b75f-8687-4d9b-5f5f-08da587460b6', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656358607/yxsbdy1ggui3z1qoymik.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656358607/yxsbdy1ggui3z1qoymik.jpg', N'Aslında çok şımarık', N'4c7016c2-840b-458c-5ca7-08da587460b4', N'515536f6-b0e9-46de-d63e-08da58747807', CAST(N'2022-06-27T22:36:48.8205368' AS DateTime2), CAST(N'2022-06-27T22:36:48.8205373' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'100fa5f9-dbd7-496d-ad9d-08da587cbca5', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362197/fzsht5yhzgi23qwmahn1.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362197/fzsht5yhzgi23qwmahn1.jpg', N'kedi1', N'2c1e963a-b241-4fa1-679b-08da587cbca3', N'62122537-c614-4f6b-7489-08da587cec7a', CAST(N'2022-06-27T23:36:39.0237431' AS DateTime2), CAST(N'2022-06-27T23:36:39.0238028' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'b6b10f1c-1b2b-4a03-ad9e-08da587cbca5', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362226/cx3b9ouf3c3fmpd93cwe.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362226/cx3b9ouf3c3fmpd93cwe.jpg', N'kedi2', N'e6a85426-cce1-464b-679c-08da587cbca3', N'0b767971-ba27-42f8-748a-08da587cec7a', CAST(N'2022-06-27T23:37:07.9156795' AS DateTime2), CAST(N'2022-06-27T23:37:07.9156807' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'ecc5574e-2d4b-4a54-ad9f-08da587cbca5', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362244/scfykkyhriyp4qatnndz.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362244/scfykkyhriyp4qatnndz.jpg', N'232321', N'4bd0e44b-9bd2-4fef-679d-08da587cbca3', N'2a512e6b-fa70-454a-748b-08da587cec7a', CAST(N'2022-06-27T23:37:27.1216147' AS DateTime2), CAST(N'2022-06-27T23:37:27.1216155' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'4625e96a-f2c2-47ee-ada0-08da587cbca5', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362266/vo7ocbacayqtypnskvsk.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656362266/vo7ocbacayqtypnskvsk.jpg', N'kadirrr', N'057ef613-30b1-4bde-679e-08da587cbca3', N'499e9efb-a366-448f-748c-08da587cec7a', CAST(N'2022-06-27T23:37:47.7236764' AS DateTime2), CAST(N'2022-06-27T23:37:47.7236770' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'9f119e99-b95e-4d3c-a3fd-08da59070ce2', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656421600/zqizspzieywfkdp5anyo.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656421600/zqizspzieywfkdp5anyo.jpg', N'güzelim', N'6b2f4bb1-1de1-4660-fa7b-08da59070ce0', N'92254316-047a-483d-50e7-08da59071952', CAST(N'2022-06-28T16:06:44.1952972' AS DateTime2), CAST(N'2022-06-28T16:06:44.1953329' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'ed1549f1-2f4d-40e2-cd34-08da593bb2d3', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656444214/duipppdjsvihyxproa8r.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656444214/duipppdjsvihyxproa8r.jpg', N'uçuyom şahitlerim var ', N'7e815042-1e12-4167-247f-08da593bb2d2', N'98d8b5ce-a279-44fc-ad52-08da593bbf6a', CAST(N'2022-06-28T22:23:36.4297202' AS DateTime2), CAST(N'2022-06-28T22:23:36.4297617' AS DateTime2), NULL)
INSERT [dbo].[Images] ([Id], [ImagePath], [Url], [ImageDescription], [LivingId], [AdvertId], [CreateTime], [UpdateTime], [ImageUserId]) VALUES (N'e50bc948-0c19-4974-8a63-08da5a91813d', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656591018/ly7luanwyg6zaissblgo.jpg', N'http://res.cloudinary.com/dfp82ddmt/image/upload/v1656591018/ly7luanwyg6zaissblgo.jpg', N'denemeokul', N'a5c88557-43d8-4c9a-aa9c-08da5a91813b', N'06e1e7ed-c3b8-4d71-4c4c-08da5a91b178', CAST(N'2022-06-30T15:10:21.1156602' AS DateTime2), CAST(N'2022-06-30T15:10:21.1157246' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Kinds] ON 

INSERT [dbo].[Kinds] ([Id], [CreateTime], [UpdateTime], [Team], [Familya], [KindName]) VALUES (1, CAST(N'2022-06-25T23:39:28.0649467' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649469' AS DateTime2), 0, 0, N'Kedi')
INSERT [dbo].[Kinds] ([Id], [CreateTime], [UpdateTime], [Team], [Familya], [KindName]) VALUES (2, CAST(N'2022-06-25T23:39:28.0649470' AS DateTime2), CAST(N'2022-06-25T23:39:28.0649471' AS DateTime2), 2, 1, N'Köpek')
SET IDENTITY_INSERT [dbo].[Kinds] OFF
GO
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'4c7016c2-840b-458c-5ca7-08da587460b4', N'Halley', 1, 1, 1, 13, CAST(N'2022-06-27T22:36:48.8207544' AS DateTime2), CAST(N'2022-06-27T22:36:48.8207849' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'2c1e963a-b241-4fa1-679b-08da587cbca3', N'Halley1', 1, 3, 1, 17, CAST(N'2022-06-27T23:36:39.0240935' AS DateTime2), CAST(N'2022-06-27T23:36:39.0241475' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'e6a85426-cce1-464b-679c-08da587cbca3', N'Halley2', 1, 2, 1, 19, CAST(N'2022-06-27T23:37:07.9156837' AS DateTime2), CAST(N'2022-06-27T23:37:07.9156838' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'4bd0e44b-9bd2-4fef-679d-08da587cbca3', N'Halley3', 0, 2, 1, 19, CAST(N'2022-06-27T23:37:27.1216177' AS DateTime2), CAST(N'2022-06-27T23:37:27.1216177' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'057ef613-30b1-4bde-679e-08da587cbca3', N'Halley4', 1, 2, 1, 19, CAST(N'2022-06-27T23:37:47.7236787' AS DateTime2), CAST(N'2022-06-27T23:37:47.7236788' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'6b2f4bb1-1de1-4660-fa7b-08da59070ce0', N'Masum2', 1, 3, 1, 14, CAST(N'2022-06-28T16:06:44.1955927' AS DateTime2), CAST(N'2022-06-28T16:06:44.1956226' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'7e815042-1e12-4167-247f-08da593bb2d2', N'masum ', 1, 5, 1, 6, CAST(N'2022-06-28T22:23:36.4300086' AS DateTime2), CAST(N'2022-06-28T22:23:36.4300399' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
INSERT [dbo].[Livings] ([Id], [LivingName], [LivingGender], [LivingAge], [KindId], [GenusId], [CreateTime], [UpdateTime], [UserId]) VALUES (N'a5c88557-43d8-4c9a-aa9c-08da5a91813b', N'masum4', 1, 3, 1, 13, CAST(N'2022-06-30T15:10:21.1160831' AS DateTime2), CAST(N'2022-06-30T15:10:21.1161282' AS DateTime2), N'7ce220a8-dda7-4dbc-a6d6-9f72c553fb94')
GO
ALTER TABLE [dbo].[Adverts] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [LivingId]
GO
ALTER TABLE [dbo].[Cities] ADD  CONSTRAINT [DF_Cities_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Cities] ADD  CONSTRAINT [DF_Cities_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
ALTER TABLE [dbo].[Districts] ADD  CONSTRAINT [DF_Districts_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Districts] ADD  CONSTRAINT [DF_Districts_UpdateTime]  DEFAULT (getdate()) FOR [UpdateTime]
GO
ALTER TABLE [dbo].[Genus] ADD  DEFAULT (CONVERT([bit],(0))) FOR [GenusType]
GO
ALTER TABLE [dbo].[Kinds] ADD  DEFAULT (N'') FOR [KindName]
GO
ALTER TABLE [dbo].[Livings] ADD  DEFAULT (N'') FOR [UserId]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Cities_CityId]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Districts_DistrictId] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Districts_DistrictId]
GO
ALTER TABLE [dbo].[Adverts]  WITH CHECK ADD  CONSTRAINT [FK_Adverts_Addresses_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[Adverts] CHECK CONSTRAINT [FK_Adverts_Addresses_AddressId]
GO
ALTER TABLE [dbo].[Adverts]  WITH CHECK ADD  CONSTRAINT [FK_Adverts_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Adverts] CHECK CONSTRAINT [FK_Adverts_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Adverts]  WITH CHECK ADD  CONSTRAINT [FK_Adverts_Livings_LivingId] FOREIGN KEY([LivingId])
REFERENCES [dbo].[Livings] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Adverts] CHECK CONSTRAINT [FK_Adverts_Livings_LivingId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_Addresses_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_Addresses_AddressId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Districts]  WITH CHECK ADD  CONSTRAINT [FK_Districts_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Districts] CHECK CONSTRAINT [FK_Districts_Cities_CityId]
GO
ALTER TABLE [dbo].[Favorites]  WITH CHECK ADD  CONSTRAINT [FK_Favorites_Adverts_AdvertId] FOREIGN KEY([AdvertId])
REFERENCES [dbo].[Adverts] ([Id])
GO
ALTER TABLE [dbo].[Favorites] CHECK CONSTRAINT [FK_Favorites_Adverts_AdvertId]
GO
ALTER TABLE [dbo].[FavoriteUser]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteUser_AspNetUsers_UsersId] FOREIGN KEY([UsersId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[FavoriteUser] CHECK CONSTRAINT [FK_FavoriteUser_AspNetUsers_UsersId]
GO
ALTER TABLE [dbo].[FavoriteUser]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteUser_Favorites_FavoritesId] FOREIGN KEY([FavoritesId])
REFERENCES [dbo].[Favorites] ([Id])
GO
ALTER TABLE [dbo].[FavoriteUser] CHECK CONSTRAINT [FK_FavoriteUser_Favorites_FavoritesId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Adverts_AdvertId] FOREIGN KEY([AdvertId])
REFERENCES [dbo].[Adverts] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Adverts_AdvertId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_AspNetUsers_ImageUserId] FOREIGN KEY([ImageUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_AspNetUsers_ImageUserId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Livings_LivingId] FOREIGN KEY([LivingId])
REFERENCES [dbo].[Livings] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Livings_LivingId]
GO
ALTER TABLE [dbo].[Livings]  WITH CHECK ADD  CONSTRAINT [FK_Livings_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Livings] CHECK CONSTRAINT [FK_Livings_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Livings]  WITH CHECK ADD  CONSTRAINT [FK_Livings_Genus_GenusId] FOREIGN KEY([GenusId])
REFERENCES [dbo].[Genus] ([Id])
GO
ALTER TABLE [dbo].[Livings] CHECK CONSTRAINT [FK_Livings_Genus_GenusId]
GO
ALTER TABLE [dbo].[Livings]  WITH CHECK ADD  CONSTRAINT [FK_Livings_Kinds_KindId] FOREIGN KEY([KindId])
REFERENCES [dbo].[Kinds] ([Id])
GO
ALTER TABLE [dbo].[Livings] CHECK CONSTRAINT [FK_Livings_Kinds_KindId]
GO
