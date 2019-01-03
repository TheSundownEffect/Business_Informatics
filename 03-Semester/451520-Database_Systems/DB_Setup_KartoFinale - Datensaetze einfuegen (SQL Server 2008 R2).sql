USE KartoFinale
GO

INSERT INTO Ort(Ort, Plz, Bundesland, Laengengrad, Breitengrad)
VALUES ('Kohlscheidt', 44444, 'NW', NULL, NULL),
       ('Karlstadt', 22222, 'SH', NULL, NULL),
       ('Rettrich', 33333, 'NI', NULL, NULL),
       ('Hamburg', 22287, 'HH', 10.0, 53.55),
       ('Heide', 25746, 'SH', 9.1, 54.2),
       ('Stralsund', 18435, 'MV', NULL, NULL)

-- Abteilungsleiter noch nicht eingefügt, deshalb erst auf NULL setzen, da Mitarbeiter erst eingefügt sein müssen
ALTER TABLE Personal.Abteilung NOCHECK CONSTRAINT AbteilungsleiterObligatory
INSERT INTO Personal.Abteilung(Abteilungsbezeichnung, Abteilungsnummer, PersonalnummerAbteilungsleiter)
VALUES ('Vertrieb', 1, NULL ),
       ('Geschäftsführung', 2, NULL ),
       ('Rechnungswesen', 3, NULL ),
       ('Personal', 4, NULL)

INSERT INTO Personal.Mitarbeiter(Personalnummer, Name, Vorname, Strasse, Hausnummer, Geschlecht, Gehalt, Abteilungsbezeichnung, PersonalnummerVorgesetzter, Ort, Plz)
VALUES (6, 'Kowalski', 'Karsten', 'Blankeneser Weg', '2', 'M', 5000.00, NULL, NULL, 'Hamburg', 22287),
       (3, 'Kart', 'Karen', 'Pantherstr.', '12', 'W', 3000.00, 'Vertrieb', 6, 'Karlstadt', 22222),
       (5, 'Klein', 'Karl', 'Minimalweg', '1', 'M', 2000.00, 'Vertrieb', 3, 'Karlstadt', 22222),
       (8, 'Klug', 'Frieda', 'Musterweg', '110', 'W', 2500.00, 'Vertrieb', 3, 'Hamburg', 22287),
       (10, 'Wunder', 'Hans', 'Kohlweg', '1', 'M', 2300.00, 'Rechnungswesen', 3, 'Karlstadt', 22222)
       
-- Abteilungsleiter jetzt eingefügt, deshalb Abteilung jetzt ändern
UPDATE Personal.Abteilung SET PersonalnummerAbteilungsleiter = 3  WHERE Abteilungsbezeichnung = 'Vertrieb';
UPDATE Personal.Abteilung SET PersonalnummerAbteilungsleiter = 6  WHERE Abteilungsbezeichnung = 'Geschäftsführung'
UPDATE Personal.Abteilung SET PersonalnummerAbteilungsleiter = 10 WHERE Abteilungsbezeichnung = 'Rechnungswesen'
UPDATE Personal.Abteilung SET PersonalnummerAbteilungsleiter = 6  WHERE Abteilungsbezeichnung = 'Personal'

ALTER TABLE Personal.Abteilung CHECK CONSTRAINT AbteilungsleiterObligatory

INSERT INTO Ehepartner(Name, Vorname, Geburtsdatum, Personalnummer)
VALUES ('Kowalski', 'Marie', '19781002', 6),
       ('Wunder', 'Karla', '19600421', 10),
       ('Klug', 'Helmut', '19550121', 8),
       ('Klein', 'Bertha', '19481202', 5)
      
INSERT INTO Kunde(Kundennummer, Name, Vorname, Strasse, Hausnummer, Geschlecht, Geburtsdatum, Ort, Plz)
VALUES (1, 'Bolte', 'Bertram', 'Busweg', '12', 'M', '19731008', 'Kohlscheidt', 44444),
       (2, 'Muster', 'Hans', 'Musterweg', '12', 'M', '19530221', 'Karlstadt', 22222),
       (3, 'Wiegerich', 'Frieda', 'Wanderstr.', NULL, 'W', '19630818', 'Rettrich', 33333),
       (4, 'Carlson', 'Peter', 'Petristr.', '201', 'M', '19710926', 'Kohlscheidt', 44444)


INSERT INTO Spielstätte(Haus, Strasse, Hausnummer, Beschreibung, Ort, Plz)
VALUES ('Hamburg Opernhaus', 'Opernstr.', '1', '', 'Hamburg', 22287),
       ('Operettenhaus', 'Bahndamm', '88', '', 'Hamburg', 22287),
       ('Sokratesbühne', 'Musterweg', '81', '', 'Karlstadt', 22222),
       ('Nordseehalle', 'Nordfeldweg', '200', '', 'Heide', 25746),
       ('Kongresshalle', 'Hahndamm', '21', '', 'Rettrich', 33333)
     
INSERT INTO Veranstaltung(Veranstaltungsnummer, Bezeichnung, Beschreibung, Autor)
VALUES (1, 'Don Giovanni', NULL, 'Mozart'),
       (2, 'Phil Collins LIVE', NULL, 'Phil Collins'),
       (3, 'Die Zauberflöte', NULL, 'Mozart'),
       (4, 'Mutter Courage', NULL, 'B. Brecht'),
       (5, 'Cats', NULL, 'A. L. Webber')

INSERT INTO Vorstellung(Vorstellungsnummer, Datum, Uhrzeit, Veranstaltungsnummer, Haus)
VALUES (1, '20110721', '20:00', 1, 'Hamburg Opernhaus'),
       (2, '20110728', '19:30', 1, 'Hamburg Opernhaus'),
       (3, '20110804', '19:30', 1, 'Hamburg Opernhaus'),
       (1, '20110105', '21:30', 3, 'Operettenhaus'),
       (2, '20110106', '21:30', 3, 'Operettenhaus'),
       (1, '20110721', '18:45', 2, 'Nordseehalle'),
       (2, '20110801', '19:00', 2, 'Kongresshalle'),
       (3, '20110918', '19:15', 2, 'Hamburg Opernhaus'),
       (1, '20110131', '19:30', 4, 'Sokratesbühne'),
       (2, '20110228', '19:30', 4, 'Sokratesbühne'),
       (3, '20110331', '20:00', 4, 'Sokratesbühne'),
       (4, '20110430', '20:00', 4, 'Sokratesbühne'),
       (5, '20110531', '20:00', 4, 'Sokratesbühne')

INSERT INTO Artikel(Artikelnummer, Preis) 
VALUES (1001, 89.00),
       (1003, 29.99),
       (1012, 20.00),
       (1081, 5.99),
       (1077, 33.50),
       (1078, 19.99),
       (1101, 89.00),
       (1102, 89.00),
       (1103, 120.00),
       (1104, 75.00),
       (1105, 60.00),
       (1201, 89.00),
       (1202, 89.00),
       (1203, 120.00),
       (1204, 75.00),
       (1205, 60.00),
       (4101, 120.00),
       (4102, 120.00),
       (4103, 120.00),
       (4104, 60.00),
       (4105, 90.00),
       (4106, 85.99)

INSERT INTO Werbeartikel(Bezeichnung, Lagerbestand, Mindestbestand, Artikelnummer)
VALUES ('Noten f. Klavier', 26, 20, 1001),
       ('T-Shirt Farbe: rot', 11, 10, 1003),
       ('Phil Collins in Concert', 21, 20, 1012),
       ('Schwarzer Zauberstock', 32, 30, 1081),
       ('Plakat mit Musical-Katzen', 89, 90, 1077),
       ('Opernführer', 9999, NULL, 1078)
       
INSERT INTO Sitzplatz(Bereich, Reihe, Sitznummer, Zustand, Artikelnummer, Vorstellungsnummer, Veranstaltungsnummer)
VALUES ('Parkett', '2', '8',  'belegt',    1101, 1, 1),
       ('Parkett', '4', '11', 'frei',      1102, 1, 1),
       ('1. Rang', '1', '12', 'frei',      1103, 1, 1),
       ('2. Rang', '3', '2',  'belegt',    1104, 1, 1),
       ('3. Rang', '7', '1',  'reserviert',1105, 1, 1),
       ('Parkett', '2', '8',  'belegt',    1201, 2, 1),
       ('Parkett', '4', '11', 'frei',      1202, 2, 1),
       ('1. Rang', '1', '12', 'frei',      1203, 2, 1),
       ('2. Rang', '3', '2',  'belegt',    1204, 2, 1),
       ('3. Rang', '7', '1',  'reserviert',1205, 2, 1),
       ('Parkett', '1', '1',  'frei',      4101, 1, 3),
       ('Parkett', '1', '2',  'frei',      4102, 1, 3),
       ('Parkett', '1', '3',  'frei',      4103, 1, 3),
       ('Parkett', '11', '14','frei',      4104, 1, 3),
       ('Parkett', '3', '21', 'frei',      4105, 1, 3),
       ('Parkett', '8', '26', 'frei',      4106, 1, 3)

INSERT INTO Bestellung(BestellNr, Datum, Personalnummer, Kundennummer)
VALUES (1, '20110126' , 5, 1),
       (3, '20110208' , 3, 3),
       (8, '20111221' , 5, 2)

INSERT INTO Bestellposten(Positionsnummer,Menge, BestellNr, Artikelnummer)
VALUES (1, 1, 1, 1101),
       (2, 1, 1, 1102),
       (3, 1, 1, 1103),
       (4, 2, 1, 1001),
       (5, 3, 1, 1003),
       (1, 1, 8, 4101),
       (2, 2, 8, 1012)
