CREATE TABLE Random(
Id INT NOT NULL,
RandomNumber INT NOT NULL);

SELECT * FROM RandomTal WHERE RandomNumber = 420;

SELECT RandomNumber, SUM(RandomNumber) AS RndRepeats FROM RandomTal GROUP BY RandomNumber ORDER BY RndRepeats


SELECT RandomNumber, SUM(RandomNumber) AS RndRepeats FROM RandomTal GROUP BY RandomNumber ORDER BY RndRepeats ASC
--Nummer 102 er det mest sjældne med 1 forekomst

SELECT RandomNumber, SUM(RandomNumber) AS RndRepeats FROM RandomTal GROUP BY RandomNumber ORDER BY RndRepeats DESC
--Nummer 1286259 er det hyppigste med 9971 forekomster