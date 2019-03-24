using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Pet911Website.Models;
using Pet911Website.ViewModels;

namespace Pet911Website.Controllers
{
    public class AnimalKindsController : Controller
    {
        private Pet911WebsiteContext db = new Pet911WebsiteContext();

        // GET: AnimalKinds
        public ActionResult Index()
        {
            return View(db.AnimalKinds.ToList());
        }

        // GET: AnimalKinds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalKind animalKind = db.AnimalKinds.Find(id);
            if (animalKind == null)
            {
                return HttpNotFound();
            }
            return View(new AnimalKindViewModel
            {
                AnimalKind = animalKind,
                Breeds = db.Breeds.Where(breed => breed.AnimalKind.Id == id).ToList()
            });
        }

        // GET: AnimalKinds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalKinds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] AnimalKind animalKind)
        {
            if (ModelState.IsValid)
            {
                db.AnimalKinds.Add(animalKind);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animalKind);
        }

        // GET: AnimalKinds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalKind animalKind = db.AnimalKinds.Find(id);
            if (animalKind == null)
            {
                return HttpNotFound();
            }
            return View(animalKind);
        }

        // POST: AnimalKinds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] AnimalKind animalKind)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalKind).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalKind);
        }

        // GET: AnimalKinds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalKind animalKind = db.AnimalKinds.Find(id);
            if (animalKind == null)
            {
                return HttpNotFound();
            }
            return View(animalKind);
        }

        // POST: AnimalKinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalKind animalKind = db.AnimalKinds.Find(id);
            db.AnimalKinds.Remove(animalKind);
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
