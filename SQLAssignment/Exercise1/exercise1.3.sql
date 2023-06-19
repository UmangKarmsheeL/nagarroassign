SELECT Person.Person.FirstName, Person.Person.LastName, HumanResources.Employee.JobTitle
FROM Person.Person 
INNER JOIN HumanResources.Employee 
ON Person.Person.BusinessEntityID = HumanResources.Employee.BusinessEntityID
WHERE JobTitle IN ('Design Engineer', 'Tool Designer', 'Marketing Assistant')