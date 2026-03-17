namespace InterviewPreparation.LanguageConcepts.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

public interface IGreeter
{
    void SayHello();
}

public class ConsoleGreeter : IGreeter
{
    public void SayHello() => Console.WriteLine("Hello from ConsoleGreeter!");
}

public class AppLauncher(IGreeter greeter)
{
    public void Run() => greeter.SayHello();
}

public class Program
{
    /* public static void Main()
    {
        var services = new ServiceCollection();

        services.AddSingleton<AppLauncher>();
        services.AddTransient<IGreeter, ConsoleGreeter>();

        var provider = services.BuildServiceProvider();
        var app = provider.GetRequiredService<AppLauncher>();

        app.Run();
    } */
}