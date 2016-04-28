using _41Taumatawiwi.Core.Repositories.Instagram;
using System.Web.Mvc;

namespace _41Taumatawiwi.Controllers
{
    public class GalleryController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            var imageRepo = new InstagramPhotoRepository();

            var images = imageRepo.GetAll();

            return View(images);
        }
    }
}
