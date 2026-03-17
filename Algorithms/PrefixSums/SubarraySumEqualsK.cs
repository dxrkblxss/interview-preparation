namespace InterviewPreparation.Algorithms.PrefixSums;

public class SubarraySumEqualsKSolution
{
    /* public static void Main()
    {
        int[] nums = [-1, 1, -1, 1];

        Console.WriteLine(SubarraySumEqualsK(nums, 0));
    } */

    public static int SubarraySumEqualsK(int[] nums, int k)
    {
        var map = new Dictionary<int, int>()
        {
            { 0, 1 }
        };

        int count = 0, sum = 0;

        foreach (var num in nums)
        {
            sum += num;
            
            map.TryGetValue(sum - k, out var targetValue);
            count += targetValue;

            map.TryGetValue(sum, out var sumValue);
            map[sum] = ++sumValue;
        }

        return count;
    }
}
