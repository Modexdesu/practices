

-- User table
CREATE TABLE [User] (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(100) NOT NULL,
	RegistrationDate DATE NOT NULL,
	Rank DECIMAL(2,1) NULL CHECK (Rank >= 0.0 AND Rank <= 5.0)
);

-- Questions table
CREATE TABLE Questions (
	Id INT PRIMARY KEY IDENTITY(1,1),
	QuestionText VARCHAR(500) NOT NULL,
	Point INT NOT NULL
);

-- Answers table
CREATE TABLE Answers (
	Id INT PRIMARY KEY IDENTITY(1,1),
	AnswerText VARCHAR(300) NOT NULL,
	IsCorrect BIT NOT NULL,
	QuestionId INT NOT NULL,
	FOREIGN KEY (QuestionId) REFERENCES Questions(Id)
);

-- GameSession table
CREATE TABLE GameSession (
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserId INT NOT NULL,
	QuestionsCount INT NOT NULL,
	Score INT NOT NULL,
	SessionStart DATETIME NOT NULL,
	SessionEnd DATETIME NULL,
	FOREIGN KEY (UserId) REFERENCES [User](Id)
);
