namespace CC.Models;

public class ArticleCardViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public ArticleCardViewModel(string title, string description, string image_url) {
        Title = title;
        Description = description;
        ImageUrl = image_url;
    }
}