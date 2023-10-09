using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StrategyGame
{
    class Gameplay
    {
        //Warrior's properties
        public static int Whealth = 100;
        public static double Wstrength = 20.0;
        public static int Wquantity = 100;
        public static double WareaBonus = 2.5;
        
        //Archer's properties
        public static int Ahealth = 85;
        public static double Astrength = 22.5;
        public static int Aquantity = 100;
        public static double AareaBonus = 2.7;
        
        /*
        public static void StartSoldiers(Soldier soldier)
        {
            Whealth = 100;
            Wstrength = 10.0;
            Wquantity = 100;
            WareaBonus = 0.5;
            Warrior warrior = new Warrior(Whealth, Wstrength, Wquantity, WareaBonus);

            Ahealth = 85;
            Astrength = 12.5;
            Aquantity = 50;
            AareaBonus = 1.5;
            Archer archer = new Archer(Ahealth, Astrength, Aquantity, AareaBonus);

        }
        */

        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }

        public static bool Y_N_Shop()
        {
            bool goodChoice;
            do
            {
                goodChoice = true;             

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        Shop();
                        Shopping();
                        Console.WriteLine("\nDo you want to keep buying resources or hiring mercenaries? ");
                        Console.WriteLine("[Y / N]");
                        Y_N_Shop();
                        break;

                    case ConsoleKey.N:
                        break;

                    default:
                        goodChoice = false;
                        Console.WriteLine("\nInvalid Selection please select Y or N\n");
                        break;
                }
            } while (!goodChoice);  return (true);
        }

        
        public static bool Shopping()
        {
            bool choice;
            do
            {
                choice = true;

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Mercinaries();
                        continue;
                    case ConsoleKey.NumPad1:
                        Mercinaries();
                        continue;

                    case ConsoleKey.D2:
                        warriorsWeapons();
                        continue;
                    case ConsoleKey.NumPad2:
                        warriorsWeapons();
                        continue;

                    case ConsoleKey.D3:
                        archersWeapons();
                            continue;
                    case ConsoleKey.NumPad3:
                        archersWeapons();
                        continue;

                    case ConsoleKey.D4:
                        upgradeSoldiersArmor();
                        continue;
                    case ConsoleKey.NumPad4:
                        upgradeSoldiersArmor();
                        continue;

                    case ConsoleKey.D5:
                        Info();
                        continue;
                    case ConsoleKey.NumPad5:
                        Info();
                        continue;

                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.NumPad6:
                        break;

                    default:
                        choice = false;
                        Console.WriteLine("\nInvalid Selection\n");
                        break;
                }
            } while (!choice); return (true);
        }
        public static void Shop()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Shop: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n1. Hire mercinaries ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("500$ (for one soldier)");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n2. Upgrade warriors' weapons ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("85$ (times number of warriors)");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n3. Upgrade archers' weapons ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("100$ (times number of archers)");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n4. Upgrade soldiers' armor ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("50$ (times number of soldiers)");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n5. Info");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n6. End of the transaction\n");
            
        }

        public static int Mercinaries()
        {
            Console.WriteLine("\nHow many mercinaries would you like to hire?\n" +
                "Number of mericnaries: ");
            int numberOfMercinaries = ReadInt32(Console.ReadLine());
            int price = numberOfMercinaries * 500;


            if (Program.startMoney < price)
            {
                Console.WriteLine("\nYou don't have enough money for " + numberOfMercinaries + " mercinaries!");
                return numberOfMercinaries;
            }
            else
            {
                int x = Program.startMoney;
                x = x - price;
                Console.WriteLine("This will cost you " + price + "$\n" +
                    "If you want to cancel press C, if you want to continue - press any other key.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was cancelled. You still have " + Program.startMoney);
                        Console.ForegroundColor = ConsoleColor.White;
                        return 0;
                    default:
                        Program.startMoney = x;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was succesful. You now have " + Program.startMoney + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Wquantity = Wquantity + numberOfMercinaries;
                        return Program.startMoney;
                }
            }
        }
        public static void warriorsWeapons()
        {
            int price = 85 * Wquantity;
            if (Program.startMoney < price)
            {
                Console.WriteLine("\nYou don't have enough money!");
            }
            else
            {
                int x = Program.startMoney;
                x = x - price;
                Console.WriteLine("\nUpgrading your warriors' weapons will cost you " + price + "$\n" +
                    "If you want to cancel press C, if you want to continue - press any other key.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was cancelled. You still have " + Program.startMoney);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Program.startMoney = x;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was succesful. You now have " + Program.startMoney + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Wstrength = Wstrength + 6.5;
                        break;
                }
            }
        }
        public static void archersWeapons()
        {
            int price = 100 * Aquantity;
            if (Program.startMoney < price)
            {
                Console.WriteLine("\nYou don't have enough money!");
            }
            else
            {
                int x = Program.startMoney;
                x = x - price;
                Console.WriteLine("\nUpgrading your archers' weapons will cost you " + price + "$\n" +
                    "If you want to cancel press C, if you want to continue - press any other key.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was cancelled. You still have " + Program.startMoney);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Program.startMoney = x;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was succesful. You now have " + Program.startMoney + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Astrength = Astrength + 5.5;
                        break;
                }
            }
        }
        public static void upgradeSoldiersArmor()
        {
            int quantity = Aquantity + Wquantity;
            int price = 50 * quantity;
            if (Program.startMoney < price)
            {
                Console.WriteLine("\nYou don't have enough money!");
            }
            else
            {
                int x = Program.startMoney;
                x = x - price;
                Console.WriteLine("\nThis will cost you " + price + "$\n" +
                    "If you want to cancel press C, if you want to continue - press any other key.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was cancelled. You still have " + Program.startMoney);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Program.startMoney = x;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Transaction was succesful. You now have " + Program.startMoney + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Whealth = Whealth + 15;
                        Ahealth = Ahealth + 15;
                        break;
                }
            }
        }

        public static void Info()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nMercinaries are soldiers who will fight as warriors for a small fee.");

            Thread.Sleep(500);

            Console.WriteLine("\nWhen upgrading warriors and archers' weapons or armor you have to improve all of your soldiers' equipment. \n" +
                "You don't want anybody to feel excluded, do you?");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
