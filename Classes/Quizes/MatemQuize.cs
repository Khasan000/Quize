using TestCode.CS_Files.Git.Interfaces;

namespace ConsoleApp;

public class MatemQuize : IQuize
{
    private static List<string> questions = new List<string>()
    {
        new string("1+1?"),
        new string("100+150?"),
        new string("Корень из 121?"),
        new string("Формула дискриминанта?"),
        new string("10*11?")
    };
    private static List<string> answers = new List<string>() { "2", "250", "11", "b2-4ac", "110" };

    
    
    public static void Start(string login)
    {
        Console.Clear();
        int counter = 0;
        Game(ref counter, login);
    }

    public static void Game(ref int counter,string login)
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
        FileWriter.WriteQuizeResult(login,counter,nameof(MatemQuize));
    }
}