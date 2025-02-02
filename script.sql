USE [master]
GO
/****** Object:  Database [AttendanceSystem]    Script Date: 14/12//2023 3:38:18 PM ******/
CREATE DATABASE [AttendanceSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AttendanceSystem', FILENAME = N'E:\IT\Setup\MSSQL16.DUONGHOANG\MSSQL\DATA\AttendanceSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AttendanceSystem_log', FILENAME = N'E:\IT\Setup\MSSQL16.DUONGHOANG\MSSQL\DATA\AttendanceSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AttendanceSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AttendanceSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AttendanceSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AttendanceSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AttendanceSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AttendanceSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AttendanceSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [AttendanceSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AttendanceSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AttendanceSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AttendanceSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AttendanceSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AttendanceSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AttendanceSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AttendanceSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AttendanceSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AttendanceSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AttendanceSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AttendanceSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AttendanceSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AttendanceSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AttendanceSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AttendanceSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AttendanceSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AttendanceSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [AttendanceSystem] SET  MULTI_USER 
GO
ALTER DATABASE [AttendanceSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AttendanceSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AttendanceSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AttendanceSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AttendanceSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AttendanceSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AttendanceSystem', N'ON'
GO
ALTER DATABASE [AttendanceSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [AttendanceSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AttendanceSystem]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[student_name] [varchar](50) NULL,
	[major_id] [bigint] NULL,
	[schedule_id] [bigint] NULL,
	[class_id] [bigint] NULL,
	[status] [varchar](50) NULL,
	[date] [datetime] NULL,
	[birthday] [datetime] NULL,
	[gender] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[role_id] [bigint] NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[class_name] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Majors]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Majors](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[major_name] [varchar](50) NULL,
	[teacher_name] [varchar](50) NULL,
	[description] [varchar](200) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_Majors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
	[start_end] [varchar](50) NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14/12//2023 3:38:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[email] [varchar](200) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role_id] [bigint] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Attendance] ON 

INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (1, N'Nguyen Van Manh', 1, 3, 3, N'Absent', CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2004-07-06T00:00:00.000' AS DateTime), N'Male', N'03278585', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (6, N'Nguyen Phuong Thao', 2, 2, 3, N'Present', CAST(N'2023-06-24T00:00:00.000' AS DateTime), CAST(N'2005-02-06T00:00:00.000' AS DateTime), N'Female', N'064236735', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (7, N'Nguyen Thanh Binh', 1, 3, 1, N'Present', CAST(N'2023-12-12T00:00:00.000' AS DateTime), CAST(N'2004-07-15T00:00:00.000' AS DateTime), N'Female', N'03278585', N'Thai Nguyen', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (8, N'Hoang Hai Quan', 3, 3, 1, N'Absent', CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2005-07-06T00:00:00.000' AS DateTime), N'Male', N'0642543', N'Bac Giang', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (10, N'Tran Hoai Anh', 1, 3, 2, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-15T00:00:00.000' AS DateTime), N'Female', N'03278585', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (11, N'Nguyen Van Tai', 2, 3, 3, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-09-02T00:00:00.000' AS DateTime), N'Male', N'03263', N'Hai Duong', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (12, N'Hoang Hai Duong', 1, 3, 2, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-12T00:00:00.000' AS DateTime), N'Male', N'03278585', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (13, N'Nguyen Thi Kim Anh', 2, 3, 3, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-08T00:00:00.000' AS DateTime), N'Female', N'03278585', N'Thai Binh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (14, N'Hoang Thanh Tu', 2, 3, 1, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-17T00:00:00.000' AS DateTime), N'Female', N'032785545', N'Nam Dinh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (15, N'Tran Huu Phuc', 3, 3, 3, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-15T00:00:00.000' AS DateTime), N'Male', N'0334754436', N'Hai Duong', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (16, N'Nguyen Thai Nguyen', 1, 3, 2, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2001-04-11T00:00:00.000' AS DateTime), N'Male', N'03278585', N'Thai Binh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (27, N'Hoang Vinh Phuc', 2, 2, 1, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-08-24T00:00:00.000' AS DateTime), N'Male', N'032734534', N'Thai Nguyen', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (28, N'Hoang Thanh Tu', 3, 1, 1, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2004-07-17T00:00:00.000' AS DateTime), N'Female', N'032785545', N'Nam Dinh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (29, N'Hoang Thanh Tu', 3, 2, 1, N'Present', CAST(N'2020-03-03T00:00:00.000' AS DateTime), CAST(N'2004-07-17T00:00:00.000' AS DateTime), N'Female', N'032785545', N'Nam Dinh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (30, N'Nguyen Van Manh', 2, 3, 3, N'Absent', CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2004-07-06T00:00:00.000' AS DateTime), N'Male', N'03278585', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (31, N'Nguyen Thanh Thao', 3, 1, 3, N'Present', CAST(N'2023-12-07T20:46:31.440' AS DateTime), CAST(N'2005-07-07T00:00:00.000' AS DateTime), N'Male', N'064236735', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (32, N'Hoang Thanh Tu', 1, 1, 1, N'Absent', CAST(N'2023-01-17T00:00:00.000' AS DateTime), CAST(N'2004-07-17T00:00:00.000' AS DateTime), N'Female', N'032785545', N'Nam Dinh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (38, N'Nguyen Van Manh', 3, 2, 3, N'Present', CAST(N'2022-06-15T00:00:00.000' AS DateTime), CAST(N'2004-07-06T00:00:00.000' AS DateTime), N'Female', N'03278585', N'Thai Nguyen', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (39, N'Hoang Thanh Tu', 1, 1, 1, N'Present', CAST(N'2019-08-20T00:00:00.000' AS DateTime), CAST(N'2004-07-17T00:00:00.000' AS DateTime), N'Female', N'032785545', N'Nam Dinh', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (40, N'Nguyen Thanh Thao', 1, 2, 3, N'Absent', CAST(N'2021-06-18T00:00:00.000' AS DateTime), CAST(N'2005-07-07T00:00:00.000' AS DateTime), N'Male', N'064236735', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (41, N'Hoang Hai Quan', 1, 3, 6, N'Present', CAST(N'2021-06-18T00:00:00.000' AS DateTime), CAST(N'2005-07-06T00:00:00.000' AS DateTime), N'Male', N'0642543', N'Bac Giang', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (43, N'Nguyen Van Manh', 1, 3, 3, N'Absent', CAST(N'2023-12-10T00:00:00.000' AS DateTime), CAST(N'2004-07-06T00:00:00.000' AS DateTime), N'Male', N'03278585', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (44, N'Nguyen Van Manh', 10002, 2, 3, N'Absent', CAST(N'2023-12-11T00:00:00.000' AS DateTime), CAST(N'2004-07-06T00:00:00.000' AS DateTime), N'Male', N'047328675', N'Ha Noi', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (46, N'Nguyen Van A', 10003, 1, 3, N'Present', CAST(N'2023-12-12T00:00:00.000' AS DateTime), CAST(N'2022-01-11T00:00:00.000' AS DateTime), N'Female', N'15615616', N'Thanh hoa', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (47, N'Duong De Ngu', 10004, 2, 7, NULL, NULL, CAST(N'2000-11-08T00:00:00.000' AS DateTime), N'Male', N'8874379384', N'Thanh Hoa', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (48, N'fwe', 1, 1, 1, NULL, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), N'Male', N'45', N'gedrge', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (49, N'vdf', 1, 1, 1, NULL, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), N'Female', N'435', N'4greg', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (50, N'Nguyen Manh Hng', 1, 1, 4, NULL, NULL, CAST(N'2023-12-13T00:00:00.000' AS DateTime), N'Male', N'354', N'grrg', 2)
INSERT [dbo].[Attendance] ([id], [student_name], [major_id], [schedule_id], [class_id], [status], [date], [birthday], [gender], [phone], [address], [role_id]) VALUES (51, N'hed', 1, 1, 1, NULL, NULL, CAST(N'2023-12-14T00:00:00.000' AS DateTime), N'Male', N'6563', N'gdfb', 2)
SET IDENTITY_INSERT [dbo].[Attendance] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (1, N'SE01', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (2, N'SE02', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (3, N'SE03', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (4, N'SE04', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (5, N'SE05', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (6, N'SE06', N'35')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (7, N'SE07', N'36')
INSERT [dbo].[Class] ([id], [class_name], [quantity]) VALUES (8, N'SEO8', N'39')
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[Majors] ON 

INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (1, N'Database Design Development', N'Nguyen Thanh Trieu', N'Thiet ke du lieu database', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (2, N'Processional Practical', N'Ngo Thuy Quynh', N'Luyen tap ki nang ca nhan, team works', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (3, N'Project Planning', N'Nguyen Trong Hung', N'Len ke hoach cho mot du an ca nhan', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (10002, N'Networking', N'Nguyen Manh Hung', N'Co ban ve ket noi va bao mat mang', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (10003, N'PDP', N'Nguyen Van Dong', N'Phat trien ban than mot cach tot nhat', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (10004, N'Marketing', N'Nguyen Van Hieu', N'Truyen thong ', N'Active')
INSERT [dbo].[Majors] ([id], [major_name], [teacher_name], [description], [status]) VALUES (10005, N'Logistic', N'Huan Hoa Hoe', N'Van Chuyen chat cam ma tuy', N'Active')
SET IDENTITY_INSERT [dbo].[Majors] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([id], [name]) VALUES (2, N'Student')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 

INSERT [dbo].[Schedule] ([id], [name], [start_end]) VALUES (1, N'Slot 1    ', N'7:30 - 11:30 am')
INSERT [dbo].[Schedule] ([id], [name], [start_end]) VALUES (2, N'Slot 2    ', N'12:30 - 16:30 pm')
INSERT [dbo].[Schedule] ([id], [name], [start_end]) VALUES (3, N'Slot 3    ', N'17:00 - 21:00 Pm')
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (1, N'Nguyen Xuan Huy', N'Male', N'huy@gmail.com', N'huy', N'1', 1)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (2, N'Hoang Cuu Bao', N'Female', N'cuubao@gmail.com', N'admin', N'123456', 1)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (3, N'Nguyen Xuan Nam', N'Female', N'huy@gmail.com', N'nam', N'2', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (4, N'Phung Anh Tu', N'Male', N'tu@gmail.com', N'totite', N'1', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (10, N'Nguyen Manh Anh', N'Male', N'manhanh@gmailcom', N'huy2004', N'1', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (11, N'Nguyen Hung Dung', N'Male', N'hungdung@gmail.com', N'dung', N'123', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (14, N'Do Hai Dang', N'Male', N'dang@gmail.com', N'dang', N'1', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (16, N'Phan Thanh Dat', N'Male', N'dat@gmail.com', N'datphan', N'1', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (18, N'Do Hai Dang', N'Male', N'dang@gmail.com', N'dang', N'1', 2)
INSERT [dbo].[Users] ([id], [fullname], [gender], [email], [username], [password], [role_id]) VALUES (19, N'Nguyen Khanh Duy', N'Male', N'duy@gmail.com', N'duy', N'2', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Class] FOREIGN KEY([class_id])
REFERENCES [dbo].[Class] ([id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Class]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Majors] FOREIGN KEY([major_id])
REFERENCES [dbo].[Majors] ([id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Majors]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Roles]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Schedule] FOREIGN KEY([schedule_id])
REFERENCES [dbo].[Schedule] ([id])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Schedule]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [AttendanceSystem] SET  READ_WRITE 
GO
