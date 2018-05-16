using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ZombieArcher:Zombie
    {
        public ZombieArcher()
        {
        }
        public ZombieArcher(int level)
        {
            name = "Zombie Archer";
            range = 1;
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 3 * level;
            this.level = level;
        }
        public override void Attack(Hero hero)
        {
            hero.Health -= attackPower;
        }
    }
}