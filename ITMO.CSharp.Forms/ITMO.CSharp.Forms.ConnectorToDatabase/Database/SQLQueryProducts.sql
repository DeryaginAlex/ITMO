/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[ProductName]
      ,[Manufacturer]
      ,[ProductCount]
      ,[Price]
  FROM [Reports].[dbo].[Products]

  drop TABLE Products

  CREATE TABLE Products
(
    Id INT IDENTITY PRIMARY KEY,
    ProductName NVARCHAR(30) NOT NULL,
    Manufacturer NVARCHAR(20) NOT NULL,
    ProductCount INT DEFAULT 0,
    Price MONEY NOT NULL
)

	
INSERT Products VALUES ('iPhone 7', 'Apple', 5, 52000)