--aqa sql varjishebia 

-- 01. SELECT 
SELECT Name, Rank FROM [User];

-- 02. DISTINCT 
SELECT DISTINCT Rank FROM [User];

-- 03. WHERE
SELECT * FROM [User] WHERE Rank > 3.0;

-- 04. ORDER BY
SELECT * FROM GameSession ORDER BY Score DESC;

-- 05. AND 
SELECT * FROM GameSession WHERE Score > 20 AND QuestionsCount = 5;

-- 06. OR 
SELECT * FROM Questions WHERE Point = 1 OR Point = 2;

-- 07. NOT 
SELECT * FROM Questions WHERE NOT (Point = 5);


-- 08. NULL 
SELECT * FROM GameSession WHERE SessionEnd IS NULL;

-- 09. INSERT INTO 
INSERT INTO [User] (Name, RegistrationDate, Rank) VALUES ('George Taylor', '2024-03-15', NULL);

-- 10. UPDATE 
UPDATE [User] SET Rank = 5.0 WHERE Id = 1;

-- 11. DELETE 
DELETE FROM GameSession WHERE Score = 0;

-- 12. Aggregate 
SELECT 
	COUNT(*) AS TotalGames,
	AVG(Score) AS AverageScore,
	MAX(Score) AS HighestScore
FROM GameSession;

-- 13. LIKE 
SELECT * FROM [User] WHERE Name LIKE 'G%';

-- 13b. LIKE 
SELECT * FROM Questions WHERE QuestionText NOT LIKE '%?%';

-- 14. IN
SELECT * FROM [User] WHERE Rank IN (1.0, 2.0, 3.0, 4.0, 5.0);

-- 15. BETWEEN
SELECT * FROM [User] WHERE Rank BETWEEN 2.5 AND 4.5;

-- 16. INNER JOIN 
SELECT gs.Id, u.Name, gs.QuestionsCount, gs.Score, gs.SessionStart, gs.SessionEnd 
FROM GameSession gs
INNER JOIN [User] u ON gs.UserId = u.Id;

-- 17. LEFT JOIN
SELECT u.Id, u.Name, u.Rank, gs.Score, gs.QuestionsCount, gs.SessionStart, gs.SessionEnd 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId;

-- 18. GROUP BY
SELECT u.Id, u.Name, COUNT(gs.Id) AS GameCount, SUM(gs.Score) AS TotalScore 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId
GROUP BY u.Id, u.Name;

-- 19. HAVING
SELECT u.Id, u.Name, COUNT(gs.Id) AS GameCount, SUM(gs.Score) AS TotalScore 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId
GROUP BY u.Id, u.Name
HAVING COUNT(gs.Id) > 1;
