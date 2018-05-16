using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RPG_Hero.Models;
using WebApplication1.Models;

namespace RPG_Hero.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            RPG_HeroContext context = new RPG_HeroContext();
            List<Hero> heroes = context.getAllHeroes();
            return View(heroes);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            RPG_HeroContext context = new RPG_HeroContext();
            Hero hero = context.GetHeroById(id);
            return View(hero);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            hero.Health = Int32.Parse(Request.Form["Health"].ToString());
            hero.Lvl = Int32.Parse(Request.Form["Lvl"].ToString());
            hero.AttackPower = Int32.Parse(Request.Form["AttackPower"].ToString());
            hero.CurrentExp = hero.Lvl = Int32.Parse(Request.Form["CurrentExp"].ToString());

            RPG_HeroContext context = new RPG_HeroContext();
            context.Create(hero);

            return RedirectToAction("Index");
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();

        }

        // POST: Hero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Health,Lvl,AttackPower,CurrentExp")] Hero hero)
        {
            RPG_HeroContext context = new RPG_HeroContext();
            context.EditById(hero);
            return RedirectToAction("Index");
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            RPG_HeroContext context = new RPG_HeroContext();
            Hero hero = context.GetHeroById(id);
            return View(hero);
        }

        // POST: Hero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            RPG_HeroContext context = new RPG_HeroContext();
            context.DeleteHero(id);
            return RedirectToAction("Index");

        }
    }
}
