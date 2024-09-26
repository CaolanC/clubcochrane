namespace CC.Models;

public class ArticleCardViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public List<string> BulletList { get; set; }

    public ArticleCardViewModel(string title, string description, string image_url, List<string> bullet_list) {
        Title = title;
        Description = description;
        ImageUrl = image_url;
        BulletList = bullet_list;
    }
}