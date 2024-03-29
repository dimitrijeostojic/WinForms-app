USE [master]
GO
/****** Object:  Database [ProjekatSoftveri]    Script Date: 8.3.2024. 23:39:11 ******/
CREATE DATABASE [ProjekatSoftveri]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjekatSoftveri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProjekatSoftveri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjekatSoftveri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProjekatSoftveri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ProjekatSoftveri] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjekatSoftveri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjekatSoftveri] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjekatSoftveri] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjekatSoftveri] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjekatSoftveri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjekatSoftveri] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjekatSoftveri] SET  MULTI_USER 
GO
ALTER DATABASE [ProjekatSoftveri] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjekatSoftveri] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjekatSoftveri] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjekatSoftveri] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjekatSoftveri] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjekatSoftveri] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjekatSoftveri', N'ON'
GO
ALTER DATABASE [ProjekatSoftveri] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProjekatSoftveri] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProjekatSoftveri]
GO
/****** Object:  Table [dbo].[Airport]    Script Date: 8.3.2024. 23:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airport](
	[AirportID] [int] IDENTITY(1,1) NOT NULL,
	[AirportName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Airport] PRIMARY KEY CLUSTERED 
(
	[AirportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flight]    Script Date: 8.3.2024. 23:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flight](
	[Flight_id] [int] IDENTITY(1,1) NOT NULL,
	[DepartureAirportID] [int] NOT NULL,
	[ArrivalAirportID] [int] NOT NULL,
	[DepartureDate] [varchar](50) NOT NULL,
	[ArrivalDate] [varchar](50) NOT NULL,
	[DepartureTime] [varchar](50) NOT NULL,
	[ArrivalTime] [varchar](50) NOT NULL,
	[Plane] [int] NOT NULL,
	[TicketPrice] [float] NOT NULL,
	[CreatedBy] [varchar](13) NOT NULL,
 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED 
(
	[Flight_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plane]    Script Date: 8.3.2024. 23:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plane](
	[PlaneID] [int] IDENTITY(1,1) NOT NULL,
	[PlaneName] [varchar](50) NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Plane] PRIMARY KEY CLUSTERED 
(
	[PlaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 8.3.2024. 23:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Flight_id] [int] NOT NULL,
	[Jmbg] [varchar](13) NOT NULL,
	[NumOfSeats] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Flight_id] ASC,
	[Jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8.3.2024. 23:39:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Jmbg] [varchar](13) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Airport] ON 

INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (1, N'Belgrade')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (2, N'London')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (3, N'Paris')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (4, N'Barcelona')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (5, N'Madrid')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (6, N'NewYork')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (7, N'Berlin')
INSERT [dbo].[Airport] ([AirportID], [AirportName]) VALUES (8, N'Lisabon')
SET IDENTITY_INSERT [dbo].[Airport] OFF
GO
SET IDENTITY_INSERT [dbo].[Flight] ON 

INSERT [dbo].[Flight] ([Flight_id], [DepartureAirportID], [ArrivalAirportID], [DepartureDate], [ArrivalDate], [DepartureTime], [ArrivalTime], [Plane], [TicketPrice], [CreatedBy]) VALUES (1, 2, 5, N'1.2.2024.', N'3.2.2024.', N'18:26', N'21:26', 3, 25, N'0511001720028')
INSERT [dbo].[Flight] ([Flight_id], [DepartureAirportID], [ArrivalAirportID], [DepartureDate], [ArrivalDate], [DepartureTime], [ArrivalTime], [Plane], [TicketPrice], [CreatedBy]) VALUES (2, 6, 1, N'1.2.2024.', N'3.2.2024.', N'18:26', N'18:26', 1, 50, N'0511001720028')
SET IDENTITY_INSERT [dbo].[Flight] OFF
GO
SET IDENTITY_INSERT [dbo].[Plane] ON 

INSERT [dbo].[Plane] ([PlaneID], [PlaneName], [Capacity]) VALUES (1, N'Boing 747', 100)
INSERT [dbo].[Plane] ([PlaneID], [PlaneName], [Capacity]) VALUES (2, N'Airbus A380', 150)
INSERT [dbo].[Plane] ([PlaneID], [PlaneName], [Capacity]) VALUES (3, N'Airbus A350XWB.', 200)
INSERT [dbo].[Plane] ([PlaneID], [PlaneName], [Capacity]) VALUES (4, N'Boeing 737-300', 50)
INSERT [dbo].[Plane] ([PlaneID], [PlaneName], [Capacity]) VALUES (5, N'Airbus A350XWB', 250)
SET IDENTITY_INSERT [dbo].[Plane] OFF
GO
INSERT [dbo].[Reservation] ([Flight_id], [Jmbg], [NumOfSeats]) VALUES (1, N'2607973721428', 4)
GO
INSERT [dbo].[User] ([Jmbg], [FirstName], [LastName], [Username], [Password], [IsAdmin]) VALUES (N'0511001720028', N'Dimitrije', N'Ostojic', N'dimi', N'870051a4cdc4cda1e2286259dc52e4fabd17d98f736f091d19339bcfb05fa6c7', 1)
INSERT [dbo].[User] ([Jmbg], [FirstName], [LastName], [Username], [Password], [IsAdmin]) VALUES (N'2607973721428', N'Borivoje', N'Ostojic', N'boki', N'b8592a5b51847d917f755f1548ca443780dd62f729a8d7463ea1e5e7153bb0dc', 0)
INSERT [dbo].[User] ([Jmbg], [FirstName], [LastName], [Username], [Password], [IsAdmin]) VALUES (N'9876543210147', N'Snezana', N'Ostojic', N'sneska', N'1310d5175141957df484174dd5a961f74590d0034f76b7f52ea501aaba376538', 0)
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airport] FOREIGN KEY([DepartureAirportID])
REFERENCES [dbo].[Airport] ([AirportID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airport]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Airport1] FOREIGN KEY([ArrivalAirportID])
REFERENCES [dbo].[Airport] ([AirportID])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Airport1]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_Plane] FOREIGN KEY([Plane])
REFERENCES [dbo].[Plane] ([PlaneID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_Plane]
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK_Flight_User1] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([Jmbg])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK_Flight_User1]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Flight] FOREIGN KEY([Flight_id])
REFERENCES [dbo].[Flight] ([Flight_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Flight]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_User] FOREIGN KEY([Jmbg])
REFERENCES [dbo].[User] ([Jmbg])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_User]
GO
USE [master]
GO
ALTER DATABASE [ProjekatSoftveri] SET  READ_WRITE 
GO
