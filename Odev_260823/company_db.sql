USE [company_db]
GO
/****** Object:  Table [dbo].[dept]    Script Date: 26.08.2023 13:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dept](
	[dept] [varchar](50) NULL,
	[dname] [varchar](50) NULL,
	[mgreno] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emp]    Script Date: 26.08.2023 13:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp](
	[eno] [int] NOT NULL,
	[ename] [varchar](50) NULL,
	[bdate] [date] NULL,
	[title] [varchar](50) NULL,
	[salary] [int] NULL,
	[dno] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proj]    Script Date: 26.08.2023 13:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proj](
	[pno] [int] NOT NULL,
	[pname] [varchar](50) NULL,
	[budget] [int] NULL,
	[dno] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[workson]    Script Date: 26.08.2023 13:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[workson](
	[eno] [int] NOT NULL,
	[pno] [int] NULL,
	[resp] [varchar](50) NULL,
	[hours] [int] NULL
) ON [PRIMARY]
GO
