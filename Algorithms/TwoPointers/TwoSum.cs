namespace InterviewPreparation.Algorithms.TwoPointers;

public class TwoSumSolution
{
    /* public static void Main()
    {
        foreach (var x in TwoSum([1, 2, 5, 7, 9, 9], 11))
        {
            Console.WriteLine(x);
        }
    } */

    public static int[] TwoSum(int[] nums, int target)
    {
        int l = 0,
            r = nums.Length - 1;

        while (l < r)
        {
            int sum = nums[l] + nums[r];

            if (sum == target) return [l, r];
            else if (sum > target) r--;
            else l++;
        }

        return [];
    }
}