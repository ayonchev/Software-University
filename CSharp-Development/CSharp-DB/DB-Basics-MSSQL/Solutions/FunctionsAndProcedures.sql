--Problem 1. Employees with Salary Above 35000
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT FirstName,
		   LastName
	  FROM Employees
	 WHERE Salary > 35000
END
GO

EXEC dbo.usp_GetEmployeesSalaryAbove35000
GO

--Problem 2. Employees with Salary Above Number
CREATE PROC usp_GetEmployeesSalaryAboveNumber(@SalaryLimit DECIMAL(18, 4))
AS
BEGIN
	SELECT FirstName,
		   LastName
	  FROM Employees
	 WHERE Salary >= @SalaryLimit
END
GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100
GO

--Problem 3. Town Names Starting With
CREATE PROC usp_GetTownsStartingWith(@StartingString VARCHAR(50))
AS
BEGIN
	DECLARE @StringLength INT = LEN(@StartingString);
	SELECT Name AS [Town]
	  FROM Towns
	 WHERE LEFT(Name, @StringLength) = @StartingString
END
GO

EXEC usp_GetTownsStartingWith 'b'
GO

--Problem 4. Employees from Town
CREATE PROC usp_GetEmployeesFromTown(@TownName VARCHAR(100))
AS
BEGIN
	SELECT e.FirstName,
		   e.LastName
	  FROM Employees AS e
	  JOIN Addresses AS a
		ON a.AddressID = e.AddressID
	  JOIN Towns AS t
		ON t.TownID = a.TownID
	 WHERE t.Name = @TownName
END
GO

EXEC usp_GetEmployeesFromTown 'Sofia'
GO

--Problem 5. Salary Level Function
CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(7)
AS
BEGIN
	/*DECLARE @SalaryLevel VARCHAR(7);

	IF(@salary < 30000)
	BEGIN
		SET @SalaryLevel = 'Low';
	END
	ELSE IF(@salary BETWEEN 30000 AND 50000)
	BEGIN
		SET @SalaryLevel = 'Average';
	END
	ELSE
	BEGIN
		SET @SalaryLevel = 'High';
	END*/

	DECLARE @SalaryLevel VARCHAR(7) = 
		CASE
		WHEN @salary < 30000 THEN 'Low'
		WHEN @salary BETWEEN 30000 AND 50000 THEN 'Average'
		ELSE 'High'
		END

	RETURN @SalaryLevel;
END
GO

SELECT Salary,
	   dbo.ufn_GetSalaryLevel(Salary)
  FROM Employees
GO

--Problem 6. Employees by Salary Level
CREATE PROC usp_EmployeesBySalaryLevel(@SalaryLevel VARCHAR(7))
AS
BEGIN
	SELECT FirstName,
		   LastName
	  FROM Employees
	 WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
END
GO

EXEC usp_EmployeesBySalaryLevel 'High'
GO

--Problem 7. Define Function
CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(100), @word VARCHAR(100))
RETURNS BIT
AS
BEGIN
	DECLARE @Index INT = 1;

	WHILE @Index <= LEN(@word)
	BEGIN
		DECLARE @CurrentCharacter CHAR = SUBSTRING(@word, @Index, 1);

		IF(CHARINDEX(@CurrentCharacter, @setOfLetters) = 0)
		BEGIN
			RETURN 0;
		END

		SET @Index = @Index + 1;
	END

	RETURN 1;
END
GO

SELECT dbo.ufn_IsWordComprised('bobr', 'Rob')
GO

--Problem 9. Find Full Name
CREATE PROC usp_GetHoldersFullName
AS
BEGIN
	SELECT FirstName + ' ' + LastName AS [Full Name]
	  FROM AccountHolders
END
GO

EXEC usp_GetHoldersFullName
GO

--Problem 10. People with Balance Higher Than
CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan(@BalanceLimit DECIMAL(15, 2))
AS
BEGIN
	SELECT ah.FirstName,
		   ah.LastName
	  FROM 
	  (
		  SELECT AccountHolderId,
		  	     SUM(Balance) AS [Balance]
		    FROM Accounts
		GROUP BY AccountHolderId
	  ) AS b
	  JOIN AccountHolders AS ah
		ON ah.Id = b.AccountHolderId
	 WHERE b.Balance > @BalanceLimit
  ORDER BY ah.LastName
END
GO

--Problem 11. Future Value Function
CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @yearlyInterestRate FLOAT, @numberOfYears INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @FutureValue DECIMAL(18, 4) = @sum * (POWER(1 + @yearlyInterestRate, @numberOfYears));
	RETURN @FutureValue;
END
GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.10, 5)
GO
