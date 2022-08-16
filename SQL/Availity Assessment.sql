USE Availity;

--Question 7A
SELECT FirstName, LastName FROM AvaCustomer WHERE LastName LIKE 'S%'
ORDER BY FirstName DESC;

--Question 7B
SELECT ao.CustomerID, ISNULL(Sum(aol.Cost * aol.Quantity),0) AS TotalAmount FROM AvaOrderLine aol
FULL JOIN AvaOrder ao ON aol.OrderID = ao.OrderID
WHERE AO.OrderDate > DATEADD(M, -6, GETDATE())
GROUP BY ao.CustomerID; 

--SELECT * FROM AvaOrderLine aol
--INNER JOIN AvaOrder ao ON aol.OrderID = ao.OrderID
--WHERE AO.OrderDate > DATEADD(M, -6, GETDATE());

--Question 7C
SELECT ao.CustomerID, ISNULL(Sum(aol.Cost * aol.Quantity),0) AS TotalAmount FROM AvaOrderLine aol
FULL JOIN AvaOrder ao ON aol.OrderID = ao.OrderID
WHERE AO.OrderDate > DATEADD(M, -6, GETDATE()) 
GROUP BY ao.CustomerID
HAVING Sum(aol.Cost * aol.Quantity) > 100 AND Sum(aol.Cost * aol.Quantity) <= 500