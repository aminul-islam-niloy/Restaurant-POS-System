using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Restaurant_POS_System.Data;
using Restaurant_POS_System.Models;

namespace Restaurant_POS_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMemoryCache _cache;


        public ProductsController(ApplicationDbContext context, IMemoryCache cache)
        {
            _db = context;
            _cache = cache;
        }

        public async Task<IActionResult> Index(int? categoryId, string search = null)
        {
            // Retrieve all categories for filtering
            ViewData["Categories"] = await _db.Categories.ToListAsync();

            // Check cache for MenuItems
            if (!_cache.TryGetValue("menuItems", out IEnumerable<MenuItem> menuItems))
            {
                // Fetch from database if not in cache
                menuItems = await _db.MenuItems
                    .Include(m => m.Category)
                    .OrderByDescending(m => m.AdditionTime)
                    .ToListAsync();

                // Cache the data for 10 minutes
                _cache.Set("menuItems", menuItems, TimeSpan.FromMinutes(10));
            }

            // Filter by Category if provided
            if (categoryId.HasValue)
            {
                menuItems = menuItems.Where(m => m.CategoryId == categoryId.Value);
            }

            // Apply search filter if provided
            if (!string.IsNullOrEmpty(search))
            {
                menuItems = menuItems.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            return View(menuItems);
        }


    }
}
