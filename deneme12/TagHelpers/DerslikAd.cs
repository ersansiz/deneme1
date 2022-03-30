using deneme12.Context;
using deneme12.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme12.TagHelpers
{
  
        [HtmlTargetElement("DerslikAd")]
        public class DerslikAd : TagHelper
        {
            private readonly ISinifRepostory _sinifRepostory;
        private readonly IDersProgramiListRepostory _dersProgramiListRepostory;
        public DerslikAd(ISinifRepostory sinifRepostory, IDersProgramiListRepostory dersProgramiListRepostory)
            {
                _sinifRepostory = sinifRepostory;
            _dersProgramiListRepostory = dersProgramiListRepostory;
        }
            public int SinifId { get; set; }
        public int DersProgramiListId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
            {
                string data = "";
                var GelenDerslik = _sinifRepostory.GetirDerslik(SinifId).Select(I => I.DerslikName);
                foreach (var item in GelenDerslik)
                {
                    data += item + " ";
                }
            var GelenDersProgrami = _dersProgramiListRepostory.GetirDerslik(DersProgramiListId).Select(I => I.DerslikName);


            foreach (var item in GelenDersProgrami)
            {
                data += item + " ";
            }
            output.Content.SetContent(data);
            }

        }
    }

