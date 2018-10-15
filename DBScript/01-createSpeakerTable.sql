
USE master
GO
DROP DATABASE IF EXISTS [DockerDBTest]
GO
Create DATABASE [DockerDBTest]
GO
USE [DockerDBTest]
GO

/****** Object:  Table [dbo].[Speakers]    Script Date: 13/10/2018 12:41:44 ******/
DROP TABLE IF EXISTS [dbo].[Speakers]
GO

/****** Object:  Table [dbo].[Speakers]    Script Date: 13/10/2018 12:41:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Speakers](
	[Id] [int] NULL,
	[First] [varchar](50) NULL,
	[Last] [varchar](50) NULL,
	[EmailAddress] [varchar](255) NULL
) ON [PRIMARY]
GO

USE [DockerDBTest]
GO

/****** Object:  Table [dbo].[Sponsors]    Script Date: 13/10/2018 12:42:09 ******/
DROP TABLE IF EXISTS [dbo].[Sponsors]
GO

/****** Object:  Table [dbo].[Sponsors]    Script Date: 13/10/2018 12:42:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sponsors](
	[Id] [int]  NULL,
	[CompanyName] [varchar](255) NULL,
	[Level] [varchar](10) NULL,
	[Description] [text] NULL,
	[Url] [varchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO