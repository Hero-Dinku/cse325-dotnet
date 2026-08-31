// Module 4: Interactively debug .NET apps with the VS Code debugger
// Demonstrates a small program with a bug, fixed using breakpoints/stepping

Console.WriteLine("=== Debugging Demo ===");
Console.WriteLine();

// Calculate the average of a list of test scores
List<int> scores = new List<int> { 85, 92, 78, 90, 88 };

int total = 0;
foreach (int score in scores)
{
    total += score;
}

// Bug (originally): dividing by wrong count, fixed after stepping through with debugger
double average = (double)total / scores.Count;

Console.WriteLine($"Scores: {string.Join(", ", scores)}");
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Average: {average:F2}");

// Set a breakpoint on the line below in VS Code (click left margin, or press F9)
// then press F5 to start debugging and step through with F10/F11
int highest = scores.Max();
int lowest = scores.Min();
Console.WriteLine($"Highest: {highest}, Lowest: {lowest}");
