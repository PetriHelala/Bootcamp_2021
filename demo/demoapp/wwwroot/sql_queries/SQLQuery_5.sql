CREATE TABLE Products (
	ProductID INT IDENTITY PRIMARY KEY NOT NULL,
		product_name NVARCHAR(100),
		price MONEY,
		picturedata VARBINARY(MAX)
)