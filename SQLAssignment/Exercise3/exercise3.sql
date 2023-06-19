

SELECT TOP 5 * FROM Sales.SalesOrderHeader
WHERE AccountNumber in (SELECT AccountNumber 
                        FROM Sales.SalesOrderHeader
                        GROUP BY AccountNumber 
                        HAVING SUM(TotalDue)>70000)
ORDER BY OrderDate DESC