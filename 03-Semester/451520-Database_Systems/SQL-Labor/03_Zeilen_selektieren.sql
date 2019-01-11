-- 1. Selektieren Sie alle Lieferungen in der Bike-Datenbank, deren Lieferung länger als vier Tage dauert.
USE Bike;
SELECT *
FROM Lieferung
WHERE Lieferzeit > 4 

-- 2. Wie heißen die Spielstätten, die in Hamburg sind? In welcher Straße sind diese?
USE KartoFinale;
SELECT DISTINCT Haus, Strasse
FROM Spielstätte
WHERE Ort = 'Hamburg';

-- 3. Geben Sie Vorname und Name aller weiblichen Kunden von KartoFinale wieder.
USE KartoFinale;
SELECT Vorname, Name
FROM Kunde
WHERE Geschlecht = 'w';

-- 4. Für welche Artikel in der 'Bike'-Datenbank ist der Lagerbestand größer oder gleich 720? Bitte geben Sie die Artnr und den Bestand aus.
USE Bike;
SELECT Artnr, Bestand
FROM Lager
WHERE Bestand >=720;

-- 5. Welche Aufträge in der 'Bike'-Datenbank erfolgten vor dem 07.01.2013? An welche Kundennummer gingen diese? Wann erfolgte der jeweilige  Auftrag?
USE Bike;
SELECT AuftrNr, Kundnr, Datum
FROM Auftrag
WHERE Datum < '07.01.2013';

-- 6. Welche Artikel in der Bike-Datenbank kosten brutto weniger als 20€?
USE Bike;
SELECT *
FROM Artikel
WHERE Preis < 20

-- 7. Für welche Mitarbeiter in der KartoFinale-Datenbank ist keine Abteilung eingetragen?
USE KartoFinale;
SELECT * 
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung IS NULL

-- 8. Für welche Werbeartikel in der KartoFinale-Datenbank ist ein Mindestbestand eingetragen?
USE KartoFinale;
SELECT *
FROM Werbeartikel
WHERE Mindestbestand IS NOT NULL;

-- 9. Von welchen Lieferanten in der Bike-Datenbank sind (ist) die Postleitzahl nicht bekannt?
USE Bike;
SELECT *
FROM Lieferant
WHERE PLZ IS NULL;

--10. Welche Ehepartner in der KartoFinale-Datenbank wurden zwischen dem 21.01.1955 und dem 21.04.1960 geboren.
USE KartoFinale;
SELECT *
FROM Ehepartner
WHERE Geburtsdatum BETWEEN '21.01.1955' AND '21.04.1960'

-- 11. Von welchen Werbeartikeln in der KartoFinale-Datenbank ist der Lagerbestand noch mindestens 20 und maximal 100 Stück?
USE KartoFinale;
SELECT *
FROM Werbeartikel
WHERE Lagerbestand BETWEEN 20 AND 100

-- 12. Welche Spielstätten sind in Hamburg oder Heide?
USE KartoFinale;
SELECT *
FROM Spielstätte
WHERE Ort IN ('Hamburg', 'Heide')

-- 13. Welche Mitarbeiter bei KartoFinale arbeiten im Vertrieb oder im Rechnungswesen?
USE KartoFinale;
SELECT *
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung IN ('Vertrieb', 'Rechnungswesen')

-- 14. Wählen Sie alle Artikel aus der Bike-Datenbank aus, die in ihrer Bezeichnung "Damen-City" enthalten.
USE Bike;
SELECT *
FROM Artikel
WHERE Bezeichnung LIKE '%Damen-City%';

-- 15. Welche Spielstätten in der KartoFinale-Datenbank beginnen mit dem Buchstaben H oder mit dem Buchstaben K.
USE KartoFinale;
SELECT Ort
FROM Spielstätte
WHERE Ort LIKE '[HK]%'

--16. Welche Mitarbeiternachnamen beginnen mit A,B,C,D,E, F, G, H, I, J oder K in der KartoFinale-Datenbank?
SELECT Name
FROM Personal.Mitarbeiter
WHERE Name LIKE '[A-K]%'

-- 17. Welche Artikel in der Bike-Datenbank kosten mehr als 20€ und weniger als 50€?
USE Bike;
SELECT *
FROM Artikel
WHERE Preis >20 AND Preis < 50

-- 18. Welche Werbeartikel in der KartoFinale-Datenbank beinhalten die Begriffe "schwarz" oder "rot" in ihrer Bezeichnung?
USE KartoFinale;
SELECT *
FROM Werbeartikel
WHERE Bezeichnung LIKE '%schwarz%' OR Bezeichnung LIKE '%rot%'

-- 19. Welche Mitarbeiter bei KartoFinale arbeiten nicht im Vertrieb? Beachten Sie, dass es auch NULL-Werte für das Attribut Abteilungsbezeichnung gibt. 
USE KartoFinale;
SELECT *
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung != 'Vertrieb' OR Abteilungsbezeichnung IS NULL;

USE KartoFinale;
SELECT *
FROM Personal.Mitarbeiter
WHERE NOT Abteilungsbezeichnung = 'Vertrieb' OR Abteilungsbezeichnung IS NULL;

-- 20. Wählen Sie alle Artikel aus der Bike-Datenbank aus, die in Ihrer Bezeichnung "Damen-City" oder "Herren-City" enthalten und deren Mass den Wert NULL haben.
USE Bike;
SELECT *
FROM Artikel
WHERE (Bezeichnung LIKE '%Damen-City%' OR Bezeichnung Like '%Herren-City%') AND Mass IS NULL;

--21. Welche Orte in der KartoFinale-Datenbank enden nicht auf 'burg' (Bedingung muss immer erfüllt sein) und haben eine Postleitzahl die kleiner als 30000 ist oder sind in Nordrhein-Westfalen?
USE KartoFinale;
SELECT *
FROM Ort
WHERE Ort NOT LIKE '%burg' AND (PLZ < 30000 OR Bundesland = 'NW')

--22. Geben Sie alle Bezeichnungen, die Bezeichnungslänge und die Typen der Artikel in der Bike-Datenbank wieder, a) deren Typ E oder Z ist und b) deren Bezeichnung länger als 15 Zeichen ist. 
USE Bike;
SELECT Bezeichnung, Typ, LEN(Bezeichnung) AS Länge
FROM Artikel
WHERE LEN(Bezeichnung) > 15 AND (Typ = 'E' OR Typ = 'Z')









