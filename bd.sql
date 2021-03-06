USE [master]
GO
/****** Object:  Database [gato3]    Script Date: 06/12/2018 10:17:18 a.m. ******/
CREATE DATABASE [gato3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gato3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\gato3.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gato3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\gato3_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gato3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gato3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gato3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gato3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gato3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gato3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gato3] SET ARITHABORT OFF 
GO
ALTER DATABASE [gato3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [gato3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gato3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gato3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gato3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gato3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gato3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gato3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gato3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gato3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gato3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gato3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gato3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gato3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gato3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gato3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gato3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gato3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gato3] SET  MULTI_USER 
GO
ALTER DATABASE [gato3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gato3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gato3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gato3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [gato3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [gato3]
GO
/****** Object:  Table [dbo].[x]    Script Date: 06/12/2018 10:17:19 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x](
	[numero] [int] NULL,
	[jugador1] [varchar](40) NULL,
	[jugador2] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[x] ([numero], [jugador1], [jugador2]) VALUES (3, N'pepe', N'alonso')
USE [master]
GO
ALTER DATABASE [gato3] SET  READ_WRITE 
GO
