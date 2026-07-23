# Handson 4 - CRUD Operations

## HTTP Methods

GET

PUT

## PUT URL

/api/Employee/{id}

### Example JSON

```json
{
  "id": 1,
  "name": "Harshini",
  "salary": 70000,
  "permanent": true
}
```

Returns

- 200 OK
- 400 BadRequest (Invalid employee id)