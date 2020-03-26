--Problem 01. Employee address
SELECT TOP 5
	   e.EmployeeID,
	   e.JobTitle,
	   a.AddressID,
	   a.AddressText
  FROM Employees AS e
  JOIN Addresses AS a
    ON a.AddressID = e.AddressID
ORDER BY e.AddressID
GO

--Problem 02.Addresses with Towns
SELECT TOP 50
		   e.FirstName,
		   e.LastName,
		   t.Name AS [Town],
		   a.AddressText 
	  FROM Employees AS e
      JOIN Addresses AS a
		ON a.AddressID = e.AddressID
	  JOIN Towns AS t
		ON t.TownID = a.TownID
  ORDER BY e.FirstName, e.LastName
GO

--Problem 03. Sales Employee
  SELECT e.EmployeeID,
 	     e.FirstName,
 	     e.LastName,
		 d.Name AS [DepartmentName]
    FROM Employees AS e
    JOIN Departments AS d
 	  ON d.DepartmentID = e.DepartmentID
   WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID
GO

--Problem 04. Employee Departments
SELECT TOP 5
		   e.EmployeeID,
 	       e.FirstName,
		   e.Salary,
		   d.Name AS [DepartmentName]
      FROM Employees AS e
      JOIN Departments AS d
 	    ON d.DepartmentID = e.DepartmentID
	 WHERE e.Salary > 15000
  ORDER BY e.DepartmentID
GO

--Problem 05. Employees Without Project
  SELECT TOP 3
			 e.EmployeeID,
			 e.FirstName
		FROM Employees AS e
	   WHERE e.EmployeeID NOT IN (SELECT EmployeeID FROM EmployeesProjects)
	ORDER BY e.EmployeeID
GO
--Another Way
     SELECT TOP 3
			    e.EmployeeID,
			    e.FirstName
		   FROM Employees AS e
LEFT OUTER JOIN EmployeesProjects AS ep
			 ON ep.EmployeeID = e.EmployeeID
		  WHERE ep.ProjectID IS NULL
	   ORDER BY e.EmployeeID
GO

--Problem 06. Employees Hired After
  SELECT e.FirstName,
  	   e.LastName,
  	   e.HireDate,
  	   d.Name AS [DeptName]
    FROM Employees AS e
    JOIN Departments AS d
      ON d.DepartmentID = e.DepartmentID
   WHERE e.HireDate > '01/01/1999' AND d.Name IN ('Sales', 'Finance')
ORDER BY e.HireDate
GO

--Problem 07. Employees With Project
SELECT TOP 5 
 		   e.EmployeeID,
   	       e.FirstName,
   		   p.Name AS [ProjectName]
      FROM Employees AS e
      JOIN EmployeesProjects AS ep
        ON ep.EmployeeID = e.EmployeeID
      JOIN Projects AS p
   	    ON p.ProjectID = ep.ProjectID
     WHERE p.StartDate > '08/13/2002' AND p.EndDate IS NULL
  ORDER BY e.EmployeeID
GO

--Problem 08. Employee 24
SELECT e.EmployeeID,
	   e.FirstName,
  CASE
	   WHEN p.StartDate > '2005' THEN NULL
	   ELSE p.Name 
   END AS [ProjectName]
  FROM Employees AS e
  JOIN EmployeesProjects AS ep
	ON ep.EmployeeID = e.EmployeeID
  JOIN Projects AS p
	ON p.ProjectID = ep.ProjectID
 WHERE e.EmployeeID = 24
GO

--Problem 09. Employee Manager
  SELECT e.EmployeeID,
   	     e.FirstName,
  	     e.ManagerID,
	     m.FirstName AS [ManagerName]
    FROM Employees AS e
    JOIN Employees AS m
      ON m.EmployeeID = e.ManagerID
   WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID
GO

--Problem 10. Employee Summary
SELECT TOP 50
		 e.EmployeeID,
  	     e.FirstName + ' ' + e.LastName AS [EmployeeName],
		 m.FirstName + ' ' + m.LastName AS [ManagerName],
		 d.Name AS [DepartmentName]
    FROM Employees AS e
    JOIN Employees AS m
  	  ON m.EmployeeID = e.ManagerID
    JOIN Departments AS d
  	  ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID
GO

--Problem 11. Min Average Salary
SELECT MIN(a.[AverageSalary]) AS [MinAverageSalary] FROM
(
	  SELECT AVG(Salary) AS [AverageSalary] 
	    FROM Employees AS e
	GROUP BY e.DepartmentID
) AS a
GO

--Problem 12. Highest Peaks in Bulgaria
  SELECT c.CountryCode,
  	     m.MountainRange,
  	     p.PeakName,
  	     p.Elevation 
    FROM Countries AS c
    JOIN MountainsCountries AS mc
  	  ON mc.CountryCode = c.CountryCode
    JOIN Mountains AS m
  	  ON m.Id = mc.MountainId
    JOIN Peaks AS p
  	  ON p.MountainId = m.Id
   WHERE c.CountryName = 'Bulgaria' AND p.Elevation > 2835
ORDER BY p.Elevation DESC
GO

--Problem 13. Count Mountain Ranges
  SELECT c.CountryCode,
  	     COUNT(mc.MountainId) AS [MountainRanges]
    FROM Countries AS c
    JOIN MountainsCountries AS mc
  	  ON mc.CountryCode = c.CountryCode
   WHERE c.CountryName IN ('Bulgaria', 'Russia', 'United States')
GROUP BY c.CountryCode
GO

--Problem 14. Countries with Rivers
SELECT TOP 5
    	   c.CountryName,
    	   r.RiverName 
      FROM Countries AS c
      JOIN Continents AS co
    	ON co.ContinentCode = c.ContinentCode
      LEFT OUTER JOIN CountriesRivers AS cr
    	ON cr.CountryCode = c.CountryCode
      LEFT OUTER JOIN Rivers AS r
    	ON r.Id = cr.RiverId
     WHERE co.ContinentName = 'Africa'
  ORDER BY c.CountryName
GO

/*--Problem 15. Continents and Currencies
SELECT *
  FROM 
(SELECT c.CurrencyCode,
	   --c.CountryName
	    COUNT(c.CountryName) AS [CountCountries]
  FROM Countries AS c
GROUP BY c.CurrencyCode 
HAVING COUNT(c.CountryName) > 1) AS r
 JOIN Countries AS c
   ON c.CurrencyCode = r.CurrencyCode*/


--Problem 16. Countries without any Mountains
SELECT COUNT(c.CountryCode) AS [CountryCode]
  FROM Countries AS c
  LEFT OUTER JOIN MountainsCountries AS mc
	ON mc.CountryCode = c.CountryCode
 WHERE mc.MountainId IS NULL
GO

--Problem 17. Highest Peak and Longest River by Country
SELECT TOP 5
		   c.CountryName,
		   MAX(p.Elevation) AS [HighestPeakElevation],
		   MAX(r.Length) AS [LongestRiverLength]
      FROM Countries AS c
 LEFT JOIN MountainsCountries AS mc
		ON mc.CountryCode = c.CountryCode
 LEFT JOIN Peaks AS p
		ON p.MountainId = mc.MountainId
 LEFT JOIN CountriesRivers AS cr
		ON cr.CountryCode = c.CountryCode
 LEFT JOIN Rivers AS r
		ON r.Id = cr.RiverId
  GROUP BY c.CountryName
  ORDER BY HighestPeakElevation DESC, 
		   LongestRiverLength DESC,
		   c.CountryName
GO

--
  