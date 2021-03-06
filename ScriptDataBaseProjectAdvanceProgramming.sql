USE [master]
GO
/****** Object:  Database [AdvanceProgramming]    Script Date: 03/03/2022 19:00:33 ******/
CREATE DATABASE [AdvanceProgramming]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdvanceProgramming', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AdvanceProgramming.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdvanceProgramming_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AdvanceProgramming_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AdvanceProgramming] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdvanceProgramming].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdvanceProgramming] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdvanceProgramming] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdvanceProgramming] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AdvanceProgramming] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdvanceProgramming] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AdvanceProgramming] SET  MULTI_USER 
GO
ALTER DATABASE [AdvanceProgramming] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdvanceProgramming] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdvanceProgramming] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdvanceProgramming] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AdvanceProgramming] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AdvanceProgramming] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AdvanceProgramming] SET QUERY_STORE = OFF
GO
USE [AdvanceProgramming]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 03/03/2022 19:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[CodeExam] [int] NOT NULL,
	[NameExam] [nvarchar](max) NOT NULL,
	[IdProfessor] [int] NOT NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[CodeExam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam_Student]    Script Date: 03/03/2022 19:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeExam] [int] NOT NULL,
	[IdStudent] [int] NOT NULL,
	[Grade] [int] NOT NULL,
 CONSTRAINT [PK_Exam_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 03/03/2022 19:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[SecretCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 03/03/2022 19:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumberQuestion] [int] NOT NULL,
	[NameQuestion] [nvarchar](max) NOT NULL,
	[Answer_1] [nvarchar](max) NOT NULL,
	[Answer_2] [nvarchar](max) NOT NULL,
	[Answer_3] [nvarchar](max) NOT NULL,
	[Answer_4] [nvarchar](max) NOT NULL,
	[NumberAnswerCorrect] [nvarchar](max) NOT NULL,
	[CodeExam] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sudent]    Script Date: 03/03/2022 19:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sudent](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[SecretCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Sudent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_Exam_Professor] FOREIGN KEY([IdProfessor])
REFERENCES [dbo].[Professor] ([Id])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_Exam_Professor]
GO
ALTER TABLE [dbo].[Exam_Student]  WITH CHECK ADD  CONSTRAINT [FK_Exam_Student_Exam] FOREIGN KEY([CodeExam])
REFERENCES [dbo].[Exam] ([CodeExam])
GO
ALTER TABLE [dbo].[Exam_Student] CHECK CONSTRAINT [FK_Exam_Student_Exam]
GO
ALTER TABLE [dbo].[Exam_Student]  WITH CHECK ADD  CONSTRAINT [FK_Exam_Student_Sudent] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Sudent] ([Id])
GO
ALTER TABLE [dbo].[Exam_Student] CHECK CONSTRAINT [FK_Exam_Student_Sudent]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Exam] FOREIGN KEY([CodeExam])
REFERENCES [dbo].[Exam] ([CodeExam])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Exam]
GO
USE [master]
GO
ALTER DATABASE [AdvanceProgramming] SET  READ_WRITE 
GO
