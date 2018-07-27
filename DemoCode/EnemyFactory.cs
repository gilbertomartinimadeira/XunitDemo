using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class EnemyFactory
    {
        public object CreateEnemy(bool isBoss)
        {
            if(isBoss)
            {
                return new BossEnemy();
            }
            return new NormalEnemy();
            
        }
    }
}
