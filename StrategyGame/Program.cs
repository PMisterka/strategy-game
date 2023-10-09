using System;
using System.Threading;
using System.IO;
using System.Media;
using System.Text.Json;

namespace StrategyGame
{
    class Program
    {
        

        public static void Print(string text, int speed = 40)//40
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
                
            }
        }

        public static void Loading(string text, int speed = 400) // 400
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);

            }
        }

        public static int startMoney = 30000; // starting with 30 000 $
        static void Main(string[] args)
        {
            

            Money m = new Money(startMoney);
            int x = startMoney;

            Console.Title = "strategy game";
            string title = @"
       .__        __                                                      
       |__| _____/  |_  ____                                              
       |  |/    \   __\/  _ \                                             
       |  |   |  \  | (  <_> )                                            
       |__|___|  /__|  \____/                                             
               \/                                                         
                            __  .__                                       
                          _/  |_|  |__   ____                             
                          \   __\  |  \_/ __ \                            
                           |  | |   Y  \  ___/                            
                           |__| |___|  /\___  >                           
                                     \/     \/                            
                                                      ___.           __   
                                    ____  ____   _____\_ |__ _____ _/  |_ 
                                  _/ ___\/  _ \ /     \| __ \\__  \\   __\
                                  \  \__(  <_> )  Y Y  \ \_\ \/ __ \|  |  
                                   \___  >____/|__|_|  /___  (____  /__|  
                                       \/            \/    \/     \/                       
                                                                 ";


            Console.WriteLine(title);
            //Console.Read();


            Thread.Sleep(2000);

            string enter = @"
 ____ ____ __
||e n t e r ||
||__________||
|/__________\|                  
                                                                 ";


            Console.WriteLine("Please press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
             Print("You and your troops were sent to the front lines.\n" +
                "As a general you have to manage money, resources and soldiers.\n" +
                "Remember, the good of the Kingdom depends on you!\n" +
                "Good luck!\n");

            Thread.Sleep(1000);
            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            
            // First Battle

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string firstPreparation = "First battle - preparation";
            Console.SetCursorPosition((Console.WindowWidth - firstPreparation.Length) / 2, Console.CursorTop);
            Console.WriteLine(firstPreparation);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Print("Money: " + startMoney + "$");
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nYou now have: \n" +
                " " + Gameplay.Wquantity.ToString() + " warriors\n" +
                " " + Gameplay.Aquantity.ToString() + " archers");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nRemember!");
            Print("All good generals must feed their soldiers.\n" +
                "After each battle there will be a food charge of 10$ per soldier" +
                "\nIf soldiers won't get food, they will leave the battlefield.\n");
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to buy resources or hire mercenaries? ");
            Console.WriteLine("[Y / N]");
            Gameplay.Y_N_Shop();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string firstBattle = "First battle";
            Console.SetCursorPosition((Console.WindowWidth - firstBattle.Length) / 2, Console.CursorTop);
            Console.WriteLine(firstBattle);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

            Battle1.FirstBattle();
            
            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            
            Console.Clear();

            Save.SaveToTxt("You lost!");
            Save.checkWin = "You lost!";
            Save.SaveToJSON();
            Aftermath.FirstAftermath();

            Console.ForegroundColor = ConsoleColor.Red;
            Print("\nFrom now on the battles will be carried out on different areas, so your soldiers can get an area bonus!\n" +
                "But be careful, your opponents will also receive a random attack boost.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);

            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();
            

            // Second battle

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string secondPreparation = "Second battle - preparation";
            Console.SetCursorPosition((Console.WindowWidth - secondPreparation.Length) / 2, Console.CursorTop);
            Console.WriteLine(secondPreparation);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Print("Money: " + startMoney + "$");
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nYou now have: \n" +
                " " + Gameplay.Wquantity.ToString() + " warriors\n" +
                " " + Gameplay.Aquantity.ToString() + " archers");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to buy resources or hire mercenaries? ");
            Console.WriteLine("[Y / N]");
            Gameplay.Y_N_Shop();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string secondBattle = "Second battle";
            Console.SetCursorPosition((Console.WindowWidth - secondBattle.Length) / 2, Console.CursorTop);
            Console.WriteLine(secondBattle);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

            Battle2.SecondBattle();

            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            Save.SaveToTxt("You lost!");
            Save.checkWin = "You lost!";
            Save.SaveToJSON();
            Aftermath.SecondAftermath();


            // Third battle

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string thirdPreparation = "Third battle - preparation";
            Console.SetCursorPosition((Console.WindowWidth - thirdPreparation.Length) / 2, Console.CursorTop);
            Console.WriteLine(thirdPreparation);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Print("Money: " + startMoney + "$");
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nYou now have: \n" +
                " " + Gameplay.Wquantity.ToString() + " warriors\n" +
                " " + Gameplay.Aquantity.ToString() + " archers");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDo you want to buy resources or hire mercenaries? ");
            Console.WriteLine("[Y / N]");
            Gameplay.Y_N_Shop();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string thirdBattle = "Third battle";
            Console.SetCursorPosition((Console.WindowWidth - thirdBattle.Length) / 2, Console.CursorTop);
            Console.WriteLine(thirdBattle);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

            Battle3.ThirdBattle();

            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            Save.SaveToTxt("You lost!");
            Save.checkWin = "You lost!";
            Save.SaveToJSON();
            Aftermath.ThirdAftermath();

            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            Save.SaveToTxt("You won!");
            Save.checkWin = "You won!";
            Save.SaveToJSON();

            TheEnd.End();

        }
        
    }
}
