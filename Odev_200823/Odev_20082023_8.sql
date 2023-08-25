SELECT * FROM EmployeeDetails INNER JOIN EmployeeSalary ON EmployeeDetails.EmpID = EmployeeSalary.EmpID WHERE NOT EmployeeSalary.Project = 'P1'
