USE [HospitalManagementdb]
GO
/****** Object:  Table [dbo].[Addward]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[docinfor]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[logintable]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[NewUser]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[patientinfor]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[patientregis]    Script Date: 14-02-2017 14:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patientregis](
	[Date] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[staffinfo]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[tblPatient]    Script Date: 14-02-2017 14:51:28 ******/
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
/****** Object:  Table [dbo].[tblregister]    Script Date: 14-02-2017 14:51:28 ******/
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
