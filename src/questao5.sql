SELECT 
f.Id,
f.Nome,
f.Salario,
f.DeptID
d.Id,
d.Nome
from Funcionarios f
inner join Departamento d
on (f.DeptID = d.Id)
WHERE Salario IN (SELECT MAX(Salario) FROM Funcionarios group by DeptID)