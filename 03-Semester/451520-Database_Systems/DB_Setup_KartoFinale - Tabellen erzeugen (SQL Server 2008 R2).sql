CREATE DATABASE KartoFinale
GO

USE KartoFinale
GO

CREATE SCHEMA Personal
GO

CREATE TABLE Ort 
(
	Ort VARCHAR(200) NOT NULL,
	Plz INTEGER NOT NULL,
	Bundesland CHAR(5) NOT NULL,
	Laengengrad DECIMAL(8 , 5) NULL,
	Breitengrad DECIMAL(8 , 5) NULL,
	CONSTRAINT pk_Ort PRIMARY KEY (Ort, Plz),
	CONSTRAINT di_Plz CHECK (Plz>0 AND Plz<=99999),
	CONSTRAINT di_Bundesland CHECK(Bundesland IN ('BW', 'BY', 'BE', 'BB', 'HB', 'HH', 'HE', 'MV', 'NI', 'NW', 'RP', 'SL', 'SN', 'ST', 'SH', 'TH'))
)
GO
 
CREATE TABLE Personal.Abteilung 
(
	Abteilungsbezeichnung VARCHAR(30) NOT NULL,
	Abteilungsnummer INTEGER NOT NULL,
	PersonalnummerAbteilungsleiter INTEGER,
	CONSTRAINT Abteilung_PK PRIMARY KEY (Abteilungsbezeichnung),
	CONSTRAINT AbteilungsleiterObligatory CHECK (PersonalnummerAbteilungsleiter IS NOT NULL)
)
GO

CREATE TABLE Personal.Mitarbeiter 
(
	Personalnummer INTEGER NOT NULL,
	Name VARCHAR(30) NOT NULL,
	Vorname VARCHAR(20) NOT NULL,
	Strasse VARCHAR(50) NOT NULL,
	Hausnummer CHAR(6) NULL,
	Geschlecht CHAR(1) DEFAULT 'W' NOT NULL,
	Gehalt DECIMAL(7 , 2) NOT NULL,
	Abteilungsbezeichnung VARCHAR(30) NULL,
	PersonalnummerVorgesetzter INTEGER NULL,
	Ort VARCHAR(200) NULL,
	Plz INTEGER NULL,
	CONSTRAINT Mitarbeiter_PK PRIMARY KEY (Personalnummer),
	CONSTRAINT Mitarbeiter_Abteilung_FK FOREIGN KEY (Abteilungsbezeichnung)
		REFERENCES Personal.Abteilung(Abteilungsbezeichnung),
	CONSTRAINT Mitarbeiter_Ort_FK FOREIGN KEY (Ort, Plz) REFERENCES Ort(Ort, Plz)	
)
GO

ALTER TABLE Personal.Abteilung ADD 
    CONSTRAINT Abteilung_Mitarbeiter_FK FOREIGN KEY (PersonalnummerAbteilungsleiter)
		REFERENCES Personal.Mitarbeiter(Personalnummer)
GO

CREATE TABLE Ehepartner 
(
	Name VARCHAR(30) NOT NULL,
	Vorname VARCHAR(20) NOT NULL,
	Geburtsdatum DATE NULL,
	Personalnummer INTEGER NOT NULL,
	CONSTRAINT Ehepartner_PK PRIMARY KEY (Personalnummer),
	CONSTRAINT Ehepartner_Mitarbeiter_FK FOREIGN KEY (Personalnummer)
		REFERENCES Personal.Mitarbeiter(Personalnummer)
)
GO

CREATE TABLE Kunde 
(
	Kundennummer INTEGER NOT NULL,
	Name VARCHAR(30) NOT NULL,
	Vorname VARCHAR(20) NOT NULL,
	Strasse VARCHAR(50) NOT NULL,
	Hausnummer CHAR(6) NULL,
	Geschlecht CHAR(1) DEFAULT 'W' NULL,
	Geburtsdatum DATE NULL,
	Ort VARCHAR(200) NULL,
	Plz INTEGER NULL,
	CONSTRAINT pk_Kunde PRIMARY KEY (Kundennummer),
	CONSTRAINT di_Geschlecht CHECK (Geschlecht='W' OR Geschlecht='M'),
	CONSTRAINT Kunde_Ort_FK FOREIGN KEY (Ort, Plz) 
		REFERENCES Ort(Ort, Plz)
		ON DELETE SET NULL
		ON UPDATE CASCADE
)
GO

CREATE TABLE Bestellung 
(
	BestellNr INTEGER NOT NULL,
	Datum DATE NOT NULL,
	Personalnummer INTEGER NOT NULL,
	Kundennummer INTEGER NOT NULL,
	CONSTRAINT pk_Bestellung PRIMARY KEY (BestellNr),
	CONSTRAINT Bestellung_Mitarbeiter_FK FOREIGN KEY (Personalnummer)
		REFERENCES Personal.Mitarbeiter(Personalnummer),
	CONSTRAINT Bestellung_Kunde_FK FOREIGN KEY (Kundennummer)
		REFERENCES Kunde(Kundennummer)
)
GO

CREATE TABLE Artikel 
(
	Artikelnummer INTEGER NOT NULL,
	Preis DECIMAL(8 , 2) NOT NULL,
	CONSTRAINT Artikel_PK PRIMARY KEY (Artikelnummer)
)
GO

CREATE TABLE Bestellposten 
(
	Positionsnummer INTEGER NOT NULL,
	Menge INTEGER DEFAULT 1 NOT NULL,
	BestellNr INTEGER NOT NULL,
	Artikelnummer INTEGER NOT NULL,
	CONSTRAINT Bestellposten_PK PRIMARY KEY (BestellNr, Positionsnummer),
	CONSTRAINT Bestellposten_Bestellung_FK FOREIGN KEY (BestellNr)
		REFERENCES Bestellung(BestellNr) 
		ON DELETE CASCADE,
	CONSTRAINT Bestellposten_Artikel_FK FOREIGN KEY (Artikelnummer)
		REFERENCES Artikel(Artikelnummer)
)
GO

CREATE TABLE Werbeartikel 
(
	Bezeichnung VARCHAR(50) NOT NULL,
	Lagerbestand INTEGER NOT NULL,
	Mindestbestand INTEGER NULL,
	Artikelnummer INTEGER NOT NULL,
	CONSTRAINT Werbeartikel_PK PRIMARY KEY	(Artikelnummer),
	CONSTRAINT Werbeartikel_Artikel_FK FOREIGN KEY (Artikelnummer)
		REFERENCES Artikel(Artikelnummer)
)
GO

CREATE TABLE Veranstaltung 
(
	Veranstaltungsnummer INTEGER NOT NULL,
	Bezeichnung VARCHAR(200) NOT NULL,
	Beschreibung VARCHAR(200) NULL,
	Autor VARCHAR(100) NULL,
	CONSTRAINT Veranstaltung_PK PRIMARY KEY	(Veranstaltungsnummer)
)
GO

CREATE TABLE Spielstätte 
(
	Haus CHAR(100) NOT NULL,
	Strasse CHAR(50) NOT NULL,
	Hausnummer CHAR(6) NULL,
	Beschreibung VARCHAR(1000) NOT NULL,
	Ort VARCHAR(200) NULL,
	Plz INTEGER NULL,
	CONSTRAINT Spielstätte_PK PRIMARY KEY (Haus),
	CONSTRAINT Spielstätte_Ort_FK FOREIGN KEY (Ort, Plz)
		REFERENCES Ort(Ort, Plz)
)
GO

CREATE TABLE Vorstellung 
(
	Vorstellungsnummer INTEGER NOT NULL,
	Datum DATE NOT NULL,
	Uhrzeit TIME NOT NULL,
	Veranstaltungsnummer INTEGER NOT NULL,
	Haus CHAR(100) NULL,
	CONSTRAINT Vorstellung_PK PRIMARY KEY (Veranstaltungsnummer, Vorstellungsnummer),
	CONSTRAINT Vorstellung_Veranstaltung_FK FOREIGN KEY(Veranstaltungsnummer)
		REFERENCES Veranstaltung(Veranstaltungsnummer)
		ON DELETE CASCADE,
	CONSTRAINT Vorstellung_Spielstätte_FK FOREIGN KEY (Haus)
		REFERENCES Spielstätte(Haus)
		ON DELETE NO ACTION
)
GO

CREATE TABLE Sitzplatz 
(
	Bereich VARCHAR(50) NOT NULL,
	Reihe CHAR(6) NULL,
	Sitznummer CHAR(6) NULL,
	Zustand VARCHAR(20) NOT NULL,
	Artikelnummer INTEGER NOT NULL,
	Vorstellungsnummer INTEGER NOT NULL,
	Veranstaltungsnummer INTEGER NOT NULL,
	CONSTRAINT Sitzplatz_PK PRIMARY KEY (Artikelnummer),
	CONSTRAINT Sitzplatz_Artikel_FK FOREIGN KEY (Artikelnummer)
		REFERENCES Artikel(Artikelnummer),
	CONSTRAINT Sitzplatz_Vorstellung_FK FOREIGN KEY (Veranstaltungsnummer, Vorstellungsnummer)
		REFERENCES Vorstellung(Veranstaltungsnummer, Vorstellungsnummer)
	ON DELETE CASCADE
)
GO

