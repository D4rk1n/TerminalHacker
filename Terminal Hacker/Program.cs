using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Terminal_Hacker
{
    class IO
    {
        public  void PrintLine(string Line)
        {
            string cl = "";
            int l = Console.CursorLeft;
            int t = Console.CursorTop;
            for (int i = 0; i < Line.Length; i++)
            {
                Console.SetCursorPosition(l, t);
                cl += Line[i];
                Console.WriteLine(cl);
                //Console.Beep(500, 500);
                Thread.Sleep(50);
            }
        }
    }
    class Password
    {
        private string[,] passwords;

        public Password() {
            passwords = new string[3, 5]
            {
                {"weeka1999","d7kooo","yamomes","mardamarda","ana5ayf3leko"},
                {"","","","",""},
                {"","","","",""}
            };
        
        }
        public string RandPass(int lvl)
        {
            int r = 0;
            return passwords[--lvl, r];
        }
     }

    class Program
    {
        Program()
        {
            Mode = Screen.Menu;
            Output = new IO();
            Pass = new Password();
        }
        private Password Pass;
        private  IO Output;
        private int Diff;
        private int WinPoints;
        private enum Screen { Menu, PasswordCrack, Win, GameOver };
        private Screen Mode;
        private  void THName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  _______ ______ _____  __  __ _____ _   _          _ ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" |__   __|  ____|  __ \\|  \\/  |_   _| \\ | |   /\\   | | ");
            Thread.Sleep(100);
            Console.WriteLine("    | |  | |__  | |__) | \\  / | | | |  \\| |  /  \\  | | ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    | |  |  __| |  _  /| |\\/| | | | | . ` | / /\\ \\ | | ");
            Thread.Sleep(100);
            Console.WriteLine("    | |  | |____| | \\ \\| |  | |_| |_| |\\  |/ ____ \\| |____ ");
            Thread.Sleep(100);
            Console.WriteLine("    |_|  |______|_|  \\_\\_|  |_|_____|_| \\_/_/    \\_\\______|");
            Thread.Sleep(100);
            Console.WriteLine("          _    _          _____ _  ________ _____          ");
            Thread.Sleep(100);
            Console.WriteLine("         | |  | |   /\\   / ____| |/ /  ____|  __ \\         ");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         | |__| |  /  \\ | |    | ' /| |__  | |__) |");
            Thread.Sleep(100);
            Console.WriteLine("         |  __  | / /\\ \\| |    |  < |  __| |  _  /");
            Thread.Sleep(100);
            Console.WriteLine("         | |  | |/ ____ \\ |____| . \\| |____| | \\ \\ ");
            Thread.Sleep(100);
            Console.WriteLine("         |_|  |_/_/    \\_\\_____|_|\\_\\______|_|  \\_\\ \n\n");
            Console.ResetColor();
            Output.PrintLine("Choose a Terminal to Be Hacked");
            Output.PrintLine("1)Aly Weeka");
            Output.PrintLine("2)Bakr");
            Output.PrintLine("3)Ehab Talkhan");
        }

       
        public void  MainMenu()
        {
            THName();
            bool next = false;
            while(!next)
            {
                string choice = Console.ReadLine();
                if (choice == "1" )
                {
                    Diff = 1;
                    next = true;
                    Mode = Screen.PasswordCrack;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (choice == "2")
                {
                    Diff = 2;
                    next = true;
                    Mode = Screen.PasswordCrack;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                if (choice == "3")
                {
                    Diff = 3;
                    next = true;
                    Mode = Screen.PasswordCrack;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (choice == "menu" || choice == "MENU")
                {
                    next = true;
                }
            }
            Console.Clear();
           
        }
        
        public void CrackPass()
        {
            
            Console.Beep();
            Console.WriteLine("You Have Chosen Diffculty : {0}", Diff);
            string pass = Pass.RandPass(Diff);
            int l = Console.CursorLeft;
            int t = Console.CursorTop;
            for (WinPoints = 3 ; WinPoints> 0;WinPoints--)
            {
               // Console.SetCursorPosition(l, t);
                Output.PrintLine("Enter Password : ");
                string input = Console.ReadLine();
                if (input == pass) break;
                else
                {
                    Output.PrintLine("Wrong Password " +Convert.ToString(WinPoints-1) +" Tries Left !");
                }
            }


            if (WinPoints > 0) Mode = Screen.Win;
            else Mode = Screen.GameOver;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {  
                switch (p.Mode)
                {
                    case Screen.Menu:
                        Console.Clear();
                        p.MainMenu();
                        break;
                    case Screen.PasswordCrack:
                        Console.Clear();
                        p.CrackPass();
                        break;
                    case Screen.Win:
                        Console.Clear();
                        break;
                    case Screen.GameOver:
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
