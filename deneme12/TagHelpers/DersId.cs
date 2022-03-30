using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace deneme12.TagHelpers
{
    [HtmlTargetElement("DersId")]
    public class DersId : TagHelper
    {
       
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        public DersId(IDersProgramiListRepostory dersProgramiListRepostory)
        {
            _dersProgramiListRepostory = dersProgramiListRepostory;
        }
        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = "";
            var GelenDersProgrami = _dersProgramiListRepostory.GetirDersProgrami(DersProgramiListId).Select(I => I.DersProgramiId);

            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
        }

    }
}
