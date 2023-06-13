namespace ConsoleApp;

public class Account : IPrintable
{
    // Password and DateBirth
    public string? _login { get; set; }
    public int _password { get; set; }
        
        
    public DateTime _bd { get; set; }
    public Account(string Login, int password, DateTime bd)
    {
        _login = Login;
        _password = password;
        _bd = bd;
    }


    public void PrintInfo()
    {
        Console.WriteLine(_login);
        Console.WriteLine(_password);
        Console.WriteLine(_bd);
    }
}