using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Ice_Task
{
    class Enemy
    {
        private string name;
        private int HP;
        private int damage;
        private int criticalChance;
        private int type;

        public int randomiseHP(int min, int max)
        {
            Random r = new Random();
            r.Next(min, max);
            return r.Next(min, max);

        }
        public int randomiseDamage(int min, int max)
        {
            Random r = new Random();
            r.Next(min, max);
            return r.Next(min, max);
        }

        public int randomiseCrit(int min, int max)
        {
            Random r = new Random();
            r.Next(min, max);
            return r.Next(min, max);
        }

        public int rollEnemyType() 
        {
            switch (switch_on)
            {
                case 1:
                    "a.	1: Goblin";
                    break;
                case 2:
                    "b.	2: Dragon";
                    break;
                case 3:
                    "c.	3: Ugandan Knuckles";
                    break;
            }
        }
    }
}
