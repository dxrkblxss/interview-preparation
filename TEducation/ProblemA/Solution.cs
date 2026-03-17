namespace InterviewPreparation.TEducation.ProblemA;

public class ProblemASolution
{
    /* public static void Main()
    {
        Console.WriteLine(CalculateMobileBill(100, 10, 12, 11));
    } */

    public static int CalculateMobileBill(int a, int b, int c, int d)
    {
        if (d <= b) return a;

        return a + (d - b) * c;
    }
}