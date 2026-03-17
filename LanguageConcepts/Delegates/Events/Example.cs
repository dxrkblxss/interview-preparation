namespace InterviewPreparation.LanguageConcepts.Delegates.Events;

public class Button
{
    public event Action? OnClick;

    public void Press()
    {
        Console.WriteLine("Кнопка нажата!");
        OnClick?.Invoke();
    }
}

public class Program
{
    /* public static void Main()
    {
        var button = new Button();

        static void ShowMessage()
        {
            Console.WriteLine("Метод ShowMessage: Событие получено!");
        }

        button.OnClick += ShowMessage;
        button.OnClick += () => Console.WriteLine("Лямбда обработчик тоже сработал!");

        button.Press();
    } */
}
