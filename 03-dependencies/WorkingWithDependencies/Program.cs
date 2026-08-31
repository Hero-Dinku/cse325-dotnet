// Module 3: Create a new .NET project and work with dependencies
// Demonstrates adding and using a NuGet package (Humanizer.Core)

using Humanizer;

Console.WriteLine("=== Working with Dependencies (Humanizer) ===");
Console.WriteLine();

int number = 1000;
Console.WriteLine($"{number} humanized: {number.ToWords()}");

TimeSpan timeSpan = TimeSpan.FromDays(2);
Console.WriteLine($"TimeSpan humanized: {timeSpan.Humanize()}");

DateTime pastDate = DateTime.Now.AddDays(-3);
Console.WriteLine($"Past date humanized: {pastDate.Humanize()}");

string pascalCaseString = "ThisIsAPascalCaseString";
Console.WriteLine($"Pascal case humanized: {pascalCaseString.Humanize()}");

Console.WriteLine($"Pluralized: {"car".Pluralize()}");
Console.WriteLine($"Singularized: {"cars".Singularize()}");
