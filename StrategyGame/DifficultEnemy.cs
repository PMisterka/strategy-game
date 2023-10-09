using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    class DifficultEnemy : Enemy
    {

        public double bonus;
        public DifficultEnemy(int Health, double Strength, int Quantity, double Attack, double rndBonus) : base(Health, Strength, Quantity, Attack)
        {
            bonus = rndBonus;
        }


        public override int Health()
        {
            return health;

        }
        public override double Strength()
        {
            return strength * bonus;
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
