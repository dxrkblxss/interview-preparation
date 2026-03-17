namespace InterviewPreparation.Algorithms.TwoPointers;

public class ContainerWithMostWaterSolution
{
    /* public static void Main()
    {
        Console.WriteLine(ContainerWithMostWater([5, 8, 1, 7, 2, 9]));
    } */

    public static int ContainerWithMostWater(int[] height)
    {
        int maxArea = 0,
            l = 0,
            r = height.Length - 1;
        
        while (l < r)
        {
            int min = Math.Min(height[l], height[r]);
            int area = (r - l) * min;

            if (area > maxArea) maxArea = area;

            if (height[l] == min) l++; else r--;
        }

        return maxArea;
    }
}