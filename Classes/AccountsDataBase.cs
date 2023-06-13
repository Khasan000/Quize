namespace ConsoleApp;

public class AccountsDataBase : IStaticPrintable
{
    protected internal static Dictionary<string, int> accounts = new Dictionary<string, int>();

    public AccountsDataBase()
    {
        accounts.Add("Admin",1111);
    }


    public static void PrintForStatic()
    {
        foreach (var variable in accounts)
        {
            Console.WriteLine($"Login: {variable.Key} | Password: {variable.Value}");
        }
    }
}