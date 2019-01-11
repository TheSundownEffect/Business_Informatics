-- Übungsaufgaben Aggregieren

-- 1. Wie lange ist die durchschnittliche Lieferzeit und wie hoch ist der durchschnittliche Nettopreis der Lieferungen in der Bike-Datenbank.
USE Bike;
SELECT AVG(Lieferzeit), AVG(Nettopreis)
FROM Lieferung

-- 2. Wie ist die Durchschnittsbeurteilung aller Mitarbeiter in der Bike-Datenbank? Sofern keine Beurteilung vorliegt, soll der Wert 1 eingetragen werden. Geben Sie den Wert mit zwei Nachkommastellen aus.   
USE Bike;
SELECT CAST(AVG(COALESCE(CAST(Beurteilung AS NUMERIC(4,2)),1)) AS NUMERIC(4,2))
FROM Personal

-- 3. Wie teuer (Netto) sind zusammen (Summe) alle Artikel in der Bike-Datenbank, die lackiert sind (Hinweis: ‘lackiert‘ ist in der Bezeichnung zu finden)?
USE Bike;
SELECT SUM(Netto) AS Summe
FROM Artikel
WHERE Bezeichnung LIKE '%lackiert%'

-- 4. Wie hoch ist das Durchschnittsgehalt des Personals in der Bike-Datenbank?
USE Bike;
SELECT AVG(Gehalt) AS Durchschnittsgehalt
FROM Personal

-- 5. Wie hoch ist das Durchschnittsgehalt des Personals mit den Aufgaben Vertreter, Meister und Azubi in der Bike-Datenbank? Benutzen Sie 'IN'.
USE Bike;
SELECT AVG(Gehalt)
FROM Personal
WHERE Aufgabe IN ('Vertreter','Meister','Azubi')

-- 6. Wie hoch ist der durchschnittliche Lagerbestand in der Bike Datenbank? Runden Sie den Wert auf zwei Nachkommastellen. Benutzen Sie ROUND und CAST.
USE Bike;
SELECT ROUND(AVG(CAST( Bestand AS NUMERIC(8,2))),2) AS "Durchschnittlicher Bestand"
FROM Lager

-- 7. Wie teuer ist der teuerste Artikel in der Bike-Datenbank?
USE Bike;
SELECT MAX(Preis) AS "Max. Preis"
FROM ARTIKEL

-- 8. Wie teuer ist der teuerste Artikel in der Bike-Datenbank, der nicht rot ist und auch kein Mass hat?
USE Bike;
SELECT MAX(Preis) AS "Max. Preis"
FROM ARTIKEL
WHERE Farbe != 'rot' AND Mass IS NULL

-- 9. Wie teuer ist der günstigste Artikel in der Bike-Datenbank?
USE Bike;
SELECT MIN(Preis) AS "Max. Preis"
FROM ARTIKEL

-- 10. Wie viele Artikel in der Bike-Datenbank sind vom Typ 'E' und kosten mehr als 70€?
USE Bike;
SELECT COUNT(Anr)
FROM Artikel
WHERE Typ = 'E' AND Preis > 70

-- 11. Zählen Sie die Anzahl der Bezeichnung und die Anzahl der Farben in der Tabelle 'Artikel' der Bike-Datenbank. Was stellen Sie fest? Zählen Sie danach die Anzahl der Artikel anhand der Artikelnummer (Spalte 'Anr'), bei denen die Farbe NULL ist. Welche Schlussfolgerung lässt sich aus den Ergebnissen in Bezug auf die Auswertung von NULL-Werten in Aggregatfunktionen ziehen.
USE Bike;
SELECT COUNT(Bezeichnung), COUNT(Farbe)
FROM Artikel

SELECT COUNT(Anr)
FROM Artikel
WHERE Farbe IS NULL

/*Antwort: COUNT zählt NULL-Werte nicht mit. Daher besteht die Möglichkeit zum Zählen von Zeilen (Tupel) in einer Tabelle (Relation) das '*' and COUNT zu übergeben: COUNT(*). Andernfalls müsste die Tabellenstruktur und das mögliche Vorkommen von NULL-Werten bekannt sein.*/

-- 12. a) Wie viele Preise gibt es in der Artikel-Tabelle der Bike-Datenbank, b) wie viele unterschiedliche Preise gibt es? Wie hoch ist die absolute Differenz zwischen beiden Werten. Beantworten Sie diese Frage in einer Abfrage. 
USE Bike;
SELECT COUNT(Preis) as "Lösung a", COUNT(DISTINCT(Preis)) as "Lösung b", ABS(COUNT(DISTINCT(Preis)) - COUNT(Preis)) AS Differenz
FROM Artikel

-- 13. Wie viele weibliche Kunden hat KartoFinal?
USE KartoFinale;
SELECT COUNT(*)
FROM Kunde
WHERE Geschlecht = 'w';

-- 14. Wie viele Stücke in der KartoFinale-Datenbank hat Mozart geschrieben?
USE KartoFinale;
SELECT COUNT(Bezeichnung)
FROM Veranstaltung
WHERE Autor = 'Mozart'

-- 15. Geben Sie die Anzahl unterschiedlicher Spielorte (i.S.v. Städten) aus der KartoFinale-Datenbank aus.
USE KartoFinale;
SELECT COUNT(DISTINCT(Ort)) AS [Anzahl Spielstädte]
FROM Spielstätte

-- 16. Wie viele Monate ist der älteste Mitarbeiter in der KartoFinale-Datenbank alt?
USE Bike;
SELECT Max(DATEDIFF(month,  GebDatum, GETDATE()))
FROM Personal

-- 17. Wie lang sind im Durchschnitt die Artikelbezeichnungen in der Bike-Datenbank?
USE Bike;
SELECT AVG(LEN(Bezeichnung)) AS Durchschnittslänge
FROM Artikel

-- 18. Wie viel ist in der Bike-Datenbank durchschnittlich pro Lieferung bestellt? Geben Sie das Ergebnis mit zwei Nachkommastellen an. 
USE Bike;
SELECT AVG(CAST(Bestellt AS Numeric(6,2))) AS [Durschnittliche Bestellmenge]
FROM Lieferung

-- 19. Wie hoch ist die größte absolute Abweichung zwischen Lagerbestand und Mindestbestand der Werbeartikel in der KartoFinale-Datenbank?
USE KartoFinale;
SELECT Max(ABS(Lagerbestand-Mindestbestand))
FROM Werbeartikel


-- Übungsaufgaben Gruppieren & Aggregieren

--1. Wie viele Artikel jeden Typs gibt es in der Bike-Datenbank?
USE Bike;
SELECT COUNT(*) AS Anzahl, Typ
FROM Artikel
GROUP BY Typ

--2. Wie lange ist die durchschnittliche Lieferzeit je Artikel, wie hoch ist das kumulative Bestellvolumen je Artikel (Anr ist die Artikelnummer) in Euro (Nettopreis) in der Bike-Datenbank (Sie finden die notwendigen Informationen in der Tabelle 'Lieferung‘)?
USE Bike;
SELECT AVG(CAST(Lieferzeit AS NUMERIC(3,2))) AS [Durchschnittliche Lieferzeit], SUM(Nettopreis) AS [Bestellvolumen], Anr
FROM Lieferung
GROUP BY Anr

--3. Berechnen Sie das Durchschnittsalter der Kunden in der KartoFinale-Datenbank nach Jahren PLZ.
USE KartoFinale;
SELECT AVG(DATEDIFF(year, Geburtsdatum, GETDATE())), Plz
FROM Kunde
GROUP BY Plz

--4. Wie alt ist der älteste Kunde aus jedem Postleitzahlengebiet?
USE KartoFinale;
SELECT MAX(DATEDIFF(year, Geburtsdatum, GETDATE())), Plz
FROM Kunde
GROUP BY Plz

--5. Wie viele freie Plätze gibt es noch je Veranstaltungsnummer (KartoFinale)?
USE KartoFinale
SELECT COUNT(*) as [freie Sitzplätze], Veranstaltungsnummer
FROM Sitzplatz
WHERE Zustand = 'frei'
GROUP BY Veranstaltungsnummer

--6. Wie hoch ist der Durchschnittspreis des Typen in der Bike-Datenbank, von dem es weniger als drei Artikel gibt?
USE Bike;
SELECT AVG(Preis) AS Durchschnittspreis, Typ
FROM Artikel
GROUP BY Typ
HAVING COUNT(Typ) < 3

--7. Berechnen Sie das Durchschnittsgehalt für die unterschiedlichen Beurteilungskategorien (1-5) in der Bike-Datenbank. 
USE Bike;
SELECT AVG(Gehalt),Beurteilung
FROM Personal
GROUP BY Beurteilung

-- 8. Bestimmen Sie das Gesamtvolumen jedes Auftrags in der Bike-Datenbank. Nutzen Sie dafür die Relation Auftragsposten. Geben Sie nur die Aufträge wieder (AuftrNr) mit einem Gesamtvolumen von mehr als 800. Um welche Auftragsnummern handelt es sich?
USE Bike;
SELECT SUM(Gesamtpreis) AS Gesamtvolumen, AuftrNr
FROM Auftragsposten
GROUP BY AuftrNr
HAVING SUM(Gesamtpreis) > 800

--9. Wie viele Teile gehören in der Bike-Datenbank zu jedem Artikeln? Nutzen Sie hierzu die Tabelle Teilestruktur.
SELECT COUNT(*) AS [Anzahl Teile], Artnr
FROM Teilestruktur
GROUP BY Artnr

--10. Geben Sie die Anzahl der Vorstellungen aus, die pro Veranstaltung stattfinden (KartoFinale).
USE KartoFinale;
SELECT COUNT(*) [Anzahl Vorstellungen], Veranstaltungsnummer
FROM Vorstellung
GROUP BY Veranstaltungsnummer

--11. Wie viele Bestellposten gab es je Bestellung (KartoFinale)?
USE KartoFinale;
SELECT COUNT(*) [Anzahl Bestellposten], BestellNr
FROM Bestellposten
GROUP BY BestellNr

--12. Geben Sie nun nur die Bestellungen mit mehr als 2 Bestellposten wieder (KartoFinale).
USE KartoFinale;
SELECT COUNT(*) [Anzahl Bestellposten], BestellNr
FROM Bestellposten
GROUP BY BestellNr
HAVING  COUNT(*) > 2

--13. Was kosten Artikel maximal, minimal und im Durchschnitt (KartoFinale)?
USE KartoFinale;
SELECT MAX(Preis) Maximalpreis, MIN(Preis) Minimalpreis, AVG(Preis) Durchschnittspreis
FROM Artikel

--14. Wie viele weibliche und männliche Kollegen gibt es (KartoFinale) in der Abteilung Vertrieb? 
USE KartoFinale;
SELECT COUNT(*) Anzahl, Geschlecht
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung = 'Vertrieb'
GROUP BY Geschlecht


-- Übungsaufgaben Sortieren
-- 1. Sortieren Sie die Orte in der KartoFinale-Datenbank aufsteigend nach der Postleitzahl. Geben Sie nur die Ort wieder, die nicht in Nordrhein-Westfalen liegen. 
USE KartoFinale;
SELECT Ort, Plz
FROM Ort
WHERE Bundesland != 'NW'
ORDER BY Plz

-- 2. Geben Sie die Artikelnummer der KartoFinale-Datenbank der Sitzplätze in absteigender Reihenfolge aus. Geben Sie nur freie Sitzplätze aus. 
USE KartoFinale;
SELECT Artikelnummer, Zustand
FROM Sitzplatz
WHERE Zustand = 'frei'
ORDER BY Reihe DESC;

-- 3. Sortieren Sie Sitzplätze nach Reihe und Sitznummer. Was fällt dabei auf?
USE KartoFinale;
Select Reihe, Sitznummer
From Sitzplatz
ORDER BY Reihe, Sitznummer;
/*Antwort: Die Sortierung funktioniert nicht vollstaendig. So wird "11" vor 2, 3, 4, 7, und 8 angezeigt. Dies ist darauf zurückzuführen, dass Reihe und Sitznummer den Datentyp char haben. Der Datentype ist in einen numerischen Datentyp zu überführen */
USE KartoFinale;
Select CAST(Reihe AS INT) Reihe, CAST(Sitznummer AS INT) Sitznummer
From Sitzplatz
ORDER BY CAST(Reihe AS INT), CAST(Sitznummer AS INT)

-- 4. In welchen Sitzplatzreihen gibt es freie oder reservierte Plätze in der KartoFinale-Datenbank? Sortieren Sie diese absteigend nach der Reihennummer. Geben Sie jede Reihe nur einmalig aus. Achten Sie auf die richtigen Datentypen!
USE KartoFinale;
SELECT DISTINCT CAST(Reihe AS INT)
FROM Sitzplatz
WHERE Zustand = 'frei' OR Zustand = 'reserviert'
ORDER BY CAST(Reihe AS INT) DESC;

-- 5. Geben Sie alle Artikeln in der KartoFinale-Datenbank aus, die zu den teuersten 50% gehören. Achten Sie darauf, dass gleiche Werte nicht voneinander "abgeschnitten" werden.
USE KartoFinale;
SELECT TOP(10)PERCENT WITH TIES Preis, Artikelnummer
FROM Artikel
ORDER BY Preis DESC;

-- 6. Welche zwei Mitarbeiter bekommen bei KartoFinale das geringste Gehalt? Geben Sie die Namen aus. 
USE KartoFInale;
SELECT TOP(2) WITH TIES Name, Gehalt
FROM Personal.Mitarbeiter
ORDER BY Gehalt

-- 7. Welche zwei Mitarbeiter bekommen bei KartoFinale das geringste Gehalt? Geben Sie die Namen aus. Berücksichtigen Sie nur Mitarbeiter, die einer Abteilung zugeordnet sind.
USE KartoFinale;
SELECT TOP(2) WITH TIES Name, Gehalt
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung IS NOT NULL
ORDER BY Gehalt DESC

-- 8. Berechnen Sie das Durchschnittsgehalt je Abteilung und sortieren Sie die Abteilungen absteigend nach dem Durchschnittsgehalt. 
USE KartoFinale;
SELECT AVG(Gehalt) AS Durchschnittsgehalt, Abteilungsbezeichnung
FROM Personal.Mitarbeiter
GROUP BY Abteilungsbezeichnung
ORDER BY AVG(Gehalt) DESC;

-- 9. In welchen Spielstätten finden die meisten Veranstaltungen statt. Geben Sie die Häuser der Relation Vorstellung in der KartoFinale-Datenbank wieder, die, gemessen an der Anzahl der Vorstellungen, unter den Top-20% liegen. 
USE KartoFinale;
SELECT TOP (20)PERCENT WITH TIES COUNT(*) [Anzahl Vorstellungen], Haus
FROM Vorstellung
GROUP BY Haus
ORDER BY COUNT(*) DESC;

-- 10. Nehmen Sie eine strategische Einordung der Lieferanten in der Bike-Datenbank vor: Bei welchen Lieferanten (Liefnr) werden zu einem hohen Bestellvolumen (Summe Nettopreis) Artikel bestellt (Wiederholung). 
USE Bike
SELECT SUM(Nettopreis) AS Gesamtbestellvolumen, Liefnr 
FROM Lieferung
GROUP BY Liefnr


