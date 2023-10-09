using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    abstract class Soldier
    {
        public int health;
        public double strength;
        public int quantity;


        public Soldier(int Health, double Strength,   int Quantity)
        {
            health = Health;
            strength = Strength;
            quantity = Quantity;
        }

        public virtual int Health()
        {
            return health;
        }

        public virtual double Strength()
        {
            return strength;
        }
       


        public virtual int Quantity()
        {
            return quantity;
        }
    }


}
