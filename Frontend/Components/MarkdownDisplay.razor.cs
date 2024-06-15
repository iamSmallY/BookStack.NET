using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Frontend.Components;

public partial class MarkdownDisplay : ComponentBase
{
    private string? _markdownHtml;
    
    [Parameter] public string? Markdown { get; set; }

    [Inject] public IJSRuntime JsRuntime { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        if (Markdown is not null)
        {
            _markdownHtml = await JsRuntime.InvokeAsync<string>("Markdown.ToHtml", Markdown
                .Replace(@"\(", @"\\(").Replace(@"\)", @"\\)")
                .Replace(@"\[", @"\\[").Replace(@"\]", @"\\]"));
            await InvokeAsync(StateHasChanged);
            await JsRuntime.InvokeVoidAsync("MathJax.startup.defaultReady");
        }
        else
        {
            _markdownHtml = null;
        }
        
        await base.OnParametersSetAsync();
    }
    
}