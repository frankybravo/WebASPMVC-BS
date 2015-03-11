using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASPMVC_BS.Models;
using WebASPMVC_BS.FirstDBModel;

namespace WebASPMVC_BS.Controllers
{
    public class SwapController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Swap/

        public ActionResult Index()
        {
            return View(db.SWAPs.ToList());
        }

        //
        // GET: /Swap/Details/5

        public ActionResult Details(long id = 0)
        {
            SWAP swap = db.SWAPs.Find(id);
            if (swap == null)
            {
                return HttpNotFound();
            }
            return View(swap);
        }

        //
        // GET: /Swap/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Swap/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SWAP swap)
        {
            if (ModelState.IsValid)
            {
                db.SWAPs.Add(swap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(swap);
        }

        //
        // GET: /Swap/Edit/5

        public ActionResult Edit(long id = 0)
        {
            SWAP swap = db.SWAPs.Find(id);
            if (swap == null)
            {
                return HttpNotFound();
            }
            return View(swap);
        }

        //
        // POST: /Swap/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SWAP swap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(swap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(swap);
        }

        //
        // GET: /Swap/Delete/5

        public ActionResult Delete(long id = 0)
        {
            SWAP swap = db.SWAPs.Find(id);
            if (swap == null)
            {
                return HttpNotFound();
            }
            return View(swap);
        }

        //
        // POST: /Swap/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SWAP swap = db.SWAPs.Find(id);
            db.SWAPs.Remove(swap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}