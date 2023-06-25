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

            List<string> Methods = new List<string>() { "Null" ,"SignIn", "LogIn", "Start new Quize","Exit"};
            List<string> Actions = new List<string>() { "Null" ,"Change Password", "Change DateTime","Start Quize" };
            List<string> Quizes = new List<string>() { "Null", "Language Quize", "Matem Quize","Russ Language" };
            

            void PrintFuncs()
            {
                for (int i = 1; i < Methods.Count; i++)
                {
                    Console.WriteLine($"{i}) {Methods[i]}"); // вывод доступных функций
                }
            }

            void PrintActions()
            {
                for (int i = 1; i < Actions.Count; i++)
                {
                    Console.WriteLine($"{i}) {Actions[i]}"); 
                }
            }

            void PrintQuize()
            {
                for (int i = 1; i < Quizes.Count; i++)
                {
                    Console.WriteLine($"{i}) {Quizes[i]}"); 
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
                    
                    if (!AccountManager.TrySignIn(login, password,dateTime))
                        continue;
                    
                    Console.Clear();
                    
                    #endregion
                }

                if (Choice == 2)
                {
                    #region LogIn
                    
                    Console.Clear();
                    
                    AccountManager.DataRequest(out var login, out var password);

                    if (!AccountManager.TryLogIn(login, password))
                    {
                        Console.WriteLine("Failed to LogIn!");
                        continue;
                    }
                    
                    Console.Clear();
                    Console.WriteLine($"Welcome {login}!");

                    #endregion
                }
                
                // Change Password
                if (Choice == 3)
                {
                    AccountManager.DataRequest(out var login, out var password,out var newPassword);
                    if (!AccountManager.ChangePassword(login, password, newPassword))
                    {
                        Console.WriteLine("Error!");
                        continue;
                    }
                    Console.WriteLine("Succeed");
                    
                }
                // Test Work LogIn
                if (Choice == 5)
                {
                    #region LogIn
                    
                    Console.Clear();
                    
                    AccountManager.DataRequest(out var login, out var password);

                    if (!AccountManager.TryLogIn(login, password))
                    {
                        Console.WriteLine("Failed to LogIn!");
                        continue;
                    }
                    
                    Console.Clear();
                    Console.WriteLine($"Welcome {login}!");

                    Console.WriteLine("Choose Action: ");
                    PrintActions();
                    
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Clear();
                        string newPassword = Console.ReadLine();
                        AccountManager.ChangePassword(login,password,newPassword);
                        Console.Clear();
                    } // Change Password

                    if (choice == 2)
                    {
                        Console.Clear();
                        AccountManager.BirthDateRequest(out var dateTime);
                        AccountManager.ChangeDateTime(login, password, dateTime);
                    } // Change DateTime

                    if (choice == 3)
                    {
                        Console.Clear();
                        PrintQuize();
                        int choiceQuize=int.Parse(Console.ReadLine());

                        switch (choiceQuize)
                        {
                            case 1:
                                LanguageQuize.Start(login);
                                break;
                            case 2:
                                MatemQuize.Start(login);
                                break;
                            case 3:
                                RussLanguage.Start(login);
                                break;
                        }
                    }

                    #endregion
                }

                else if (Choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Exit...");
                    Environment.Exit(1);
                }
                
            }
        }
    }
}