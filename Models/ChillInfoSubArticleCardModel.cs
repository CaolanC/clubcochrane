namespace CC.Models;

public class ChillInfoSubArticleCardModel
{
    public string ImgPath { get; set; }
    public string Header { get; set; }
    public string Description { get; set; }
    
    public string Color { get; set; }

    public ChillInfoSubArticleCardModel(string img_path, string header, string description, string color)
    {
        ImgPath = img_path;
        Header = header;
        Description = description;
        Color = color;
    }
}