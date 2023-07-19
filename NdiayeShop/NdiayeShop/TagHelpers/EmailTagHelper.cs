using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NdiayeShop.TagHelpers
{
    public class EmailTagHelper:TagHelper
    {
        public string? Address { get; set; }
        public string? Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "email";
            output.Attributes.SetAttribute("href","mailto" + Address);
            output.Content.SetContent(Content);
        }
    }
}
