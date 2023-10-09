using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class Money
    {
        public int _money;
       /* 
         * public int _Mon
        {
            get { return _money; }
            set{ _money = 1000; }
        }
        */

        public Money(int _Money)
        {
            _money = _Money;
        }

        public static int AddMoney(int add)
        {
            
            Program.startMoney = Program.startMoney + add;
            return Program.startMoney;
        } 

        public static int FoodMoney(int minus)
        {
            Program.startMoney = Program.startMoney - minus;
            return Program.startMoney;
        }
        
    }
}
