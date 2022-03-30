using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class GunList : ViewComponent
    {
        private readonly IGunRepostory _gunRepostory;
        public GunList(IGunRepostory gunRepostory)
        {
            _gunRepostory = gunRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_gunRepostory.GetirHepsi());
        }
    }
}
