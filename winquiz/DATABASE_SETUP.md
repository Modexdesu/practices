# Database Setup Guide

## Quick Setup

### Option 1: Automatic Database Creation (Recommended)

The application will automatically create the database on first run if:
1. SQL Server LocalDB is installed (comes with Visual Studio)
2. The connection string is valid

Just run the application and it will initialize the database automatically.

### Option 2: Manual Database Setup

1. Open SQL Server Management Studio (SSMS) or SQL Server Object Explorer in Visual Studio
2. Connect to your SQL Server instance (default: `(localdb)\mssqllocaldb`)
3. Execute the scripts in this order:

#### Step 1: Create Tables
```sql
-- Execute: Database/Schema.sql
```

#### Step 2: Insert Test Data
```sql
-- Execute: Database/SeedData.sql
```

#### Step 3: Verify Setup (Optional)
```sql
-- Check User table
SELECT * FROM [User];

-- Check Questions
SELECT * FROM Questions;

-- Check Answers
SELECT * FROM Answers;

-- Check GameSessions
SELECT * FROM GameSession;
```

## Connection String Configuration

The connection string is defined in `Data/QuizDbContext.cs` in the `OnConfiguring` method:

```csharp
var connectionString = @"Server=(localdb)\mssqllocaldb;Database=QuizDb;Integrated Security=true;";
```

### Common Connection String Variations

**For Local SQL Server Express:**
```
Server=.\SQLEXPRESS;Database=QuizDb;Integrated Security=true;
```

**For Named SQL Server Instance:**
```
Server=SERVER_NAME\INSTANCE_NAME;Database=QuizDb;Integrated Security=true;
```

**With SQL Authentication:**
```
Server=SERVER_NAME;Database=QuizDb;User Id=sa;Password=YOUR_PASSWORD;
```

**For SQL Server on Azure:**
```
Server=tcp:server_name.database.windows.net,1433;Initial Catalog=QuizDb;Persist Security Info=False;User ID=username;Password=password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

## SQL Exercises Solutions

The file `Database/Exercises.sql` contains 19 solved SQL exercises:

1. **SELECT** - List all users with Name and Rank
2. **DISTINCT** - Get unique Rank values
3. **WHERE** - Find users with Rank > 3.0
4. **ORDER BY** - Sort sessions by Score descending
5. **AND** - Sessions with Score > 20 AND QuestionsCount = 5
6. **OR** - Questions with Point = 1 OR Point = 2
7. **NOT** - Questions where Point ≠ 5
8. **NULL** - Incomplete sessions (SessionEnd IS NULL)
9. **INSERT INTO** - Add new user
10. **UPDATE** - Update user Rank to 5.0
11. **DELETE** - Remove sessions with Score = 0
12. **Aggregate** - Count, average, and max scores
13. **LIKE** - Users starting with 'G' / Questions without '?'
14. **IN** - Users with specific Rank values
15. **BETWEEN** - Users with Rank between 2.5 and 4.5
16. **INNER JOIN** - Sessions with user names
17. **LEFT JOIN** - All users with their sessions (if any)
18. **GROUP BY** - User game count and total score
19. **HAVING** - Users who played more than once

## Troubleshooting

### Error: "Cannot connect to database"

**Solution:** Ensure SQL Server LocalDB is running. In Visual Studio, go to:
- View → SQL Server Object Explorer
- Look for `(localdb)\mssqllocaldb`
- Right-click and select "Create New Database"

### Error: "Foreign Key constraint violation"

**Solution:** Ensure tables are created in the correct order:
1. User
2. Questions
3. Answers (references Questions)
4. GameSession (references User)

### Error: "Database already exists"

**Solution:** Either:
- Use the existing database (it's safe to rerun the schema script)
- Or delete the existing database and recreate it

### Error: "Connection timeout"

**Solution:** 
- Check your SQL Server is running
- Verify the connection string is correct
- Check firewall settings if using remote server

## Database Backup

To backup the database:

```sql
BACKUP DATABASE QuizDb TO DISK='C:\Backup\QuizDb.bak';
```
// es tavisit daamata mara ravi mainc kaia davtoveb
To restore the database:

```sql
RESTORE DATABASE QuizDb FROM DISK='C:\Backup\QuizDb.bak';
```

## Resetting the Database

To start fresh, run this in your connection context:

```sql
-- Drop tables (careful - this deletes all data!)
DROP TABLE IF EXISTS GameSession;
DROP TABLE IF EXISTS Answers;
DROP TABLE IF EXISTS Questions;
DROP TABLE IF EXISTS [User];

-- Then re-run the Schema.sql script
```
