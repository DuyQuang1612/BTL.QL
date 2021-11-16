using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMQLSQA.Models;
using PMQLSQA.Models.Process;
namespace PMQLSQA.Controllers
{
    public class CreateAccountsController : Controller
    {
        private PMQLSQADbContext db = new PMQLSQADbContext();
        private StringProcess m = new StringProcess();
        // GET: CreateAccounts
        public ActionResult Index()
        {
            return View(db.CreateAccounts.ToList());
        }

        // GET: CreateAccounts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateAccount createAccount = db.CreateAccounts.Find(id);
            if (createAccount == null)
            {
                return HttpNotFound();
            }
            return View(createAccount);
        }

        // GET: CreateAccounts/Create
        public ActionResult Create()
        {
            var x3 = db.CreateAccounts.ToList();
            if (x3.Count == 0)
            {
                ViewBag.MaUser = "STT001";
            }
            else
            {
                var y3 = x3.OrderByDescending(m => m.MaUser).FirstOrDefault().MaUser;
                var newKey3 = m.AutoGenerateKey3(y3);
                ViewBag.MaUser = newKey3;
            }
            return View();
        }

        // POST: CreateAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaUser,FirstName,LastName,Email,Username,Password,ConfirmPassword")] CreateAccount createAccount)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.CreateAccounts.Add(createAccount);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Khoa chinh bi trung,vui long nhap lai");
                return View(createAccount);
            }


            return View(createAccount);
        }

        // GET: CreateAccounts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateAccount createAccount = db.CreateAccounts.Find(id);
            if (createAccount == null)
            {
                return HttpNotFound();
            }
            return View(createAccount);
        }

        // POST: CreateAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaUser,FirstName,LastName,Email,Username,Password,ConfirmPassword")] CreateAccount createAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createAccount);
        }

        // GET: CreateAccounts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateAccount createAccount = db.CreateAccounts.Find(id);
            if (createAccount == null)
            {
                return HttpNotFound();
            }
            return View(createAccount);
        }

        // POST: CreateAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CreateAccount createAccount = db.CreateAccounts.Find(id);
            db.CreateAccounts.Remove(createAccount);
            db.SaveChanges();
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
