CREATE TABLE TestTable (
	ProductID INT IDENTITY PRIMARY KEY NOT NULL
	, product_name nvarchar(100)
	, picFileName NVARCHAR (100)
	, PictureData VARBINARY (MAX)
	)
GO