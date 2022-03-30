using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("GunAd")]
    public class GunAd : TagHelper
    {
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        private readonly IOgrenciRepostory _ogrenciRepostory;

        public GunAd(IOgrenciRepostory ogrenciRepostory, IDersProgramiListRepostory dersProgramiListRepostory)
        {
            _ogrenciRepostory = ogrenciRepostory;
            _dersProgramiListRepostory = dersProgramiListRepostory;

        }
        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenDersProgrami = _dersProgramiListRepostory.GetirGun(DersProgramiListId).Select(I => I.GunName);


            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
        }
        
      


    }
  
}
