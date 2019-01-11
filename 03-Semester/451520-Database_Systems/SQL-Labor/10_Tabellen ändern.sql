-- Tabellen aendern

--1
ALTER TABLE Autor
DROP CONSTRAINT ckGeschlecht,deGeschlecht, COLUMN Geschlecht

--2
ALTER TABLE Autor
ADD Geschlecht CHAR(1) NOT NULL CONSTRAINT deGeschlecht DEFAULT 'w',
CONSTRAINT ckGeschlecht CHECK(Geschlecht IN ('m', 'w'))

--3
ALTER TABLE Buch
DROP CONSTRAINT dePreis, ckPreis, COLUMN Provision, Preis

--4
ALTER TABLE Buch
ADD Preis	numeric(5,2) CONSTRAINT dePreis DEFAULT 21.99,
Provision AS Preis * 0.05, 
CONSTRAINT ckPreis CHECK(Preis > 20 AND Preis <120)

--5
ALTER TABLE Bank
ALTER COLUMN Hausnummer varchar(5)

--6
DROP TABLE Autorenschaft; 

--7
CREATE TABLE Autorenschaft
(
ISBN	bigint,
AutorID dtyp_AutID NOT NULL,
Beitrag numeric(5,2) NOT NULL,
Erfassungsdatum date CONSTRAINT de_Erfassungsdatum DEFAULT GETDATE(),
CONSTRAINT pkAutorenschaft PRIMARY KEY (ISBN, AutorID),
CONSTRAINT fk_Autorenschaft1 FOREIGN KEY(ISBN)
REFERENCES Buch(ISBN)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT fk_Autorenschaft2 FOREIGN KEY (AutorID)
REFERENCES AUtor(AutorID)
ON DELETE NO ACTION
ON UPDATE CASCADE
)

