namespace ConsoleApp;

public class AccountManager
{
    public static bool IsAccountAvaible(string login)
    {
        bool containsKey;
        return containsKey = AccountsDataBase.accounts.ContainsKey(login);
    }
        
    public bool TrySignIn(string login, int password)
    {
        if (!IsAccountAvaible(login))
        {
            AccountsDataBase.accounts.Add(login,password);
            FileWriter.CreateAndWrite(login,password);
            
            return true;
        }
        return false;
    }

    public bool TryLogIn(string login, int password)
    {
        if (AccountsDataBase.accounts.ContainsKey(login) && AccountsDataBase.accounts.ContainsValue(password))
            return true;
        return false;
    }

    public static void DataRequest(out string loginOut, out int passwordOut)
    {
        Console.Write("Enter login: ");
        string login = Console.ReadLine();
        
        int password = default;

        try
        {
            Console.Write("Enter password: ");
            password = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        loginOut = login;
        passwordOut = password;
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