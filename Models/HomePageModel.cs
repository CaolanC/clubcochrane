namespace CC.Models;

public class HomePageModel
{
    public PageArticleViewModel TopArticle { get; set; }
    public ChillInfoModel MidArticle { get; set; }
    public TreeGraphViewModel TreeGraph { get; set; }
    public HomePageModel(
        PageArticleViewModel top_article,
        ChillInfoModel mid_article,
        TreeGraphViewModel tree_graph
    ) 
    {
        TopArticle = top_article;
        MidArticle = mid_article;
        TreeGraph = tree_graph;
    }
}