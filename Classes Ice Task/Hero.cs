using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Ice_Task
{
    class Hero
    {
        private string name;
        private int HP;
        private int damage;
        private int criticalChance;

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
    }
    }
