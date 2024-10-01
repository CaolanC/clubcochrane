namespace CC.Models;

public class ChillInfoSubArticleCardModel
{
    public string ImgPath { get; set; }
    public string Header { get; set; }
    public string Description { get; set; }
    

    public ChillInfoSubArticleCardModel(string img_path, string header, string description)
    {
        ImgPath = img_path;
        Header = header;
        Description = description;
    }
}