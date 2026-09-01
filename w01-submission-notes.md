# W01 Assignment: .NET Applications — Submission Notes

## Part 1: Web API with ASP.NET Core Controllers (Module 6)

### Pizzas List (existing content + additional record)

The base `Pizzas` list included two pizzas from the module (Cheese, Pepperoni). I added a third record (Hawaiian) to satisfy the "at least one additional record" requirement:

```json
[
  { "id": 1, "name": "Cheese", "isGlutenFree": false },
  { "id": 2, "name": "Pepperoni", "isGlutenFree": false },
  { "id": 3, "name": "Hawaiian", "isGlutenFree": true }
]
```

### CRUD Operation Tests

**GET all pizzas** — `GET /Pizzas`
- Status Code: `200 OK`
- Response: `[{"id":1,"name":"Cheese","isGlutenFree":false},{"id":2,"name":"Pepperoni","isGlutenFree":false},{"id":3,"name":"Hawaiian","isGlutenFree":true}]`

**GET pizza by id** — `GET /Pizzas/2`
- Status Code: `200 OK`
- Response: `{"id":2,"name":"Pepperoni","isGlutenFree":false}`

**POST new pizza** — `POST /Pizzas`
- Request Body: `{"name":"Veggie","isGlutenFree":false}`
- Status Code: `201 Created`
- Response: `{"id":4,"name":"Veggie","isGlutenFree":false}`

**PUT update pizza** — `PUT /Pizzas/1`
- Request Body: `{"name":"Cheese Deluxe","isGlutenFree":true}`
- Status Code: `204 No Content`

**DELETE pizza** — `DELETE /Pizzas/3`
- Status Code: `204 No Content`

**Final GET (verifying changes)** — `GET /Pizzas`
- Status Code: `200 OK`
- Response: `[{"id":1,"name":"Cheese Deluxe","isGlutenFree":true},{"id":2,"name":"Pepperoni","isGlutenFree":false},{"id":4,"name":"Veggie","isGlutenFree":false}]`

---

## Part 2: Sales Summary Report Function (Module 5)

Added to `05-files-directories/FilesAndDirectories/Program.cs`, using `StringBuilder` to build a formatted report of total sales and per-file breakdown.

```csharp
// Generates a sales summary report showing total sales across all files
// and a per-file breakdown, using StringBuilder
static string GenerateSalesSummaryReport(string folderPath)
{
    StringBuilder sb = new StringBuilder();
    decimal grandTotal = 0;
    var fileTotals = new Dictionary<string, decimal>();

    string[] salesFiles = Directory.GetFiles(folderPath, "*.txt");

    foreach (string file in salesFiles)
    {
        string fileName = Path.GetFileName(file);
        if (fileName == "sales_summary.txt") continue;

        decimal fileTotal = 0;
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (decimal.TryParse(line, out decimal amount))
            {
                fileTotal += amount;
            }
        }

        fileTotals[fileName] = fileTotal;
        grandTotal += fileTotal;
    }

    sb.AppendLine("Sales Summary");
    sb.AppendLine("----------------------------");
    sb.AppendLine($" Total Sales: {grandTotal:C}");
    sb.AppendLine();
    sb.AppendLine(" Details:");
    foreach (var entry in fileTotals)
    {
        sb.AppendLine($"  {entry.Key}: {entry.Value:C}");
    }

    return sb.ToString();
}
```

### Sample Output

```
Sales Summary
----------------------------
 Total Sales: $8,282.25

 Details:
  february.txt: $2,480.75
  january.txt: $2,555.75
  march.txt: $3,245.75
```

---

## Repository

All source code for Modules 1–6 is available at:
https://github.com/Hero-Dinku/cse325-dotnet
