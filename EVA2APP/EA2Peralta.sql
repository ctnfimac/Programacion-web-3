USE [master]

DROP DATABASE IF EXISTS EVA2DB;
GO

CREATE DATABASE EVA2DB;
GO

USE [EVA2DB];
GO


CREATE TABLE [dbo].[Competidor](
	[IdCompetidor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](300) NOT NULL,
	CONSTRAINT Competidor_PK PRIMARY KEY(IdCompetidor)
)
GO


CREATE TABLE [dbo].[Premio](
	[IdPremio] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Anio] [nvarchar](300) NOT NULL,
	[IdCompetidor] [int] NOT NULL,
	CONSTRAINT Premio_PK PRIMARY KEY(IdPremio),
	CONSTRAINT Premio_Competidor_FK FOREIGN KEY(IdCompetidor) REFERENCES Competidor(IdCompetidor)
)
GO

select * from [dbo].[Competidor]
go

select * from [dbo].[Premio]
go

delete from [dbo].[Premio] 
where IdPremio = 4;

truncate table [dbo].[Premio];
go