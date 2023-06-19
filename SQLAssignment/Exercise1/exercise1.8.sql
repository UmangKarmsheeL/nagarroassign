SELECT CommissionPct AS SalesPersonID,CommissionPct, 'Commission Band'= CASE
WHEN CommissionPct = 0 THEN 'band 0'
WHEN CommissionPct > 0 and CommissionPct <= 0.01 THEN 'band 1'
WHEN CommissionPct > 0.01 and CommissionPct <= 0.015 THEN 'band 2'
WHEN CommissionPct > 0.015 THEN 'band 3'END
FROM Sales.SalesPerson
ORDER BY CommissionPct