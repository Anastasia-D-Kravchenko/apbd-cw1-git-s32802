// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using apbd_cw1_git_s32802;

Console.WriteLine("Welcome to the Statistics App!");
Console.WriteLine("Please enter a series of numbers separated by spaces:");

string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input)) {
    Console.WriteLine("Error: No data was entered. Please provide at least one number.");
}
else {
    string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine($"Processing {numbers.Length} numbers...");
}