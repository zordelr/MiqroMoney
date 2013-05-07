using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiqroMoney.Models;

namespace MiqroMoney.Controllers
{
    public class MerchantProcessingController : Controller
    {
        private MIDContext db = new MIDContext();

        //
        // GET: /MerchantProcessing/

        public ActionResult Index()
        {
            return View(db.mid.ToList());
        }

        //
        // GET: /MerchantProcessing/Details/5

        public ActionResult Details(int id = 0)
        {
            MerchantProcessingIDs merchantprocessingids = db.mid.Find(id);
            if (merchantprocessingids == null)
            {
                return HttpNotFound();
            }
            return View(merchantprocessingids);
        }

        //
        // GET: /MerchantProcessing/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MerchantProcessing/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MerchantProcessingIDs merchantprocessingids)
        {
            if (ModelState.IsValid)
            {
                db.mid.Add(merchantprocessingids);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(merchantprocessingids);
        }

        //
        // GET: /MerchantProcessing/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MerchantProcessingIDs merchantprocessingids = db.mid.Find(id);
            if (merchantprocessingids == null)
            {
                return HttpNotFound();
            }
            return View(merchantprocessingids);
        }

        //
        // POST: /MerchantProcessing/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MerchantProcessingIDs merchantprocessingids)
        {
            if (ModelState.IsValid)
            {
                db.Entry(merchantprocessingids).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(merchantprocessingids);
        }

        //
        // GET: /MerchantProcessing/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MerchantProcessingIDs merchantprocessingids = db.mid.Find(id);
            if (merchantprocessingids == null)
            {
                return HttpNotFound();
            }
            return View(merchantprocessingids);
        }

        //
        // POST: /MerchantProcessing/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MerchantProcessingIDs merchantprocessingids = db.mid.Find(id);
            db.mid.Remove(merchantprocessingids);
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