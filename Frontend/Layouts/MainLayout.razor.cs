using Microsoft.AspNetCore.Components;

namespace Frontend.Layouts;

public partial class MainLayout : ComponentBase
{
    [Parameter] public RenderFragment? LeftContent { get; set; }
    [Parameter] public RenderFragment? MainContent { get; set; }
    [Parameter] public RenderFragment? RightContent { get; set; }
}