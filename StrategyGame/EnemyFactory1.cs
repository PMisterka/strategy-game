using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class EnemyFactory1 : EnemyFactory
    {

        public override Enemy rndEnemy(int r)
        {
            Random rnd = new Random();
            int quantity = rnd.Next(30, 41);
            double attack = Enemy.strength * quantity;

            switch (r)
            {
                case 1:
                    return new EasyEnemy(55, 7.5, quantity, attack);
                
                case 2:
                    return new EasyEnemy(60, 8.5, quantity, attack);

                case 3:
                    return new EasyEnemy(60, 9.0, quantity, attack);

                default:
                    break;

            }

            return null;
           
        }
    }
}
