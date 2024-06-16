using Microsoft.AspNetCore.Components;

namespace Frontend.Pages;

public partial class Page : ComponentBase
{
    private string _markdownStr =
        "# 你好，世界\n## 二级标题测试\n1. 列表测试\n2. 测试行内公式 \\( f(x)=\\sum_{i=1}^{n}i^2 \\)\n3. 测试行间公式 \\[ f(x)=\\frac{\\partial g}{\\partial x} \\]\n```python\nimport numpy\nprint(\"hello world\")\n```\n";

    protected override void OnInitialized()
    {
        for (var i = 0; i < 5; ++i)
        {
            _markdownStr += '\n' + _markdownStr;
        }
        base.OnInitialized();
    }
}