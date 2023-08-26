SELECT ES.Project, COUNT(ED.EmpID) AS CalisanSayisi
FROM EmployeeSalary ES INNER JOIN EmployeeDetails ED ON ES.EmpID = ED.EmpID
GROUP BY ES.Project
ORDER BY CalisanSayisi DESC;