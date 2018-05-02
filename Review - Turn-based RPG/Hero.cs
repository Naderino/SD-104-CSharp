using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    class Hero
    {
        public int health;
        public int level;
        public int attackPower;
        public int currentExp;

        public Hero()
        {
            health = 5;
            level = 1;
            attackPower = 2;
            currentExp = 0;
        }

        public void LevelUp()
        {
            int timesToLevel = this.currentExp / 40;
            if (timesToLevel > 0)
            {
                level += timesToLevel;
                Console.WriteLine("Hero Leveled Up!!" + "New Level: " + level);
                attackPower += timesToLevel * 5;
                health += 3 * level;
                currentExp -= timesToLevel * 40;
            }
        }
        
        public void Attack(Monster monster)
        {
            monster.health -= this.attackPower;
        }

        public bool isDead()
        {
            if (health <= 0)
                return true;
            else
                return false;
        }
    }
}
