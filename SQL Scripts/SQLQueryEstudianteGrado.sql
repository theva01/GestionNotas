CREATE TABLE EstudianteGrado
(
    EstudianteID VARCHAR(20) FOREIGN KEY REFERENCES Estudiantes(NumeroId),
    GradoID INT FOREIGN KEY REFERENCES Grados(ID),
    PRIMARY KEY (EstudianteID, GradoID)
);

--drop table EstudianteGrado

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
