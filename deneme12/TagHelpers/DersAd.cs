using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("DersAd")]
    public class DersAd : TagHelper
    {
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        public DersAd(IDersProgramiListRepostory dersProgramiListRepostory)
        {
            _dersProgramiListRepostory = dersProgramiListRepostory;

        }
       

        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenDersProgrami = _dersProgramiListRepostory.GetirDers(DersProgramiListId).Select(I => I.DersName);

            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
        }
        
      


    }
  
}
