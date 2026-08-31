// Module 1: Write your first C# code
// Demonstrates variables, string interpolation, math operators, and conditionals

// Variables and data types
string firstName = "Hero";
string lastName = "Dinku";
int age = 22;
double gpa = 3.85;
bool isEnrolled = true;

// String interpolation
Console.WriteLine($"Hello, {firstName} {lastName}!");
Console.WriteLine($"You are {age} years old with a GPA of {gpa}.");
Console.WriteLine($"Currently enrolled: {isEnrolled}");

// Basic math operators
int a = 42;
int b = 5;
Console.WriteLine($"\n{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");
Console.WriteLine($"{a} % {b} = {a % b}");

// Simple conditional
int score = 87;
string grade = score switch
{
    >= 93 => "A",
    >= 90 => "A-",
    >= 87 => "B+",
    >= 83 => "B",
    >= 80 => "B-",
    _ => "C or below"
};
Console.WriteLine($"\nA score of {score} earns a grade of: {grade}");

// Simple loop
Console.WriteLine("\nCounting to 5:");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Count: {i}");
}
