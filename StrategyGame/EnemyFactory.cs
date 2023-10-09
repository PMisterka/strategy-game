using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyGame
{
    abstract class EnemyFactory
    {
        
        public abstract Enemy rndEnemy(int r);
    }
}
