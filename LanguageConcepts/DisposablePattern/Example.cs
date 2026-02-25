namespace InterviewPreparation.LanguageConcepts.DisposablePattern;

public class MyDbConnection : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Console.WriteLine("Соединение закрыто");
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    public void SomeMethod()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        Console.WriteLine("Blah-blah-blah");
    }
}

public class Program
{
    // public static void Main()
    // {
    //     using var dbConnection = new MyDbConnection();
    //     dbConnection.SomeMethod();

    //     var secDbConnection = new MyDbConnection();
    //     secDbConnection.Dispose();
    //     secDbConnection.SomeMethod();
    // }
}