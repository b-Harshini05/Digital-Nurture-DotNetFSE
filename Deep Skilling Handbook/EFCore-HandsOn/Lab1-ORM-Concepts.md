# Lab 1 - Understanding ORM

## What is ORM?

Object Relational Mapping (ORM) is a technique that maps C# classes to database tables.

Example:

- Category class → Categories table
- Product class → Products table

Each object becomes a row in the database.

## Benefits

- Reduces SQL code
- Faster development
- Easy maintenance
- Object-oriented programming support

## EF Core vs EF Framework

| EF Core | EF Framework |
|----------|--------------|
| Cross-platform | Windows only |
| Lightweight | Larger framework |
| High performance | Mature framework |
| Supports LINQ | Supports LINQ |
| Async operations | Async operations |

## EF Core 8 Features

- JSON column mapping
- Compiled models
- Better performance
- Interceptors
- Improved bulk operations

## Create Console App

```bash
dotnet new console -n RetailInventory
cd RetailInventory
```

## Install Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design
```