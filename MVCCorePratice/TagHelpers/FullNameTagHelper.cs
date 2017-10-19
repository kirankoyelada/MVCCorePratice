using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MVCCorePratice.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("full-name")]
    public class FullNameTagHelper : TagHelper
    {
        public ModelExpression AddressFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        }
    }
}
