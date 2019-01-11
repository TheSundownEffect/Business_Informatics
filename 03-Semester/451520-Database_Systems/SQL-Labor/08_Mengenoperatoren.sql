-- 1. Welche Mitarbeiter haben bisher nichts verkauft. Vergleichen Sie dazu, welche Personalnummer nicht in der Tabelle Bestellung vorkommt, jedoch bei den Mitarbeitern genannt wird. Verwenden Sie EXCEPT (KartoFinale).  
USE KartoFinale
SELECT Personalnummer
FROM Personal.Mitarbeiter
EXCEPT
SELECT Personalnummer
FROM Bestellung

-- 2. Ladenh�ter sollen beworben werden. Zu welchen Artikelnummern in der KartoFinale-Datenbank liegen keine Bestellungen vor?
USE KartoFinale;
SELECT Artikelnummer
FROM Artikel
EXCEPT
SELECT Artikelnummer
FROM Bestellposten

-- 3. F�r welche Werbeartikel gibt es derzeit keine Bestellungen? Erstellen Sie eine Anfrage mit Unterabfrage anhand derer die Bezeichnung der Werbeartikel ausgegeben wird, f�r die es derzeit keine Bestellungen gibt (KartoFinale). 
SELECT Bezeichnung
FROM Werbeartikel
WHERE Artikelnummer IN (
SELECT Artikelnummer
FROM Artikel
EXCEPT
SELECT Artikelnummer
FROM Bestellposten)

-- 4. Pr�fen Sie in der KartoFinale-Datenbank anhand der Nachnamen, welche Mitarbeiter wahrscheinlich verheiratet sind. Nutzen Sie INTERSECT. Geben Sie die Nachnamen aus. Anders formuliert: Welche Nachnamen kommen sowohl in der Relation Ehepartner wie auch in der Relation Mitarbeiter vor? 
USE KartoFinale;
SELECT Name
FROM Ehepartner
INTERSECT
SELECT Name
FROM Personal.Mitarbeiter

-- 5. An welchen Spielst�tten in der KartoFinale-Datenbank k�nnen sofort Mitarbeiter zur Hilfe eilen: An welchen Orten sind Spielst�tten und Wohnorte von Mitarbeitern?
USE KartoFinale;
SELECT Ort
FROM Personal.Mitarbeiter
INTERSECT
SELECT Ort
FROM Spielst�tte 

-- 6. Wie hei�en die Spielst�tten (das Haus), bei denen die Mitarbeiter helfen k�nnen (KartoFinale)?
USE KartoFinale;
SELECT Haus
FROM Spielst�tte
WHERE Ort IN (SELECT Ort
FROM Personal.Mitarbeiter
INTERSECT
SELECT Ort
FROM Spielst�tte )

-- 7. Geben Sie alle Vornamen von Ehepartnern, Kunden und Mitarbeitern aus. Behalten Sie Duplikate bei (KartoFinale).
USE KartoFinale;
SELECT Vorname
FROM Ehepartner
UNION ALL
SELECT Vorname
FROM Personal.Mitarbeiter
UNION ALL
SELECT Vorname
FROM Kunde

-- 8. Aus welchen Orten kommen die Mitarbeiter aus der Bike-Datenbank und der KartoFinale-Datenbank? Erzeugen Sie eine gemeinsame Tabelle.
SELECT Ort
FROM Bike.dbo.Personal
UNION
SELECT ORT 
FROM KartoFinale.Personal.Mitarbeiter

-- 9. Geben Sie das Durchschnittsgehalt von KartoFinale und aus der Bike-Datenbank aus. Die resultierende Abfrage soll zwei Spalten umfassen: Durchschnittsgehalt und Datenbank. F�r jede Datenbank soll es einen Eintrag geben. 
SELECT AVG(Gehalt) AS Durchschnittsgehalt, 'Bike' AS Datenbank
FROM Bike.dbo.Personal
UNION
SELECT  AVG(Gehalt), 'KartoFinale' 
FROM KartoFinale.Personal.Mitarbeiter
