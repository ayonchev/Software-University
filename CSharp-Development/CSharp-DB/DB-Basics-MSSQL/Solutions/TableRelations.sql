--01. One-To-One Relationship
CREATE TABLE Passports(
	PassportID INT PRIMARY KEY,
	PassportNumber NVARCHAR(50) NOT NULL UNIQUE
)
GO

CREATE TABLE Persons(
	PersonID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	Salary DECIMAL(15, 2),
	PassportID INT UNIQUE,
	CONSTRAINT FK_Persons_Passports FOREIGN KEY(PassportID) REFERENCES Passports(PassportID)
)
GO

INSERT INTO Passports VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')
GO

INSERT INTO Persons VALUES 
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101)
GO

--02. One-To-Many Relationship
CREATE TABLE Manufacturers(
	ManufacturerID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	EstablishedOn DATETIME2 NOT NULL
)
GO

CREATE TABLE Models(
	ModelID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	ManufacturerID INT,
	CONSTRAINT FK_Models_Manufacturers FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
)
GO

INSERT INTO Manufacturers VALUES
('BMW', '07/03/1916'),
('Tesla', '01/01/2003'),
('Lada', '01/05/1966')
GO

INSERT INTO Models VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)
GO

--03. Problem 3.	Many-To-Many Relationship
CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(50) NOT NULL	
)
GO

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL
)
GO

CREATE TABLE StudentsExams(
	StudentID INT NOT NULL,
	ExamID INT NOT NULL,
	CONSTRAINT PK_StudentsExams PRIMARY KEY(StudentID, ExamID),
	CONSTRAINT FK_StudentsExams_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
	CONSTRAINT FK_StudentsExams_Exams FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
)
GO

INSERT INTO Students VALUES
('Mila'), 
('Toni'), 
('Ron')
GO

INSERT INTO Exams VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')
GO

INSERT INTO StudentsExams VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)
GO

SELECT s.Name, e.Name FROM StudentsExams AS se
JOIN Students AS s ON s.StudentID = se.StudentID
JOIN Exams AS e ON e.ExamID = se.ExamID
GO

--04. Self-Referencing
CREATE TABLE Teachers(
	TeacherID INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	ManagerID INT,
	CONSTRAINT FK_Teachers_Teachers FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
)
GO

INSERT INTO Teachers VALUES
(101, 'John', NULL),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101),
(106, 'Greta', 101)
GO

--05. Online Store Database
CREATE TABLE Cities(
	CityID INT PRIMARY KEY,
	Name VARCHAR(50)
)
GO

CREATE TABLE Customers(
	CustomerID INT PRIMARY KEY, 
	Name VARCHAR(50),
	Birthday DATETIME2,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)
GO

CREATE TABLE Orders(
	OrderID INT PRIMARY KEY,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)	
)
GO

CREATE TABLE ItemTypes(
	ItemTypeID INT PRIMARY KEY,
	Name VARCHAR(50)
)
GO

CREATE TABLE Items(
	ItemID INT PRIMARY KEY,
	Name VARCHAR(50),
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)
GO

CREATE TABLE OrderItems(
	OrderID INT NOT NULL,
	ItemID INT NOT NULL,
	CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID, ItemID),
	CONSTRAINT FK_OrderItems_Orders FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
	CONSTRAINT FK_OrderItems_Items FOREIGN KEY(ItemID) REFERENCES Items(ItemID)
)
GO

--06. University Database
CREATE DATABASE University
GO

CREATE TABLE Majors(
	MajorID INT PRIMARY KEY,
	Name VARCHAR(50)
)
GO

CREATE TABLE Subjects(
	SubjectID INT PRIMARY KEY,
	SubjectName VARCHAR(50)
)
GO

CREATE TABLE Students(
	StudentID INT PRIMARY KEY,
	StudentNumber INT NOT NULL,
	StudentName VARCHAR(50) NOT NULL,
	MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)
GO

CREATE TABLE Agenda(
	StudentID INT NOT NULL,
	SubjectID INT NOT NULL,
	CONSTRAINT PK_Agenda PRIMARY KEY(StudentID, SubjectID),
	CONSTRAINT FK_Agenda_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
	CONSTRAINT FK_Agenda_Subjects FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
)
GO

CREATE TABLE Payments(
	PaymentID INT PRIMARY KEY,
	PaymentDate DATETIME2,
	PaymentAmount DECIMAL(15, 2),
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)
GO

--09. Peaks In Rila
SELECT m.MountainRange, p.PeakName, p.Elevation FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC
GO
