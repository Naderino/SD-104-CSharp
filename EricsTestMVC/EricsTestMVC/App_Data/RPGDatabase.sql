USE [master]
GO
/****** Object:  Database [RPGGame]    Script Date: 5/14/2018 12:56:31 PM ******/
CREATE DATABASE [RPGGame]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RPGGame', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RPGGame.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RPGGame_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RPGGame_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RPGGame] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RPGGame].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RPGGame] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RPGGame] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RPGGame] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RPGGame] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RPGGame] SET ARITHABORT OFF 
GO
ALTER DATABASE [RPGGame] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RPGGame] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RPGGame] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RPGGame] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RPGGame] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RPGGame] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RPGGame] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RPGGame] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RPGGame] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RPGGame] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RPGGame] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RPGGame] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RPGGame] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RPGGame] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RPGGame] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RPGGame] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RPGGame] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RPGGame] SET RECOVERY FULL 
GO
ALTER DATABASE [RPGGame] SET  MULTI_USER 
GO
ALTER DATABASE [RPGGame] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RPGGame] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RPGGame] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RPGGame] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RPGGame] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RPGGame', N'ON'
GO
ALTER DATABASE [RPGGame] SET QUERY_STORE = OFF
GO
USE [RPGGame]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [RPGGame]
GO
/****** Object:  Table [dbo].[Hero]    Script Date: 5/14/2018 12:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hero](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Health] [int] NOT NULL,
	[LVL] [int] NOT NULL,
	[AttackPower] [int] NOT NULL,
	[CurrentEXP] [int] NULL,
	[Name] [varchar](250) NULL,
	[Alive] [tinyint] NULL,
	[Weapon] [int] NULL,
 CONSTRAINT [PK_Hero] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Weapon]    Script Date: 5/14/2018 12:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weapon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
	[AttackValue] [int] NULL,
	[AttackModifier] [int] NULL,
	[Hands] [tinyint] NULL,
 CONSTRAINT [PK_Weapon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hero]  WITH CHECK ADD  CONSTRAINT [FK_Hero_Weapon] FOREIGN KEY([Weapon])
REFERENCES [dbo].[Weapon] ([ID])
GO
ALTER TABLE [dbo].[Hero] CHECK CONSTRAINT [FK_Hero_Weapon]
GO
USE [master]
GO
ALTER DATABASE [RPGGame] SET  READ_WRITE 
GO
