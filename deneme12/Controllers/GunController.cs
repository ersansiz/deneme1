using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.Controllers
{
    public class DersController : Controller
    {
        private readonly IDersRepostory _dersRepostrory;
        public DersController(IDersRepostory dersRepostrory)
        {
            _dersRepostrory = dersRepostrory;
        }
        public IActionResult Index()
        {
            return View(_dersRepostrory.GetirHepsi());
        }
    }
}
