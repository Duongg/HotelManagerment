USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 3/24/2019 10:20:21 PM ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotel', N'ON'
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/24/2019 10:20:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 3/24/2019 10:20:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking](
	[bookingID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [varchar](50) NOT NULL,
	[roomNo] [varchar](50) NOT NULL,
	[checkindate] [date] NOT NULL,
	[checkoutdate] [date] NOT NULL,
	[totalpay] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[prepay] [float] NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[bookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/24/2019 10:20:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 3/24/2019 10:20:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payment](
	[paymentID] [int] IDENTITY(1,1) NOT NULL,
	[bookingID] [int] NOT NULL,
	[customerID] [varchar](50) NOT NULL,
	[roomNo] [varchar](50) NOT NULL,
	[totalday] [int] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[paymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 3/24/2019 10:20:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[roomNo] [varchar](50) NOT NULL,
	[roomtype] [varchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[status] [bit] NOT NULL,
	[description] [varchar](10) NULL,
 CONSTRAINT [PK_Room_1] PRIMARY KEY CLUSTERED 
(
	[roomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([Username], [Password], [Role]) VALUES (N'Duong', N'123', 1)
INSERT [dbo].[Account] ([Username], [Password], [Role]) VALUES (N'Nghia', N'234', 0)
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (1, N'123', N'D234', CAST(N'2019-03-23' AS Date), CAST(N'2019-03-29' AS Date), 686679, 0, 232)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (2, N'123', N'D255', CAST(N'2019-03-23' AS Date), CAST(N'2019-03-23' AS Date), 23423, 0, 34)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (3, N'123', N'S122', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-27' AS Date), 972702, 0, 3)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (4, N'2222', N'S123', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-25' AS Date), 3213548, 0, 2323)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (5, N'1234', N'D234', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-29' AS Date), 588582, 0, 2323)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (6, N'123', N'qwqe', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 123, 0, 23)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (7, N'123', N'D255', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 23423, 0, 34)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (8, N'123', N'qwqe', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 123, 0, 23)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (9, N'123', N'D234', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 98097, 0, 23)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (10, N'1234', N'D255', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 23423, 0, 23)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (11, N'1234', N'D234', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 98097, 0, 123)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (12, N'1234', N'D234', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 98097, 1, 123)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (13, N'123', N'D255', CAST(N'2019-03-24' AS Date), CAST(N'2019-03-24' AS Date), 23423, 0, 213)
INSERT [dbo].[Booking] ([bookingID], [customerID], [roomNo], [checkindate], [checkoutdate], [totalpay], [status], [prepay]) VALUES (14, N'1234567890', N'S123', CAST(N'2019-03-05' AS Date), CAST(N'2019-03-24' AS Date), 6160446, 1, 0)
SET IDENTITY_INSERT [dbo].[Booking] OFF
INSERT [dbo].[Customer] ([customerID], [name], [phone], [birthday]) VALUES (N'123', N'nghia', N'123123123123', CAST(N'2019-03-23' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [phone], [birthday]) VALUES (N'1234', N'as', N'123123', CAST(N'2019-03-24' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [phone], [birthday]) VALUES (N'1234567890', N'Duong', N'0987654321', CAST(N'2019-03-05' AS Date))
INSERT [dbo].[Customer] ([customerID], [name], [phone], [birthday]) VALUES (N'2222', N'gia', N'123123', CAST(N'1998-12-16' AS Date))
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (1, 1, N'123', N'D234', 7, 686679)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (2, 1, N'123', N'D234', 7, 686679)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (3, 4, N'2222', N'S123', 2, 3213548)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (4, 2, N'123', N'D255', 1, 23423)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (5, 3, N'123', N'S122', 4, 972702)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (6, 5, N'1234', N'D234', 6, 588582)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (7, 6, N'123', N'qwqe', 1, 123)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (8, 6, N'123', N'qwqe', 1, 123)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (9, 6, N'123', N'qwqe', 1, 123)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (10, 6, N'123', N'qwqe', 1, 123)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (11, 7, N'123', N'D255', 1, 23423)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (12, 7, N'123', N'D255', 1, 23423)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (13, 8, N'123', N'qwqe', 1, 123)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (14, 9, N'123', N'D234', 1, 98097)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (15, 10, N'1234', N'D255', 1, 23423)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (16, 11, N'1234', N'D234', 1, 98097)
INSERT [dbo].[Payment] ([paymentID], [bookingID], [customerID], [roomNo], [totalday], [total]) VALUES (17, 13, N'123', N'D255', 1, 23423)
SET IDENTITY_INSERT [dbo].[Payment] OFF
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'D234', N'double', 98097, 1, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'D255', N'double', 23423, 1, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'P069', N'double', 595959, 1, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'P092', N'twin', 9000000, 0, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'P906', N'single', 200000, 1, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'qwqe', N'single', 123, 1, N'123')
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'S122', N'single', 324234, 1, NULL)
INSERT [dbo].[Room] ([roomNo], [roomtype], [price], [status], [description]) VALUES (N'S123', N'single', 3213548, 0, N'')
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Customer]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Room1] FOREIGN KEY([roomNo])
REFERENCES [dbo].[Room] ([roomNo])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Room1]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Booking] FOREIGN KEY([bookingID])
REFERENCES [dbo].[Booking] ([bookingID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Booking]
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
