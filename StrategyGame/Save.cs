using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;
using System.Text.Json;

namespace StrategyGame
{
    class Save
    {
        public static void SaveToTxt(string checkWin)
        {


            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Results.txt";
            // string path = @"C:\Users\patee\source\repos\StrategyGame\Results.txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(checkWin);
                sw.WriteLine("After all the battles, you have: ");
                sw.WriteLine(Gameplay.Wquantity + " warriors");
                sw.WriteLine(Gameplay.Aquantity + " archers");
                sw.WriteLine(Program.startMoney + "$");
                sw.WriteLine("Altogether, you fought against " + (Battle1.quantityOfAllEnemies + Battle2.quantityOfAllEnemies + Battle3.quantityOfAllEnemies) + " enemies");

            }

        }
        public static string checkWin;

        public string Result { get; set; }
        public int Warriors { get; set; }
        public int Archers { get; set; }
        public int Money { get; set; }
        public string _1 { get; set; }
        public int NumberOfEnemies { get; set; }
        
        public Save()
        {
            Result = checkWin;
            _1 = "After all the battles, you have: ";
            Warriors = Gameplay.Wquantity;
            Archers = Gameplay.Aquantity;
            Money = Program.startMoney;
            NumberOfEnemies = (Battle1.quantityOfAllEnemies + Battle2.quantityOfAllEnemies + Battle3.quantityOfAllEnemies);
            

        }

        public static void SaveToJSON()
        {
            Save example1 = new Save();
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
            string example1AsJson = JsonSerializer.Serialize(example1, options);

            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Results.json";
           // string fileName = @"C:\Users\patee\source\repos\StrategyGame\Results.json";
            File.WriteAllText(fileName, example1AsJson);

        }

    }
}
