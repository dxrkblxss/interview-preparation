namespace InterviewPreparation.LanguageConcepts.CancellationTokens;

public class Program
{
    public static async Task Print(string s, int sec, CancellationToken ct = default)
    {
        while (sec > 0)
        {
            ct.ThrowIfCancellationRequested();

            Console.WriteLine(s);

            await Task.Delay(1000, ct);

            sec--;
        }
    }

    /* public static async Task Main()
    {
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(TimeSpan.FromSeconds(2.5));

        try
        {
            await Print("Hello!", 5, cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Stopped safely.");
        }
    } */
}