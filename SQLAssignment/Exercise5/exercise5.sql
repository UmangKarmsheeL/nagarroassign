/*
CREATE PROCEDURE dbo.GetPeopleByFirstName
    @FirstNameFilter NVARCHAR(50) = NULL
AS
BEGIN
    SELECT FirstName, MiddleName, LastName
    FROM Person.Person
    WHERE (@FirstNameFilter IS NULL OR FirstName LIKE @FirstNameFilter + '%')
END
*/


EXEC dbo.GetPeopleByFirstName 'A'