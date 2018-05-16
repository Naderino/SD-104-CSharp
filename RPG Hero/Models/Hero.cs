using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication1.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public int Health { get; set; }
        public int Lvl { get; set; }
        public int AttackPower { get; set; }
        public int CurrentExp { get; set; }

        public Hero()
        {
            Health = 5;
            Lvl = 1;
            AttackPower = 2;
            CurrentExp = 0;
        }

        public void LevelUp()
        {
            int timesToLevel = this.CurrentExp / 40;
            if (timesToLevel > 0)
            {
                Lvl += timesToLevel;
                Console.WriteLine("Hero Leveled Up!!" + "New Level: " + Lvl);
                AttackPower += timesToLevel * 5;
                Health += 3 * Lvl;
                CurrentExp -= timesToLevel * 40;
            }
        }
        
        public void Attack(Monster monster)
        {
            monster.health -= this.AttackPower;
        }

        public bool isDead()
        {
            if (Health <= 0)
                return true;
            else
                return false;
        }
    }
}
