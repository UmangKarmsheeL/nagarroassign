SELECT  Name, Color,Weight
FROM Production.Product 
WHERE Weight = (SELECT MAX(Weight) FROM Production.Product)