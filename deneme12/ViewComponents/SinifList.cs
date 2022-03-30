using deneme12.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.ViewComponents
{
    public class SinifList : ViewComponent
    {
        private readonly ISinifRepostory _sinifRepostory;
        public SinifList(ISinifRepostory sinifRepostory)
        {
            _sinifRepostory = sinifRepostory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_sinifRepostory.GetirHepsi());
        }
    }
}
