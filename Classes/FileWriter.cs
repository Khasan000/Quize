using System.Collections;

namespace ConsoleApp;

public class FileWriter
{
    public static void CreateFile(string login, string password, DateTime dateTime)
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
    public static void ChangePassword(string login, string password, string newPassword)
    {
        Console.Clear();

        if (!CheckPassword(login, password))
        {
            Console.WriteLine("Incorrect password!");
            return;
        }
        
        string[] lines = File.ReadAllLines(login + ".txt");//
        lines[0] = newPassword;

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
    
    
    

    
}
