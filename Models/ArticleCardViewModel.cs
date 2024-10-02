namespace CC.Models;

public class ArticleCardViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Description2 { get; set; }
    public string ImageUrl { get; set; }

    public List<string> BulletList { get; set; }

    public ArticleCardViewModel(string title, string description, string description2, string image_url, List<string> bullet_list) {
        Title = title;
        Description = description;
        Description2 = description2;
        ImageUrl = image_url;
        BulletList = bullet_list;
    }
}