namespace InterviewPreparation.LanguageConcepts.MemoryManagment.SpanTMemoryT.MemoryT;

public class Program
{
    public static async Task ProcessDataAsync(Memory<byte> data)
    {
        await Task.Delay(100);

        Span<byte> span = data.Span;

        Console.WriteLine($"Обработано {span.Length} байт");
    }

    /* public static async Task Main()
    {
        byte[] buffer = new byte[1024];

        for (int i = 0; i < 100; i++) buffer[i] = (byte)i;

        Memory<byte> mem = buffer.AsMemory(0, 50);

        await ProcessDataAsync(mem);
    } */
}