SELECT ename, pname, title
 FROM emp, proj, workson WHERE emp.eno = workson.eno and proj.pno = workson.pno 