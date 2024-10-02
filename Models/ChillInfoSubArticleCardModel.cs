namespace CC.Models;

public class ChillInfoSubArticleCardModel
{
    public string ImgPath { get; set; }
    public string Header { get; set; }
    public List<string> Paragraphs { get; set; }
    

    public ChillInfoSubArticleCardModel(string img_path, string header, List<string> paragraphs)
    {
        ImgPath = img_path;
        Header = header;
        Paragraphs = paragraphs;
    }
}