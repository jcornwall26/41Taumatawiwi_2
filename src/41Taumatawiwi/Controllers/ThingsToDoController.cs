using Microsoft.AspNet.Mvc;

namespace _41Taumatawiwi.Controllers
{
    public class ThingsToDoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
