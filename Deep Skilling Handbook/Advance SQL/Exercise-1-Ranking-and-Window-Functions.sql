-- Create Products Table

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert Sample Data

INSERT INTO Products VALUES
(1,'Laptop','Electronics',80000),
(2,'Mobile','Electronics',50000),
(3,'Tablet','Electronics',50000),
(4,'TV','Electronics',60000),
(5,'Shoes','Fashion',3000),
(6,'Jacket','Fashion',5000),
(7,'Watch','Fashion',5000),
(8,'Bag','Fashion',2500);

----------------------------------------------------
-- ROW_NUMBER()
----------------------------------------------------

SELECT *
FROM
(
    SELECT *,
           ROW_NUMBER() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS RowNum
    FROM Products
) AS Result
WHERE RowNum <= 3;

----------------------------------------------------
-- RANK()
----------------------------------------------------

SELECT *,
       RANK() OVER
       (
           PARTITION BY Category
           ORDER BY Price DESC
       ) AS RankNo
FROM Products;

----------------------------------------------------
-- DENSE_RANK()
----------------------------------------------------

SELECT *,
       DENSE_RANK() OVER
       (
           PARTITION BY Category
           ORDER BY Price DESC
       ) AS DenseRankNo
FROM Products;