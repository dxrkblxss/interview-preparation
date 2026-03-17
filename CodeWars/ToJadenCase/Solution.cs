namespace InterviewPreparation.CodeWars.ToJadenCase;

using System.Text;

public static class ToJadenCaseSolution
{
    /* public static void Main()
    {
        Console.WriteLine("hello world!".ToJadenCase());
    } */

    public static string ToJadenCase(this string phrase)
    {
        if (string.IsNullOrEmpty(phrase)) return phrase;

        phrase = phrase.Trim();

        var sb = new StringBuilder(phrase.Length);

        sb.Append(char.ToUpper(phrase[0]));

        for (int i = 1; i < phrase.Length; i++)
        {
            char x = phrase[i];
            if (char.IsWhiteSpace(phrase[i - 1]))
                x = char.ToUpper(phrase[i]);

            sb.Append(x);
        }

        return sb.ToString();
    }
}