using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Pet911Website.Models;
using Pet911Website.ViewModels;

namespace Pet911Website.Controllers
{
    public class BreedsController : Controller
    {
        private Pet911WebsiteContext db = new Pet911WebsiteContext();

        // GET: Breeds
        public ActionResult Index()
        {
            return View(new AnimalKindViewModel
            {
                Breeds = db.Breeds.ToList()
            });
        }

        // GET: Breeds/Details/5
        public ActionResult Details(int? id, int? animalId)
        {
            if (id == null || animalId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }

            breed.AnimalKind = db.AnimalKinds.SingleOrDefault(animal => animal.Id == animalId);
            return View(breed);
        }

        // GET: Breeds/Create
        public ActionResult Create(int? animalId)
        {
            return View(new Breed
            {
                AnimalKind = db.AnimalKinds.SingleOrDefault(animal => animal.Id == animalId)
            });
        }

        // POST: Breeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,AnimalKind")] Breed breed)
        {
            var animalId = breed.AnimalKind.Id;
            breed.AnimalKind = db.AnimalKinds.Single(animal => animal.Id == animalId);
            if (ModelState.IsValid)
            {
                db.Breeds.Add(breed);
                db.SaveChanges();
                return RedirectToAction("Details", "AnimalKinds", new { id = animalId });
            }

            return View(breed);
        }

        // GET: Breeds/Edit/5
        public ActionResult Edit(int? id, int? animalId)
        {
            if (id == null || animalId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }
            breed.AnimalKind = db.AnimalKinds.SingleOrDefault(animal => animal.Id == animalId);
            return View(breed);
        }

        // POST: Breeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,AnimalKind")] Breed breed)
        {
            var animalId = breed.AnimalKind.Id;
            breed.AnimalKind = db.AnimalKinds.Single(animal => animal.Id == animalId);
            if (ModelState.IsValid)
            {
                db.Entry(breed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "AnimalKinds", new { id = animalId });
            }
            return View(breed);
        }

        // GET: Breeds/Delete/5
        public ActionResult Delete(int? id, int? animalId)
        {
            if (id == null || animalId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return HttpNotFound();
            }
            breed.AnimalKind = db.AnimalKinds.SingleOrDefault(animal => animal.Id == animalId);
            return View(breed);
        }
         
        // POST: Breeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Breed breed = db.Breeds.Include(x => x.AnimalKind).SingleOrDefault(x => x.Id == id);
            var animalId = breed.AnimalKind.Id;
            db.Breeds.Remove(breed);
            db.SaveChanges();
            return RedirectToAction("Details", "AnimalKinds", new { id = animalId });
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
