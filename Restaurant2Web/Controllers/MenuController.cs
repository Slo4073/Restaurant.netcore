using Microsoft.AspNetCore.Mvc;
using Restaurant2Web.Models;
using RestaurantWeb2.Data;

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
            _db.Menus.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
