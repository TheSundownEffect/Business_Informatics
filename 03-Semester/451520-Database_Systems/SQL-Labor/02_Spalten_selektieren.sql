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

-- 4. In welchen Orten sind Spielst�tten? Stellen Sie sicher, dass jeder Ort nur einmal angegeben wird. (KartoFinale)
USE KartoFinale;
SELECT DISTINCT Ort
FROM Spielst�tte;

-- 5. Fragen Sie den Zustand der Sitzpl�tze in der KartoFinale-Datenbank als "Belegung" ab.
USE KartoFinale;
SELECT Zustand AS Belegung
FROM Sitzplatz;

-- 6. Wie viele St�ck je Werbeartikel sind noch vorhanden, bis der Mindestbestand erreicht ist? W�hlen Sie den Titel "Puffer." (KartoFinale)
USE KartoFinale;
SELECT Artikelnummer, Bezeichnung, Lagerbestand-Mindestbestand AS Puffer
FROM Werbeartikel;

-- 7. Fragen Sie die Tabelle "Lager" der Bike-Datenbank so ab, dass der Mindestbestand um 15% erh�ht ist. Geben Sie der berechneten Spalte den Titel "Erh�hter Mindestbestand". 
USE Bike;
SELECT Artnr, Mindbest * 1.15 AS "Erh�hter Mindestbestand"
FROM Lager

-- 8. Alle Vorstellungen dauern 90 Minuten. Fragen Sie die Tabelle "Vorstellungen" der KartoFinale-Datenbank ab und erg�nzen Sie den konstanten Wert 90 als "Vorstellungsdauer. 
USE KartoFinale;
SELECT *, 90 AS 'Veranstaltungsdauer'
FROM Vorstellung

-- 9. Welche Zust�nde gibt es f�r die Sitzpl�tze in der KartoFinale-Datenbank?
USE KartoFinale
SELECT DISTINCT Zustand
FROM Sitzplatz

-- 10. Berechnen Sie den Wert der Nettopreis der Artikel in der Bike-Datenbank basierend auf den Preisen. �berpr�fen Sie Ihr Ergebnis, in dem Sie zus�tzlich den Nettopreis abfragen.
USE Bike;
SELECT Netto, Preis/1.19 AS Netto, Preis
FROM Artikel

--11. Berechnen Sie den Umsatzsteuersatz jedes Artikels. 
USE Bike;
SELECT Netto, Preis, (Preis-Netto)/Netto
FROM Artikel
