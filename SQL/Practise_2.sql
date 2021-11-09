-- Practise 2.1
SELECT COUNT(CustomerId)
FROM Customers

-- Practise 2.2
-- Cannot use listing function simultaneously with aggregate(sum, avg, multiplication) function
SELECT SUM(UnitPrice*UnitsInStock) AS 'Value of Stock'
FROM Products

-- Practise 2.3, without discount
SELECT SUM(Discount/Quantity*UnitPrice) AS 'TofuSoldIn$'
FROM [Order Details]
WHERE ProductID = (
    SELECT ProductID
    FROM Products
    WHERE ProductName = 'Tofu')

-- Practise 2.3, with discount
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'TofuSoldIn$'
FROM [Order Details]
WHERE ProductID = 14

-- Practise 2.3, with discount and "Longlife Tofu", as subquery
SELECT ProductID, ProductName
FROM Products
WHERE ProductName LIKE '%Tofu%'

-- Practise 2.3, with discount, 'Tofu' and 'Longlife tofu' given specifically
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'TofuSoldIn$'
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

-- Practise 2.3, with discount and "Longlife Tofu", as subquery, searching 'something like Tofu' from Products
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'TofuSoldIn$'
FROM [Order Details]
WHERE ProductID IN (
    SELECT ProductID
    FROM Products
    WHERE ProductName LIKE '%Tofu%')

