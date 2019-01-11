--5. Der Kunde Bolte von KartoFinale hat geheiratet und der neue Name ist nicht bekannt. Geben Sie die Namen und Vorname der Tabelle Kunde so aus, dass für den Namen 'Bolte' nun der Wert NULL bei der Ausgabe erscheint. 
SELECT Vorname, NULLIF(Name, 'Bolte')
FROM Kunde

--6. Fragen Sie alle Artikel mit einem Preis zwischen 25 und 100 ab. Artikel mit einem Preis von 25 und 100 sollen berücksichtigt werden.
SELECT Artikelnummer, Preis
FROM Artikel
WHERE Preis >= 25 AND Preis <= 100

SELECT Artikelnummer, Preis
FROM Artikel
WHERE Preis BETWEEN 25 AND 100	

--7. Karen Kart ist aus Karlstadt nach 22287 Hamburg umgezogen. Aktualisieren Sie die Relation Mitarbeiter.
-- UPDATE Mitarbeiter --Mit dieser Zeile funktioniert es in der KartoFinale Datenbank
UPDATE Mitarbeiter
SET Ort = 'Hamburg', Plz = 22287
WHERE Name = 'Kart' AND Vorname = 'Karen' AND Ort = 'Karlstadt'

--8. Geben Sie das Durschnittsgehalt der Mitarbeiter je Abteilung wieder. Geben Sie das Ergebnis mit zwei Nachkommastellen aus. Geben Sie nur die Abteilungen wieder, deren Durchschnittsgehalt größer als 2400 ist.
SELECT  Abteilungsbezeichnung, CAST(AVG(Gehalt) AS NUMERIC(7,2)) AS Durchschnittsgehalt
FROM Mitarbeiter
GROUP BY (Abteilungsbezeichnung)
HAVING AVG(Gehalt) > 2400

--9. Geben Sie alle Kunden- und alle Mitarbeiternamen aus. Vor- und Nachname sollen als ein Wert wiedergegeben werden. Achten Sie darauf, dass Vor- und Nachname durch ein Leerzeichen getrennt sind und die ausgegebene Spalte eine Bezeichnung hat.
SELECT CONCAT(Vorname,' ', Name) AS Name
FROM Kunde
UNION
SELECT CONCAT(Vorname,' ', Name)
FROM Mitarbeiter

--10. Geben Sie alle Orte wieder, aus denen kein Mitarbeiter stammt
SELECT Ort
FROM Ort
EXCEPT
SELECT Ort
FROM Mitarbeiter

--11. Geben Sie die teuersten 5 Artikel mit Preis und Artikelnummer wieder. Stellen Sie sicher, dass Artikel mit gleichem Preis gleichermaßen berücksichtigt werden. Ist der sechstteuerste Artikel genauso teuer wie der fünftteuerste, so soll der sechstteuerste (auch siebt-, achtteuerste etc.) Artikel mit ausgegeben werden. 
SELECT TOP(5) WITH TIES Preis, Artikelnummer
FROM Artikel
ORDER BY Preis DESC;

--12. Geben Sie alle Mitarbeiter aus, deren Straße auf 'weg' endet.
SELECT *
FROM Mitarbeiter
WHERE Strasse LIKE '%weg'

--13. Geben Sie alle Mitarbeiter aus, deren Nachname kein 'e' und kein 'a' im Nachnamen haben. 
SELECT *
FROM Mitarbeiter
WHERE Name NOT LIKE '%[ae]%'

--14. Erstellen Sie eine Abfrage, aus der ersichtlich wird, aus welchem Bundesland jeder Kunde stammt. Geben Sie zusätzlich den Ort jedes Kunden mit aus.
SELECT Name, Vorname, Bundesland, K.Ort
FROM Kunde AS K
LEFT JOIN Ort AS O
ON O.Ort = K.Ort AND O.Plz = K.Plz

--15. Geben Sie die Bezeichnungen der Werbeartikel wieder, für die Bestellungen in der Datenbank vorliegen (in der Relation Bestellposten). Erstellen Sie hierzu eine Abfrage mit Unterabfrage (Achtung: Der Hinweis wird in der Klausur nicht vorhanden sein).
SELECT Bezeichnung
FROM Werbeartikel
WHERE Artikelnummer IN (SELECT Artikelnummer
							FROM Bestellposten)

--16. Aus welchem Bundesland kommt der Mitarbeiter mit dem höchsten Gehalt?
SELECT Bundesland 
FROM Ort 
WHERE Ort IN (
SELECT Ort
FROM Mitarbeiter
WHERE Gehalt = 
(SELECT MAX(Gehalt)
FROM Mitarbeiter))

--17. Erstellen Sie eine Abfrage, aus der ersichtlich wird, wie viele Kunden aus jedem Bundesland stammen.
SELECT COUNT(Name) AS Anzahl, Bundesland
FROM Kunde AS K
LEFT JOIN Ort AS O
ON O.Ort = K.Ort AND O.Plz = K.Plz
GROUP BY Bundesland

--18. Legen Sie die Relation 'Lieferant' an. 
CREATE Table Lieferant (
Lieferantennummer int IDENTITY(1,1) CONSTRAINT pk_Lieferant PRIMARY KEY,
Erfassungsdatum date CONSTRAINT df_Erfassungsdatum_Leferant DEFAULT GETDATE(),
Plz int,
Ort varchar(200),
Bezeichnung varchar(200),
CONSTRAINT fk_Ort_Lieferant FOREIGN KEY (Ort, Plz)
REFERENCES Ort(Ort, Plz)
);

--19. Ergänzen Sie die Fremdschlüsselbeziehung zwischen 'Lieferant' und 'Werbeartikel'.
ALTER TABLE Werbeartikel
ADD Lieferant int, 
CONSTRAINT fk_Lieferant_Artikel FOREIGN KEY(Lieferant)
REFERENCES Lieferant(Lieferantennummer)

--20. Fügen Sie den Lieferanten ‚LieferAlles’ aus 22222 Karlstadt in die Relation Lieferant ein. 
INSERT INTO Lieferant(Bezeichnung, Plz, Ort)
VALUES('LieferAlles', 22222, 'Karlstadt')

--21. Löschen Sie die Spalte Lieferant aus der Relation Werbeartikel. Löschen Sie auch die Foreign-Key-Einschränkung.
ALTER TABLE Werbeartikel
DROP CONSTRAINT fk_Lieferant_Artikel, COLUMN Lieferant

