
USE [Agenda]
GO

/****** Object:  Table [dbo].[Contactos]    Script Date: 4/11/2024 11:33:31 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contactos]') AND type in (N'U'))
DROP TABLE [dbo].[Contactos]
GO

/****** Object:  Table [dbo].[Contactos]    Script Date: 4/11/2024 11:33:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contactos](
	[Id] [int] NOT NULL IDENTITY(1,1),
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

USE [Agenda]
GO

INSERT INTO [dbo].[Contactos]
           ([Nombre]
           ,[FechaNacimiento]
           ,[Telefono]
           ,[Observaciones])
     VALUES
           ('Diego','2002/07/18',608310124,'¡Soy yo! :D'),
		   ('Esther','2002/10/23',2122022,'Una máquina'),
		   ('Lucas','2002/02/27',12345678,'Mi amigo el Lucas'),
		   ('Ignacio','1990/06/03',600320124,'Tutor Avanade'),
		   ('Sergio','1994/12/27',650902132,'Tutor Avanade'),
		   ('Blanca','2002/03/07',612240421,'Teleco'),
		   ('Javi','2002/06/09',720119832,'Trompista'),
		   ('Maiki','2002/10/03',62265482,'Payaso'),
		   ('Alba','2003/06/23',12332112,'Jefa'),
		   ('Andrea','2004/09/09',32112333,'Cruz Roja'),
		   ('Félix','1999/07/02',690112233,'Gym coach'),
		   ('Manolo','1980/04/30',687902312,'Vecino');
GO


