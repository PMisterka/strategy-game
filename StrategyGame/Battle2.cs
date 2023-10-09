using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StrategyGame
{
    class Battle2
    {
        //public static EnemyFactory firstEnemy;
        public static int quan;
        public static int quantityOfAllEnemies = quan;
        public static void SecondBattle()
        {
            EnemyFactory2 enemyFactory2 = new EnemyFactory2();

            Random rnd = new Random();
            int r = rnd.Next(1, 4);
            enemyFactory2.rndEnemy(r);
            enemyFactory2.rndEnemy(r).Health().ToString();
            quan = enemyFactory2.rndEnemy(r).Quantity();
            int oneEnemyHP = enemyFactory2.rndEnemy(r).Health();
            double Estr = enemyFactory2.rndEnemy(r).Strength();
            //double EnemyBonus = EnemyFactory2.rand;
            quantityOfAllEnemies = quan;

            //Console.WriteLine("Enemy:\n" +
            //"hp: " +  x+"\n" +
            // "ilość: " + EasyEnemy.quantity + " or" + y + "\n" +
            // "ile bije: " + EasyEnemy.strength + "\n" +
            //"ile bije * ilosc:" + EasyEnemy.attack);

            Console.ForegroundColor = ConsoleColor.Red;
            Program.Print("\nThere are three frontlines.\n" +
                "You must split your warriors among them.\n" +
                "Archers are always in the third frontline, \nmeaning they will attack, when all the warriors die.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYou have " + Gameplay.Wquantity + " warriors\n" +
                "How many of them would you like to put in the first frontline?");

            int firstWarriors = Gameplay.ReadInt32(Console.ReadLine());

            while (firstWarriors > Gameplay.Wquantity)
            {
                Console.WriteLine("You don't have this many warriors!");
                firstWarriors = Gameplay.ReadInt32(Console.ReadLine());

                if (firstWarriors <= Gameplay.Wquantity) break;
            }

            int thirdWarriors = Gameplay.Wquantity - firstWarriors;
            Console.WriteLine("\nYou have " + thirdWarriors + " warriors left\n" +
                "How many of them would you like to put in the second frontline?");
            int secondWarriors = Gameplay.ReadInt32(Console.ReadLine());

            while (secondWarriors > thirdWarriors)
            {
                Console.WriteLine("You don't have this many warriors!");
                secondWarriors = Gameplay.ReadInt32(Console.ReadLine());

                if (secondWarriors <= thirdWarriors) break;
            }

            thirdWarriors = thirdWarriors - secondWarriors;


            int thirdArchers = Gameplay.Aquantity;
            int thirdSoldiers = thirdWarriors + thirdArchers;

            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThe frontline: \n" +
                "1. " + firstWarriors + " warriors\n" +
                "2. " + secondWarriors + " warriors\n" +
                "3. " + thirdWarriors + " warriors and " + Gameplay.Aquantity + " archers");
            Console.ForegroundColor = ConsoleColor.White;


            string enter = @"
 ____ ____ __
||e n t e r ||
||__________||
|/__________\|                  
                                                                 ";

            Console.WriteLine("\nPlease press" + enter + "\nto continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string secondBattle = "Second battle";
            Console.SetCursorPosition((Console.WindowWidth - secondBattle.Length) / 2, Console.CursorTop);
            Console.WriteLine(secondBattle);
            Console.ForegroundColor = ConsoleColor.White;

            Gameplay.Wquantity = firstWarriors + secondWarriors + thirdWarriors;
            Gameplay.Aquantity = thirdArchers;


            for (int i = 1; i < 5; i++)
            {
                double enemyHP = oneEnemyHP * quan;
                switch (i)
                {
                    case 1:
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe first fight begins!\n" +
                            "You are facing " + quan + " enemies.\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Program.Loading(". . .\n");
                        Thread.Sleep(500);

                        double ourHP1 = firstWarriors * Gameplay.Whealth; //quantity of warriors in the first front line times health of each warrior
                        //int enemyHP = enemyFactory2.rndEnemy(r).Health() * enemyFactory2.rndEnemy(r).Quantity();

                        double ourAttack1 = firstWarriors * Gameplay.Wstrength;
                        double enemyAttack1 = Estr * quan;

                        //Console.WriteLine("our attack: " + ourAttack1 + " Our HP: " + ourHP1);
                        //Console.WriteLine("e attack: " + enemyAttack1 + " e HP: " + enemyHP);

                        if (ourAttack1 > (1.05 * enemyHP))
                        {
                            if (ourHP1 <= enemyAttack1)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You won this fight!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = (int)(ourHP1 / Gameplay.Whealth);
                                if (quan < 0) i = 4;
                                break;
                            }

                        }

                        else if (ourAttack1 <= (1.05 * enemyHP) && ourAttack1 >= (0.95 * enemyHP))
                        {
                            if (ourHP1 <= enemyAttack1)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 85)
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP1 = (double)(ourHP1 - enemyAttack1);
                                    enemyHP = (double)(enemyHP - ourAttack1);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    firstWarriors = (int)(ourHP1 / Gameplay.Whealth);
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP1 = (double)(ourHP1 - enemyAttack1);
                                    enemyHP = (double)(enemyHP - ourAttack1);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    firstWarriors = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack1 <= (0.95 * enemyHP) && ourAttack1 >= (0.85 * enemyHP))
                        {
                            if (ourHP1 <= enemyAttack1)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 15)
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP1 = (double)(ourHP1 - enemyAttack1);
                                    enemyHP = (double)(enemyHP - ourAttack1);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    firstWarriors = (int)(ourHP1 / Gameplay.Whealth);
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP1 = (double)(ourHP1 - enemyAttack1);
                                    enemyHP = (double)(enemyHP - ourAttack1);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    firstWarriors = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack1 < 0.85 * enemyHP)
                        {
                            if (ourHP1 <= enemyAttack1)
                            {
                                Console.WriteLine("You lost this fight!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = 0;
                                if (quan <= 0) i = 4;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("You lost this fight!");
                                ourHP1 = (double)(ourHP1 - enemyAttack1);
                                enemyHP = (double)(enemyHP - ourAttack1);
                                quan = (int)(enemyHP / oneEnemyHP);
                                firstWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                        }

                        else
                            break;



                    case 2:
                        if (firstWarriors < 0) firstWarriors = 0;
                       //secondWarriors += firstWarriors;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe second fight begins!\n" +
                            "You are facing " + quan + " enemies.\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Program.Loading(". . .\n");
                        Thread.Sleep(500);

                        double ourHP2 = secondWarriors * Gameplay.Whealth; //quantity of warriors in the 2nd front line times health of each warrior

                        double ourAttack2 = secondWarriors * Gameplay.Wstrength;
                        double enemyAttack2 = Estr * (enemyHP / quan);

                        //Console.WriteLine("our attack: " + ourAttack2 + " Our HP: " + ourHP2);
                        //Console.WriteLine("e attack: " + enemyAttack2 + " e HP: " + enemyHP);

                        if (ourAttack2 > (1.05 * enemyHP))
                        {
                            if (ourHP2 <= enemyAttack2)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You won this fight!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = (int)(ourHP2 / Gameplay.Whealth);
                                if (quan <= 0) i = 4;
                                continue;
                            }

                        }

                        else if (ourAttack2 <= (1.05 * enemyHP) && ourAttack2 >= (0.95 * enemyHP))
                        {
                            if (ourHP2 <= enemyAttack2)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 85)
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP2 = (double)(ourHP2 - enemyAttack2);
                                    enemyHP = (double)(enemyHP - ourAttack2);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    secondWarriors = (int)(ourHP2 / Gameplay.Whealth);
                                    if (quan <= 0) i = 4;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP2 = (double)(ourHP2 - enemyAttack2);
                                    enemyHP = (double)(enemyHP - ourAttack2);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    secondWarriors = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack2 <= (0.95 * enemyHP) && ourAttack2 >= (0.85 * enemyHP))
                        {
                            if (ourHP2 <= enemyAttack2)
                            {
                                Console.WriteLine("This fight is over!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 15)
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP2 = (double)(ourHP2 - enemyAttack2);
                                    enemyHP = (double)(enemyHP - ourAttack2);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    secondWarriors = (int)(ourHP2 / Gameplay.Whealth);
                                    if (quan <= 0) i = 4;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    ourHP2 = (double)(ourHP2 - enemyAttack2);
                                    enemyHP = (double)(enemyHP - ourAttack2);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    secondWarriors = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack2 < 0.85 * enemyHP)
                        {
                            if (ourHP2 <= enemyAttack2)
                            {
                                Console.WriteLine("You lost this fight!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You lost this fight!");
                                ourHP2 = (double)(ourHP2 - enemyAttack2);
                                enemyHP = (double)(enemyHP - ourAttack2);
                                quan = (int)(enemyHP / oneEnemyHP);
                                secondWarriors = 0;
                                if (quan <= 0) i = 4;
                                continue;
                            }
                        }

                        else
                            break;



                    case 3:
                        if (secondWarriors < 0) secondWarriors = 0;
                       // thirdWarriors += secondWarriors;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nThe third fight begins!\n" +
                            "You are facing " + quan + " enemies.\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Program.Loading(". . .\n");
                        Thread.Sleep(500);

                        double WHP3 = thirdWarriors * Gameplay.Whealth; //quantity of warriors in the 3rd front line times health of each warrior
                        double AHP3 = thirdArchers * Gameplay.Ahealth;
                        double ourHP3 = (WHP3 + AHP3);


                        double ourAttack3 = (thirdWarriors * Gameplay.Wstrength) + (thirdArchers * Gameplay.Astrength);
                        double enemyAttack3 = Estr * (enemyHP / quan);


                        //Console.WriteLine("our attack: " + ourAttack3 + " Our HP: " + (WHP3 + AHP3));
                        //Console.WriteLine("e attack: " + enemyAttack3 + " e HP: " + enemyHP);

                        if (ourAttack3 > (1.05 * enemyHP))
                        {
                            if ((WHP3 + AHP3) <= enemyAttack3)
                            {
                                Console.WriteLine("This fight is over!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                //if(WHP3 <= 0)
                                //{
                                //    AHP3 = (double)(AHP3 + WHP3);
                                //}
                                //ourHP3 = (double)((WHP3 + AHP3) - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                //thirdSoldiers = (int)(ourHP3 / Gameplay.Whealth);
                                thirdWarriors = 0;
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You won this fight!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                //ourHP3 = (double)((WHP3 + AHP3) - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                thirdWarriors = (int)(WHP3 / Gameplay.Whealth);
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = (int)(AHP3 / Gameplay.Ahealth);
                                if (quan <= 0) i = 4;
                                continue;
                            }

                        }

                        else if (ourAttack3 <= (1.05 * enemyHP) && ourAttack3 >= (0.95 * enemyHP))
                        {
                            if ((WHP3 + AHP3) <= enemyAttack3)
                            {
                                Console.WriteLine("This fight is over!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                thirdWarriors = 0;
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 85)
                                {
                                    Console.WriteLine("This fight is over!");
                                    WHP3 = (double)(WHP3 - enemyAttack3);
                                    enemyHP = (double)(enemyHP - ourAttack3);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    thirdWarriors = (int)(WHP3 / Gameplay.Whealth);
                                    if ((thirdWarriors) <= 0)
                                    {
                                        AHP3 = (double)(AHP3 + WHP3);
                                    }
                                    thirdArchers = (int)(AHP3 / Gameplay.Ahealth);
                                    if (quan <= 0) i = 4;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    WHP3 = (double)(WHP3 - enemyAttack3);
                                    enemyHP = (double)(enemyHP - ourAttack3);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    thirdWarriors = 0;
                                    if ((thirdWarriors) <= 0)
                                    {
                                        AHP3 = (double)(AHP3 + WHP3);
                                    }
                                    thirdArchers = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack3 <= (0.95 * enemyHP) && ourAttack3 >= (0.85 * enemyHP))
                        {
                            if ((WHP3 + AHP3) <= enemyAttack3)
                            {
                                Console.WriteLine("This fight is over!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                thirdWarriors = 0;
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                int checkIfWin = rnd.Next(101);
                                if (checkIfWin < 15)
                                {
                                    Console.WriteLine("This fight is over!");
                                    WHP3 = (double)(WHP3 - enemyAttack3);

                                    enemyHP = (double)(enemyHP - ourAttack3);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    thirdWarriors = (int)(WHP3 / Gameplay.Whealth);
                                    if ((thirdWarriors) <= 0)
                                    {
                                        AHP3 = (double)(AHP3 + WHP3);
                                    }
                                    thirdArchers = (int)(AHP3 / Gameplay.Ahealth);
                                    if (quan <= 0) i = 4;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("This fight is over!");
                                    WHP3 = (double)(WHP3 - enemyAttack3);
                                    enemyHP = (double)(enemyHP - ourAttack3);
                                    quan = (int)(enemyHP / oneEnemyHP);
                                    thirdWarriors = 0;
                                    if ((thirdWarriors) <= 0)
                                    {
                                        AHP3 = (double)(AHP3 + WHP3);
                                    }
                                    thirdArchers = 0;
                                    if (quan <= 0) i = 4;
                                    break;
                                }
                            }
                        }

                        else if (ourAttack3 < 0.85 * enemyHP)
                        {
                            if ((WHP3 + AHP3) <= enemyAttack3)
                            {
                                Console.WriteLine("You lost this fight!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                thirdWarriors = 0;
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = 0;
                                if (quan <= 0) i = 4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You lost this fight!");
                                WHP3 = (double)(WHP3 - enemyAttack3);
                                enemyHP = (double)(enemyHP - ourAttack3);
                                quan = (int)(enemyHP / oneEnemyHP);
                                thirdWarriors = 0;
                                if ((thirdWarriors) <= 0)
                                {
                                    AHP3 = (double)(AHP3 + WHP3);
                                }
                                thirdArchers = 0;
                                if (quan <= 0) i = 4;
                                continue;
                            }
                        }

                        else
                            break;

                    case 4:
                        Program.Loading(". . .\n");
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThe second battle is over");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;



                }

            }

            Gameplay.Wquantity = firstWarriors + secondWarriors + thirdWarriors;
            Gameplay.Aquantity = thirdArchers;

            if (Gameplay.Wquantity <= 0) Gameplay.Wquantity = 0;
            if (Gameplay.Aquantity <= 0) Gameplay.Aquantity = 0;
            //Console.WriteLine("w i a:" + Gameplay.Wquantity + "  " + Gameplay.Aquantity);


        }

    }
}
