namespace InterviewPreparation.Algorithms.HashMaps;

public class TwoSum
{
    // public static void Main()
    // {
    //     int[] arr = GetTwoSum([9, 7, 1, 5, 2, 9], 11);

    //     foreach (var x in arr)
    //     {
    //         Console.WriteLine(x);
    //     }
    // }

    public static int[] GetTwoSum(int[] numbers, int target)
    {
        var dict = new Dictionary<int, int>()
        {
            { numbers[0], 0 }
        };

        for (int i = 1; i < numbers.Length; i++)
        {
            int num = numbers[i];
            if (!dict.ContainsKey(num))
                dict[num] = i;

            int diff = target - num;
            if (dict.TryGetValue(diff, out var value))
                return [value, i];
        }

        return [];
    }
}