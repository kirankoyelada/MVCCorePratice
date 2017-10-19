using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCCorePratice.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("auto-price")]
    public class AutoPriceTagHelper : TagHelper
    {
        [HtmlAttributeName("model-name")]
        public string Model { get; set; }
        [HtmlAttributeNotBound]
        public string Make { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {            
            output.TagMode = TagMode.StartTagOnly;
            output.PreElement.SetHtmlContent("<h1>Pre Element Example</h1>");
            output.PreContent.SetHtmlContent("<h1>Pre Content Example</h1>");
            output.Content.SetHtmlContent("<h1>Content example</h1>");
            output.PostElement.SetHtmlContent("<h1>Post content example</h1>");
            output.PostContent.SetHtmlContent("<h1>Post element exaple</h1>");            
        }
    }
}
