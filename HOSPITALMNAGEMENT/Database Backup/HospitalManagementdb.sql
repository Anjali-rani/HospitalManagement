USE [master]
GO
/****** Object:  Database [HospitalManagementdb]    Script Date: 11-03-2017 16:50:19 ******/
CREATE DATABASE [HospitalManagementdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalManagementdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\HospitalManagementdb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HospitalManagementdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\HospitalManagementdb_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HospitalManagementdb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalManagementdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalManagementdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalManagementdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalManagementdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalManagementdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalManagementdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalManagementdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET RECOVERY FULL 
GO
ALTER DATABASE [HospitalManagementdb] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalManagementdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalManagementdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalManagementdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalManagementdb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HospitalManagementdb', N'ON'
GO
USE [HospitalManagementdb]
GO
/****** Object:  Table [dbo].[Addward]    Script Date: 11-03-2017 16:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Addward](
	[Buildingno] [varchar](50) NULL,
	[Floorno] [varchar](50) NULL,
	[Roomno] [varchar](50) NULL,
	[Roomtype] [varchar](50) NULL,
	[Beds] [varchar](50) NULL,
	[Price] [int] NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 11-03-2017 16:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] NOT NULL,
	[County] [varchar](30) NULL,
 CONSTRAINT [PK__Country__10D1609FB7B4A288] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[countryState]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[countryState](
	[StateId] [int] NOT NULL,
	[CountryId] [int] NULL,
	[State] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[docinfor]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[docinfor](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[DOB] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[Specialist] [varchar](50) NOT NULL,
	[Country] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](150) NOT NULL,
	[Pincode] [int] NOT NULL,
 CONSTRAINT [PK_docinfor] PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[logintable]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logintable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_logintable] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NewUser]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NewUser](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ConfirmPassword] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NewUser] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[patientinfor]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patientinfor](
	[pid] [int] NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Address] [varchar](150) NOT NULL,
	[Disease] [varchar](50) NOT NULL,
	[DateIn] [varchar](50) NOT NULL,
	[DateOut] [varchar](50) NOT NULL,
	[Roomno] [varchar](50) NOT NULL,
	[Roomtype] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Building] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Medicine] [varchar](50) NOT NULL,
	[Total] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[patientregis]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patientregis](
	[Date] [varchar](50) NOT NULL,
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Disease] [varchar](50) NOT NULL,
	[Bloodgroup] [varchar](50) NOT NULL,
	[Building] [varchar](50) NOT NULL,
	[Roomno] [varchar](50) NOT NULL,
	[Roomtype] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_patientregis] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staffinfo]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staffinfo](
	[Staffid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Salary] [varchar](50) NOT NULL,
	[Phoneno] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_staffinfo] PRIMARY KEY CLUSTERED 
(
	[Staffid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stateCity]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stateCity](
	[CityId] [int] NULL,
	[StateId] [int] NULL,
	[City] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPatient]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPatient](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Address] [varchar](150) NOT NULL,
	[Disease] [varchar](50) NOT NULL,
	[DateIn] [varchar](50) NOT NULL,
	[DateOut] [varchar](50) NOT NULL,
	[Roomno] [varchar](50) NOT NULL,
	[Roomtype] [varchar](50) NOT NULL,
	[TotalDays] [varchar](50) NOT NULL,
	[Price] [varchar](50) NOT NULL,
	[Building] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Medicine] [varchar](50) NOT NULL,
	[Total] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPatient] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblregister]    Script Date: 11-03-2017 16:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblregister](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblregister] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[countryState]  WITH CHECK ADD  CONSTRAINT [FK__countrySt__Count__04E4BC85] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[countryState] CHECK CONSTRAINT [FK__countrySt__Count__04E4BC85]
GO
ALTER TABLE [dbo].[stateCity]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[countryState] ([StateId])
GO
USE [master]
GO
ALTER DATABASE [HospitalManagementdb] SET  READ_WRITE 
GO
