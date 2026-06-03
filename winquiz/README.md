# Windows Forms Quiz Application

A comprehensive quiz application built with .NET 10 and Windows Forms, featuring a player quiz mode and an admin panel for managing questions.

## Features

### Player Mode
- User registration with name
- Select number of questions (5 or 10)
- Interactive quiz with randomized questions
- Multiple choice answers
- Point-based scoring system
- Progress tracking with progress bar
- Results display showing final score
- Session tracking in database

### Admin Mode
- View all questions and answers
- Add new questions with point values
- Edit existing questions
- Delete questions (with cascade delete on answers)
- Add answers with correct/incorrect marking
- Edit answers
- Delete answers
- View all users and their profiles
- View all game sessions with player information

## Database Schema

### User Table
- `Id` (INT, PK, Identity)
- `Name` (VARCHAR(100), NOT NULL)
- `RegistrationDate` (DATE, NOT NULL)
- `Rank` (DECIMAL(2,1), NULL, 0.0-5.0 range)

### Questions Table
- `Id` (INT, PK, Identity)
- `QuestionText` (VARCHAR(500), NOT NULL)
- `Point` (INT, NOT NULL)

### Answers Table
- `Id` (INT, PK, Identity)
- `AnswerText` (VARCHAR(300), NOT NULL)
- `IsCorrect` (BIT, NOT NULL)
- `QuestionId` (INT, FK → Questions)

### GameSession Table
- `Id` (INT, PK, Identity)
- `UserId` (INT, FK → User)
- `QuestionsCount` (INT, NOT NULL)
- `Score` (INT, NOT NULL)
- `SessionStart` (DATETIME, NOT NULL)
- `SessionEnd` (DATETIME, NULL)

## Setup Instructions

### Prerequisites
- .NET 10 SDK or later
- SQL Server LocalDB (included with Visual Studio) or SQL Server instance
- Visual Studio 2022 or later (or Visual Studio Community)

### Database Setup

1. Open `Database/Schema.sql` in SQL Server Management Studio or Visual Studio
2. Execute the schema script to create all tables
3. Execute `Database/SeedData.sql` to populate test data
4. Optionally execute `Database/Exercises.sql` to see example queries

Alternatively, the application will automatically create the database on first run if using LocalDB.

### Connection String

The default connection string in `Data/QuizDbContext.cs` is:
```
Server=(localdb)\mssqllocaldb;Database=QuizDb;Integrated Security=true;
```

To use a different SQL Server instance, modify the `OnConfiguring` method in `QuizDbContext.cs`.

### Running the Application

1. Open `winquiz.sln` in Visual Studio
2. Build the solution (Build → Build Solution)
3. Press F5 or click Run to start the application

## Usage

### Player Mode
1. Enter your name
2. Select the number of questions (5 or 10)
3. Click "Start Quiz"
4. Select an answer for each question
5. Click "Next Question" to proceed
6. Click "Finish" to complete the quiz early
7. View your results
8. Click "Start Over" to play again

### Admin Mode
1. Click "Admin Panel" from the main screen
2. Navigate to the "Questions & Answers" tab
3. Select a question to view its answers
4. Use buttons to Add/Edit/Delete questions and answers
5. Navigate to "Users" tab to see all registered players
6. Navigate to "Game Sessions" tab to see play history

## SQL Exercises

The `Database/Exercises.sql` file contains solutions for 19 SQL exercises covering:
- SELECT, DISTINCT, WHERE, ORDER BY
- AND, OR, NOT, NULL
- INSERT, UPDATE, DELETE
- Aggregate functions (COUNT, AVG, MAX)
- LIKE, IN, BETWEEN
- INNER JOIN, LEFT JOIN
- GROUP BY, HAVING

## Architecture

### Models
- `User` - Player information
- `Question` - Quiz questions
- `Answer` - Answer options for questions
- `GameSession` - Quiz play history

### Data Access Layer
- `QuizDbContext` - Entity Framework Core context
- `QuizRepository` - Data access methods with async/await

### UI Forms
- `Form1` - Main quiz player interface
- `AdminForm` - Admin panel with tabbed interface
- `QuestionEditForm` - Dialog for adding/editing questions
- `AnswerEditForm` - Dialog for adding/editing answers

## Technologies

- **.NET 10**
- **Windows Forms** - UI framework
- **Entity Framework Core 8.0** - ORM
- **SQL Server** - Database
- **C# 13** - Programming language

## Project Structure

```
winquiz/
├── Database/
│   ├── Schema.sql       (Database schema)
│   ├── SeedData.sql     (Test data)
│   └── Exercises.sql    (SQL exercise solutions)
├── Models/
│   ├── User.cs
│   ├── Question.cs
│   ├── Answer.cs
│   └── GameSession.cs
├── Data/
│   ├── QuizDbContext.cs (EF Core context)
│   └── QuizRepository.cs (Data access)
├── Form1.cs             (Main quiz UI)
├── AdminForm.cs         (Admin interface)
├── QuestionEditForm.cs  (Question dialog)
└── AnswerEditForm.cs    (Answer dialog)
```

## Notes

- Questions are randomized on each quiz
- Each player gets a new user record (new registrations for each game)
- Game sessions track start and end times
- Score is calculated based on points of correct answers
- Rank is optional and not updated automatically by the application
- All UI interactions use async/await for database operations

## Future Enhancements

- User authentication and login
- Leaderboard/statistics view
- Question categories
- Difficulty levels
- Timed quizzes
- Export results to CSV
- Question import/export
- Multi-language support
