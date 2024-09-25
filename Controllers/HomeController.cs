using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CC.Models;
using CC.Helpers;

namespace CC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var homepage_helper = new HomePageHelper();

        return View(homepage_helper.MakeHomePage());
    }

    public IActionResult GSC()
    {
        return View();
    }

    public IActionResult Contact()
    {           
        var article_card1 = new ArticleCardViewModel(
            "Not WAWfiowafji!",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            "/images/generic/placeholder.jpg"
        );

        var article_card2 = new ArticleCardViewModel(
            "Not WAFFLES    !",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            "/images/generic/placeholder.jpg"
        );

        var double_page_article1 =  new PageArticleViewModel (
            article_card2,
            "#1fedd2",
            "#1fedd2",
            "#1fedd2"
        );

        var double_page_article2 =  new PageArticleViewModel (
            article_card1,
            "#ffffff",
            "#1f75ff",
            "#1ffff2"
        );

        var double_article = new DoublePageArticleViewModel (
            double_page_article1,
            double_page_article2
        );

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
