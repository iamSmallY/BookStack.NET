using Microsoft.AspNetCore.Components;

namespace Frontend.Components;

public partial class IconButton : ComponentBase
{
    [Parameter] public RenderFragment? Icon { get; set; }
    [Parameter] public RenderFragment? Text { get; set; }
    [Parameter] public RenderFragment? After { get; set; }
}