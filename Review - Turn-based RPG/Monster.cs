using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    abstract class Monster
    {
        public int health;
        public int level;
        public int attackPower;
        public int range;
        public string name;

        public abstract void Attack(Hero hero);

        public bool isDead()
        {
            if (health <= 0)
                return true;
            else
                return false;
        }
    }
}
