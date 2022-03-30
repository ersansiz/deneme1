using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("SaatAd")]
    public class SaatAd : TagHelper
    {
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        public SaatAd( IDersProgramiListRepostory dersProgramiListRepostory)
        {
            
            _dersProgramiListRepostory = dersProgramiListRepostory;

        }

        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenDersProgrami = _dersProgramiListRepostory.GetirSaat(DersProgramiListId).Select(I => I.SaatName);

            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
        }
        
      


    }
  
}
