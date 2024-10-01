INSERT INTO Pais (idPais, nombre) VALUES
(1, 'España'),
(2, 'Argentina'),
(3, 'Brasil'),
(4, 'Uruguay'),
(5, 'Francia'),
(6, 'Países Bajos'),
(7, 'Alemania'),
(8, 'Polonia'),
(9, 'Portugal'),
(10, 'Italia');

INSERT INTO Posicion (idPosicion, posicion) VALUES
(1, 'PO'),   
(2, 'DFC'),  
(3, 'LI'),   
(4, 'LD'),   
(5, 'MC'),   
(6, 'MCD'),  
(7, 'MCO'),  
(8, 'MD'),   
(9, 'MI'),   
(10, 'EI'),  
(11, 'ED'),  
(12, 'DC');  

INSERT INTO Jugador (idJugador, idPais, idPosicion, nombre, apellido, nacimiento, numCamiseta) VALUES
(1, 7, 1, 'Marc-André', 'ter Stegen', '1992-04-30', 1),
(2, 1, 1, 'Iñaki', 'Peña', '1992-04-30', 13),
(3, 4, 2, 'Ronald', 'Araujo', '1999-03-07', 4),
(4, 5, 2, 'Jules', 'Kounde', '1998-11-12', 23),
(5, 1, 3, 'Alejandro', 'Balde', '2003-10-18', 3),
(6, 9, 4, 'Joao', 'Cancelo', '1994-05-27', 2),
(7, 1, 2, 'Iñigo', 'Martínez', '1991-05-17', 5),
(8, 1, 4, 'Sergi', 'Roberto', '1992-02-07', 36),
(9, 1, 5, 'Pablo', 'Gaviria', '2004-08-05', 6),
(10, 1, 5, 'Pedri', 'González', '2002-11-25', 8),
(11, 6, 5, 'Frenkie', 'de Jong', '1997-05-12', 21),
(12, 7, 5, 'Ilkay', 'Gundogan', '1990-09-24', 22),
(13, 1, 6, 'Oriol', 'Romeu', '1991-09-24', 18),
(14, 1, 10, 'Ansu', 'Fati', '2002-10-31', 10),
(15, 9, 12, 'João', 'Félix', '1999-11-10', 14),
(16, 8, 12, 'Robert', 'Lewandowski', '1988-08-21', 9),
(17, 3, 12, 'Vitor', 'Roque', '2005-02-28', 99),
(18, 3, 11, 'Raphael', 'Dias', '1996-12-14', 11),
(19, 1, 10, 'Ferran', 'Torres', '2000-02-29', 7),
(20, 1, 11, 'Lamine', 'Yamal', '2007-07-13', 19),
(21, 1, 12, 'Pau', 'Victor', '2001-11-26', 26);

INSERT INTO Cuerpo_Tecnico (idTecnico, tecnico, idJugador) VALUES 
(1, 'Hansi Flick', 1),
(2, 'MARCUS SORG', 2),
(3, 'TONI TAPALOVIC', 3),
(4, 'HEIKO WESTERMANN', 4);

INSERT INTO Gol (idGol, descripcion) VALUES
(1, 'Gol 1'),
(2, 'Gol 2'),
(3, 'Gol 3'),
(4, 'Gol 4'),
(5, 'Gol 5'),
(6, 'Gol 6'),
(7, 'Gol 7'),
(8, 'Gol 8'),
(9, 'Gol 9'),
(10, 'Gol 10'),
(11, 'Gol 11'),
(12, 'Gol 12'),
(13, 'Gol 13'),
(14, 'Gol 14'),
(15, 'Gol 15'),
(16, 'Gol 16'),
(17, 'Gol 17'),
(18, 'Gol 18'),
(19, 'Gol 19'),
(20, 'Gol 20');

INSERT INTO Jugador_Gol (idJugador, idGol) VALUES
(1, 1),
(2, 5),
(3, 6),
(4, 3),
(5, 2),
(6, 7),
(7, 8),
(8, 9),
(9, 10),
(10, 11),
(11, 12),
(12, 13),
(13, 14),
(14, 15),
(15, 16),
(16, 17),
(17, 18),
(18, 19),
(19, 20),
(20, 1),
(21, 2);


