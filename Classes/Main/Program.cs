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
            Methods.Insert(0, "Null");

            bool InAccount = default;
            

            void PrintFuncs()
            {
                for (int i = 1; i < Methods.Count; i++)
                {
                    Console.WriteLine($"{i}) {Methods[i]}"); // вывод доступных функций
                }
            }


            while (true)
            {
                PrintFuncs();

                Console.WriteLine("Choice: ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    #region SignIn
                 
                    Console.Clear();
                    
                    string login;
                    int password;
                    DateTime dateTime;
                    

                    AccountManager.DataRequest(out login, out password);
                    AccountManager.BirthDateRequest(out dateTime);
                    

                    if (!manager.TrySignIn(login, password))
                        throw new ArgumentException($"Account {login} has already exist");
                    new Account(login, password, dateTime);

                    Console.Clear();
                    
                    #endregion
                }

                if (Choice == 2)
                {
                    #region LogIn
                    
                    Console.Clear();

                    string login;
                    int password;

                    AccountManager.DataRequest(out login, out password);

                    if (manager.TryLogIn(login, password))
                    {
                        if (InAccount)
                        {
                            Console.WriteLine("You are already logged in");
                            continue;
                        }

                        Console.WriteLine("Successful login! : {0}", login);
                        InAccount = true;
                    }

                    #endregion
                }

                if (Choice == 3)
                {

                }
            }
        }
    }
}