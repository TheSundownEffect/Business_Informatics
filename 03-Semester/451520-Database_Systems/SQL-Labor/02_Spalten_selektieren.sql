-- 1. Fragen Sie die Tabelle 'Ort' der Datenbank KartoFinale ab.
USE KartoFinale;
Select *
FROM Ort;

-- 2. Fragen Sie die Tabelle 'Mitarbeiter' der Datenbank KartoFinale ab.
USE KartoFinale;
Select *
FROM Personal.Mitarbeiter;

-- 3. Fragen Sie die  Tabelle 'Abteilung' von KartoFinale ab. (KartoFinale)
USE KartoFinale;
Select *
FROM Personal.Abteilung;

-- 4. In welchen Orten sind Spielstätten? Stellen Sie sicher, dass jeder Ort nur einmal angegeben wird. (KartoFinale)
USE KartoFinale;
SELECT DISTINCT Ort
FROM Spielstätte;

-- 5. Fragen Sie den Zustand der Sitzplätze in der KartoFinale-Datenbank als "Belegung" ab.
USE KartoFinale;
SELECT Zustand AS Belegung
FROM Sitzplatz;

-- 6. Wie viele Stück je Werbeartikel sind noch vorhanden, bis der Mindestbestand erreicht ist? Wählen Sie den Titel "Puffer." (KartoFinale)
USE KartoFinale;
SELECT Artikelnummer, Bezeichnung, Lagerbestand-Mindestbestand AS Puffer
FROM Werbeartikel;

-- 7. Fragen Sie die Tabelle "Lager" der Bike-Datenbank so ab, dass der Mindestbestand um 15% erhöht ist. Geben Sie der berechneten Spalte den Titel "Erhöhter Mindestbestand". 
USE Bike;
SELECT Artnr, Mindbest * 1.15 AS "Erhöhter Mindestbestand"
FROM Lager

-- 8. Alle Vorstellungen dauern 90 Minuten. Fragen Sie die Tabelle "Vorstellungen" der KartoFinale-Datenbank ab und ergänzen Sie den konstanten Wert 90 als "Vorstellungsdauer. 
USE KartoFinale;
SELECT *, 90 AS 'Veranstaltungsdauer'
FROM Vorstellung

-- 9. Welche Zustände gibt es für die Sitzplätze in der KartoFinale-Datenbank?
USE KartoFinale
SELECT DISTINCT Zustand
FROM Sitzplatz

-- 10. Berechnen Sie den Wert der Nettopreis der Artikel in der Bike-Datenbank basierend auf den Preisen. Überprüfen Sie Ihr Ergebnis, in dem Sie zusätzlich den Nettopreis abfragen.
USE Bike;
SELECT Netto, Preis/1.19 AS Netto, Preis
FROM Artikel

--11. Berechnen Sie den Umsatzsteuersatz jedes Artikels. 
USE Bike;
SELECT Netto, Preis, (Preis-Netto)/Netto
FROM Artikel
