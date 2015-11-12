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
    public class TrackController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Track/

        public ActionResult Index()
        {
            return View(db.TRACKs.ToList());
        }

        public ActionResult IndexCarousel()
        {
            return View(db.TRACKs.ToList());
        }

        //
        // GET: /Track/Details/5

        public ActionResult Details(int id = 0)
        {
            TRACK track = db.TRACKs.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            return View(track);
        }

        //
        // GET: /Track/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Track/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TRACK track)
        {
            if (ModelState.IsValid)
            {
                int new_id = 0;
                if (db.TRACKs.Any())
                {
                    new_id = db.TRACKs.Max(TRACK => TRACK.id) + 1;
                
                }
                track.id = new_id;
                
                db.TRACKs.Add(track);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(track);
        }

        //
        // GET: /Track/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TRACK track = db.TRACKs.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            return View(track);
        }

        //
        // POST: /Track/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TRACK track)
        {
            if (ModelState.IsValid)
            {
                db.Entry(track).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(track);
        }

        //
        // GET: /Track/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TRACK track = db.TRACKs.Find(id);
            if (track == null)
            {
                return HttpNotFound();
            }
            return View(track);
        }

        //
        // POST: /Track/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRACK track = db.TRACKs.Find(id);
            db.TRACKs.Remove(track);
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