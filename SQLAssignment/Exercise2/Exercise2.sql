/*Using JOIN*/
SELECT *
FROM Sales.Customer c
LEFT JOIN Sales.SalesOrderHeader o ON c.CustomerID = o.CustomerID
WHERE o.SalesOrderID IS NULL;

/*Using a SubQuery*/


SELECT *
FROM Sales.Customer
WHERE CustomerID NOT IN (
  SELECT DISTINCT CustomerID FROM Sales.SalesOrderHeader
);

/*Using a CTE*/

WITH Orders AS (
  SELECT DISTINCT CustomerID FROM Sales.SalesOrderHeader
)
SELECT *
FROM Sales.Customer c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.CustomerID IS NULL;

/*Using an EXIST statement*/

SELECT *
FROM Sales.Customer c
WHERE NOT EXISTS (
  SELECT 1 FROM Sales.SalesOrderHeader o WHERE c.CustomerID = o.CustomerID
);