using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EricsTestMVC.Models
{
    public partial class Hero
    {
        public void LevelUp()
        {
            this.LVL += 1;
            this.Health += 50;
        }

        [NotMapped]
        public Weapon HeroWeapon { get; set; }

    }
}