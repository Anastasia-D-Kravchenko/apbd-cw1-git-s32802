// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using apbd_cw1_git_s32802;

Console.WriteLine("Welcome to the Statistics App!");
Console.WriteLine("Please enter a series of numbers separated by spaces:");

string? input = Console.ReadLine();
string[] numbers = input?.Split(' ') ?? Array.Empty<string>();

Console.WriteLine($"You entered {numbers.Length} potential numbers.");