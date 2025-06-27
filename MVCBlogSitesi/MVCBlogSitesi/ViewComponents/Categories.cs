using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCBlogSitesi.Data;

namespace MVCBlogSitesi.ViewComponents
{
    public class Categories : ViewComponent
    {
        private readonly DatabaseContext _database;

        public Categories(DatabaseContext database) // DI
        {
            _database = database;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _database.Categories.ToListAsync());
        }
    }
}
