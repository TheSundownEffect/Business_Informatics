-- --------------------------------------------------------
-- Filename:					SQL-Commands
-- Author:						Bräunlich, Christian
-- Study course:				Business Informatics
-- Module compartment:			Database Systems
-- --------------------------------------------------------


/* DDL (SQL Data Definition Language */

-- Datenbank anlegen.
CREATE DATABASE IF NOT EXISTS `databasename` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;
USE `databasename`;

-- Tabelle anlegen
CREATE TABLE IF NOT EXISTS `tablename` (
  `column1` int(11) DEFAULT NULL,
  `column2` int(11) DEFAULT NULL,
   KEY `column1` (`column1`)
) -- ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;


-- Änderung an bestehender Tabellenstruktur
ALTER TABLE myTable
MODIFY ( Nr NUMERIC(5) );

-- Spalten hinzufügen
ALTER TABLE myTable
ADD ( Tel NUMERIC(20),
	  Fax NUMERIC(20))
	  );

-- Tabelle löschen
DROP TABLE myTable
INCLUDING CONTENTS;


-- Fortlaufende Nummer vergeben (z. B. für Primärkey)
CREATE SEQUENCE Buch$Nr
INCREMENT BY 1 MINVALUE 1;
INSERT INTO Buch (
	Nr,
	Autor_Nr,
	Titel )
VALUES (
	Buch$Nr.NEXTVAL,
	10,
	'myBookTitle');
	


	
-- DQL (SQL Data Query Language)

-- Alle Daten einer Tabelle einlesen
SELECT * FROM myTable;

-- oder mit Anführungszeichen:
-- Groß- und Kleinschreibung wird berücksichtigt.
SELECT * FROM "my Table";

-- Sortierung (DESC = absteigend)
SELECT fieldName1, fieldName2
FROM myTable
ORDER BY fieldname2, fieldName1 DESC;

-- Vergleich mit Ignorierung von Groß-/Kleinbuchstaben.
-- Oracle:		UPPER()
-- MS-Access:	UCASE()
SELECT * FROM myTable
WHERE UCASE(fieldName1) =
UCASE('xy');

-- Suche mit Teilstrings
SELECT * FROM myTable
WHERE fieldName1 LIKE 'B%';

-- Suche mit Teilstrings ( ein _ steht für genau 1 Zeichen)
SELECT * FROM myTable
WHERE fieldName1 LIKE '_B';

-- Selektiere Zeilen, wo fieldName1 in angegebener Menge enthalten ist.
SELECT * FROM myTable
WHERE fieldName1 IN ( 11, 13, 17);

	

-- Join zweier Tabellen.
SELECT
	myTable1.fieldName3,
	myTable2.fieldName4
FROM myTable1,
	 myTable2
WHERE
myTable1.foreignKeyField = myTable2.primaryKeyField;


-- Join vierer Tabellen.
-- Bei Verknüpfung von n Tabellen sind n-1 Join-Kriterien erforderlich
SELECT Autor.Name,
	Autor.Vorname,
	Buch.Titel,
	Gebiet.Bez,
	Verlag.Name_Kurz
FROM Autor, Buch, Gebiet, Verlag
WHERE Buch.Autor_Nr = Autor. NR
AND Buch.Gebiet_Abk = Gebiet.Abk
AND Buch.Verlag_Nr = Verlag.Nr;

	

	
	
	
	
	
	

-- DML (SQL Data Manipulation Language)

-- Daten in bestehender Tabelle einfügen.
INSERT INTO myTable (
	Nr,
	Nachname,
	Vorname,
	GebJahr
) VALUES (
	1,
	'Hansen',
	'Max',
	1917
);
	
-- Daten in Tabelle ändern.
UPDATE myTable
SET Vorname = Maxi,
	GebJahr = NULL		-- NULL: Feld löschen
WHERE Nr = 1;

-- Zeilen löschen
DELETE FROM myTable
WHERE GebJahr < (SYSDATE - 3650);

-- Transaktion: Die seit dem vorherigen COMMIT-Kommando eingegebenen
-- SQL-DML-Kommandos wirklich ausführen.
COMMIT;

-- Transaktion: Die seit dem vorherigen COMMIT-Kommando eingegebenen
-- SQL-DML-Kommandos rückgängig machen.
ROLLBACK;

-- Locking einer ganzen Tabelle (bis zum nächsten COMMIT oder ROLLBACK)
-- (Locking einzelner Reihen geschieht automatisch bei Änderungen.)
LOCK TABLE myTable
IN EXCLUSIVE MODE NOWAIT;

-- Locking bestimmter SELECT ... WHERE ... ausgewählter Datensätze
-- (bis zum nächsten COMMIT oder ROLLBACK) schon beim Lesezugriff,
-- damit zwischen Lesezugriff und späterer Änderung kein anderer
-- Benutzer diese Datensätze ändern kann.
SELECT * FROM myTable
WHERE myFieldname = 'xy'
FOR UPDATE OF myFieldname;






-- DCL (SQL Data Control Language)

-- Rechte vergeben
GRANT SELECT, DELETE, UPDATE, REFERENCES(Nr) ON myTable TO Username;

-- Rechte entziehen
REVOKE DELETE ON myTable FROM Username;


