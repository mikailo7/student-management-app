CREATE TABLE Korisnici(
Id INT IDENTITY(1,1) PRIMARY KEY,
Ime NVARCHAR(50),
Lozinka NVARCHAR(50)
)
CREATE TABLE Satovi(
Id INT IDENTITY(1,1) PRIMARY KEY,
KorisnikId INT,
Marka NVARCHAR(50),
Cena DECIMAL(10,2),
Baterija INT,
Koraci INT,
OtkucajiSrca INT,
SleepMode BIT,
Datum DATE,

FOREIGN KEY(KorisnikId) REFERENCES Korisnici(Id)
)
INSERT INTO Korisnici (Ime, Lozinka)
VALUES
('marko','markovic'),
('nikola','nikolic'),
('ana','anic');

INSERT INTO Satovi (KorisnikId, Marka, Cena, Datum, Koraci, OtkucajiSrca, SleepMode)
VALUES
(1,'Samsung Galaxy Watch',350,'2025-01-10',5000,80,0),
(1,'Apple Watch Series 8',600,'2025-02-05',7200,75,1),
(1,'Huawei Watch GT',280,'2025-03-01',4500,82,0),
(1,'Xiaomi Mi Watch',200,'2025-03-15',9000,78,1),
(1,'Garmin Vivoactive',420,'2025-04-01',6100,76,0),

(2,'Samsung Galaxy Watch',350,'2025-01-12',4000,85,1),
(2,'Apple Watch SE',450,'2025-02-10',6800,77,0),
(2,'Huawei Watch Fit',230,'2025-03-02',5200,83,0),
(2,'Xiaomi Redmi Watch',150,'2025-03-20',7300,79,1),
(2,'Garmin Forerunner',500,'2025-04-05',8800,74,0),

(3,'Samsung Galaxy Watch',360,'2025-01-15',6400,80,1),
(3,'Apple Watch Ultra',900,'2025-02-18',8100,72,0),
(3,'Huawei Watch GT 3',300,'2025-03-05',5600,84,1),
(3,'Xiaomi Mi Watch Lite',170,'2025-03-22',7100,79,0),
(3,'Garmin Venu',550,'2025-04-10',9200,73,1); 
SELECT * FROM Korisnici
WHERE Ime='marko' AND Lozinka='marko1'
CREATE TABLE PulsLog
(
Id INT IDENTITY(1,1) PRIMARY KEY,
SatId INT,
Puls INT,
Datum DATETIME,

FOREIGN KEY (SatId) REFERENCES Satovi(Id)
)