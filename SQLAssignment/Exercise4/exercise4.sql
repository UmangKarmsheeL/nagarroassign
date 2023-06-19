/*CREATE FUNCTION dbo.ConvertCurrency(
    @SalesOrderID INT,
    @CurrencyCode NVARCHAR(3),
    @Date DATE
)
RETURNS TABLE
AS
RETURN (
    SELECT  sod.ProductID, sod.UnitPrice, sod.UnitPrice * cr.AverageRate AS ConvertedUnitPrice
    FROM Sales.SalesOrderDetail sod
    JOIN Sales.SalesOrderHeader soh ON sod.SalesOrderID = soh.SalesOrderID
    JOIN Sales.CurrencyRate cr ON soh.CurrencyRateID = cr.CurrencyRateID
    JOIN Sales.Currency c ON cr.ToCurrencyCode = c.CurrencyCode
    WHERE sod.SalesOrderID = @SalesOrderID
    AND c.CurrencyCode = @CurrencyCode
    AND cr.EndOfDayRate = CONVERT(DATETIME, @Date, 101) -- Convert date to datetime
)*/


SELECT * 
FROM dbo.ConvertCurrency(43659, 'EUR', '2023-03-31')

