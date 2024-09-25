namespace CC.Models;

public class PageArticleViewModel
{
    public ArticleCardViewModel ArticleCard { get; set; }
    public string Color1 { get; set; }
    public string Color2 { get; set; }
    public string Color3 { get; set; }

    public PageArticleViewModel(ArticleCardViewModel article_card, string color1, string color2, string color3) {
        ArticleCard = article_card;
        Color1 = color1;
        Color2 = color2;
        Color3 = color3;
    }
}