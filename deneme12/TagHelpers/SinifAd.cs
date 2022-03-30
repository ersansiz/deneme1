using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("SinifAd")]
    public class SinifAd : TagHelper
    {
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        private readonly IOgrenciRepostory _ogrenciRepostory;
        
        public SinifAd(IOgrenciRepostory ogrenciRepostory, IDersProgramiListRepostory dersProgramiListRepostory)
        {
            _ogrenciRepostory = ogrenciRepostory;
            _dersProgramiListRepostory = dersProgramiListRepostory;
           
        }
        public int OgrenciId { get; set; }
        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenSinif=_ogrenciRepostory.GetirSinif(OgrenciId).Select(I => I.SinifName);
            foreach (var item in GelenSinif)
            {
                data+=item+" ";
            }

            var GelenDersProgrami = _dersProgramiListRepostory.GetirSinif(DersProgramiListId).Select(I => I.SinifName);

            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
        }
        
      


    }
  
}
