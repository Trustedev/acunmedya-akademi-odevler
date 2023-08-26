SELECT EmpID
FROM EmployeeDetails
WHERE EmployeeDetails.EmpID IN (SELECT EmpID FROM EmployeeSalary);