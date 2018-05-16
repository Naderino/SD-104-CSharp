using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            List<Monster> monsters = new List<Monster>();
            Random r = new Random();
            const int NUM_OF_MONSTERS = 10;
            for (int i = 0; i < NUM_OF_MONSTERS; i++)
            {
                int level = r.Next(1, 10);
                int rand = r.Next(1,7);
                switch (rand)
                {
                    case 1:
                        monsters.Add(new Goblin(level));
                        break;
                    case 2:
                        monsters.Add(new SpearGoblin(level));
                        break;
                    case 3:
                        monsters.Add(new Skeleton(level));
                        break;
                    case 4:
                        monsters.Add(new HoodedGoblin(level));
                        break;
                    case 5:
                        monsters.Add(new Zombie(level));
                        break;
                    case 6:
                        monsters.Add(new Zombie(level));
                        break;
                }
            }

            return View(monsters);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}