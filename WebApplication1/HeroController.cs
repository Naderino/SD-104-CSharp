using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1
{
    public class HeroController : Controller
    {
        private HeroContext db = new HeroContext();

        // GET: Hero
        public async Task<ActionResult> Index()
        {
            return View(await db.Heroes.ToListAsync());
        }

        // GET: Hero/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
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
        public async Task<ActionResult> Create([Bind(Include = "Id,health,level,attackPower,currentExp")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Heroes.Add(hero);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Hero/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Hero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,health,level,attackPower,currentExp")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hero).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        // GET: Hero/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Hero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Hero hero = await db.Heroes.FindAsync(id);
            db.Heroes.Remove(hero);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
