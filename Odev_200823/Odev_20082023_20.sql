SELECT FullName, LEN(FullName) - LEN(REPLACE(FullName, 'n', '')) AS LetterCount FROM EmployeeDetails WHERE FullName LIKE '%n%'