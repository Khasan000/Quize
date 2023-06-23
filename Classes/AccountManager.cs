namespace ConsoleApp;

public class AccountManager
{
    public static bool IsAccountAvaible(string login)
    {
        bool containsKey;
        return containsKey = AccountsDataBase.accounts.ContainsKey(login);
    }
        
    public bool TrySignIn(string login, string password)
    {
        if (!File.Exists(login+".txt"))
        {
            FileWriter.CreateFile(login,password);
            return true;
        }
        return false;
    }

    public bool TryLogIn(string login, string password)
    {
        if (File.Exists(login + ".txt"))
        {
            
            return true;
        }
        return false;
    }

    public static void DataRequest(out string loginOut, out string passwordOut)
    {
        Console.Write("Enter login: ");
        string login = Console.ReadLine();
        
        string password = default;

        try
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        loginOut = login;
        passwordOut = password;
    }
    
    public static void DataRequest(out string loginOut, out string passwordOut,out string newPasswordOut)
    {
        Console.Write("Enter login: ");
        string login = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        Console.Write("Enter NewPassword: ");
        string NewPassword = Console.ReadLine();
        
            

        loginOut = login;
        passwordOut = password;
        newPasswordOut = NewPassword;
    }

    public static void BirthDateRequest(out DateTime BirthDay)
    {
        DateTime dateTime = default; // year month day
        try
        {
            Console.Write("Input year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Input month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input day: ");
            int day = int.Parse(Console.ReadLine());

            dateTime = new DateTime(year, month, day);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }


        BirthDay = dateTime;
    }
    
}