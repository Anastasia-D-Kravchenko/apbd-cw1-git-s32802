namespace apbd_cw1_git_s32802;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] numbers) {
        if (numbers == null || numbers.Length == 0) {
            return 0;
        }

        int sum = 0;
        foreach (var n in numbers) {
            sum += n;
        }

        return (double)sum / numbers.Length;
    }
    
    public static int CalculateMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        return max;
    }
    
    public static int CalculateMin(int[] numbers)
    {
        // Skeleton: logic to be added in next commit
        return 0;
    }
}