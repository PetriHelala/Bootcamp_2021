CREATE PROCEDURE sp_Product_Add
@ProductName NVARCHAR(100),
@Price MONEY,
@PictureData VARBINARY(MAX)
AS
BEGIN
INSERT INTO Products(ProductName,Price,PictureData)
VALUES(@ProductName,@Price,@PictureData)
END