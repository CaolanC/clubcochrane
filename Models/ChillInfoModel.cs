namespace CC.Models;

public class ChillInfoModel
{
    public string Header { get; set; }
    public string Info { get; set; }

    public string KeyPoint { get; set; }
    public List<ChillInfoSubArticleCardModel> SubArticleCards { get; set; }
    public ChillInfoModel
        (string header, 
        string info, 
        string key_point, 
        List<ChillInfoSubArticleCardModel> sub_article_cards
    ) {
        Header = header;
        Info = info;
        KeyPoint = key_point;
        SubArticleCards = sub_article_cards;
    }
}