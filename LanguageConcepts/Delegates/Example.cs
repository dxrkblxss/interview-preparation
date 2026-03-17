namespace InterviewPreparation.LanguageConcepts.Delegates;

public class Calculator
{
    public int Calculate(int a, int b, Func<int, int, int> operation)
        => operation(a, b);
}

public class Program
{
    public static int Multiply(int x, int y) => x * y;

    /* public static void Main()
    {
        var calculator = new Calculator();

        var sum = calculator.Calculate(1, 2, (x, y) => x + y);
        var mul = calculator.Calculate(5, 5, Multiply);

        Console.WriteLine($"sum: {sum}\nmul: {mul}");
    } */
}