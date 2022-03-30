using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("VeliAd")]
    public class VeliAd : TagHelper
    {
        private readonly IOgrenciRepostory _ogrenciRepostory;
        public VeliAd(IOgrenciRepostory ogrenciRepostory)
        {
            _ogrenciRepostory = ogrenciRepostory;
        }
        public int OgrenciId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenVeli=_ogrenciRepostory.GetirVeli(OgrenciId).Select(I => I.VeliName);
            foreach (var item in GelenVeli)
            {
                data+=item+" ";
            }
            output.Content.SetContent(data);
        }

    }
}
