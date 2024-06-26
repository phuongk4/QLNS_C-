USE [QLNS-NIQ]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactID] [int] NULL,
	[EmpId] [int] NOT NULL,
	[JoinedDate] [date] NULL,
	[PeriodOfContact] [int] NULL,
	[PostID] [int] NULL,
	[EmpTypeID] [int] NULL,
	[DepID] [int] NULL,
	[Sal] [float] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepID] [int] NOT NULL,
	[DepName] [nchar](100) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] NOT NULL,
	[Name] [nchar](100) NULL,
	[Birthday] [date] NULL,
	[Gender] [nchar](10) NULL,
	[Phone] [nchar](10) NULL,
	[Address] [nchar](100) NULL,
	[Qualification] [nchar](100) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpType]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpType](
	[EmpTypeID] [int] NOT NULL,
	[EmpTypeName] [nchar](100) NULL,
 CONSTRAINT [PK_EmpType] PRIMARY KEY CLUSTERED 
(
	[EmpTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostID] [int] NOT NULL,
	[PostName] [nchar](100) NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roll_Cast]    Script Date: 7/3/2023 9:47:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roll_Cast](
	[EmpID] [int] NOT NULL,
	[BreakDay] [int] NULL,
	[AddDay] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_Roll_Cast] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (1, 1, CAST(N'2023-04-01' AS Date), 5, 1, 1, 1, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (2, 2, CAST(N'2023-04-01' AS Date), 5, 2, 2, 2, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (3, 3, CAST(N'2023-04-01' AS Date), 6, 3, 3, 3, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (4, 4, CAST(N'2023-04-10' AS Date), 7, 2, 3, 1, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (5, 5, CAST(N'2023-04-02' AS Date), 6, 4, 3, 1, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (6, 6, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (7, 7, CAST(N'2023-04-02' AS Date), 3, 3, 2, 3, 3000000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (8, 8, CAST(N'2000-08-20' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (9, 9, CAST(N'2000-03-03' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (10, 10, CAST(N'2000-02-08' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (11, 11, CAST(N'2000-04-10' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (12, 12, CAST(N'2000-04-04' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (99, 99, CAST(N'2008-05-04' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (999, 999, CAST(N'2023-05-08' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (1000, 1000, CAST(N'2023-04-12' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (1001, 1001, CAST(N'2023-04-11' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (9999, 9999, CAST(N'2008-05-04' AS Date), 5, 3, 1, 3, 3010000)
INSERT [dbo].[Contact] ([ContactID], [EmpId], [JoinedDate], [PeriodOfContact], [PostID], [EmpTypeID], [DepID], [Sal]) VALUES (10000, 10000, CAST(N'2008-05-04' AS Date), 5, 3, 1, 3, 3010000)
GO
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (1, N'Phòng A                                                                                             ')
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (2, N'Phòng B                                                                                             ')
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (3, N'Phòng C                                                                                             ')
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (4, N'Phòng D                                                                                             ')
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (5, N'Phòng E                                                                                             ')
INSERT [dbo].[Department] ([DepID], [DepName]) VALUES (6, N'Phòng F                                                                                             ')
GO
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (1, N'vinhABC                                                                                             ', CAST(N'2000-03-03' AS Date), N'Nu        ', N'0646456456', N'TP Nam D                                                                                            ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (2, N'Duc                                                                                                 ', CAST(N'2000-04-10' AS Date), N'Nam       ', N'0464981565', N'TP Hung Yen                                                                                         ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (3, N'Dong                                                                                                ', CAST(N'2000-05-20' AS Date), N'Nu        ', N'0456472132', N'TP Yen Bai                                                                                          ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (4, N'HelloWorld                                                                                          ', CAST(N'2023-04-18' AS Date), N'Nam       ', N'0646456456', N'TP Long An                                                                                          ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (5, N'Khai                                                                                                ', CAST(N'2008-05-04' AS Date), N'Nu        ', N'0676461322', N'TP Ha Long                                                                                          ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (6, N'vinh123                                                                                             ', CAST(N'2023-04-19' AS Date), N'Nam       ', N'0123456789', N'TP Lang Son                                                                                         ', N'TnDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (7, N'Dong sieu cute                                                                                      ', CAST(N'2008-05-04' AS Date), N'Nu        ', N'0676461322', N'TP Ha Long Viet Nam                                                                                 ', N'TNDH                                                                                                ')
INSERT [dbo].[Employee] ([EmpID], [Name], [Birthday], [Gender], [Phone], [Address], [Qualification]) VALUES (999, N'string                                                                                              ', CAST(N'2023-05-08' AS Date), N'hoho      ', N'9999      ', N'Lum                                                                                                 ', N'Lua                                                                                                 ')
GO
INSERT [dbo].[EmpType] ([EmpTypeID], [EmpTypeName]) VALUES (1, N'Trưởng Phòng                                                                                        ')
INSERT [dbo].[EmpType] ([EmpTypeID], [EmpTypeName]) VALUES (2, N'Nhân Viên                                                                                           ')
INSERT [dbo].[EmpType] ([EmpTypeID], [EmpTypeName]) VALUES (3, N'Giám Đốc                                                                                            ')
INSERT [dbo].[EmpType] ([EmpTypeID], [EmpTypeName]) VALUES (4, N'Chủ Tịch                                                                                            ')
INSERT [dbo].[EmpType] ([EmpTypeID], [EmpTypeName]) VALUES (5, N'Phó Phòng                                                                                           ')
GO
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (1, N'Làm ở cơ sở A                                                                                       ')
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (2, N'Làm ở cơ sở B                                                                                       ')
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (3, N'Làm ở cơ sở C                                                                                       ')
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (4, N'Làm ở cơ sở D                                                                                       ')
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (5, N'Làm ở cơ sở E                                                                                       ')
INSERT [dbo].[Post] ([PostID], [PostName]) VALUES (6, N'Làm ở cơ sở F                                                                                       ')
GO
INSERT [dbo].[Roll_Cast] ([EmpID], [BreakDay], [AddDay], [Total]) VALUES (1, 5, 2, 7)
INSERT [dbo].[Roll_Cast] ([EmpID], [BreakDay], [AddDay], [Total]) VALUES (2, 3, 2, 5)
INSERT [dbo].[Roll_Cast] ([EmpID], [BreakDay], [AddDay], [Total]) VALUES (3, 8, 2, 10)
INSERT [dbo].[Roll_Cast] ([EmpID], [BreakDay], [AddDay], [Total]) VALUES (4, 3, 3, 6)
INSERT [dbo].[Roll_Cast] ([EmpID], [BreakDay], [AddDay], [Total]) VALUES (5, 8, 3, 11)
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_Department] FOREIGN KEY([DepID])
REFERENCES [dbo].[Department] ([DepID])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_Department]
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_EmpType] FOREIGN KEY([EmpTypeID])
REFERENCES [dbo].[EmpType] ([EmpTypeID])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_EmpType]
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_Post] FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_Post]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Contact1] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Contact] ([EmpId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Contact1]
GO
ALTER TABLE [dbo].[Roll_Cast]  WITH CHECK ADD  CONSTRAINT [FK_Roll_Cast_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Roll_Cast] CHECK CONSTRAINT [FK_Roll_Cast_Employee]
GO
