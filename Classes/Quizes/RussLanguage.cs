using TestCode.CS_Files.Git.Interfaces;

namespace ConsoleApp;

public class RussLanguage : IQuize
{
    private static List<string> questions = new List<string>()
    {
        new string("Лагать/Логать?"),
        new string("Копать/Капать?"),
        new string("Я пошел гулять. Где здесь подлежащее?"),
        new string("Ковылять/Кавылять?"),
        new string("Русский/Руский?")
    };
    private static List<string> answers = new List<string>()
    {
        "Лагать", "Копать", "Я", "Ковылять", "Русский"
    };
    
    
    public static void Start(string login)
    {
        Console.Clear();
        int counter = 0;
        Game(ref counter,login);    
    }

    public static void Game(ref int counter, string login)
    {
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(questions[i]);
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == answers[i].ToLower())
            {
                counter++;
                Console.WriteLine("Correct!");
                Thread.Sleep(300);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Incorrect");
                Thread.Sleep(300);
                Console.Clear();
            }

            Console.WriteLine($"You score: {counter} / {questions.Count}");
            Thread.Sleep(1000);
            Console.Clear();
        }
        FileWriter.WriteQuizeResult(login,counter,nameof(RussLanguage));
    }
}