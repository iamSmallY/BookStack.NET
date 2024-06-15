Markdown = {}

Markdown.ToHtml = (md) => {
    var html = marked(md);
    html = DOMPurify.sanitize(html);
    return html;
}

window.MathJax = {
    tex: {
        inlineMath: [["$", "$"], ["\\(", "\\)"]]
    },
    options: {
        enableMenu: false
    }
};