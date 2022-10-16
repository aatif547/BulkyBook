using BulkyBook.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers
{
    public class CategoryController1 : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController1(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
