using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    abstract class Enemy
    {
        public static int health;
        public static double strength;
        public static int quantity;
        public static double attack;

        public Enemy (int Health, double Strength, int Quantity, double Attack)
        {
            health = Health;
            strength = Strength;
            quantity = Quantity;
            attack = Attack;
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
       
        public virtual double Attack()
        {
            attack = strength * quantity;
            return attack;
        }
    }
}
