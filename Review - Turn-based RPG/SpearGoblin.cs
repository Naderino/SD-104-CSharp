using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    class SpearGoblin : Goblin
    {
        public SpearGoblin ( int level )
        {
            name = "Spear Goblin";
            range = level * 2;
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 2 * level;
            this.level = level;
        }

        public override void Attack(Hero hero)
        {
            hero.health -= attackPower + range;
        }
    }
}
