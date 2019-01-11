-- Werte einfuegen

--1 Werte einfuegen
-- Ort
INSERT INTO Ort(Name, Plz, Bundesland, Einwohnerzahl, Fläche)
VALUES ('Schleswig', 24837, 'SH', 24266,24.3),
('Harburg', 21073, 'HH', 26098, 3.9),
('Rotenburg (Wümme)', 27356,'NDS', 21392, 99),
('Schuby', 24850, 'SH', 2567, 23.94),
('Bremervörde', 27432, 'NDS', 18654, 150.18)

-- Buch
INSERT INTO Buch(ISBN, Titel, Verlag, Jahr, Preis)
Values(3344556677889, 'Datenbanksysteme', 'Springer', 2012, 29.99),
(4455667788990, 'NoSQL', 'Gabler', 2016, 27.50),
(5566778899001, 'Einführung in die Wirtschaftsinformatik', 'DeGruyter', 2006, 35.69),
(6677889900112, 'Python für Einsteiger','O`Reilly', 2017, 29.99),
(7788990011223, 'Data Science Handbook', 'Springer', 2015, 34.99)

-- Autor
INSERT INTO Autor (Name, Vorname, Geschlecht, Ort, Plz)
VALUES('Meyer','Herbert','m','Harburg',21073),
('Susanne','Müller','w','Schuby', 24850),
('Sabine','Haase','w','Harburg',21073),
('Chrstian','Fuchs','m','Schleswig',24837),
('Maxi','Munter','w','Bremervörde',27432)

-- Autorenschaft
INSERT INTO Autorenschaft(ISBN, AutorID, Beitrag)
VALUES(4455667788990,3, 0.8),
(4455667788990, 4, 0.2),
(5566778899001,5., 1.00),
(6677889900112,4, 1.00),
(7788990011223,1, 1.00),
(3344556677889,2, 0.5),
(3344556677889,4, 0.5)

-- Bank
INSERT INTO Bank(BLZ, Ort, Plz, Bezeichnung, Straße, Hausnummer)
Values(912345,'Schuby', 24850, 'ZinsHoch', 'Mozartweg',1),
(123456,'Schuby', 24850, 'SparViel', 'Beethovenweg',2),
(234567,'Schleswig', 24837, 'GeldohneGrenzen', 'Bachstraße', 3),
(345678,'Schleswig', 24837,'BaufinanzBank', 'Wagnerweg', 4),
(456789,'Harburg', 21073,'ReichundCo.', 'Brahmsplatz',5)

-- Konto
INSERT INTO Konto(Kontonummer, BLZ, Autor)
VALUES(111111,123456,1),
(222222,123456,2),
(333333,234567,3),
(444444,345678,4),
(555555,456789,5)

--2 
UPDATE Buch
SET Preis = Preis *1.1

--3
UPDATE Autor
SET Vorname = Vorname + ' Stefan'
WHERE Vorname = 'Herbert' AND Name = 'Meyer'

--4
UPDATE Buch
SET Titel = Titel + ' Eine Einführung.'
WHERE ISBN = 4455667788990

--5
ALTER TABLE Autor
ADD Änderungsdatum date CONSTRAINT de_Aenderung DEFAULT GETDATE()

--6
UPDATE Autor
SET Name = 'Christiansen', Vorname = 'Hanna' , Geschlecht = 'w', Ort = 'Harburg', Plz = 21073, Änderungsdatum = DEFAULT
WHERE AutorID = 3 

--7
DELETE FROM Konto
WHERE Einrichtungsdatum >= '08.12.2017'

--8 
DELETE FROM Autorenschaft
WHERE AutorID IN (SELECT AutorID
				FROM Autor
				WHERE Name = 'Maxi' AND Vorname = 'Munter')


