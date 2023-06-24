using TestCode.CS_Files.Git.Interfaces;

namespace ConsoleApp;

public class LanguageQuize : IQuize
{

    private static List<string> questions = new List<string>()
    {
        new string("Мой любимый язык?"),
        new string("Каким знаком обозначается что тип может допускать null?"),
        new string("Каким ключевый словом создается новое пространство имен?"),
        new string("Каким ключевым словом мы передаем в функцию поле по ссылке?"),
        new string("Какое ключевое слово нужно, чтобы вызвать кастомное исключение?")
    };

    private static List<string> answers = new List<string>() { "C#", "?", "namespace", "ref", "throw" };
    

    public static void Start()
    {
        Console.Clear();
        int counter = 0;
        Game(ref counter);
    }

   

    private static void Game(ref int counter)
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
    }
    
}