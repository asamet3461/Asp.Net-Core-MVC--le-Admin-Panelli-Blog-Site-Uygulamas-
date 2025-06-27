using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCBlogSitesi.Data;

namespace MVCBlogSitesi.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var model = _context.Categories.Include(p => p.Posts).FirstOrDefault(c => c.Id == id);
            return View(model);
        }
    }
}
