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
}