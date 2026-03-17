namespace InterviewPreparation.LanguageConcepts.MemoryManagment.Finalizers;

public class User
{
    public string Name { get; set; } = String.Empty;
    public int Age { get; set; }

    ~User()
    {
        Console.WriteLine($"The user object has been removed from memory.");
    }
}

public class Program
{
    /* public static void Main()
    {
        var user = new User();

        user.Name = "Maria";
        user.Age = 19;

        Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}");

        user = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}");
    } */
}