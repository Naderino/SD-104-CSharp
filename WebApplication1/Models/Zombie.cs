using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Zombie:Monster
    {
        public Zombie()
        {
        }
        public Zombie(int level)
        {
            name = "Zombie";
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 3 * level;
            this.level = level;
        }
        public override void Attack(Hero hero)
        {
            hero.health -= attackPower;
        }
    }
}