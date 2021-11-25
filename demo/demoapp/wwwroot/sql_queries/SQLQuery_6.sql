INSERT INTO Products (ProductName, Price, PictureData) 
	SELECT 'TOKAI LC-107S', 399.00, 
	* FROM OPENROWSET(BULK N'C:\users\zenid\desktop\oppiminen\training\demo\demoapp\wwwroot\img\guitars\TOKAI LC-107S.jpg', SINGLE_BLOB) image;
