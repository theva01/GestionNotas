-- ______________Grados______________ 

-- RF5: Registro de grados escolares
USE Anderson_NotasDB;

CREATE TABLE Grados
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Grado NVARCHAR(20) NOT NULL,
	Grupo NVARCHAR(10) NOT NULL
);

Select * from Grados;

CREATE PROCEDURE InsertarGrado
    @Grado NVARCHAR(20),
	@Grupo NVARCHAR(10)
AS
BEGIN
    INSERT INTO Grados (Grado, Grupo)
    VALUES ( @Grado, @Grupo)
END

EXEC InsertarGrado 'Sexto', 'A';

Select * From Grados;
