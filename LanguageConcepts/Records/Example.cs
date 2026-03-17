namespace InterviewPreparation.LanguageConcepts.Records;

public record User(string Name, int Age);

public class Program
{
    /* public static void Main()
    {
        var user1 = new User("Pasha", 17);
        var user2 = new User("Pasha", 17);

        Console.WriteLine(user1 == user2);

        var olderPasha = user1 with { Age = 18 };

        Console.WriteLine($"Name: {olderPasha.Name}\nAge: {olderPasha.Age}");
    } */
}