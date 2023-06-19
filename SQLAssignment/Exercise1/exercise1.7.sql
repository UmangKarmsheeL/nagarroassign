SELECT FirstName, LastName, ROW_NUMBER() OVER (ORDER BY FirstName) AS RowNumber
FROM Person.Person
WHERE FirstName LIKE '%ss%'


