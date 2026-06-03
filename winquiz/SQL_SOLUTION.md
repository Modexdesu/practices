# SQL Assignment - Complete Solution
# es ais chamovawerine imis shemdeg rac kodi davwere imitom rom chemit damezara :p
This document contains all SQL solutions for the Quiz Application database assignment.

## ეტაპი 1 — ცხრილების შექმნა (Stage 1 - Create Tables)

**File: `Database/Schema.sql`**

The schema creates 4 tables in the correct order (with foreign keys last):

### Tables Created:
1. **[User]** - Player information
   - Id (INT, PK, Identity)
   - Name (VARCHAR(100), NOT NULL)
   - RegistrationDate (DATE, NOT NULL)
   - Rank (DECIMAL(2,1), NULL, 0.0-5.0 range)

2. **Questions** - Quiz questions
   - Id (INT, PK, Identity)
   - QuestionText (VARCHAR(500), NOT NULL)
   - Point (INT, NOT NULL)

3. **Answers** - Answer options
   - Id (INT, PK, Identity)
   - AnswerText (VARCHAR(300), NOT NULL)
   - IsCorrect (BIT, NOT NULL)
   - QuestionId (INT, FK → Questions)

4. **GameSession** - Game play history
   - Id (INT, PK, Identity)
   - UserId (INT, FK → User)
   - QuestionsCount (INT, NOT NULL)
   - Score (INT, NOT NULL)
   - SessionStart (DATETIME, NOT NULL)
   - SessionEnd (DATETIME, NULL)

---

## ეტაპი 2 — სატესტო მონაცემები (Stage 2 - Test Data)

**File: `Database/SeedData.sql`**

Test data inserted in correct order:

### Data Included:
- **8 Users** - Sample player data with names, registration dates, and ranks
- **10 Questions** - Quiz questions with various point values
- **40 Answers** - 4 answers per question, with IsCorrect flag
- **10 GameSessions** - Sample play sessions with scores and timestamps

---

## ეტაპი 3 — SQL სავარჯიშოები (Stage 3 - SQL Exercises)

**File: `Database/Exercises.sql`**

All 19 SQL exercises with complete solutions:

### Exercise Queries:

**01. SELECT** - Get all users' names and ranks
```sql
SELECT Name, Rank FROM [User];
```

**02. DISTINCT** - Get unique rank values
```sql
SELECT DISTINCT Rank FROM [User];
```

**03. WHERE** - Users with rank > 3.0
```sql
SELECT * FROM [User] WHERE Rank > 3.0;
```

**04. ORDER BY** - All sessions sorted by score (descending)
```sql
SELECT * FROM GameSession ORDER BY Score DESC;
```

**05. AND** - Sessions with score > 20 AND questions = 5
```sql
SELECT * FROM GameSession WHERE Score > 20 AND QuestionsCount = 5;
```

**06. OR** - Questions with points 1 or 2
```sql
SELECT * FROM Questions WHERE Point = 1 OR Point = 2;
```

**07. NOT** - Questions where points ≠ 5
```sql
SELECT * FROM Questions WHERE NOT (Point = 5);
```

**08. NULL** - Incomplete sessions (SessionEnd IS NULL)
```sql
SELECT * FROM GameSession WHERE SessionEnd IS NULL;
```

**09. INSERT INTO** - Add new user
```sql
INSERT INTO [User] (Name, RegistrationDate, Rank) VALUES ('George Taylor', '2024-03-15', NULL);
```

**10. UPDATE** - Update user rank to 5.0
```sql
UPDATE [User] SET Rank = 5.0 WHERE Id = 1;
```

**11. DELETE** - Remove sessions with score 0
```sql
DELETE FROM GameSession WHERE Score = 0;
```

**12. Aggregate** - Count, average, and max scores
```sql
SELECT 
	COUNT(*) AS TotalGames,
	AVG(Score) AS AverageScore,
	MAX(Score) AS HighestScore
FROM GameSession;
```

**13. LIKE** - Users starting with 'G'
```sql
SELECT * FROM [User] WHERE Name LIKE 'G%';
```

**13b. LIKE** - Questions without '?'
```sql
SELECT * FROM Questions WHERE QuestionText NOT LIKE '%?%';
```

**14. IN** - Users with specific ranks
```sql
SELECT * FROM [User] WHERE Rank IN (1.0, 2.0, 3.0, 4.0, 5.0);
```

**15. BETWEEN** - Users with rank 2.5-4.5
```sql
SELECT * FROM [User] WHERE Rank BETWEEN 2.5 AND 4.5;
```

**16. INNER JOIN** - Sessions with user names
```sql
SELECT gs.Id, u.Name, gs.QuestionsCount, gs.Score, gs.SessionStart, gs.SessionEnd 
FROM GameSession gs
INNER JOIN [User] u ON gs.UserId = u.Id;
```

**17. LEFT JOIN** - All users with their sessions (if any)
```sql
SELECT u.Id, u.Name, u.Rank, gs.Score, gs.QuestionsCount, gs.SessionStart, gs.SessionEnd 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId;
```

**18. GROUP BY** - Each user's game count and total score
```sql
SELECT u.Id, u.Name, COUNT(gs.Id) AS GameCount, SUM(gs.Score) AS TotalScore 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId
GROUP BY u.Id, u.Name;
```

**19. HAVING** - Users who played more than once
```sql
SELECT u.Id, u.Name, COUNT(gs.Id) AS GameCount, SUM(gs.Score) AS TotalScore 
FROM [User] u
LEFT JOIN GameSession gs ON u.Id = gs.UserId
GROUP BY u.Id, u.Name
HAVING COUNT(gs.Id) > 1;
```

---

## How to Use These SQL Files

### Step 1: Create Database
1. Open SQL Server Management Studio (SSMS)
2. Execute `Database/Schema.sql`
3. This creates all 4 tables with proper constraints

### Step 2: Add Test Data
1. Execute `Database/SeedData.sql`
2. This populates the database with 8 users, 10 questions, 40 answers, and 10 sessions

### Step 3: Run Exercises
1. Execute any query from `Database/Exercises.sql`
2. Each query demonstrates a different SQL concept

---

## Key Points

✅ **Correct Table Order**: User → Questions → Answers → GameSession (FK dependencies respected)

✅ **Rank Validation**: DECIMAL(2,1) with CHECK constraint (0.0-5.0)

✅ **SessionEnd**: Can be NULL (for incomplete sessions)

✅ **All 19 Exercises**: Complete and tested

✅ **Comments**: Each query labeled in Georgian with explanation

---

## Files Location

```
Database/
├── Schema.sql      (ეტაპი 1 - Table creation)
├── SeedData.sql    (ეტაპი 2 - Test data)
└── Exercises.sql   (ეტაპი 3 - 19 SQL exercises)
```

---

## Summary

This is a complete SQL assignment solution covering:
- ✅ Database schema design with proper constraints
- ✅ Test data insertion in correct order
- ✅ 19 SQL exercises covering all major SQL concepts

All files are ready to execute in SQL Server!
