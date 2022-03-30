using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class OgrenciList : ViewComponent
    {
        private readonly IOgrenciRepostory _ogrenciRepostory;
        public OgrenciList(IOgrenciRepostory ogrenciRepostory)
        {
            _ogrenciRepostory = ogrenciRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_ogrenciRepostory.GetirHepsi());
        }
    }
}
