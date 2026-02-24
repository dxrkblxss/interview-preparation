namespace InterviewPreparation;

public class ContainerWithMostWater
{
    // public static void Main()
    // {
    //     int maxArea = MaxArea([5, 8, 1, 7, 2, 9]);

    //     Console.WriteLine(maxArea);
    // }

    public static int MaxArea(int[] height)
    {
        int maxArea = 0,
            l = 0,
            r = height.Length - 1;
        
        while (l < r)
        {
            int min = Math.Min(height[l], height[r]);
            int area = (r - l) * min;

            if (area > maxArea) maxArea = area;

            if (min == height[l]) l++; else r--;
        }

        return maxArea;
    }
}