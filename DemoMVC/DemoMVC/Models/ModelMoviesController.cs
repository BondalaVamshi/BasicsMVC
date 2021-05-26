using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace DemoMVC.Models
{
    public class ModelMoviesController : Controller
    {
        private MoviesDb db = new MoviesDb();

        // GET: ModelMovies
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: ModelMovies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelMovie modelMovie = db.Movies.Find(id);
            if (modelMovie == null)
            {
                return HttpNotFound();
            }
            return View(modelMovie);
        }

        // GET: ModelMovies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] ModelMovie modelMovie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(modelMovie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelMovie);
        }

        // GET: ModelMovies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelMovie modelMovie = db.Movies.Find(id);
            if (modelMovie == null)
            {
                return HttpNotFound();
            }
            return View(modelMovie);
        }

        // POST: ModelMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] ModelMovie modelMovie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelMovie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelMovie);
        }

        // GET: ModelMovies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelMovie modelMovie = db.Movies.Find(id);
            if (modelMovie == null)
            {
                return HttpNotFound();
            }
            return View(modelMovie);
        }

        // POST: ModelMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelMovie modelMovie = db.Movies.Find(id);
            db.Movies.Remove(modelMovie);
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
