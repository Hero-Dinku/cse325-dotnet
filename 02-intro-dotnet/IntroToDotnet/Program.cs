// Module 2: Introduction to .NET
// Demonstrates basic .NET runtime concepts and built-in framework methods

Console.WriteLine("=== Introduction to .NET ===");
Console.WriteLine();

Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine($"Operating System: {Environment.OSVersion}");
Console.WriteLine($"Machine Name: {Environment.MachineName}");
Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");

double value = 7.8934;
Console.WriteLine();
Console.WriteLine($"Original value: {value}");
Console.WriteLine($"Rounded (2 decimal places): {Math.Round(value, 2)}");
Console.WriteLine($"Rounded (0 decimal places): {Math.Round(value)}");
Console.WriteLine($"Ceiling: {Math.Ceiling(value)}");
Console.WriteLine($"Floor: {Math.Floor(value)}");
Console.WriteLine($"Square Root of 144: {Math.Sqrt(144)}");
Console.WriteLine($"Power (2^8): {Math.Pow(2, 8)}");

Console.WriteLine();
Console.WriteLine($"Current Date/Time: {DateTime.Now}");
Console.WriteLine($"UTC Date/Time: {DateTime.UtcNow}");
