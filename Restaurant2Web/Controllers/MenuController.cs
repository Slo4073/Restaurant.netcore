using Microsoft.AspNetCore.Mvc;
using Restaurant.DataAccess;
using Restaurant2.Models;

namespace Restaurant2Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Menu> objCustomerList = _db.Menus;
            return View(objCustomerList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Menu obj)
        {
            if(ModelState.IsValid)
            {
                _db.Menus.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View(obj);
        }

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var menuFromDb = _db.Menus.Find(id);

            if (menuFromDb == null)
            {
                return NotFound();
            }
            return View(menuFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Menu obj)
        {
            if (ModelState.IsValid)
            {
                _db.Menus.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var menuFromDb = _db.Menus.Find(id);

            if (menuFromDb == null)
            {
                return NotFound();
            }
            return View(menuFromDb);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Menus.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Menus.Remove(obj);
            _db.SaveChanges();
            TempData["sucess"] = "Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
