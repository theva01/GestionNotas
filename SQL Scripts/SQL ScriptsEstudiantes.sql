CREATE DATABASE Anderson_NotasDB

USE Anderson_NotasDB;

CREATE TABLE Estudiantes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroId VARCHAR(20) NOT NULL,
    Nombre NVARCHAR(50) NOT NULL,
	Apellido NVARCHAR(50) NOT NULL,
    FechaNacimiento DATE,
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15),
	Correo NVARCHAR(40)
);

 SELECT * FROM Estudiantes;
--Drop table Estudiantes

--CREATE PROCEDURE InsertarEstudiante
--    @NumeroId VARCHAR(20),
--    @Nombre NVARCHAR(50),
--    @Apellido NVARCHAR(50),
--    @FechaNacimiento DATE,
--    @Direccion NVARCHAR(200),
--    @Telefono NVARCHAR(15),
--    @Correo NVARCHAR(40)
--AS
--BEGIN
--    INSERT INTO Estudiantes (NumeroId, Nombre, Apellido, FechaNacimiento, Direccion, Telefono, Correo)
--    VALUES (@NumeroId, @Nombre, @Apellido, @FechaNacimiento, @Direccion, @Telefono, @Correo);
--END;


--Drop procedure InsertarEstudiante


-- Registro para porbar
INSERT INTO Estudiantes (NumeroId, Nombre, Apellido, FechaNacimiento, Direccion, Telefono, Correo) 
VALUES 
    ('123', N'Juan', 'Ortis', '2000-01-01', N'Calle 123', '1234567890', 'jortis@gmail.com'),
    ('456', N'Mara', 'Ester','1999-02-15', N'Avenida 456', '0987654321' , 'mester@gmail.com'),
    ('789', N'Pedro ', 'Garcia', '2001-05-20', N'Plaza 789', '5678901234', 'pgarcia@gmail.com'),
    ('012', N'Luisa ', 'Marz', '1998-12-10', N'Paseo 012', '6789012345', 'lmarz@gmail.com'),
    ('345', N'Ana ', 'Lisalo', '2002-08-05', N'Bulevar 345', '7890123456', 'alisalo@gmail.com');

Select * FROM Estudiantes;


-- Consulta con NumeroID
SELECT * FROM Estudiantes WHERE NumeroId = '123';

-- Consulta con Nombre
SELECT * FROM Estudiantes WHERE Nombre = N'Juan Pérez';

-- Consulta de procedimientos
SELECT 
    OBJECT_NAME(object_id) AS NombreProcedimiento,
    create_date AS FechaCreacion
FROM 
    sys.procedures
ORDER BY 
    create_date DESC;


Select * From sys.procedures;
