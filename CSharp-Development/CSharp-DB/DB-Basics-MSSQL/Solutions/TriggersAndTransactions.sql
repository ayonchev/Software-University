--Problem 1. Create Table Logs
CREATE TABLE Logs(
	Id INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES Accounts,
	OldSum DECIMAL(15, 2) NOT NULL,
	NewSum DECIMAL(15, 2) NOT NULL
)
GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts AFTER UPDATE
AS
BEGIN
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT i.Id,
		   d.Balance, 
		   i.Balance 
	 FROM inserted AS i 
	 JOIN deleted AS d 
	   ON d.Id = i.Id
END
GO

--Problem 2. Create Table Emails
CREATE TABLE NotificationEmails(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT FOREIGN KEY REFERENCES Accounts,
	Subject NVARCHAR(255) NOT NULL,
	Body NVARCHAR(255) NOT NULL
)
GO

CREATE OR ALTER TRIGGER tr_LogsUpdate ON Logs AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails(Recipient, Subject, Body)
	SELECT i.AccountId,
		   'Balance change for account: ' + CONVERT(NVARCHAR(50), i.AccountId),
		   'On ' + CONVERT(NVARCHAR(50), GETDATE()) + ' your balance was changed from ' + CONVERT(NVARCHAR(50), i.OldSum) + ' to ' + CONVERT(NVARCHAR(50), i.OldSum) + '.'
	  FROM inserted AS i
END
GO

--Problem 3. Deposit Money
CREATE PROC usp_DepositMoney @AccountId INT, @MoneyAmount DECIMAL(18, 4)
AS
BEGIN
	BEGIN TRANSACTION
		IF(@MoneyAmount < 0)
		BEGIN
			ROLLBACK
			RETURN
		END

		UPDATE Accounts
		SET Balance = Balance + @MoneyAmount
		WHERE Id = @AccountId

		COMMIT
END
GO

--Problem 4. Withdraw Money
CREATE PROC usp_WithdrawMoney @AccountId INT, @MoneyAmount DECIMAL(18, 4)
AS
BEGIN
	BEGIN TRANSACTION
		IF(@MoneyAmount < 0)
		BEGIN
			ROLLBACK
			RETURN
		END

		UPDATE Accounts
		SET Balance = Balance - @MoneyAmount
		WHERE Id = @AccountId

		DECLARE @UpdatedAccountBalance DECIMAL(18, 4) = (SELECT Balance FROM Accounts WHERE Id = @AccountId)
		IF(@UpdatedAccountBalance < 0)
		BEGIN
			ROLLBACK
			RETURN
		END

		COMMIT
END
GO

--Problem 5. Money Transfer
CREATE PROC usp_TransferMoney @SenderId INT, @ReceiverId INT, @Amount DECIMAL(18, 4)
AS
BEGIN
	BEGIN TRANSACTION
		IF(@Amount < 0 OR 
		   (SELECT Balance FROM Accounts WHERE Id = @SenderId) - @Amount < 0)
		BEGIN
			ROLLBACK
			RETURN
		END

		UPDATE Accounts
		SET Balance = Balance - @Amount
		WHERE Id = @SenderId

		UPDATE Accounts
		SET Balance = Balance + @Amount
		WHERE Id = @ReceiverId

		COMMIT
END
GO

--Problem 6. Trigger


--Problem 8. Employees with Three Projects
CREATE PROC usp_AssignProject @emloyeeId INT, @projectID INT
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
		VALUES (@emloyeeId, @projectID)

		DECLARE @CountProjectsForEmployee INT = 
		(SELECT COUNT(ProjectId) AS [CountProjects] 
		FROM EmployeesProjects
		WHERE EmployeeID = @emloyeeId
		GROUP BY EmployeeID)

		IF(@CountProjectsForEmployee >= 4)
		BEGIN
			ROLLBACK
			RAISERROR('The employee has too many projects!', 16, 1)
			RETURN
		END

		COMMIT
END
GO

--Problem 9. Delete Employees
CREATE TABLE Deleted_Employees(
	EmployeeId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(50) NOT NULL,
	DepartmendId INT NOT NULL,
	Salary MONEY NOT NULL
)
GO

CREATE OR ALTER TRIGGER tr_DeleteEmployee ON Employees AFTER DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT d.FirstName,
		   d.LastName,
		   d.MiddleName,
		   d.JobTitle,
		   d.DepartmentID,
		   d.Salary
	  FROM deleted AS d
END
GO
