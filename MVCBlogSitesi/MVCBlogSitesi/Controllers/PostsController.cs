using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCBlogSitesi.Data;

namespace MVCBlogSitesi.Controllers
{
    public class PostsController : Controller
    {
        private readonly DatabaseContext _context;

        public PostsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _context.Posts.ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> SearchAsync(string kelime)
        {
            var model = await _context.Posts.Where(p => p.Name.Contains(kelime)).ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var model = await _context.Posts.FindAsync(id);
            return View(model);
        }
    }
}
