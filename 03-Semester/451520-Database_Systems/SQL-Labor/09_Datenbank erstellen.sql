
DROP DATABASE Buch;
GO

USE Buch
GO

CREATE TYPE dtyp_AutID FROM int NOT NULL;
CREATE TYPE dtyp_Plz FROM int;
GO

CREATE TABLE Ort
(
Name varchar(30),
Plz dtyp_Plz NOT NULL,
Bundesland varchar(30) CONSTRAINT de_Bundesland DEFAULT 'SH',
Einwohnerzahl int NOT NULL,
Fläche numeric(12,2) NOT NULL,
Einwohner_qkm AS Einwohnerzahl / Fläche,
CONSTRAINT pkOrt PRIMARY KEY(Plz, Name),
CONSTRAINT ckPlz CHECK(Plz > 0 AND Plz <=99999),
CONSTRAINT ckBundesland CHECK(Bundesland IN ('NDS', 'HH', 'HB', 'SH'))

);

CREATE TABLE Buch
(
ISBN	bigint CONSTRAINT pkBuch PRIMARY KEY,
Titel 	varchar(50) NOT NULL,
Verlag 	varchar(50) NOT NULL,
Jahr	smallint CONSTRAINT deJahr DEFAULT YEAR(GETDATE()),
Preis	numeric(5,2) CONSTRAINT dePreis DEFAULT 21.99,
Provision AS Preis * 0.05, 
CONSTRAINT ckPreis CHECK(Preis > 20 AND Preis <120)
);

--1
CREATE TABLE Bank
(
BLZ int CONSTRAINT pkBank PRIMARY KEY,
Bezeichnung varchar(30) NOT NULL,
Ort varchar(30) NOT NULL,
Straße varchar(30) NOT NULL,
Hausnummer int NOT NULL,
Plz dtyp_Plz NOT NULL,
CONSTRAINT uBezeichnung UNIQUE(Bezeichnung, Ort),
CONSTRAINT fk_Bank FOREIGN KEY(Plz, Ort)
REFERENCES Ort (Plz, Name)
ON DELETE NO ACTION
ON UPDATE NO ACTION

);

--2
CREATE TABLE Autor
(
AutorID dtyp_AutID Identity(1,1),
Name varchar(30) NOT NULL,
Vorname varchar(30) NOT NULL,
Geschlecht char(1) NOT NULL,
Ort varchar(30),
Plz dtyp_Plz,
CONSTRAINT ckGeschlecht CHECK(Geschlecht IN ('m', 'w')),
CONSTRAINT pkAutor PRIMARY KEY (AutorID),
CONSTRAINT fk_Autor FOREIGN KEY(Plz, Ort)
REFERENCES Ort(Plz, Name)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

--3
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

--4
CREATE TABLE Konto
(
Kontonummer int,
BLZ int,
Autor dtyp_AutID,
Einrichtungsdatum datetime CONSTRAINT de_Einrichtungsdatum DEFAULT GETDATE(),
CONSTRAINT pkKonto PRIMARY KEY(Kontonummer, BLZ),
CONSTRAINT fk_Konto_Autor FOREIGN KEY (Autor)
REFERENCES Autor(AutorID)
ON UPDATE CASCADE
ON DELETE CASCADE,
CONSTRAINT fk_Konto_Bank FOREIGN KEY (BLZ)
REFERENCES BANK(BLZ)
ON UPDATE CASCADE
ON DELETE NO ACTION
);