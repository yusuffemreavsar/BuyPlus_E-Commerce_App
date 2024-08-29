using Microsoft.AspNetCore.Mvc;

namespace BuyPlus_E_CommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
