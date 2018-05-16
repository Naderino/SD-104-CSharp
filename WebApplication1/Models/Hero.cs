using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication1.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public int health { get; set; }
        public int level { get; set; }
        public int attackPower { get; set; }
        public int currentExp { get; set; }

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
