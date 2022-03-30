using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class DerslikList : ViewComponent
    {
        private readonly IDerslikRepostory _derslikRepostory;
        public DerslikList(IDerslikRepostory derslikRepostory)
        {
            _derslikRepostory = derslikRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_derslikRepostory.GetirHepsi());
        }
    }
}
