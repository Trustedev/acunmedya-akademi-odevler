SELECT CHARINDEX('A', FullName) AS LetterLocation
FROM EmployeeDetails
WHERE FullName LIKE '%A%';