-- Musterlösungen Unterabfragen

-- 1. Von welchem Werbeartikel in der KartoFinale-Datenbank muss ein überdurchschnittlicher Mindestbestand vorgehalten werden. Anders: Für welche Werbeartikel ist der Mindestbestand höher als der durchschnittliche Mindestbestand?
USE KartoFinale
SELECT *
FROM Werbeartikel
WHERE Mindestbestand > (SELECT AVG(Mindestbestand)
FROM Werbeartikel)

-- 2. Bitte schreiben Sie eine Abfrage mit Unterabfrage, die es immer wieder ermöglicht, die Kollegen von Frau Kart zu ermitteln, die mit ihr in einer Abteilung arbeiten. Die Abfrage soll auch noch korrekte Ergebnisse liefern, sobald Frau Kart die Abteilung wechselt.
SELECT *
FROM Personal.Mitarbeiter
WHERE Abteilungsbezeichnung = (SELECT Abteilungsbezeichnung
FROM Personal.Mitarbeiter
WHERE Name = 'Kart')

-- 3. Welche Mitarbeiter verdienen mehr als Frau Kart? Aus welchen Abteilungen kommen diese?
USE KartoFinale;
SELECT Abteilungsbezeichnung, Name, Gehalt
FROM Personal.Mitarbeiter
WHERE Gehalt > (SELECT Gehalt
FROM Personal.Mitarbeiter
WHERE Name = 'Kart')

-- 4. Wählen Sie alle Veranstaltungen aus, die von der Uhrzeit später starten, als die Veranstaltung mit der Veranstaltungsnummer 1 und der Vorstellungsnummer 2.
USE KartoFinale;
SELECT * 
FROM Vorstellung
WHERE Uhrzeit > (SELECT Uhrzeit
FROM Vorstellung
WHERE Vorstellungsnummer = 2 AND Veranstaltungsnummer = 1)

 --5. Wo finden die Veranstaltungen aus Aufgbae 4 statt? Geben Sie die jeweiligen Häuser einmalig aus.  
 USE KartoFinale;
SELECT DISTINCT(Haus) 
FROM Vorstellung
WHERE Uhrzeit > (SELECT Uhrzeit
FROM Vorstellung
WHERE Vorstellungsnummer = 2 AND Veranstaltungsnummer = 1)

-- 6. Geben Sie die Gehälter der Mitarbeiter, die unter dem Durchschnitt verdienen, mit einer 10%-igen Gehaltserhöhung aus (KartoFinale).
USE KartoFinale;
SELECT Gehalt * 1.10 AS [Erhöhte Gehälter]
FROM Personal.Mitarbeiter
WHERE Gehalt < (SELECT AVG(Gehalt) 
FROM Personal.Mitarbeiter) 

-- 7. Welche Mitarbeiter haben keinen Vorgesetzten?
USE KartoFinale;
Select Name
FROM Personal.Mitarbeiter
WHERE PersonalnummerVorgesetzter IS NULL;

-- 8. Geben Sie die Artikel in der Bike-Datenbank aus, die die selbe Farbe haben. Vermeiden sie Duplikate in den Beziehungen. Artikel ohne Farbe sollen nicht berücksichtigt werden. 
USE Bike;
SELECT t1.Bezeichnung, t2.Bezeichnung
FROM Artikel t1, Artikel t2
WHERE t1.Farbe = t2.Farbe AND t1.Anr<t2.Anr AND t1.Farbe IS NOT NULL

-- 9. Geben Sie alle Artikel wieder, die gleich viel oder weniger als einer der Artikel mit den Artikelnummern 1001, 1003 oder 1012 kosten.
USE KartoFinale
SELECT *
FROM Artikel
WHERE Preis <= ANY (SELECT Preis
FROM Artikel
WHERE Artikelnummer = 1001 OR Artikelnummer = 1003 OR Artikelnummer = 1012)

-- 10. Geben Sie alle Artikel wieder, die gleich viel oder weniger als alle Artikel mit den Artikelnummern 1001, 1003 und 1012 kosten.
USE KartoFinale
SELECT *
FROM Artikel
WHERE Preis <= ALL (SELECT Preis
FROM Artikel
WHERE Artikelnummer = 1001 OR Artikelnummer = 1003 OR Artikelnummer = 1012)

-- 11. Wie groß ist die Differenz jedes Mitarbeiters zu dem Höchstgehalt in der KartoFinale-Datenbank als Absolutwert aus.
USE KartoFinale
SELECT Name, Gehalt, ABS(Gehalt - (SELECT MAX(Gehalt) FROM Personal.Mitarbeiter)) AS Gehaltsunterschied
FROM Personal.Mitarbeiter

-- 12. Welcher Mitarbeiter hat die größte Abweichung vom Durchschnittsgehalt in der KartoFinale-Datenbank?
USE KartoFinale
SELECT TOP(1) Name, Gehalt, ABS(Gehalt - (SELECT AVG(Gehalt) FROM Personal.Mitarbeiter)) AS Gehaltsunterschied
FROM Personal.Mitarbeiter
ORDER BY Gehaltsunterschied DESC;

-- 13. Welche Mitarbeiter in der Bike-Datenbank verdient mehr als das durchschnittliche Vertretergehalt? Wie heißen diese Mitarbeiter und was verdienen sie?
USE Bike;
SELECT Name, Gehalt, Aufgabe
FROM Personal
WHERE Gehalt > (SELECT AVG(Gehalt) FROM Personal WHERE Aufgabe Like 'Vertreter')

-- 14. Welche Mitarbeiter in der Bike-Datenbank verdienen mehr als alle Vertreter? Wie heißen diese Mitarbeiter und was verdienen sie?
USE Bike;
SELECT Name, Gehalt, Aufgabe
FROM Personal
WHERE Gehalt > ALL (SELECT Gehalt FROM Personal WHERE Aufgabe Like 'Vertreter')

-- 15. Wie heißen jeweils die Vorgesetzten der KartoFinale-Mitarbeiter?
USE KartoFinale
SELECT M1.Name, M2.Name
FROM Personal.Mitarbeiter M2, Personal.Mitarbeiter M1
WHERE M2.Personalnummer = (SELECT PersonalnummerVorgesetzter 
FROM Personal.Mitarbeiter
WHERE M1.Name = Name)

-- 16. Welcher Mitarbeiter bei KartoFinale sind mit welchen Ehepartnern verheiratet. Gegeben Sie vor und Nachname von Mitarbeiter und Ehepartnern aus.
USE KartoFinale
SELECT Vorname, Name, (SELECT Vorname
FROM Personal.Mitarbeiter M
WHERE M.Personalnummer = E.Personalnummer) Vorname, (SELECT Name
FROM Personal.Mitarbeiter M
WHERE M.Personalnummer = E.Personalnummer) Nachname
FROM Ehepartner E

USE KartoFinale
SELECT E.Vorname, E.Name, M.Vorname, M.Name
FROM Personal.Mitarbeiter M, Ehepartner E
WHERE M.Personalnummer = E.Personalnummer

-- 17. Wie heißen die AbteilungsleiterInnen der Abteilungen bei KartoFinale?
USE KartoFinale
SELECT A.Abteilungsbezeichnung, M.Name
FROM Personal.Abteilung A, Personal.Mitarbeiter M
WHERE M.Personalnummer = (SELECT PersonalnummerAbteilungsleiter
FROM Personal.Abteilung
WHERE Abteilungsnummer = A.Abteilungsnummer)

-- 18. Welche Mitarbeiter der Bike-Datenbank verdienen mehr als das Durchschnittsgehalt der KartoFinale-Datenbank?
SELECT P.Gehalt, P.Name
FROM Bike.dbo.Personal P
WHERE P.Gehalt > (SELECT AVG(M.Gehalt) FROM KartoFinale.Personal.Mitarbeiter M)

-- 19. Welche Mitarbeiter bei KartoFinale kommen aus Schleswig-Holstein.
USE KartoFinale;
SELECT Vorname, Name, Ort, Plz
FROM Personal.Mitarbeiter
WHERE PLZ IN (SELECT PLZ FROM Ort WHERE Bundesland = 'SH')

-- 20. Welcher Mitarbeiter in der Bike-Datenbank wurde besser (größer) als im Durchschnitt bewertet. Geben Sie die Durchschnittsbewertung mit aus. 
USE Bike;
SELECT *, (SELECT AVG(CAST(Beurteilung AS NUMERIC(3,2))) FROM Personal)
FROM Personal
WHERE Beurteilung > (SELECT AVG(CAST(Beurteilung AS NUMERIC(3,2))) FROM Personal)

-- 21. Wer ist bei KartoFinale mit einem Mitarbeiter verheiratet, der mehr als im Durchschnitt verdient. 
USE KartoFinale;
SELECT Vorname, Name
FROM Ehepartner E
WHERE E.Personalnummer IN (SELECT Personalnummer FROM Personal.Mitarbeiter WHERE Gehalt > (SELECT AVG(Gehalt) FROM Personal.Mitarbeiter))


-- 22.  Wie hoch ist das Bestellvolumen jedes Bestellpostens in der KartoFinale-Datenbank? 
USE KartoFinale
SELECT a.Preis, b.Menge, a.Artikelnummer,  a.Preis * b.Menge AS Bestellvolumen
FROM Artikel a, Bestellposten b
WHERE a.Artikelnummer = b.Artikelnummer  

-- 23. Wie hoch ist das Bellvolumen je Bestellnummer (Bestellnr) bei KartoFinale?
USE KartoFinale
SELECT b.BestellNr, SUM(a.Preis * b.Menge) AS Bestellvolumen
FROM Artikel a, Bestellposten b
WHERE a.Artikelnummer = b.Artikelnummer 
GROUP BY b.Bestellnr

-- 24. Welche Personen in der KartoFinale-Datenbank haben eine Gehaltsdifferenz größer als 1000?
USE KartoFinale;
SELECT M1.Name, M2.Name, M1.Gehalt, M2.Gehalt
FROM Personal.Mitarbeiter M1, Personal.Mitarbeiter M2
WHERE ABS(M1.Gehalt - M2.Gehalt) > 1000 AND M1.Personalnummer > M2.Personalnummer
