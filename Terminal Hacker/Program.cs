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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < Line.Length; i++)
            {
                Console.SetCursorPosition(l, t);
                cl += Line[i];
                Console.WriteLine(cl);
                //Console.Beep(500, 500);
                Thread.Sleep(50);
            }
        }
        public void ClearAfterCursor()
        {
            for (int i = 0; i < 10; i++) Console.WriteLine("\t\t\t\t\t\t\t\t");
        }
    }
    class Password
    {
        private string[,] passwords;

        public Password() {
            passwords = new string[3, 5]
            {
                {"weeka1999","d7kooo","yamomes","mardamarda","ana5ayf3leko"},
                {"allass","lmfao","nodiscussion","ahmedmousa",""},
                {"6fromleft","6fromright","magda1998","lmaoyeah","yes"}
            };
        
        }
        public string RandPass(int lvl)
        {
            Random random = new Random();
            int r = random.Next(5);
            return passwords[--lvl, 0];
        }
     }

    class Program
    {
        Program()
        {
            Mode = Screen.Menu;
            Output = new IO();
            Pass = new Password();
            Exit = false;
        }
        private Password Pass;
        private  IO Output;
        private int Diff;
        private int WinPoints;
        private bool Exit;
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
        private void GO()
        {
            Console.WriteLine(@"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████ 
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ 
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ 
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░
░ ░   ░   ░   ▒   ░      ░      ░   
      ░       ░  ░       ░      ░  ░
 ▒█████   ██▒   █▓▓█████  ██▀███    
▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒  
▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒  
▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄    
░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒  
░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░  
  ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░  
░ ░ ░ ▒       ░░     ░     ░░   ░   
    ░ ░        ░     ░  ░   ░      ");

        }
        private void AG()
        {
            Console.WriteLine(@"    _____________    $$$$$$\   $$$$$$\  $$$$$$$$\  $$$$$$\   $$$$$$\                      
   /      _      \  $$  __$$\ $$  __$$\ $$  _____|$$  __$$\ $$  __$$\                       
   [] :: (_) :: []  $$ /  $$ |$$ /  \__|$$ |      $$ /  \__|$$ /  \__|    
   [] ::::::::: []  $$$$$$$$ |$$ |      $$$$$\    \$$$$$$\  \$$$$$$\  
   [] ::::::::: []  $$  __$$ |$$ |      $$  __|    \____$$\  \____$$\  
   [] ::::::::: []  $$ |  $$ |$$ |  $$\ $$ |      $$\   $$ |$$\   $$ 
   [] ::::::::: []  $$ |  $$ |\$$$$$$  |$$$$$$$$\ \$$$$$$  |\$$$$$$  |
   [_____________]  \__|  \__| \______/ \________| \______/  \______/
       I     I       $$$$$$\  $$$$$$$\   $$$$$$\  $$\   $$\ $$$$$$$$\ $$$$$$$$\ $$$$$$$\  
       I_   _I      $$  __$$\ $$  __$$\ $$  __$$\ $$$\  $$ |\__$$  __|$$  _____|$$  __$$\
        /   \       $$ /  \__|$$ |  $$ |$$ /  $$ |$$$$\ $$ |   $$ |   $$ |      $$ |  $$ 
        \   /       $$ |$$$$\ $$$$$$$  |$$$$$$$$ |$$ $$\$$ |   $$ |   $$$$$\    $$ |  $$ |
        (   )       $$ |\_$$ |$$  __$$< $$  __$$ |$$ \$$$$ |   $$ |   $$  __|   $$ |  $$ |
        (   )       $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |\$$$ |   $$ |   $$ |      $$ |  $$ |
        /   \       \$$$$$$  |$$ |  $$ |$$ |  $$ |$$ | \$$ |   $$ |   $$$$$$$$\ $$$$$$$  |
        \___/        \______/ \__|  \__|\__|  \__|\__|  \__|   \__|   \________|\_______/ ");
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
            char heart = '\u2665';
            for (WinPoints = 3 ; WinPoints> 0;WinPoints--)
            {
                Console.SetCursorPosition(l, t);
                Output.ClearAfterCursor();
               
           
                Console.SetCursorPosition(l, t);
                string HP = "";
               for(int i = 0;i<WinPoints;i++)
                {
                    HP += heart;
                }
                
                Output.PrintLine("Your HP " + HP);
                Output.PrintLine("Enter Password : ");
                string input = Console.ReadLine();
                if (input == pass)
                {
                    Output.PrintLine("Password Accepted");
                    break;
                }
                else
                {
                    Output.PrintLine("Wrong Password " + Convert.ToString(WinPoints - 1) + " Tries Left !");
                }
            }
        

            if (WinPoints > 0) Mode = Screen.Win;
            else Mode = Screen.GameOver;
        }
        public void GameOver()
        {
            GO();
            Output.PrintLine("\nDo You Want to Play Again ? y/n");
            char c = Convert.ToChar(Console.Read());
            if (c == 'y')
            {
                Mode = Screen.Menu;
            }
            else { Exit = true; }
        }
        public void WinScreen()
        {
            AG();
            Output.PrintLine("\nDo You Want to Play Again ? y/n");
            char c = Convert.ToChar(Console.Read());
            if(c == 'y')
            {
                Mode = Screen.Menu;
            }
            else { Exit = true; }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            while (!p.Exit)
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
                        p.WinScreen();
                        break;
                    case Screen.GameOver:
                        Console.Clear();
                        p.GameOver();
                        break;

                }
            }
        }
    }
}
