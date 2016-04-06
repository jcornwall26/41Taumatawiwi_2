using Microsoft.AspNet.Mvc;

namespace _41Taumatawiwi.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
