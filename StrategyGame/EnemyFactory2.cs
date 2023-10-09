using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class EnemyFactory2 : EnemyFactory
    {
       // public static double rand;
        public override Enemy rndEnemy(int r)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(40, 51);
            double rand = rnd.Next(1, 3);
            double strength = DifficultEnemy.strength;
            double attack = strength * quantity;

            switch (r)
            {
                case 1:
                    return new DifficultEnemy(60, 8.5, quantity, attack, rand);

                case 2:
                    return new DifficultEnemy(70, 9.0, quantity, attack, rand);

                case 3:
                    return new DifficultEnemy(75, 9.5, quantity, attack, rand);

                default:
                    break;

            }

            return null;

        }
    }
}
