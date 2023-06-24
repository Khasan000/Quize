namespace ConsoleApp;

public class AccountsDataBase 
{
    protected internal static Dictionary<string, int> accounts = new Dictionary<string, int>();

    public AccountsDataBase()
    {
        accounts.Add("Admin",1111);
    }


    public static void PrintInfoForStatic()
    {
        foreach (var variable in accounts)
        {
            Console.WriteLine($"Login: {variable.Key} | Password: {variable.Value}");
        }
    }
}