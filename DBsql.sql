CREATE DATABASE Usuario

USE Usuario
GO
CREATE TABLE Empleado(
	[IdEmpleado] [decimal](18, 0) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[IdGenero] [decimal](18, 0) NULL,
	[IdCiudad] [decimal](18, 0) NULL,
)

ALTER TABLE Vinculacion add CONSTRAINT  PK_Empleado PRIMARY KEY (Idvinculacion)
GO

CREATE TABLE Vinculacion (
	[Idvinculacion] [decimal](18, 0) NOT NULL,
	[IdEmpleado] [decimal](18, 0) NOT NULL,
	[FechaIngreso] [datetime] NULL,
	[Idcargo] [decimal](18, 0) NULL,
	[FechaRetiro] [datetime] NULL,
	[FechaRegistro] [datetime] NULL,
 )
 ALTER TABLE Vinculacion add CONSTRAINT  [PK_Vinculacion] PRIMARY KEY (Idvinculacion)


ALTER TABLE Vinculacion  WITH CHECK ADD  CONSTRAINT FK_Vinculacion FOREIGN KEY(IdEmpleado)
REFERENCES dbo.Empleado (IdEmpleado)
GO

ALTER TABLE Vinculacion CHECK CONSTRAINT FK_Vinculacion
GO


