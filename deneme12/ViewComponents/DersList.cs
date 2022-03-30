using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class DersList : ViewComponent
    {
        private readonly IDersRepostory _dersRepostory;
        public DersList(IDersRepostory dersRepostory)
        {
            _dersRepostory = dersRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_dersRepostory.GetirHepsi());
        }
    }
}
