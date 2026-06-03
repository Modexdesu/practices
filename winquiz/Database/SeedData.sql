-- amis umetesobac ais davawerine radgam umetesad prosta xelit iyo saweri

-- Insert Users
INSERT INTO [User] (Name, RegistrationDate, Rank) VALUES 
('Alice Johnson', '2024-01-15', 4.5),
('Bob Smith', '2024-01-20', 3.2),
('Charlie Brown', '2024-02-01', 5.0),
('Diana Prince', '2024-02-10', 2.8),
('Eve Wilson', '2024-02-15', 4.0),
('Frank Miller', '2024-02-20', 1.5),
('Grace Lee', '2024-03-01', 3.7),
('Henry Davis', '2024-03-05', 4.2);

-- Insert Questions
INSERT INTO Questions (QuestionText, Point) VALUES 
('What is the capital of France?', 1),
('Which planet is known as the Red Planet?', 1),
('Who wrote Romeo and Juliet?', 2),
('What is the largest ocean on Earth?', 1),
('In what year did World War II end?', 2),
('What is the chemical symbol for Gold?', 1),
('Who painted the Mona Lisa?', 2),
('What is the square root of 144?', 1),
('How many continents are there?', 1),
('What is the smallest prime number?', 1);

-- Insert Answers (QuestionId 1-10)
-- Question 1: What is the capital of France?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('Paris', 1, 1),
('London', 0, 1),
('Berlin', 0, 1),
('Madrid', 0, 1);

-- Question 2: Which planet is known as the Red Planet?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('Mars', 1, 2),
('Venus', 0, 2),
('Jupiter', 0, 2),
('Saturn', 0, 2);

-- Question 3: Who wrote Romeo and Juliet?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('William Shakespeare', 1, 3),
('Jane Austen', 0, 3),
('Charles Dickens', 0, 3),
('Mark Twain', 0, 3);

-- Question 4: What is the largest ocean on Earth?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('Pacific Ocean', 1, 4),
('Atlantic Ocean', 0, 4),
('Indian Ocean', 0, 4),
('Arctic Ocean', 0, 4);

-- Question 5: In what year did World War II end?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('1945', 1, 5),
('1944', 0, 5),
('1946', 0, 5),
('1943', 0, 5);

-- Question 6: What is the chemical symbol for Gold?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('Au', 1, 6),
('Ag', 0, 6),
('Gd', 0, 6),
('Gl', 0, 6);

-- Question 7: Who painted the Mona Lisa?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('Leonardo da Vinci', 1, 7),
('Michelangelo', 0, 7),
('Raphael', 0, 7),
('Donatello', 0, 7);

-- Question 8: What is the square root of 144?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('12', 1, 8),
('10', 0, 8),
('14', 0, 8),
('11', 0, 8);

-- Question 9: How many continents are there?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('7', 1, 9),
('6', 0, 9),
('8', 0, 9),
('5', 0, 9);

-- Question 10: What is the smallest prime number?
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId) VALUES 
('2', 1, 10),
('1', 0, 10),
('3', 0, 10),
('0', 0, 10);

-- Insert GameSessions
INSERT INTO GameSession (UserId, QuestionsCount, Score, SessionStart, SessionEnd) VALUES 
(1, 5, 4, '2024-03-10 10:00:00', '2024-03-10 10:15:00'),
(2, 10, 6, '2024-03-10 11:00:00', '2024-03-10 11:30:00'),
(1, 10, 9, '2024-03-10 14:00:00', '2024-03-10 14:35:00'),
(3, 5, 5, '2024-03-11 09:00:00', '2024-03-11 09:12:00'),
(4, 10, 3, '2024-03-11 10:00:00', NULL),
(5, 5, 25, '2024-03-11 11:00:00', '2024-03-11 11:18:00'),
(2, 5, 0, '2024-03-12 08:00:00', '2024-03-12 08:10:00'),
(6, 10, 5, '2024-03-12 09:00:00', '2024-03-12 09:40:00'),
(7, 5, 22, '2024-03-12 10:00:00', '2024-03-12 10:14:00'),
(3, 10, 28, '2024-03-13 11:00:00', '2024-03-13 11:45:00');
