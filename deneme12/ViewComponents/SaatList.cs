using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class SaatList : ViewComponent
    {
        private readonly ISaatRepostory _saatRepostory;
        public SaatList(ISaatRepostory saatRepostory)
        {
            _saatRepostory = saatRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_saatRepostory.GetirHepsi());
        }
    }
}
