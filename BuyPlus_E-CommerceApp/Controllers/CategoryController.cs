using BuyPlus_E_CommerceApp.Data;
using BuyPlus_E_CommerceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyPlus_E_CommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categoryList= _context.Categories.ToList();
            return View(categoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
