SELECT
LEFT([FirstName], 1) AS [FirstLetter]
FROM WizzardDeposits
GROUP BY LEFT([FirstName], 1), DepositGroup
HAVING DepositGroup = 'Troll Chest'
ORDER BY [FirstLetter]
GO


--Problem 11. Average Interest
SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired ASC
GO

USE SoftUni
SELECT DepartmentID, SUM(Salary) AS [TotalSalary] FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID
GO

SELECT DepartmentID, MIN(Salary) AS [MinimumSalary] FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND HireDate > '01/01/2000'
GROUP BY DepartmentID
GO

SELECT DepartmentID, MAX(Salary) AS [MaxSalary] FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000
GO

SELECT COUNT(Salary) FROM Employees
WHERE ManagerID IS NULL
GO



