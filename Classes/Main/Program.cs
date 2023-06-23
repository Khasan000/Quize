using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    public class Program
    {


        static void Main()
        {
            #region Main

            AccountManager manager = new AccountManager();

            List<string> Methods = new List<string>() { "SignIn", "LogIn", "Start new Quize" };
            Methods.Insert(0, "Null");

            void PrintFuncs()
            {
                for (int i = 1; i < Methods.Count; i++)
                {
                    Console.WriteLine($"{i}) {Methods[i]}"); // вывод доступных функций
                }
            }

            #endregion
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
                    string password;
                    DateTime dateTime;
                    

                    AccountManager.DataRequest(out login, out password);
                    AccountManager.BirthDateRequest(out dateTime);
                    

                    if (!manager.TrySignIn(login, password,dateTime))
                        continue;
                    
                    
                    
                    Console.Clear();
                    
                    #endregion
                }

                if (Choice == 2)
                {
                    #region LogIn
                    
                    Console.Clear();
                    
                    AccountManager.DataRequest(out var login, out var password);

                    if (!manager.TryLogIn(login, password))
                    {
                        Console.WriteLine("Failed to LogIn!");
                        continue;
                    }
                    
                    Console.Clear();
                    Console.WriteLine($"Welcome {login}!");

                    #endregion
                }

                if (Choice == 3)
                {
                    AccountManager.DataRequest(out var login, out var password,out var newPassword);
                    FileWriter.ChangePassword(login,password,newPassword);
                    

                }

            }
        }
    }
}