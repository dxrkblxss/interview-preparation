namespace InterviewPreparation;

public class TwoSum
{
    // public static void Main()
    // {
    //     int[] arr = TwoSum([1, 2, 5, 7, 9, 9], 11);

    //     foreach (var x in arr)
    //     {
    //         Console.WriteLine(x);
    //     }
    // }

    public static int[] GetTwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;

        while (l < r)
        {
            int sum = numbers[l] + numbers[r];

            if (sum == target) return [numbers[l], numbers[r]];
            else if (sum > target) r--;
            else l++;
        }

        return [];
    }
}