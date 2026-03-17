namespace InterviewPreparation.Algorithms.HashMaps;

public class TwoSumSolution
{
    /* public static void Main()
    {
        foreach (var x in TwoSum([9, 7, 1, 5, 2, 9], 11))
        {
            Console.WriteLine(x);
        }
    } */

    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>()
        {
            { nums[0], 0 }
        };

        for (int i = 1; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out var value))
                return [value, i];
            
            map[nums[i]] = i;
        }

        return [];
    }
}