USE [master]
GO
/****** Object:  Database [SMS-Db]    Script Date: 6/30/2020 11:26:07 ******/
CREATE DATABASE [SMS-Db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMS-Db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMS-Db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMS-Db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMS-Db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMS-Db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMS-Db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMS-Db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMS-Db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMS-Db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMS-Db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMS-Db] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMS-Db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMS-Db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMS-Db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMS-Db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMS-Db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMS-Db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMS-Db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMS-Db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMS-Db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMS-Db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMS-Db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMS-Db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMS-Db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMS-Db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMS-Db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMS-Db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMS-Db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMS-Db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMS-Db] SET  MULTI_USER 
GO
ALTER DATABASE [SMS-Db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMS-Db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMS-Db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMS-Db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMS-Db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMS-Db] SET QUERY_STORE = OFF
GO
USE [SMS-Db]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[courseCode] [nchar](10) NOT NULL,
	[courseTitle] [nchar](30) NULL,
	[lecturerID] [nchar](5) NULL,
	[creditHours] [nchar](5) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[courseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transcript]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transcript](
	[studID] [nchar](8) NOT NULL,
	[courseCode] [nchar](10) NULL,
	[grade] [nchar](10) NULL,
	[score] [nchar](10) NULL,
	[academicYear] [nchar](10) NULL,
	[semesterNo] [nchar](10) NULL,
	[date] [date] NULL,
	[transID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[transID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Transcript_ResultSlip]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Transcript_ResultSlip]
AS
SELECT        dbo.Transcript.studID, dbo.Transcript.courseCode, dbo.Transcript.grade, dbo.Transcript.score, dbo.Course.courseTitle, dbo.Course.creditHours
FROM            dbo.Transcript INNER JOIN
                         dbo.Course ON dbo.Transcript.courseCode = dbo.Course.courseCode
GO
/****** Object:  Table [dbo].[Hall]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hall](
	[hall_ID] [nchar](5) NOT NULL,
	[hallName] [nchar](50) NULL,
	[hall_Tutor] [nchar](5) NULL,
 CONSTRAINT [PK_Hall] PRIMARY KEY CLUSTERED 
(
	[hall_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[studentID] [nchar](8) NOT NULL,
	[firstName] [nchar](30) NOT NULL,
	[lastName] [nchar](30) NOT NULL,
	[otherName] [nchar](30) NULL,
	[hall_ID] [nchar](5) NULL,
	[deptID] [nchar](5) NULL,
	[contact] [nchar](10) NULL,
	[email] [nchar](30) NOT NULL,
	[studentPin] [nchar](5) NOT NULL,
	[postalAddress] [nchar](50) NULL,
	[maritalStatus] [nchar](10) NOT NULL,
	[college] [nchar](50) NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[homeLanguage] [nchar](20) NOT NULL,
	[programme] [nchar](500) NOT NULL,
	[picture] [varbinary](max) NULL,
	[citizenship] [nchar](30) NULL,
	[DOB] [date] NOT NULL,
	[academicLevel] [nchar](10) NULL,
	[residenceStatus] [nchar](10) NULL,
	[roomNo] [nchar](5) NULL,
	[acaYear] [nchar](10) NULL,
	[gPA] [nchar](10) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[deptID] [nchar](5) NOT NULL,
	[deptName] [nchar](30) NULL,
	[lectID] [nchar](5) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[deptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Student_List]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Student_List]
AS
SELECT        dbo.Student.firstName, dbo.Student.lastName, dbo.Student.otherName, dbo.Department.deptName, dbo.Hall.hallName, dbo.Student.college, dbo.Student.gender, dbo.Student.programme, dbo.Student.academicLevel, 
                         dbo.Student.studentID
FROM            dbo.Student INNER JOIN
                         dbo.Department ON dbo.Student.deptID = dbo.Department.deptID INNER JOIN
                         dbo.Hall ON dbo.Student.hall_ID = dbo.Hall.hall_ID
GO
/****** Object:  View [dbo].[rptHall]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rptHall]
AS
SELECT        dbo.Student.studentID, dbo.Hall.hallName
FROM            dbo.Hall INNER JOIN
                         dbo.Student ON dbo.Hall.hall_ID = dbo.Student.hall_ID
GO
/****** Object:  View [dbo].[rptCourses]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rptCourses]
AS
SELECT        dbo.Transcript.studID, dbo.Course.courseCode, dbo.Course.courseTitle
FROM            dbo.Course INNER JOIN
                         dbo.Transcript ON dbo.Course.courseCode = dbo.Transcript.courseCode
GO
/****** Object:  Table [dbo].[Lecturer]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lecturer](
	[lectID] [nchar](5) NOT NULL,
	[lectName] [nchar](30) NOT NULL,
	[email] [nchar](30) NULL,
	[deptID] [nchar](5) NOT NULL,
	[position] [nchar](50) NULL,
	[Password] [nchar](10) NULL,
 CONSTRAINT [PK_Lecturer] PRIMARY KEY CLUSTERED 
(
	[lectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Logins]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Logins]
AS
SELECT        dbo.Student.studentID, dbo.Lecturer.lectID, dbo.Lecturer.Password, dbo.Student.studentPin, dbo.Student.firstName, dbo.Lecturer.lectName
FROM            dbo.Student CROSS JOIN
                         dbo.Lecturer
GO
/****** Object:  View [dbo].[Transcript_Details]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Transcript_Details]
AS
SELECT        dbo.Department.deptName, dbo.Hall.hallName, dbo.Student.studentID, dbo.Student.firstName, dbo.Student.lastName, dbo.Student.gPA, dbo.Student.academicLevel, dbo.Student.programme
FROM            dbo.Department INNER JOIN
                         dbo.Student ON dbo.Department.deptID = dbo.Student.deptID INNER JOIN
                         dbo.Hall ON dbo.Student.hall_ID = dbo.Hall.hall_ID
GO
/****** Object:  View [dbo].[Hall_Report]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Hall_Report]
AS
SELECT        dbo.Student.studentID, dbo.Hall.hallName, dbo.Hall.hall_ID, dbo.Student.hall_ID AS Expr1
FROM            dbo.Hall INNER JOIN
                         dbo.Student ON dbo.Hall.hall_ID = dbo.Student.hall_ID
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 6/30/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[grade] [nchar](4) NULL,
	[remarks] [nchar](30) NULL,
	[gradePoints] [nchar](5) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Course] ([courseCode], [courseTitle], [lecturerID], [creditHours]) VALUES (N'CSCD 214  ', N'Digital Electronics           ', N'003  ', N'2    ')
INSERT [dbo].[Course] ([courseCode], [courseTitle], [lecturerID], [creditHours]) VALUES (N'CSCD 302  ', N'Programming 3                 ', N'001  ', N'3    ')
INSERT [dbo].[Course] ([courseCode], [courseTitle], [lecturerID], [creditHours]) VALUES (N'CSCD 312  ', N'Artificiaal Intelligence      ', N'002  ', N'3    ')
GO
INSERT [dbo].[Department] ([deptID], [deptName], [lectID]) VALUES (N'1    ', N'Computer Science              ', N'1    ')
INSERT [dbo].[Department] ([deptID], [deptName], [lectID]) VALUES (N'2    ', N'Mathematics                   ', N'     ')
INSERT [dbo].[Department] ([deptID], [deptName], [lectID]) VALUES (N'3    ', N'Geography                     ', N'     ')
INSERT [dbo].[Department] ([deptID], [deptName], [lectID]) VALUES (N'4    ', N'Physics                       ', N'     ')
INSERT [dbo].[Department] ([deptID], [deptName], [lectID]) VALUES (N'5    ', N'Business                      ', N'     ')
GO
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'A   ', N'Excellent                     ', N'12   ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'B+  ', N'Very Good                     ', N'10.5 ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'B   ', N'Good                          ', N'9    ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'C+  ', N'Average                       ', N'7.5  ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'C   ', N'Average                       ', N'6    ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'D+  ', N'Pass                          ', N'4.5  ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'D   ', N'Pass                          ', N'3    ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'E   ', N'Satisfactory                  ', N'1.5  ')
INSERT [dbo].[Grade] ([grade], [remarks], [gradePoints]) VALUES (N'F   ', N'Fail                          ', N'0    ')
GO
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'1    ', N'Akuafo                                            ', N'005  ')
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'2    ', N'Commonwealth                                      ', N'001  ')
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'3    ', N'Legon                                             ', N'004  ')
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'4    ', N'Mensah sarbah                                     ', N'003  ')
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'5    ', N'Volta                                             ', N'002  ')
INSERT [dbo].[Hall] ([hall_ID], [hallName], [hall_Tutor]) VALUES (N'6    ', N'Non-Resident                                      ', NULL)
GO
INSERT [dbo].[Lecturer] ([lectID], [lectName], [email], [deptID], [position], [Password]) VALUES (N'001  ', N'Samuel Winful                 ', N'sw2019@gmail.com              ', N'1    ', N'HOD                                               ', N'admin123  ')
INSERT [dbo].[Lecturer] ([lectID], [lectName], [email], [deptID], [position], [Password]) VALUES (N'002  ', N'Emmanuella Agordzo            ', N'emma2017@gmail.com            ', N'2    ', N'                                                  ', N'admin123  ')
INSERT [dbo].[Lecturer] ([lectID], [lectName], [email], [deptID], [position], [Password]) VALUES (N'003  ', N'Nancy Donkor                  ', N'                              ', N'3    ', N'                                                  ', N'admin123  ')
INSERT [dbo].[Lecturer] ([lectID], [lectName], [email], [deptID], [position], [Password]) VALUES (N'004  ', N'Amoako Mills                  ', N'am-wo@yahoo.com               ', N'4    ', N'                                                  ', N'admin123  ')
INSERT [dbo].[Lecturer] ([lectID], [lectName], [email], [deptID], [position], [Password]) VALUES (N'005  ', N'Morrison King                 ', N'                              ', N'5    ', N'                                                  ', N'admin123  ')
GO
INSERT [dbo].[Student] ([studentID], [firstName], [lastName], [otherName], [hall_ID], [deptID], [contact], [email], [studentPin], [postalAddress], [maritalStatus], [college], [gender], [homeLanguage], [programme], [picture], [citizenship], [DOB], [academicLevel], [residenceStatus], [roomNo], [acaYear], [gPA]) VALUES (N'10600141', N'Akosua                        ', N'WIafe-Akenten                 ', N'Nyarkoa                       ', N'1    ', N'1    ', N'0554399042', N'Invalid Email                 ', N'10421', N'P. O. Box LG19                                    ', N'Single    ', N'Basic and Applied Sciences                        ', N'Female    ', N'English             ', N'Bachelor of Science in Engineering                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', NULL, N'Ghanaian                      ', CAST(N'2020-06-30' AS Date), N'300       ', N'True      ', N'UG_10', N'2017/2018 ', N'4.0       ')
GO
SET IDENTITY_INSERT [dbo].[Transcript] ON 

INSERT [dbo].[Transcript] ([studID], [courseCode], [grade], [score], [academicYear], [semesterNo], [date], [transID]) VALUES (N'10600141', N'CSCD 214  ', NULL, NULL, N'2018/2019 ', N'1         ', NULL, 9)
SET IDENTITY_INSERT [dbo].[Transcript] OFF
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_studentID]  DEFAULT ((0.0)) FOR [studentID]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_gPA]  DEFAULT ((4.0)) FOR [gPA]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [is taught by] FOREIGN KEY([lecturerID])
REFERENCES [dbo].[Lecturer] ([lectID])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [is taught by]
GO
ALTER TABLE [dbo].[Hall]  WITH CHECK ADD  CONSTRAINT [is a tutor of] FOREIGN KEY([hall_Tutor])
REFERENCES [dbo].[Lecturer] ([lectID])
GO
ALTER TABLE [dbo].[Hall] CHECK CONSTRAINT [is a tutor of]
GO
ALTER TABLE [dbo].[Lecturer]  WITH CHECK ADD  CONSTRAINT [lists] FOREIGN KEY([deptID])
REFERENCES [dbo].[Department] ([deptID])
GO
ALTER TABLE [dbo].[Lecturer] CHECK CONSTRAINT [lists]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [contains] FOREIGN KEY([deptID])
REFERENCES [dbo].[Department] ([deptID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [contains]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [stays in] FOREIGN KEY([hall_ID])
REFERENCES [dbo].[Hall] ([hall_ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [stays in]
GO
ALTER TABLE [dbo].[Transcript]  WITH CHECK ADD  CONSTRAINT [has] FOREIGN KEY([studID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[Transcript] CHECK CONSTRAINT [has]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Hall"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 19
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Hall_Report'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Hall_Report'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Lecturer"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Logins'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Logins'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Course"
            Begin Extent = 
               Top = 12
               Left = 229
               Bottom = 142
               Right = 399
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Transcript"
            Begin Extent = 
               Top = 6
               Left = 555
               Bottom = 136
               Right = 725
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rptCourses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rptCourses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Hall"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 15
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rptHall'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'rptHall'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Department"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 119
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Hall"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 119
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Student_List'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Student_List'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Department"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "Hall"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transcript_Details'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transcript_Details'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Transcript"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Course"
            Begin Extent = 
               Top = 17
               Left = 399
               Bottom = 147
               Right = 569
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transcript_ResultSlip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transcript_ResultSlip'
GO
USE [master]
GO
ALTER DATABASE [SMS-Db] SET  READ_WRITE 
GO
