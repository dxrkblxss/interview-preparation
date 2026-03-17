namespace InterviewPreparation.LanguageConcepts.DisposablePattern;

public class ResourceHolder : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            Console.WriteLine("Connection has been closed.");
        }

        _disposed = true;
    }

    public void SomeMethod()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        Console.WriteLine("Blah-blah-blah.");
    }
}

public class Program
{
    /* public static void Main()
    {
        using var resHolder = new ResourceHolder();
        resHolder.SomeMethod();

        var secResHolder = new ResourceHolder();
        secResHolder.Dispose();
        secResHolder.SomeMethod();
    } */
}