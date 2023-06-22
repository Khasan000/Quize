using System.Collections;

namespace ConsoleApp;

public class FileWriter
{
    public static void CreateFile(string login, string password)
    {
        Console.Clear();
        using (StreamWriter writer = new StreamWriter(login + ".txt"))
        {
            writer.WriteLine(password);
            writer.Close();
        }
    }
    public static void ChangePassword(string login, string password, string newPassword)
    {
        Console.Clear();
       
        if (!File.Exists(login + ".txt"))
        {
            Console.WriteLine($"Account {login} does not exist");
            return;
        }
        
        using (StreamReader reader = new StreamReader(login + ".txt"))
        {
            string passwordInFile = reader.ReadLine();
            reader.Close();

            if (passwordInFile != password)
            {
                Console.WriteLine("Incorrect password!");
                return;
            }
        }
        
        string[] lines = File.ReadAllLines(login + ".txt");//

        lines[0] = newPassword;
            
            
        File.WriteAllLines(login+".txt",lines);
    }
    

    
}
