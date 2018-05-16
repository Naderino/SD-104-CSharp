using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Models
{
    public class Goblin : Monster
    {
        public Goblin()
        {

        }

        public Goblin ( int level )
        {
            name = "Goblin";
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 2 * level;
            this.level = level;
        }

        public override void Attack(Hero hero)
        {
            hero.Health -= attackPower;
        }
    }
}
