/*
CREATE TRIGGER tr_Product_ListPrice
ON Production.Product
AFTER UPDATE
AS
BEGIN
    IF UPDATE(ListPrice)
    BEGIN
        DECLARE @MaxPercentChange DECIMAL(10,2) = 1.15
        IF EXISTS (
            SELECT *
            FROM inserted i
            JOIN deleted d ON i.ProductID = d.ProductID
            WHERE i.ListPrice > d.ListPrice * @MaxPercentChange
        )
        BEGIN
            RAISERROR('The list price cannot be raised more than 15%% in a single change.', 16, 1)
            ROLLBACK TRANSACTION
            RETURN
        END
    END
END
*/