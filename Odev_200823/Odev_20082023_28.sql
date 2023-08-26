SELECT *, X.Salary      
FROM EmployeeDetails Y
LEFT JOIN EmployeeSalary X ON Y.EmpID = X.EmpID;