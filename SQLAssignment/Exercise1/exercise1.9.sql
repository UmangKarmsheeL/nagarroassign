DECLARE @id INT
SELECT @id =BusinessEntityID
FROM Person.Person
WHERE FirstName='Ruth' and LastName='Ellerbrock' and PersonType='EM'
EXECUTE dbo.uspGetEmployeeManagers @BusinessEntityID = @id