using learnASP.NET_CORE_mvc.Data;
using learnASP.NET_CORE_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace learnASP.NET_CORE_mvc.Controllers
{
    public class NoteController : Controller
    {
        private readonly dbContext _context;

        public NoteController(dbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Note> notesList = _context.Notes;
            return View(notesList);
        }
        //get
        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Note obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("inputError", "name input and description input are the same");
            }
            if (ModelState.IsValid)
            { 
            _context.Notes.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var editedNote = _context.Notes.Find(id);
            if (editedNote == null)
            {
                return NotFound();
            }
            return View(editedNote);
        }

        [HttpPost]
        public IActionResult Update(Note obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("updateError", "updated inputs are the same");
            }
            if (ModelState.IsValid)
            {
                _context.Notes.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            var deletedNote = _context.Notes.Find(id);
            if (deletedNote!= null)
            {
                _context.Notes.Remove(deletedNote);
                _context.SaveChanges();
            }
            return RedirectToAction("index");   
        }
    }
}
