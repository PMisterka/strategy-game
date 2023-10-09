using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StrategyGame
{
    class Aftermath
    {
        public static void FirstAftermath()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string firstAftermath = "First battle - aftermath";
            Console.SetCursorPosition((Console.WindowWidth - firstAftermath.Length) / 2, Console.CursorTop);
            Console.WriteLine(firstAftermath);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Program.Print("\nAfter this great battle, you still have: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Wquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" warriors");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Aquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" archers");

            Thread.Sleep(500);

            string enter = @"
 ____ ____ __
||e n t e r ||
||__________||
|/__________\|                  
                                                                 ";


            Console.WriteLine("Please press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            if (Gameplay.Aquantity == 0 && Gameplay.Wquantity == 0 && Program.startMoney<=0)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 "; 


                Console.WriteLine(gameover);
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition((Console.WindowWidth - firstAftermath.Length) / 2, Console.CursorTop);
                Console.WriteLine(firstAftermath);
                Thread.Sleep(500);

                // Won battle reward
                int x = Battle1.quantityOfAllEnemies;
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nFor winning this battle you receive ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(250 * x + "$");
                Money.AddMoney(250 * x);

                // Food fees
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nSoldiers must eat! This will cost you: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( ((Gameplay.Wquantity + Gameplay.Aquantity) * 10) + "$");
                Money.FoodMoney(((Gameplay.Wquantity + Gameplay.Aquantity) * 10));

                Thread.Sleep(1000);

                if (Program.startMoney < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou have lost all of your money!");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();

                    string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 ";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(gameover);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nNow you have: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Program.startMoney + "$");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();
                }
            }

        }


        public static void SecondAftermath()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string secondAftermath = "Second battle - aftermath";
            Console.SetCursorPosition((Console.WindowWidth - secondAftermath.Length) / 2, Console.CursorTop);
            Console.WriteLine(secondAftermath);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Program.Print("\nAfter this great battle, you still have: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Wquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" warriors");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Aquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" archers");

            Thread.Sleep(500);

            string enter = @"
 ____ ____ __
||e n t e r ||
||__________||
|/__________\|                  
                                                                 ";


            Console.WriteLine("Please press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            if (Gameplay.Aquantity == 0 && Gameplay.Wquantity == 0 && Program.startMoney <= 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 ";


                Console.WriteLine(gameover);
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition((Console.WindowWidth - secondAftermath.Length) / 2, Console.CursorTop);
                Console.WriteLine(secondAftermath);
                Thread.Sleep(500);

                // Won battle reward
                int x = Battle1.quantityOfAllEnemies;
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nFor winning this battle you receive ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(700 * x + "$");
                Money.AddMoney(700 * x);

                // Food fees
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nSoldiers must eat! This will cost you: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(((Gameplay.Wquantity + Gameplay.Aquantity) * 10) + "$");
                Money.FoodMoney(((Gameplay.Wquantity + Gameplay.Aquantity) * 10));

                Thread.Sleep(1000);

                if (Program.startMoney < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou have lost all of your money!");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();

                    string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 ";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(gameover);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nNow you have: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Program.startMoney + "$");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();
                }


            }

        }


        public static void ThirdAftermath()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string thirdAftermath = "Third battle - aftermath";
            Console.SetCursorPosition((Console.WindowWidth - thirdAftermath.Length) / 2, Console.CursorTop);
            Console.WriteLine(thirdAftermath);
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;
            Program.Print("\nAfter this great battle, you still have: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Wquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" warriors");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Gameplay.Aquantity);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" archers");

            Thread.Sleep(500);

            string enter = @"
 ____ ____ __
||e n t e r ||
||__________||
|/__________\|                  
                                                                 ";


            Console.WriteLine("Please press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();

            if (Gameplay.Aquantity == 0 && Gameplay.Wquantity == 0)
            {
                

                Console.ForegroundColor = ConsoleColor.DarkRed;
                string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 ";


                Console.WriteLine(gameover);
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition((Console.WindowWidth - thirdAftermath.Length) / 2, Console.CursorTop);
                Console.WriteLine(thirdAftermath);
                Thread.Sleep(500);

                // Won battle reward
                int x = Battle1.quantityOfAllEnemies;
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nFor winning this battle you receive ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(500 * x + "$");
                Money.AddMoney(500 * x);

                // Food fees
                Console.ForegroundColor = ConsoleColor.White;
                Program.Print("\nSoldiers must eat! This will cost you: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(((Gameplay.Wquantity + Gameplay.Aquantity) * 10) + "$");
                Money.FoodMoney(((Gameplay.Wquantity + Gameplay.Aquantity) * 10));
                
                Thread.Sleep(1000);

                if (Program.startMoney < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou have lost all of your money!");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();

                    string gameover = @"
                                     
                   ____   _____      _____     ____  
                  / ___\  \__  \    /     \  _/ __ \ 
                 / /_/  >  / __ \_ |  Y Y  \ \  ___/ 
                 \___  /  (____  / |__|_|  /  \___  >
                /_____/        \/        \/       \/ 
                                         
                    ____   ___  __   ____   _______  
                   /  _ \  \  \/ / _/ __ \  \_  __ \ 
                  (  <_> )  \   /  \  ___/   |  | \/ 
                   \____/    \_/    \___  >  |__|    
                                        \/                            
                                                                 ";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(gameover);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.Print("\nNow you have: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Program.startMoney + "$");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease press" + enter + "\nto continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.Clear();
                }


            }

        }
    }
}
