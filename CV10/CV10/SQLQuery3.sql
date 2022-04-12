SELECT * FROM [Student] LEFT JOIN
[StudentPredmet] on Id = StudentKluc
LEFT JOIN [Predmet] on Skratka = PredmetKluc;
SELECT Priezvisko, COUNT (Priezvisko) as Pocet
FROM [Student]
GROUP BY Priezvisko
ORDER BY Pocet DESC;
SELECT PredmetKluc FROM [StudentPredmet] GROUP BY PredmetKluc
HAVING COUNT(StudentKluc) < 3;
SELECT PredmetKluc, 
COUNT(StudentKluc) as Pocet, 
MIN(Hodnotenie) as Najlepsie,
MAX(Hodnotenie) as Najhorsie,
AVG(Hodnotenie) as Priemerne
FROM [Hodnotenie]
GROUP BY PredmetKluc;