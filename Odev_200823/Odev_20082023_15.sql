SELECT EmpID
FROM EmployeeDetails
WHERE EmployeeDetails.EmpID NOT IN (SELECT EmpID FROM EmployeeSalary);