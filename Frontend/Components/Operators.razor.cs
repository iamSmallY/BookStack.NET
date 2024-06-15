using Microsoft.AspNetCore.Components;

namespace Frontend.Components;

public partial class Operators : ComponentBase
{
    [Parameter] public OperatorTypes Types { get; set; }

    public static OperatorTypes Book => OperatorTypes.NewPage | OperatorTypes.NewSection | OperatorTypes.Edit
                                        | OperatorTypes.Sort | OperatorTypes.Copy | OperatorTypes.Permissions
                                        | OperatorTypes.Delete | OperatorTypes.Follow | OperatorTypes.Star
                                        | OperatorTypes.Export;
    public static OperatorTypes Section => OperatorTypes.NewPage | OperatorTypes.Edit | OperatorTypes.Copy
                                           | OperatorTypes.Move | OperatorTypes.Permissions | OperatorTypes.Delete
                                           | OperatorTypes.SortBook | OperatorTypes.Follow | OperatorTypes.Star
                                           | OperatorTypes.Export;
    
    public static OperatorTypes Page => OperatorTypes.Edit | OperatorTypes.Copy | OperatorTypes.Move 
                                        | OperatorTypes.Revisions | OperatorTypes.Permissions | OperatorTypes.Delete
                                        | OperatorTypes.Follow | OperatorTypes.Star | OperatorTypes.Export;
    
    [Flags]
    public enum OperatorTypes
    {
        NewPage = 1, 
        NewSection = 2,
        Edit = 4, 
        Sort = 8,
        Copy = 16, 
        Move = 32,
        Revisions = 64, 
        Permissions = 128, 
        Delete = 256,
        SortBook = 512,
        Follow = 1024, 
        Star = 2048,
        Export = 4096
    }
}