DECLARE @DBNAME_TEMP VARCHAR(255)
DECLARE @DBNAME VARCHAR(255)
DECLARE @USER VARCHAR(255)
SET @USER = stuff(suser_sname(), 1, charindex('\', suser_sname()), '')
SET @DBNAME = CONCAT('[Verlag_', @USER, ']' )

DECLARE @DELETE_TEMPLATE VARCHAR(MAX)
SET @DELETE_TEMPLATE = 'DROP DATABASE IF EXISTS {DBNAME}'
DECLARE @DELETE_SCRIPT VARCHAR(MAX)
SET @DELETE_SCRIPT = REPLACE(@DELETE_TEMPLATE, '{DBNAME}', @DBNAME)
EXECUTE (@DELETE_SCRIPT)
GO

DECLARE @COMPAT_TEMPLATE VARCHAR(MAX)
DECLARE @RECOVERY_TEMPLATE VARCHAR(MAX)
DECLARE @CREATE_TEMPLATE VARCHAR(MAX)

SET @CREATE_TEMPLATE = 'CREATE DATABASE {DBNAME}'
SET @COMPAT_TEMPLATE='ALTER DATABASE {DBNAME} SET COMPATIBILITY_LEVEL = 100'
SET @RECOVERY_TEMPLATE='ALTER DATABASE {DBNAME} SET RECOVERY SIMPLE'


DECLARE @DBNAME_TEMP VARCHAR(255)
DECLARE @DBNAME VARCHAR(255)
DECLARE @USER VARCHAR(255)
SET @USER = stuff(suser_sname(), 1, charindex('\', suser_sname()), '')
SET @DBNAME = CONCAT('[Verlag_', @USER, ']' )

DECLARE @DATA_TEMPLATE VARCHAR(MAX)
SET @DATA_TEMPLATE = '
--Datenbank anlegen
USE {DBNAME}

CREATE TABLE Buch
(
ISBN	bigint CONSTRAINT pkBuch PRIMARY KEY,
Titel 	varchar(50) NOT NULL,
Verlag 	varchar(50) NOT NULL,
Erscheinungsjahr	smallint,
Preis	numeric(5,2) CONSTRAINT dePreis DEFAULT 20.00,
CONSTRAINT ckPreis CHECK(Preis > 19.99)
)

CREATE TABLE Mitarbeiter

(
MitarbeiterID int IDENTITY(1,1) CONSTRAINT pkMitarbeiter PRIMARY KEY,
Plz int NOT NULL,
Ort varchar(30) NOT NULL,
Vorgesetzter int,
Abteilung varchar(30),
Vorname varchar(30) NOT NULL,
Nachname varchar(30) NOT NULL,
CONSTRAINT fk_Vorgesetzter FOREIGN KEY (Vorgesetzter)
REFERENCES Mitarbeiter(MitarbeiterID)
ON UPDATE NO ACTION
ON DELETE NO ACTION
)

CREATE TABLE Autor
(
AutorID int Identity(1,1),
Nachname varchar(30) NOT NULL,
Vorname varchar(30) NOT NULL,
Geschlecht char(1) NOT NULL CONSTRAINT deGeschlecht DEFAULT ''w'',
Ort varchar(30), 
Plz int,
Betreuer int,
CONSTRAINT ckGeschlecht CHECK(Geschlecht IN (''m'', ''w'')),
CONSTRAINT pkAutor PRIMARY KEY (AutorID),
CONSTRAINT fkBetreuer FOREIGN KEY (Betreuer)
REFERENCES Mitarbeiter(MitarbeiterID)
)

CREATE TABLE Autorenschaft
(
ISBN	bigint,
AutorID int,
Erfassungsdatum date NOT NULL CONSTRAINT de_Erfassungsdatum DEFAULT GETDATE(),
CONSTRAINT pkAutorenschaft PRIMARY KEY (ISBN, AutorID),
CONSTRAINT fk_Autorenschaft_ISBN FOREIGN KEY(ISBN)
REFERENCES Buch(ISBN)
ON DELETE CASCADE
ON UPDATE CASCADE,
CONSTRAINT fk_Autorenschaft_AutorID FOREIGN KEY (AutorID)
REFERENCES Autor(AutorID)
ON DELETE CASCADE
ON UPDATE CASCADE
)

CREATE TABLE Konto
(
IBAN varchar(30),
Autor int NOT NULL,
CONSTRAINT pkKonto PRIMARY KEY(IBAN),
CONSTRAINT fk_Konto_Autor FOREIGN KEY (Autor)
REFERENCES Autor(AutorID)
ON UPDATE CASCADE
ON DELETE CASCADE,
)

-- Werte einfuegen 
USE {DBNAME}

--Mitarbeiter
INSERT INTO Mitarbeiter(Nachname, Vorname, Vorgesetzter, Abteilung, Plz, Ort)
VALUES(''Weiß'', ''Sabine'', NULL, ''Finanzen'', 22222, ''Hamburg''), 
(''Probst'', ''Stefan'', NULL, NULL, 22222, ''Hamburg''), 
(''Grunewald'', ''Ursel'', NULL, ''Finanzen'', 22222, ''Hamburg''), 
(''Meyer'', ''Hannes'', NULL, ''Finanzen'', 22222, ''Hamburg''), 
(''Müller'', ''Bärbel'',4, ''Finanzen'', 22222, ''Hamburg''), 
(''Asmussen'', ''Stefan'', NULL, ''Marketing'', 33333, ''Nordenhamm''), 
(''Schumacher'', ''Marion'', NULL, ''Technologie'', 19345, ''Berlin'')

--Autor
INSERT INTO Autor(Vorname, Nachname, Geschlecht, Ort, Plz, Betreuer)
Values(''Anke'', ''Baumgartner'', ''w'', ''Steinhöring'', 85641, 1), 
(''Swen'', ''Berg'', ''m'', ''Steinhöring'', 85641, 1), 
(''Nicole'', ''Osterhagen'', ''w'', ''Steinhöring'', 85641, 2), 
(''Mario'', ''Ebersbach'', ''m'', ''Alfhausen'', 49594, 2), 
(''Annett'', ''Schultheiß'', ''w'', ''Oberthal'', 66647, 2), 
(''Sabine'', ''Muster'', ''w'', ''Hamburg'', 22222, 1),
(''Wolfgang'', ''Eisenhaer'',''m'', ''Frechen'', ''50226'', 2)

--Buch
INSERT INTO Buch(ISBN, Titel, Verlag, Erscheinungsjahr, Preis)
Values(1111111111,''Einführung Wirtschaftsinformatik'', ''GutDruck'', 2016, 69.99), 
(2222222222,''Grundlagen Datenbanksysteme'', ''GutDruck'', 2007, 29.99), 
(3333333333,''Technoligevorausschau'', ''Neue Bücher'', 2015, 35.49),
(4444444444,''Strategisches Management'', ''Neue Bücher'', 2016, 25.99),
(5555555555,''Wirtschaftsinformatik für Fortgeschrittene'', ''Books Unlimited'', 2013, 59.99),
(6666666666,''Data Science für Dummies'', ''GutDruck'', 2017, 21.99),
(7777777777,''Data Science revisted'', ''GutDruck'', 2017, 25.99),
(8888888888, ''New Art of Data Science'', ''GutDruck'', NULL, NULL)

--Autorenschaft
INSERT INTO Autorenschaft(ISBN, AutorID)
VALUES (1111111111,2),
(1111111111,3), 
(2222222222,2), 
(2222222222,4), 
(5555555555,5)

--Konto
INSERT INTO Konto(IBAN, Autor)
VALUES(22334455, 2), (55667788, 3), (566667788, 3)

'



DECLARE @SQL_SCRIPT VARCHAR(MAX)

SET @SQL_SCRIPT = REPLACE(@CREATE_TEMPLATE, '{DBNAME}', @DBNAME)
EXECUTE (@SQL_SCRIPT)

SET @SQL_SCRIPT = REPLACE(@COMPAT_TEMPLATE, '{DBNAME}', @DBNAME)
EXECUTE (@SQL_SCRIPT)

SET @SQL_SCRIPT = REPLACE(@RECOVERY_TEMPLATE, '{DBNAME}', @DBNAME)
EXECUTE (@SQL_SCRIPT)

SET @SQL_SCRIPT = REPLACE(@DATA_TEMPLATE, '{DBNAME}', @DBNAME)
EXECUTE (@SQL_SCRIPT)



