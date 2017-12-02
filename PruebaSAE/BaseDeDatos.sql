USE [master]
GO
/****** Object:  Database [PruebaHC2]    Script Date: 2/12/2017 10:28:22 a. m. ******/
CREATE DATABASE [PruebaHC2]
GO

USE [PruebaHC2]
GO
/****** Object:  Table [dbo].[Hijo]    Script Date: 2/12/2017 10:28:22 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hijo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPadre] [bigint] NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Hijo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Padre]    Script Date: 2/12/2017 10:28:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Padre](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Padre] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Hijo]  WITH CHECK ADD  CONSTRAINT [FK_Hijo_Padre] FOREIGN KEY([IdPadre])
REFERENCES [dbo].[Padre] ([Id])
GO
ALTER TABLE [dbo].[Hijo] CHECK CONSTRAINT [FK_Hijo_Padre]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarHijosPorPadre]    Script Date: 2/12/2017 10:28:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarHijosPorPadre]
	@idPadre bigint
AS
-- =============================================
-- Author:		Humberto Corredor
-- Create date: 2017-12-02
-- Description:	Consulta los hijos de un padre
-- =============================================
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Hijo where IdPadre = @idPadre
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarPadres]    Script Date: 2/12/2017 10:28:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarPadres]
AS
-- =============================================
-- Author:		Humberto Corredor
-- Create date: 2017-12-02
-- Description:	Consulta todos los padres
-- =============================================
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Padre
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarHijo]    Script Date: 2/12/2017 10:28:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarHijo]
	@idPadre bigint,
	@nombre nvarchar(200)
AS
-- =============================================
-- Author:		Humberto Corredor
-- Create date: 2017-12-02
-- Description:	Inserta un hijo
-- =============================================
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into Hijo (IdPadre, Nombre) values (@idPadre, @nombre)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarPadre]    Script Date: 2/12/2017 10:28:23 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarPadre]
	@nombre nvarchar(200)
AS
-- =============================================
-- Author:		Humberto Corredor
-- Create date: 2017-12-02
-- Description:	Inserta un padre
-- =============================================
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into Padre (Nombre) values (@nombre)
END

GO
