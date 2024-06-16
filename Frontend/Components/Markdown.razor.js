export class Markdown {
    static toHtml(md) {
        let html = marked(md);
        html = DOMPurify.sanitize(html);
        return html;
    }
    
    static renderMathematicalFormulas() {
        MathJax.startup.defaultReady();
    }
}

window.Markdown = Markdown;