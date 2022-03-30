using deneme12.Context;
using deneme12.Interfaces;
using deneme12.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace deneme12.ViewComponents
{
    public class DersProgramiList : ViewComponent
    {
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        private readonly IDersProgamiRepostory _dersProgamiRepostory;
    

        public DersProgramiList(IDersProgramiListRepostory dersProgramiListRepostory, IDersProgamiRepostory dersProgamiRepostory)
        {
            _dersProgamiRepostory = dersProgamiRepostory;
            _dersProgramiListRepostory = dersProgramiListRepostory;
           
        }
        public IViewComponentResult Invoke(int? sinifId)
        {
            DersProgramiListVm model = new DersProgramiListVm
            {
                DersProgrami = _dersProgamiRepostory.GetirHepsi(),
                DersProgramiList= _dersProgramiListRepostory.GetirHepsi(),
             
                
                
            };
           

            if (sinifId.HasValue)
            {
                DersProgramiListVm dersProgrami = new DersProgramiListVm
                {
                    DersProgrami = _dersProgamiRepostory.GetirHepsi(),
                    DersProgramiList = _dersProgramiListRepostory.GetirSinifIdile((int)sinifId),
                   
                };
                return View(dersProgrami);
            }
            return View(model);


        }
    }
}
