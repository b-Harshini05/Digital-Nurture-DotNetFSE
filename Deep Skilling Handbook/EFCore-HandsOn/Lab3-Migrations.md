# EF Core CLI Commands

## Install EF CLI

```bash
dotnet tool install --global dotnet-ef
```

## Create Migration

```bash
dotnet ef migrations add InitialCreate
```

## Apply Migration

```bash
dotnet ef database update
```

After executing the above commands, SQL Server will create

- Categories Table
- Products Table

Verify using SQL Server Management Studio (SSMS).