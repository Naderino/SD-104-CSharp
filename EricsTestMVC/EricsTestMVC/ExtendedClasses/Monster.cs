using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EricsTestMVC.Models
{
    public partial class Monster
    {

        [NotMapped]
        public virtual Weapon Weapon1 { get; set; }
    }
}
