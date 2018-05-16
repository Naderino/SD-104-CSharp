using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Skeleton:Monster
    {
            public Skeleton()
            {
            }
            public Skeleton(int level)
            {
                name = "Skeleton";
                if (level == 1)
                    attackPower = 1;
                else
                    attackPower = level;
                health = 2 * level;
                this.level = level;
            }
            public override void Attack(Hero hero)
            {
                hero.Health -= attackPower;
            }

    }
}