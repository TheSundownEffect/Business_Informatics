-- 1. Der Kunde Bolte von KartoFinale hat geheiratet und der neue Name ist nicht bekannt. Geben Sie die Name und Vorname der Tabelle Kunde so aus, dass für den Namen 'Bolte' nun der Wert NULL bei der Ausgabe erscheint. 
USE KartoFinale
SELECT Vorname, NULLIF(Name, 'Bolte')
FROM Kunde

-- 2. Geben Sie die Artikelnummer und den Zustand der Sitzplätze aus der KartoFinale-Datenbank aus. 'Reserviert' und 'belegt' sollen als NULL ausgegeben werden. Geben Sie zur Kontrolle den ursprünglichen Zustand mit aus. 
USE KartoFinale;
SELECT Artikelnummer, NULLIF(NULLIF(Zustand, 'belegt'), 'reserviert'), Zustand
FROM Sitzplatz

--3. Geben Sie aus der Tabelle Mitarbeiter den Nachnamen und die Abteilung aus. Sofern keine Abteilung eingetragen ist, soll "Geschäftsführung" in der Spalte stehen. Achten Sie auf eine Bezeichnung der Spalte in der Ausgabe.
USE KartoFinale
SELECT Name, COALESCE(Abteilungsbezeichnung, 'Gesch‰ftsf¸hrung') AS Abteilung
FROM Personal.Mitarbeiter

--4 Fragen Sie die Bezeichnung und die Farbe der Artikel der KartoFinale-Datenbank ab. Ist keine Farbe vorhanden, soll dort das Maß ('Mass') eingetragen sein. Ist dies ebenfalls nicht vorhanden, soll die Bezeichnung wiedergegeben werden. 
USE Bike;
SELECT Bezeichnung, COALESCE(Farbe, Mass, Bezeichnung) AS Farbe
FROM Artikel

--5 Fragen Sie die Relation Kunde von KartoFinale. Geben Sie den Nachnamen und das Geburtsdatum aus und überführen Sie das Geburtsdatum der Kunden von KartoFinale in das Format varchar. 
USE KartoFinale;
SELECT Name, CAST(Geburtsdatum AS varchar) AS Geburtsdatum
FROM Kunde

--6 Fragen Sie die Tabelle Ort der KartoFinale-Datenbank ab. Verändern Sie den Längengrad so, dass 6 Nachkommastellen und 4 Vorkommastellen möglich sind. 
USE KartoFinale;
SELECT Ort, CAST(Laengengrad AS NUMERIC(10,6)), Laengengrad
FROM Ort

--7. Geben Sie die Differenz zwischen Laengengrad und Breitengrad der Orte in der KartoFinale-Datenbank als absoluten Wert aus.
USE KartoFinale;
SELECT Ort, ABS(Laengengrad - Breitengrad), Laengengrad - Breitengrad
FROM Ort

-- 8 Runden Sie die Steuer der Artikel in der Bike-Datenbank auf eine Nachkommastelle.
USE Bike;
SELECT Bezeichnung,  ROUND(Steuer,1)
FROM Artikel

-- 9 Berechnen Sie den Bruttopreis der Lieferungen in der Bike-Datenbank. Runden Sie die Bruttopreise  auf zwei Nachkommastellen. 
USE Bike
SELECT ROUND(Nettopreis * 1.19,1)
FROM Lieferung

-- 10 Berechnen Sie den Bruttopreis der Lieferungen in der Bike-Datenbank. Runden Sie die Bruttopreise  auf zwei Nachkommastellen und verändern Sie das Zahlenformat so, dass auch nur zwei Nachkommastellen dargestellt wird.
USE Bike
SELECT CAST(ROUND(Nettopreis * 1.19,1) AS NUMERIC(6,2))
FROM Lieferung

--11 Geben Sie die L‰nge der Namen der Mitarbeiter von KartoFinale wieder.
USE KartoFinale;
SELECT LEN(Name), Name
FROM Personal.Mitarbeiter

--12 Geben Sie Name und Vorname der Mitarbeiter aus der KartoFinale-Datenbank in einer gemeinsamen Spalte aus. Achten Sie darauf, dass zwischen Vorname und Nachname ein Leerzeichen ist. 
USE KartoFinale;
SELECT Concat(Vorname, ' ', Name) 
FROM Personal.Mitarbeiter

--13 Geben Sie Plz und Ort aus der Tabelle Ort in der KartoFinale-Datenbank als eine Spalte aus.
USE KartoFinale;
SELECT CONCAT(PLZ, ' ', Ort)
FROM Ort

--14. Geben Sie aus der KartoFinale-Datenbank die vollständige Adresse jedes Kunden in einer Spalte wieder (Strasse, Hausnummer, Plz, Ort). Werte können mit '+' und mit CONCAT verbunden werden. Welche Variante ist hier zu wählen und warum? Probieren Sie hierfür beide Varianten aus und vergleichen Sie die Ergebnisse. Achten Sie auf Lesbarkeit.
USE KartoFinale;
SELECT Strasse + ' ' + CAST(Hausnummer AS varchar) + ' ' + CAST(Plz as char(5)) + ' ' + Ort
FROM Kunde

USE KartoFinale;
SELECT CONCAT(Strasse, ' ', CAST(Hausnummer AS varchar),' ', CAST(Plz as char(5)),' ', Ort)
FROM Kunde
/*Vergleich der Ergebnisse: Werden Werte mit '+' verbunden, so wird NULL für den Eintrag zur¸ckgegeben, bei dem die Hausnummer nicht bekannt ist.*/

-- 15. Geben Sie in der KartoFinale-Datenbank den vollständigen Namen (Vorname und Nachname) der Ehepartner in einer Spalte wieder und bezeichnen Sie diese Spalte als "Name komplett". Verwenden Sie die Funktion 'CONCAT'. 
USE KartoFinale;
SELECT CONCAT(Vorname, ' ', Name) AS [Name komplett]
FROM Ehepartner;

-- 16. Sämtliche Veranstaltungen, die im Opernhaus stattfanden, werden in die Elbphilharmonie verlegt. Fragen Sie die Vorstellungsnummer und das Haus ab. Stellen Sie sicher, dass als Haus nicht "Hamburg Opernhaus", sondern "Hamburg Elbphilharmonie" angezeigt wird. 
USE KartoFinale;
SELECT Veranstaltungsnummer, REPLACE( Haus, 'Opernhaus', 'Elbphilharmonie') AS Haus
FROM Vorstellung

-- 17. Sämtliche Veranstaltungen, die im Opernhaus stattfanden, werden in die Elbphilharmonie verlegt. Fragen Sie die Vorstellungsnummer und das Haus ab. Stellen Sie sicher, dass als Haus nicht "Hamburg Opernhaus", sondern "Hamburg Elbphilharmonie" angezeigt wird.  Zudem steht die Nordseehalle nicht mehr zur Verfügung. Statt Nordseehalle soll der Wert NULL wiedergegeben werden. 
USE KartoFinale;
SELECT Veranstaltungsnummer, REPLACE(NULLIF(Haus, 'Nordseehalle'), 'Opernhaus', 'Elbphilharmonie') AS Haus
FROM Vorstellung

-- 18. Geben Sie die Preise der Artikel in der KartoFinale-Datenbank im Format "25.99 EURO" (Zwei Nachkommastellen, als Anhang den Text 'EURO') aus. 
USE KartoFinale;
SELECT  Artikelnummer, CONCAT(CAST(Preis AS varchar), ' ', 'EURO') AS "Preis mit Euro"
FROM Artikel

-- 19. Verändern Sie den Zustand "belegt" in der Tabelle Sitzplatz der KartoFinale-Datenbank in "besetzt" und geben Sie die Artikelnummern und deren Zustände wieder. 
USE KartoFinale
SELECT Artikelnummer, REPLACE(Zustand, 'setzt', 'legt') AS "Neuer Zustand"
FROM Sitzplatz

-- 20. Verändern Sie den Zustand "belegt" in der Tabelle Sitzplatz der KartoFinale-Datenbank in "besetzt". Achten Sie auf eine sinnvolle Spaltenbezeichnung. Geben Sie bitte die Zustände aller Artikel wieder. Behalten Sie die Änderung von "besetzt" in "belegt" bei. Bitte nutzen Sie REPLACE.
USE KartoFinale;
SELECT Artikelnummer, REPLACE(Zustand, 'legt','setzt') AS Zustand
FROM Sitzplatz

-- 21. Wie viele Jahre sind die Vorstellung in der KartoFinale-Datenbank her?
USE KartoFinale;
SELECT Year(GETDATE())-YEAR(Datum), Datum
FROM Vorstellung

-- 22. Berechnen Sie das alter der Mitarbeiter in der Bike-Datenbank in Tagen und in Jahren.
USE Bike;
SELECT DATEDIFF(day,  GebDatum, GETDATE()), DATEDIFF(year,  GebDatum, GETDATE()), GebDatum
FROM Personal

-- 23. Was gibt der Ausdruck NULLIF(10.99, 10.99) zurück?
SELECT NULLIF(10.99, 10.99)

-- 24 Was gibt der Ausdruck COALESCE(NULL, 1, NULL, 2) zurück?
SELECT COALESCE(NULL, 1, NULL, 2)

-- 25. Was gibt der Ausdruck COALESCE(NULLIF(10.99, 10.99), NULL, 1, NULL) zurück?
SELECT COALESCE(NULLIF(10.99, 10.99), NULL, 1, NULL)

-- 26. Was gibt der Ausdruck REPLACE('Das Wetter wird gut', 'gut', 'regnerisch') zurück?
SELECT REPLACE('Das Wetter wird gut', 'gut', 'regnerisch')

-- 27. Was gibt der Ausdruck UPPER('auto') zurück?
SELECT  UPPER('auto')

