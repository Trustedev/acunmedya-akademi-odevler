USE [Employees]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 25.08.2023 21:30:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[EmpID] [int] NOT NULL,
	[FullName] [varchar](50) NULL,
	[ManagerID] [int] NULL,
	[DateOfJoin] [date] NULL,
	[City] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 25.08.2023 21:30:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeSalary](
	[EmpID] [int] NOT NULL,
	[Project] [varchar](50) NULL,
	[Salary] [int] NULL,
	[Variable] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (121, N'John Snow', 321, CAST(N'2019-01-31' AS Date), N'Winterfell')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (321, N'Walter White', 986, CAST(N'2020-01-30' AS Date), N'California')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (421, N'Kuldeep Rana', 878, CAST(N'2021-11-27' AS Date), N'New Delhi')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (666, N'Jesse Pinkman
', 999, CAST(N'2020-05-15' AS Date), N'New York')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (612, N'Eddard Stark
', 121, CAST(N'1972-01-01' AS Date), N'Winterfell')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (125, N'Daenerys Targaryen', 121, CAST(N'1990-06-06' AS Date), N'Dragonstone')
INSERT [dbo].[EmployeeDetails] ([EmpID], [FullName], [ManagerID], [DateOfJoin], [City]) VALUES (241, N'Arya Stark', 612, CAST(N'2004-12-20' AS Date), N'Winterfell')
GO
INSERT [dbo].[EmployeeSalary] ([EmpID], [Project], [Salary], [Variable]) VALUES (121, N'P1', 8000, 500)
INSERT [dbo].[EmployeeSalary] ([EmpID], [Project], [Salary], [Variable]) VALUES (321, N'P2', 10000, 1000)
INSERT [dbo].[EmployeeSalary] ([EmpID], [Project], [Salary], [Variable]) VALUES (421, N'P1', 12000, 0)
INSERT [dbo].[EmployeeSalary] ([EmpID], [Project], [Salary], [Variable]) VALUES (125, N'P3', 15000, 5000)
GO
