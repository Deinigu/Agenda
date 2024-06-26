USE [master]
GO
/****** Object:  Database [Agenda]    Script Date: 4/12/2024 11:51:15 AM ******/
CREATE DATABASE [Agenda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Agenda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Agenda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Agenda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Agenda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Agenda] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agenda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agenda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Agenda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Agenda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Agenda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Agenda] SET ARITHABORT OFF 
GO
ALTER DATABASE [Agenda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Agenda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Agenda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Agenda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Agenda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Agenda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Agenda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Agenda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Agenda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Agenda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Agenda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Agenda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Agenda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Agenda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Agenda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Agenda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Agenda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Agenda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Agenda] SET  MULTI_USER 
GO
ALTER DATABASE [Agenda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Agenda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Agenda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Agenda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Agenda] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Agenda] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Agenda] SET QUERY_STORE = OFF
GO
USE [Agenda]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 4/12/2024 11:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[BorrarContacto]    Script Date: 4/12/2024 11:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarContacto]
    @Id INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; 

        DELETE FROM Agenda.dbo.Contactos
        WHERE Id = @Id;

        COMMIT; 
    END TRY
    BEGIN CATCH
        ROLLBACK;
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[EditarContacto]    Script Date: 4/12/2024 11:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarContacto]
    @Id INT,
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Telefono VARCHAR(9),
    @Observaciones VARCHAR(500)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Agenda.dbo.Contactos
        SET 
            Nombre = @Nombre,
            FechaNacimiento = @FechaNacimiento,
            Telefono = @Telefono,
            Observaciones = @Observaciones
        WHERE Id = @Id;

        COMMIT; -- Confirmar la transacción si es exitosa
    END TRY
    BEGIN CATCH
        ROLLBACK; -- Revertir la transacción si ocurre un error

        -- Imprimir el mensaje de error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarContactos]    Script Date: 4/12/2024 11:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarContactos]
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        SELECT * FROM Agenda.dbo.Contactos;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        -- Throw an error message
        THROW;
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[NuevoContacto]    Script Date: 4/12/2024 11:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NuevoContacto]
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Telefono VARCHAR(9),
    @Observaciones VARCHAR(500)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; -- Start a transaction

        -- Your INSERT statement here
        INSERT INTO Agenda.dbo.Contactos
        (
            Nombre,
            FechaNacimiento,
            Telefono,
            Observaciones
        )
        VALUES
        (
            @Nombre,
            @FechaNacimiento,
            @Telefono,
            @Observaciones
        );

        COMMIT; -- Commit the transaction if successful
    END TRY
    BEGIN CATCH
        ROLLBACK; -- Rollback the transaction if an error occurs
        -- Print the error message
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
GO
USE [master]
GO
ALTER DATABASE [Agenda] SET  READ_WRITE 
GO
