using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Frontend.Components;

public partial class TopRow : ComponentBase
{
    private string _userHeadImgUrl = "";
    private string _searchInput = "";
    private string SearchInput
    {
        get => _searchInput;
        set
        {
            _searchInput = value;
            OnSearchInputChanged();
        }
    }

    private InputText SearchInputElement { get; set; } = default!;
    private async void OnSearchInputChanged()
    {
        if (string.IsNullOrEmpty(SearchInput))
        {
            return;
        }

    }
}