using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes_Ice_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hero hero = new Hero();
            Enemy enemy = new Enemy();

            hero.randomiseCrit(7,6);
            hero.randomiseDamage(9,5);
            hero.randomiseHP(3,6);

            enemy.randomiseCrit(1,18);
            enemy.randomiseDamage(5,9);
            enemy.randomiseHP(4,7);




        }   
    }
}
