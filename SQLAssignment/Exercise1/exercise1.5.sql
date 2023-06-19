SELECT Description, ISNULL(CAST(MaxQty AS decimal(10,2)), 0.00) AS MaxQty
FROM Sales.SpecialOffer