// Module 5: Work with files and directories
// Plus: Sales Summary Report function (Part 2 of assignment)

using System.Text;

string salesDataFolder = Path.Combine(Directory.GetCurrentDirectory(), "SalesData");

Console.WriteLine("=== Work with Files and Directories ===");
Console.WriteLine();

// List all files in the directory
Console.WriteLine($"Files in {salesDataFolder}:");
string[] files = Directory.GetFiles(salesDataFolder, "*.txt");
foreach (string file in files)
{
    Console.WriteLine($"  - {Path.GetFileName(file)}");
}

// Read and display content of each file
Console.WriteLine();
Console.WriteLine("File contents:");
foreach (string file in files)
{
    Console.WriteLine($"--- {Path.GetFileName(file)} ---");
    string content = File.ReadAllText(file);
    Console.WriteLine(content);
}

// Generate and display the sales summary report
Console.WriteLine();
string report = GenerateSalesSummaryReport(salesDataFolder);
Console.WriteLine(report);

// Write the report to a file
string reportPath = Path.Combine(salesDataFolder, "sales_summary.txt");
File.WriteAllText(reportPath, report);
Console.WriteLine($"Report written to: {reportPath}");

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
