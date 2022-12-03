using learnASP.NET_CORE_mvc.Data;
using learnASP.NET_CORE_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace learnASP.NET_CORE_mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly dbContext _context;

        public CategoryController(dbContext context)
        {
            _context= context;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _context.Categories;
            return View();
        }
    }
}
