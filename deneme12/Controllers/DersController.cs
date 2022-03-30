using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.Controllers
{
    public class GunController : Controller
    {
        private readonly IGunRepostory _gunRepostrory;
        public GunController(IGunRepostory gunRepostrory)
        {
            _gunRepostrory = gunRepostrory;
        }
        public IActionResult Index()
        {
            return View(_gunRepostrory.GetirHepsi());
        }
    }
}
