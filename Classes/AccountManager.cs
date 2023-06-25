namespace ConsoleApp;

public class AccountManager
{
    private static bool IsExist(string login)
    {
        return File.Exists(login + ".txt");
    }
    public static bool TrySignIn(string login, string password,DateTime dateTime)
    {
        if (!IsExist(login))
        {
            FileWriter.CreateFile(login,password,dateTime);
            return true;
        }

        Console.WriteLine($"Account {login} already exists!");
        return false;
    }
    public static bool TryLogIn(string login, string password)
    {
        if (!IsExist(login))
        {
            Console.WriteLine("Account does not exist!");
            return false;
        }
        return FileWriter.CheckPassword(login, password);
    }
    public static void ChangeDateTime(string login, string password, DateTime dateTime)
    {
        FileWriter.ChangeDateTime(login,password,dateTime);
    }
    public static bool ChangePassword(string login, string password, string newPassword)
    {
        FileWriter.ChangePassword (login, password, newPassword);
        return true;
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