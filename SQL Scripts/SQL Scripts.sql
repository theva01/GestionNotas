CREATE DATABASE Anderson_NotasDB

USE Anderson_NotasDB;

CREATE TABLE Estudiantes (
    NumeroId VARCHAR(20) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE,
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15)
);

-- Indices
CREATE INDEX IX_NumeroId ON Estudiantes (NumeroID);
CREATE INDEX IX_Nombre ON Estudiantes (Nombre);
--DROP INDEX IX_NumeroId ON Estudiantes;
--DROP INDEX IX_Nombre ON Estudiantes;


--CREATE PROCEDURE InsertarEstudiante
--    @NumeroId VARCHAR(20),
--    @Nombre NVARCHAR(100),
--    @FechaNacimiento DATE,
--    @Direccion NVARCHAR(200),
--    @Telefono NVARCHAR(15)
--AS
--BEGIN
--    INSERT INTO Estudiantes (NumeroId, Nombre, FechaNacimiento, Direccion, Telefono)
--    VALUES (@NumeroId, @Nombre, @FechaNacimiento, @Direccion, @Telefono);
--END;


-- Registro para porbar
INSERT INTO Estudiantes (NumeroId, Nombre, FechaNacimiento, Direccion, Telefono) 
VALUES 
    ('123', N'Juan', '2000-01-01', N'Calle 123', '1234567890'),
    ('456', N'Mara', '1999-02-15', N'Avenida 456', '0987654321'),
    ('789', N'Pedro G', '2001-05-20', N'Plaza 789', '5678901234'),
    ('012', N'Luisa Marz', '1998-12-10', N'Paseo 012', '6789012345'),
    ('345', N'Ana Lisalo', '2002-08-05', N'Bulevar 345', '7890123456');

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

-- ______________Grados______________ 

-- RF5: Registro de grados escolares

CREATE TABLE Grados
(
    ID INT PRIMARY KEY,
    Grado NVARCHAR(50)
);

CREATE PROCEDURE InsertarGrado
    @ID INT,
    @Grado NVARCHAR(50)
AS
BEGIN
    INSERT INTO Grados (ID, Grado)
    VALUES (@ID, @Grado)
END

EXEC InsertarGrado 6, 'Sexto';

CREATE TABLE EstudianteGrado
(
    EstudianteID VARCHAR(20) FOREIGN KEY REFERENCES Estudiantes(NumeroId),
    GradoID INT FOREIGN KEY REFERENCES Grados(ID),
    PRIMARY KEY (EstudianteID, GradoID)
);


-- Ejemplo de uso

EXEC InsertarGrado 7, 'Septimo'
EXEC InsertarGrado 8, 'Octavo'
EXEC InsertarGrado 9, 'Noveno'
EXEC InsertarGrado 10, 'Decimo'
EXEC InsertarGrado 11, 'Once'

-- RF6: Asignación de estudiantes a grados específicos
CREATE PROCEDURE AsignarEstudianteGrado
    @EstudianteID VARCHAR(20),
    @GradoID INT
AS
BEGIN
    INSERT INTO EstudianteGrado (EstudianteID, GradoID)
    VALUES (@EstudianteID, @GradoID)
END

-- Asignar al estudiante con ID 123 al grado con ID 6
EXEC AsignarEstudianteGrado 123, 6 
EXEC AsignarEstudianteGrado 456, 7


-- RF7: Visualización de la lista de estudiantes por grado
CREATE PROCEDURE VerEstudiantesPorGrado
    @Grado NVARCHAR(50)
AS
BEGIN
    SELECT E.Nombre
    FROM Estudiantes E
    INNER JOIN EstudianteGrado EG ON E.NumeroId = EG.EstudianteID
    INNER JOIN Grados G ON EG.GradoID = G.ID
    WHERE G.Grado = @Grado
END

-- Ejemplo de uso
EXEC VerEstudiantesPorGrado 'Septimo'

--__________________________________________No Execute


-- Registros de ejemplo
INSERT INTO Estudiantes (NumeroId, Nombre, FechaNacimiento, Direccion, Telefono)
VALUES (1, 'Juan Perez', '2005-01-01', 'Calle 123', '3001234567')

INSERT INTO EstudianteGrado (EstudianteID, GradoID)
VALUES (1, 1) -- Asignamos a Juan Perez al grado Sexto
