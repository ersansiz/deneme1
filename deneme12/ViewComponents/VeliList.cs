using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class VeliList : ViewComponent
    {
        private readonly IVeliRepostory _veliRepostory;
        public VeliList(IVeliRepostory veliRepostory)
        {
            _veliRepostory = veliRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_veliRepostory.GetirHepsi());
        }
    }
}
