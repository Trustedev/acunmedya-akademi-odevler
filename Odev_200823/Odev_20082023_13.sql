SELECT *
FROM EmployeeDetails
WHERE EmpID NOT IN 
(SELECT EmpID from EmployeeSalary);