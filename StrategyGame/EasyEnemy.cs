using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class EasyEnemy : Enemy
    {
        public EasyEnemy(int Health, double Strength, int Quantity, double Attack) : base(Health, Strength, Quantity, Attack)
        {

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
        public override double Attack()
        {
            attack = strength * quantity;
            return attack;
        }
       

    }
}
