SELECT *
FROM EmployeeDetails
WHERE EmpID IN 
(SELECT EmpID from EmployeeSalary);