// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using apbd_cw1_git_s32802;

while (true)
{
    Console.WriteLine("\nEnter numbers separated by spaces (or type 'exit' to quit):");
    string? input = Console.ReadLine();

    if (input?.ToLower() == "exit") break;

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid input. Try again.");
        continue;
    }
    
    string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine($"Processing {numbers.Length} numbers...");
}