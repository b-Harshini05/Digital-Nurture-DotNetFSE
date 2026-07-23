-- Create Departments Table

CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- Create Employees Table

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID)
);

---------------------------------------------------
-- Sample Data
---------------------------------------------------

INSERT INTO Departments VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');

INSERT INTO Employees
(FirstName,LastName,DepartmentID,Salary,JoinDate)
VALUES
('John','Doe',1,5000,'2020-01-15'),
('Jane','Smith',2,6000,'2019-03-22'),
('Michael','Johnson',3,7000,'2018-07-30'),
('Emily','Davis',4,5500,'2021-11-05');

---------------------------------------------------
-- Stored Procedure
---------------------------------------------------

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID=@DepartmentID;
END;

---------------------------------------------------
-- Execute
---------------------------------------------------

EXEC sp_GetEmployeesByDepartment 3;

---------------------------------------------------
-- Insert Employee Stored Procedure
---------------------------------------------------

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;

---------------------------------------------------
-- Execute
---------------------------------------------------

EXEC sp_InsertEmployee
'David',
'Brown',
3,
6500,
'2024-05-20';