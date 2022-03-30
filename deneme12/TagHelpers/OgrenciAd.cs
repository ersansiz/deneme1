using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("OgrenciAd")]
    public class OgrenciAd : TagHelper
    {
        private readonly IVeliRepostory _veliRepostory;
        public OgrenciAd(IVeliRepostory veliRepostory)
        {
            _veliRepostory = veliRepostory;
        }
        public int VeliId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenOgrenci=_veliRepostory.GetirOgrenci(VeliId).Select(I => I.OgrenciName);
            foreach (var item in GelenOgrenci)
            {
                data+=item+" ";
            }
            output.Content.SetContent(data);
        }

    }
}
