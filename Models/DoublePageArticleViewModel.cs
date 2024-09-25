namespace CC.Models;

public class DoublePageArticleViewModel
{
    public PageArticleViewModel PageArticle1 { get; set; }
    public PageArticleViewModel PageArticle2 { get; set; }

    public DoublePageArticleViewModel(PageArticleViewModel page_article1, PageArticleViewModel page_article2)
    {
        PageArticle1 = page_article1;
        PageArticle2 = page_article2;
    }
}