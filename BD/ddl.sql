DROP DATABASE IF EXISTS 5to_Barcelonatonka;
CREATE DATABASE 5to_Barcelonatonka;
USE 5to_Barcelonatonka;

CREATE TABLE Pais (
idPais TINYINT NOT NULL,
nombre VARCHAR(45) NOT NULL,
    CONSTRAINT PK_idPais PRIMARY KEY (idPais)
);

CREATE TABLE Posicion (
idPosicion TINYINT NOT NULL,
posicion CHAR(13) NOT NULL,
    CONSTRAINT PK_idPosicion PRIMARY KEY (idPosicion),
    CONSTRAINT UQ_Posicion_posicion UNIQUE (posicion)
);

CREATE TABLE Jugador (
idJugador SMALLINT NOT NULL,
idPais TINYINT NOT NULL,
idPosicion TINYINT NOT NULL,
nombre VARCHAR(45) NOT NULL,
apellido VARCHAR(45) NOT NULL,
nacimiento DATE NOT NULL,
numCamiseta TINYINT UNSIGNED,
    CONSTRAINT PK_idJugador PRIMARY KEY (idJugador),
    CONSTRAINT FK_idPais FOREIGN KEY (idPais)
        REFERENCES Pais (idPais),
    CONSTRAINT FK_idPosicion FOREIGN KEY (idPosicion) 
        REFERENCES Posicion (idPosicion)
);

CREATE TABLE Cuerpo_Tecnico (
idTecnico TINYINT NOT NULL AUTO_INCREMENT,
tecnico VARCHAR(45) NOT NULL,
idJugador SMALLINT NOT NULL,
    CONSTRAINT PK_idTecnico PRIMARY KEY (idTecnico),
    CONSTRAINT FK_idJugador_Tecnico FOREIGN KEY (idJugador)
        REFERENCES Jugador(idJugador)
);

CREATE TABLE Gol (
idGol SMALLINT NOT NULL,
descripcion VARCHAR(255) NULL,
    CONSTRAINT PK_idGol PRIMARY KEY (idGol)
);

CREATE TABLE Jugador_Gol (
idJugador SMALLINT NOT NULL,
idGol SMALLINT NOT NULL,
    CONSTRAINT PK_JugadorGol PRIMARY KEY (idJugador, idGol),
    CONSTRAINT FK_idJugador_Gol FOREIGN KEY (idJugador) 
        REFERENCES Jugador(idJugador),
    CONSTRAINT FK_idGol FOREIGN KEY (idGol) REFERENCES Gol(idGol)
);

SELECT idJugador, CONCAT(nombre, ' ', apellido) AS NameCom
FROM Jugador;

SELECT nombre, apellido, nacimiento, 
    YEAR(CURDATE()) - YEAR(nacimiento) AS CalEdad
FROM Jugador
WHERE idJugador = 1;

