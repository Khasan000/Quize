using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            AccountManager manager = new AccountManager();
            AccountsDataBase dataBase = new AccountsDataBase();
            
            const int StartChoice = 1;

            List<string> Methods = new List<string>() { "SignIn", "LogIn", "Start new Quize" };
            Methods.Insert(0,"Null");

            bool InAccount = default;
            
           
            
            while (true)
            {
                for (int i = 1; i < Methods.Count; i++)
                {
                    Console.WriteLine($"{i}) {Methods[i]}"); // вывод доступных функций
                }
                
                Console.WriteLine("Choice: ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    #region SignIn
                    Account SignAccount;

                    string login;
                    int password;
                    DateTime dateTime;
                    
                    AccountManager.DataRequest(out login,out password);
                    AccountManager.BirthDateRequest(out dateTime);
                    
                        if (!manager.TrySignIn(login, password))
                            throw new ArgumentException($"Account {login} has already exist");
                        SignAccount = new Account(login, password, dateTime);
                        
                    AccountsDataBase.PrintInfoForStatic();
                    
                    #endregion
                }

                if (Choice == 2)
                {
                    #region LogIn

                    string login;
                    int password;
                    
                    AccountManager.DataRequest(out login, out password);

                    if (manager.TryLogIn(login, password))
                    {
                        InAccount = true;

                        Console.WriteLine("Successful login!: {0}",login);
                        
                    }

                    #endregion
                }
            }
        }
    }
    
    public class EntryManager
    {
        private List<string> ScienceSection = new List<string>() { "IT", "Math", "Russian" };
        
        public void StartNewQuiz(int i)
        {
            
        }
    }

    public abstract class Quize
    {
        public abstract void Start();
        public abstract void CheckResult();
        
    }

    public class MathQuize : Quize
    {
        
        
        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void CheckResult()
        {
            throw new NotImplementedException();
        }
    }
}

