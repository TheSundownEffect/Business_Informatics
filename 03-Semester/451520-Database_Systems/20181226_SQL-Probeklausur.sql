/* * * * * * * * * * * * * * * * * *
 * SQL-Probeklausur
 * Date: 26.06.2018
 * Author: Christian Bräunlich
*/

-- Tools
USE KartoFinale;
USE Bike;

-- 5.	Der Kunde Bolte von KartoFinale hat geheiratet und der neue Name ist nicht bekannt.
--		Geben Sie die Namen und Vorname der Tabelle Kunde so aus, dass für den Namen ‚Bolte‘ nun der Wert NULL bei der Ausgabe erscheint.
--
USE KartoFinale;
SELECT NULLIF(Name, 'Bolte') AS Nachname, Vorname AS [Aufgabe 5]
FROM Kunde;


-- 6.	Fragen Sie alle Artikel mit einem Preis zwischen 25 und 100 ab. Artikel mit einem Preis von 25 und 100 sollen berücksichtigt werden.
--
SELECT '' AS [Aufgabe 6]
USE KartoFinale;
SELECT Artikelnummer, Preis
FROM Artikel
WHERE Preis >= 25.00 AND Preis <= 100.00
ORDER BY Preis;

-- 7.	Karen Kart ist aus der Karlstadt nach 22287 Hamburg umgezogen. Aktualisieren Sie die Relation Mitarbeiter.
--
SELECT '' AS [Aufgabe 7]
USE KartoFinale;
/*UPDATE Personal.Mitarbeiter
SET Ort = 'Hamburg', Plz = 22287
WHERE Name = 'Kart' AND Vorname = 'Karen' AND Ort = 'Karlstadt'
*/

-- 8.	Geben Sie das Durchschnittsgehalt der Mitarbeiter je Abteilung wieder. Geben Sie das Ergebnis mit zwei Nachkommastellen aus.
--		Geben Sie nur die Abteilungen wieder, deren Durchschnittsgehalt größer als 2400 ist.
--
USE KartoFinale;
SELECT CAST(AVG(Gehalt) AS NUMERIC(10, 2)) AS [Aufgabe 8]
FROM Personal.Mitarbeiter
GROUP BY (Abteilungsbezeichnung)
HAVING AVG(Gehalt) > 2400;

-- 9.	Geben Sie alle Kunden- und alle Mitarbeiternamen aus. Vor- und Nachname sollen als ein Wert wiedergegeben werden.
--		Achten Sie darauf, dass Vor- und Nachname durch ein Leerzeichen getrennt sind und die ausgegebene Spalte eine Bezeichnung hat.
--
SELECT CONCAT(Vorname, ' ', Name) AS [Aufgabe 9]
FROM Kunde
UNION
SELECT CONCAT(Vorname, ' ', Name)
FROM Personal.Mitarbeiter;

-- 10.	Geben Sie alle Orte wieder, aus denen kein Mitarbeiter stammt.
--
USE KartoFinale;
SELECT o.Ort AS [Aufgabe 10]
FROM personal.mitarbeiter AS m
FULL OUTER JOIN Ort AS o
ON m.Ort = o.Ort
WHERE m.Ort IS NULL OR o.Ort is NULL;

-- 11.	Geben Sie die teuersten 5 Artikel mit Preis und Artikelnummer wieder. Stellen Sie sicher, dass Artikel mit gleichem Preis gleichermaßen berücksichtigt werden. Ist der sechstteuerste Artikel genauso teuer wie der fünftteuerste, so soll der sechstteuerste (auch siebt-, achtteuerste etc.) Artikel mit ausgegeben werden.
--
SELECT '' AS [Aufgabe 11]
USE KartoFinale;
SELECT TOP(5) WITH TIES Preis, Artikelnummer 
  FROM Artikel
  ORDER BY Preis DESC;

-- 12.	Geben Sie alle Mitarbeiter aus, deren Straße auf ‚weg‘ endet.
--
USE KartoFinale;
SELECT Personal.Mitarbeiter.Name AS [Aufgabe 12]
FROM Personal.Mitarbeiter
WHERE Strasse LIKE '%weg';

-- 13.	Geben Sie alle Mitarbeiter aus, deren Nachname kein ‚e‘ und kein ‚a‘ im Nachnamen haben.
--
USE KartoFinale;
SELECT Name AS [Aufgabe 13]
FROM Personal.Mitarbeiter
WHERE Name NOT LIKE '%a%' AND Name NOT LIKE '%e%';


-- 14.	Erstellen Sie eine Abfrage, aus der ersichtlich wird, aus welchem Bundesland jeder Kunde stammt.
--		Geben Sie zusätzlich den Ort jedes Kunden mit aus.
--
SELECT '' AS [Aufgabe 14]
USE KartoFinale;
SELECT Name, Vorname, Bundesland, Ort.Ort
FROM Kunde, Ort
WHERE Kunde.Ort = Ort.Ort AND Ort.Plz = Kunde.Plz;

-- 15.	Geben Sie die Bezeichnung der Werbeartikel wieder, für die Bestellungen in der Datenbank vorliegen (in der Relation Bestellposten).
--		Erstellen Sie hierzu eine Abfrage mit Unterabfrage (Achtung: Der Hinweis wird in der Klausur nicht vorhanden sein).
--
USE KartoFinale;
SELECT Bezeichnung AS [Aufgabe 15]
FROM Werbeartikel
WHERE Artikelnummer IN (SELECT Artikelnummer FROM Bestellposten);

SELECT Bezeichnung AS [Aufgabe 15 - easy]
FROM Werbeartikel, Bestellposten
WHERE Werbeartikel.Artikelnummer = Bestellposten.Artikelnummer;

-- 16.	Aus welchem Bundesland kommt der Mitarbeiter mit dem höchsten Gehalt?
--
USE KartoFinale;
SELECT Ort.Bundesland AS [Aufgabe 16]
FROM Ort, Personal.Mitarbeiter
WHERE Ort.Ort = Mitarbeiter.Ort AND Gehalt = (SELECT MAX(Gehalt) FROM Personal.Mitarbeiter)


-- 17.	Erstellen Sie eine Abfrage, aus der ersichtlich wird, wie viele Kunden aus jedem Bundesland stammen.
--
SELECT '' AS [Aufgabe 17]
USE KartoFinale;


GROUP BY Bundesland;

-- 18.	Legen Sie die Relation ‚Lieferant‘ an.
--
SELECT '' AS [Aufgabe 18]



-- 19.	Ergänzen Sie die Fremdschlüsselbeziehung zwischen ‚Lieferant‘ und ‚Werbeartikel‘.
--
SELECT '' AS [Aufgabe 19]



-- 20.	Fügen Sie den Lieferanten ‚LieferAlles‘ aus 22222 Karlstadt in die Relation Lieferant ein.
--
SELECT '' AS [Aufgabe 20]



-- 21.	Löschen Sie die Spalte ‚Lieferantennummer‘ aus der Relation Werbeartikel. Löschen Sie auch die Foreign-Key-Einschränkung.
--
SELECT '' AS [Aufgabe 21]



