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
    public class PhieuXuatsController : Controller
    {
        private PMQLSQADbContext db = new PMQLSQADbContext();
        private StringProcess h = new StringProcess();
        // GET: PhieuXuats
        public ActionResult Index()
        {
            return View(db.PhieuXuats.ToList());
        }

        // GET: PhieuXuats/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuats/Create
        public ActionResult Create()
        {
            var x5 = db.PhieuXuats.ToList();
            if (x5.Count == 0)
            {
                ViewBag.MaPhieuXuat = "STT001";
            }
            else
            {
                var y5 = x5.OrderByDescending(m => m.MaPhieuXuat).FirstOrDefault().MaPhieuXuat;
                var newKey5 = h.AutoGenerateKey5(y5);
                ViewBag.MaPhieuXuat = newKey5;
            }
            return View();
        }

        // POST: PhieuXuats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuXuat,SanPhamXuat,SoLuongXuat,NgayXuatHang,NguoiBan,KhachHangMua")] PhieuXuat phieuXuat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.PhieuXuats.Add(phieuXuat);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Khoa chinh bi trung,vui long nhap lai");
                return View(phieuXuat);
            }


            return View(phieuXuat);
        }

        // GET: PhieuXuats/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // POST: PhieuXuats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuXuat,SanPhamXuat,SoLuongXuat,NgayXuatHang,NguoiBan,KhachHangMua")] PhieuXuat phieuXuat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuXuat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phieuXuat);
        }

        // GET: PhieuXuats/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            if (phieuXuat == null)
            {
                return HttpNotFound();
            }
            return View(phieuXuat);
        }

        // POST: PhieuXuats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PhieuXuat phieuXuat = db.PhieuXuats.Find(id);
            db.PhieuXuats.Remove(phieuXuat);
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
