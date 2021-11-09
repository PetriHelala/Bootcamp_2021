-- Day 9, Practise 1.1
SELECT * FROM Customers WHERE Country='Finland'

-- Practise 1.2
SELECT * FROM Orders WHERE CustomerId='QUEDE'

-- Practise 1.2, alternative implementation
SELECT * 
FROM ORDERS 
WHERE CustomerID = (
	SELECT CustomerID
	FROM Customers
	WHERE CompanyName = 'Que Delícia')

-- Practise 1.3
SELECT *
FROM EMPLOYEES
WHERE CITY ='London'