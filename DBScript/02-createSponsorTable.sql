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
	[Id] [smallint] NOT NULL,
	[CompanyName] [varchar](255) NULL,
	[Level] [varchar](10) NULL,
	[Description] [text] NULL,
	[Url] [varchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
