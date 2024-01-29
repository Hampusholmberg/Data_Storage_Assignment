DROP TABLE Products
DROP TABLE Brands
DROP TABLE SubCategories
DROP TABLE Categories

CREATE TABLE Categories (
  Id INT PRIMARY KEY,
  CategoryName NVARCHAR(100) NOT NULL
);

CREATE TABLE SubCategories (
  Id INT PRIMARY KEY,
  SubCategoryName NVARCHAR(100) NOT NULL,
  CategoryId INT REFERENCES Categories(Id) NOT NULL
);

CREATE TABLE Brands (
  Id INT PRIMARY KEY,
  BrandName NVARCHAR(100) NOT NULL
);

CREATE TABLE Products (
  ArticleNumber INT PRIMARY KEY,
  Title NVARCHAR(100) NOT NULL,
  Description NVARCHAR(MAX) NOT NULL,
  Price MONEY NOT NULL,
  CategoryId INT REFERENCES Categories(Id) NOT NULL,
  SubCategoryId INT REFERENCES SubCategories(Id) NOT NULL,
  BrandId INT REFERENCES Brands(Id) NOT NULL
);