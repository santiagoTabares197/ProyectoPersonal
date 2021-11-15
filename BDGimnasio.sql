use [BDGimnasio]
GO
	
SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GuardarRutina]

@Musculos nvarchar(50),
@EjerciciosR nvarchar(50),
@Repeticiones int,
@Series int
as
INSERT INTO RutinaC(Musculos,EjerciciosR,Repeticiones,Series) values(@Musculos,@EjerciciosR,@Repeticiones,@Series)


CREATE PROCEDURE EliminarRutina
@id int
as
delete from RutinaC where id=@id

CREATE PROCEDURE ConsultarRutina
@id int
as
select * from RutinaC where id = @id


