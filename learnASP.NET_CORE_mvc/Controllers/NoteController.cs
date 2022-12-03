using learnASP.NET_CORE_mvc.Data;
using learnASP.NET_CORE_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace learnASP.NET_CORE_mvc.Controllers
{
    public class NoteController : Controller
    {
        private readonly dbContext _context;

        public NoteController(dbContext context)
        {
            _context= context;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Note> notesList = _context.Notes;
            return View();
        }
        //get
        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        public IActionResult Create(Note object)
        {
            return View();
        }
    }
}
