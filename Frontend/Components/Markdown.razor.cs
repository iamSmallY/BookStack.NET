using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Frontend.Components;

public partial class Markdown : ComponentBase
{
    private string? _markdownHtml;
    private IJSObjectReference? _module;
    
    [Parameter] public string? MarkdownString { get; set; }

    [Inject] public IJSRuntime JsRuntime { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        if (MarkdownString is not null)
        {
            _module = await JsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./Components/Markdown.razor.js");
            _markdownHtml = await _module.InvokeAsync<string>("Markdown.toHtml", MarkdownString
                .Replace(@"\(", @"\\(").Replace(@"\)", @"\\)")
                .Replace(@"\[", @"\\[").Replace(@"\]", @"\\]"));
            await InvokeAsync(StateHasChanged);
            await _module.InvokeVoidAsync("Markdown.renderMathematicalFormulas");
        }
        else
        {
            _markdownHtml = null;
        }
        
        await base.OnParametersSetAsync();
    }
}