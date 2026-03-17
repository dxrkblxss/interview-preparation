namespace InterviewPreparation.LanguageConcepts.MemoryManagment.SpanTMemoryT.ReadOnlyMemoryT;

public class Program
{
    public static async Task ProcessDataAsync(ReadOnlyMemory<char> data)
    {
        await Task.Delay(100);

        ReadOnlySpan<char> span = data.Span;

        Console.WriteLine($"Обработано {span.Length * 2} байт");
    }

    /* public static async Task Main()
    {
        string str = "Hello, World!";

        ReadOnlyMemory<char> slice = str.AsMemory(7, 5);

        await ProcessDataAsync(slice);
    } */
}