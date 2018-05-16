using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication1.Models
{
    public abstract class Monster
    {
        public int health { get; set; }
        public int level { get; set; }
        public int attackPower { get; set; }
        public int range { get; set; }
        public string name { get; set; }

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
