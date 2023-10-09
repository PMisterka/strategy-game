using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class Warrior : Soldier
    {
        public double areaBonus;
        public Warrior(int Health, double Strength, int Quantity, double AreaBonus) : base(Health, Strength, Quantity)
        {
            areaBonus = AreaBonus;
        }
        public override int Health()
        {
            return health;

        }
        public override double Strength()
        {
            return strength;
        }
        public override int Quantity()
        {
            return quantity;
        }
      
       
        public double AreaBonus()
        {
            return areaBonus;
        }

    }
}
