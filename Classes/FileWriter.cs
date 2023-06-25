using System.Collections;

namespace ConsoleApp;

public class FileWriter
{
    public static void CreateFile(string login, string password, DateTime dateTime) // protected
    {
        Console.Clear();
        using (StreamWriter writer = new StreamWriter(login + ".txt"))
        {
            writer.WriteLine(password);
            
            writer.Write(dateTime.Date.Day+".");
            writer.Write(dateTime.Date.Month+".");
            writer.Write(dateTime.Date.Year);
            
            writer.Close();
        }
    }
    public static void ChangePassword(string login, string password, string newPassword) // protected
    {
        Console.Clear();
        
        string[] lines = File.ReadAllLines(login + ".txt");//
        lines[0] = newPassword;

        File.WriteAllLines(login+".txt",lines);
    }
    public static void ChangeDateTime(string login, string password, DateTime dateTime) 
    {
        Console.Clear();
        
        string[] lines = File.ReadAllLines(login + ".txt");//
        lines[1] = dateTime.Date.Day + "." + dateTime.Date.Month + "." + dateTime.Date.Year;
        
        File.WriteAllLines(login+".txt",lines);

    }
    public static bool CheckPassword(string login,string password) 
    {
        Console.Clear();

        using (StreamReader reader = new StreamReader(login + ".txt"))
        {
            string passwordInFile = reader.ReadLine();
            reader.Close();

            if (passwordInFile != password)
            {
                return false;
            }

            return true;
        }
    }

    public static void WriteQuizeResult(string login,int result,string QuizeName)
    {
        using (StreamWriter writer = new StreamWriter(login + ".txt",true))
        {
            writer.WriteLine("\n");
            writer.WriteLine($"Your result for {QuizeName}: {result}/5");
            writer.Close();
        }
    }
    
    

    
}
