USE [Db_Login]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 10/11/2019 11:11:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Kin_Name] [nvarchar](50) NOT NULL,
	[Kin_Phone] [nvarchar](50) NOT NULL,
	[Amount] [nvarchar](50) NOT NULL,
	[Vehicle_No] [nvarchar](50) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Seat_No] [int] NOT NULL,
	[Destination] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Code] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/11/2019 11:11:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[LastLogin] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (17, N'dfghjk', N'dfghj@fghjkl.com', N'3456789', N'ertyufgh', N'sderftgyhujiko', N'234567', N'3456', N'KLK-380-XA', N'Monday, 7 October 2019', 6, N'LAGOS - ASABA', N'Male', 8370)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (18, N'dfghjk', N'vbnmo@gtyhujk.fghj', N'56789', N'dfghjk', N'fgtyhujikol', N'234567', N' NGN 4567.00', N'KLK-380-XA', N'Monday, 7 October 2019', 9, N'LAGOS - BAYELSA', N'Female', 3839)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (19, N'olusegun olaniyi', N'bababtundeolusegun@outlook.com', N'07068550755', N'33 shagamu road ikorodu lagos ', N'sehor', N'08090410535', N' NGN 5000.00', N'APP-162-XS', N'Friday, 11 October 2019', 8, N'LAGOS - BAYELSA', N'Male', 5326)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (20, N'ertyuio', N'fghjk@yuiohyuj.hj', N'345678', N'ghyujikol', N'drgthyujki', N'2345678', N' NGN 4567.00', N'APP-163-XS', N'Saturday, 19 October 2019', 11, N'LAGOS - WARRI', N'Female', 2079)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1017, N'babatunde olusegun olaniyi', N'babatundeolusegun@yahoo.com', N'08090410537', N'ikorodu lagos', N'eshor', N'08090410535', N' NGN 6000.00', N'APP-163-XS', N'Saturday, 19 October 2019', 12, N'LAGOS - BAYELSA', N'Male', 6898)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1018, N'rtyuio', N'tyuiop@tyuio.fgh', N'456789045678', N'yuiopdrfgthyjk', N'ertyuikollkjhg', N'2345678900987', N' NGN 6000.00', N'APP-163-XS', N'Saturday, 19 October 2019', 6, N'LAGOS - WARRI', N'Female', 8516)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1019, N'wertyui', N'dfghjk@dfghj.fgh', N'34567890', N'sdfghjklkjh', N'dfghjklkjhg', N'3456789876545678', N' NGN 6000.00', N'KLK-383-XA', N'Saturday, 19 October 2019', 3, N'LAGOS - BAYELSA', N'Male', 5765)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1020, N'wsedrftghyujk', N'derftghy@rty.ghj', N'345678', N'edrftgyhujik', N'sdfghjk', N'2345678', N' NGN 234567.00', N'APP-163-XS', N'Saturday, 19 October 2019', 2, N'LAGOS - BAYELSA', N'Female', 5871)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1021, N'wertyuio', N'ertyui@rtyui.frgh', N'2345678', N'dfghjk', N'ertyuiko', N'345678', N' NGN 4567.00', N'APP-163-XS', N'Saturday, 19 October 2019', 5, N'LAGOS - WARRI', N'Female', 3965)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1022, N'wertyuio', N'ertyui@rtyui.frgh', N'2345678', N'dfghjk', N'ertyuiko', N'345678', N' NGN 4567.00', N'APP-163-XS', N'Saturday, 19 October 2019', 7, N'LAGOS - WARRI', N'Female', 4788)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1023, N'wertyui', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 15, N'LAGOS - UGHELLI', N'Male', 6857)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1024, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 1, N'LAGOS - UGHELLI', N'Male', 1497)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1025, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 3, N'LAGOS - UGHELLI', N'Male', 1541)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1026, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 4, N'LAGOS - UGHELLI', N'Male', 5632)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1027, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 8, N'LAGOS - UGHELLI', N'Male', 6135)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1028, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 10, N'LAGOS - UGHELLI', N'Male', 1200)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1029, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 9, N'LAGOS - UGHELLI', N'Male', 5293)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1030, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 13, N'LAGOS - UGHELLI', N'Male', 4785)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1031, N'olatunde jonhson', N'ertyuio@rftgyh.gthj', N'2345675678', N'wertyuiopertyu', N'asdfghjkl', N'234567898765', N' NGN 56789.00', N'APP-163-XS', N'Saturday, 19 October 2019', 14, N'LAGOS - UGHELLI', N'Male', 4983)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1032, N'qwertyui', N'sdfghj@fgh.fghj', N'2345678', N'sdfghjk', N'edrftyuio', N'23456789', N' NGN 3456.00', N'APP-124-XS', N'Saturday, 19 October 2019', 14, N'LAGOS - ASABA', N'Female', 9087)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1033, N'babatunde rosemary', N'babatunderosemary@gmail.com', N'07068550755', N'ikorodu', N'babatunde olusegun', N'08090410537', N' NGN 5000.00', N'APP-162-XS', N'Thursday, 10 October 2019', 14, N'LAGOS  -  PHC', N'Female', 7624)
INSERT [dbo].[Booking] ([Id], [Name], [Email], [Phone], [Address], [Kin_Name], [Kin_Phone], [Amount], [Vehicle_No], [Date], [Seat_No], [Destination], [Gender], [Code]) VALUES (1034, N'babatunde', N'bababtunde@yahoo.com', N'07068550755', N'ikorodu lagos', N'mercy', N'08090410535', N' NGN 5000.00', N'KLK-380-XA', N'Sunday, 10 November 2019', 5, N'LAGOS - BAYELSA', N'Male', 1386)
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [LastLogin]) VALUES (1, N'barez     ', N'bare      ', NULL)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [LastLogin]) VALUES (2, N'admin     ', N'admin     ', N'Nov 10 2019  8:37AM')
SET IDENTITY_INSERT [dbo].[Users] OFF
