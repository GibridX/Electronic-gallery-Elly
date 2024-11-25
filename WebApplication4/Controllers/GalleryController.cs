using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public GalleryController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Images.ToListAsync());
        }

        public async Task<IActionResult> DisplayImage(int id)
        {
            var image = await _context.Images.FirstOrDefaultAsync(i => i.Id == id);
            if (image == null) return NotFound();

            return File(image.ImageData, image.ContentType);
        }
    }
}
