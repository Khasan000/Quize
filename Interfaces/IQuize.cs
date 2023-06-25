namespace TestCode.CS_Files.Git.Interfaces;

public interface IQuize
{
    public static abstract void Start(string login);
    public static abstract void Game(ref int counter,string login);
}