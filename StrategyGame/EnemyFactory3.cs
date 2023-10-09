using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class EnemyFactory3 : EnemyFactory
    {
        // public static double rand;
        public override Enemy rndEnemy(int r)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(60, 71);
            double rand = rnd.Next(2, 4);
            double strength = DifficultEnemy.strength;
            double attack = strength * quantity;

            switch (r)
            {
                case 1:
                    return new DifficultEnemy(80, 9.5, quantity, attack, rand);

                case 2:
                    return new DifficultEnemy(90, 9.0, quantity, attack, rand);

                case 3:
                    return new DifficultEnemy(75, 9.5, quantity, attack, rand);

                default:
                    break;

            }

            return null;

        }
    }
}
