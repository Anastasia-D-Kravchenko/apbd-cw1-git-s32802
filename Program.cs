using apbd_cw1_git_s32802;

Console.WriteLine("MAIN VERSION: Statistics App");
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

    try
    {
        int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

        double average = StatisticsHelper.CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Please enter only valid integers separated by spaces.");
    }
}