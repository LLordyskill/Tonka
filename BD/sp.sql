USE 5to_Barcelonatonka;
DROP PROCEDURE IF EXISTS Insertar;
CREATE PROCEDURE Insertar( 
    IN xtecnico VARCHAR(45), 
    OUT xidtecnico TINYINT)
BEGIN 
    INSERT INTO Cuerpo_Tecnico (tecnico) 
    VALUES (xtecnico); 
    SET xidtecnico = LAST_INSERT_ID();
END;

DROP FUNCTION IF EXISTS NameCom;
CREATE FUNCTION NameCom(idJugador SMALLINT) RETURNS VARCHAR(50)
BEGIN
    DECLARE fullName VARCHAR(50);
    SELECT CONCAT(nombre, ' ', apellido) INTO fullName
    FROM Jugador
    WHERE Jugador.idJugador = idJugador;
    RETURN fullName;
END;

DROP PROCEDURE IF EXISTS ProcesarNuevoGol;
CREATE PROCEDURE ProcesarNuevoGol(IN id_jugador SMALLINT)
BEGIN
    CALL MostrarDetallesJugador(id_jugador);
END;

DROP TRIGGER IF EXISTS AfteRInsertPosicion;
CREATE TRIGGER AfteRInsertPosicion
AFTER INSERT ON Posicion
FOR EACH ROW
BEGIN
    CALL ProcesarNuevoposicion(NEW.posicion);
END;

DROP PROCEDURE IF EXISTS InsertJugador;
CREATE PROCEDURE InsertJugador (
    IN idJugador SMALLINT, 
    IN idPais TINYINT, 
    IN idPosicion TINYINT, 
    IN nombre VARCHAR(45), 
    IN apellido VARCHAR(45), 
    IN nacimiento DATE, 
    IN numCamiseta TINYINT UNSIGNED)
BEGIN
    INSERT INTO Jugador (idJugador, idPais, idPosicion, nombre, apellido, nacimiento, numCamiseta) 
    VALUES (idJugador, idPais, idPosicion, nombre, apellido, nacimiento, numCamiseta);
END;

DROP FUNCTION IF EXISTS CalcularEdad;
CREATE FUNCTION CalcularEdad(fecha_nacimiento DATE) RETURNS INT
BEGIN
    DECLARE edad INT;
    SET edad = TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE());
    RETURN edad;
END;

DROP PROCEDURE IF EXISTS NewNumCam;
CREATE PROCEDURE NewNumCam( 
    IN idJugadorUpdate SMALLINT, 
    IN nuevoNumeroCamiseta TINYINT UNSIGNED)
BEGIN
    UPDATE Jugador
    SET numCamiseta = nuevoNumeroCamiseta
    WHERE idJugador = idJugadorUpdate;
END;

DROP FUNCTION IF EXISTS Tecnico;
CREATE FUNCTION Tecnico(tecnico VARCHAR(45)) RETURNS VARCHAR(45)
BEGIN
    RETURN tecnico;
END;
