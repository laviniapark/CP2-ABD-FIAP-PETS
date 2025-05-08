using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CP2_PETS.Tag_Helpers;

public class BotaoTagHelper : TagHelper
{
    public string? Texto { get; set; } = "Cadastrar";

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        output.Attributes.SetAttribute("class", "btn btn-primary");
        output.Content.SetContent(Texto);
    }
}