using CC.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CC.Helpers;

public class HomePageHelper
{

    private readonly ChillInfoHelper _chillInfoHelper;

    public HomePageHelper()
    {
        _chillInfoHelper = new ChillInfoHelper();
    }
    public HomePageHelper(ChillInfoHelper chillInfoHelper)
    {
        _chillInfoHelper = chillInfoHelper;
    }
    public HomePageModel MakeHomePage()

    {

        var plans = new List<string>();
        plans.Add("Learn the .NET framework");
        var article_card = new ArticleCardViewModel
        (
            "Welcome!",
            "I'm Caolan, a computer science student at Dublin City University (DCU) in Ireland. I created this website to: Learn the .NET framework Practice frontend design Provide a platform for any public APIs I might develop in the future Currently, I'm working on migrating my GSC documentation project here to make it more accessible. I'm also expanding the site with more pages to enhance the navigation bar. I'm incredibly passionate about computer science and spend as much time as possible programming. In addition to coding, I'm a guitarist with gigging experience and a speedrunner holding a few cheeky world records. I pride myself on my persistence and continuously learn from the many (many) mistakes I've made along the way. Thank you for visiting, and I hope you find something here that piques your interest!",
            "/images/generic/placeholder.jpg",
            plans
        );

        var top_article = new PageArticleViewModel
        (
            article_card,
            "#eb4034",
            "#ed4c1f",
            "#ed1fa8"
        );

        var chill_article_helper = new ChillInfoHelper();

        var mid_article = chill_article_helper.HomePage();  


        // var left_article = new PageArticleViewModel
        // (
        //     article_card,
        //     "#ff4f34",
        //     "#ed4c1f",
        //     "#ed1fa8"
        // );


        // var right_ar"
        // );

        // var double_article = new DoublePageArticleViewModel
        // (
        //     left_article,
        //     right_article
        // );
        var node_list = new List<string>();
        
        for(int i = 0; i < 10; i++) {
            node_list.Append("Node: " + i);
        }

        var tree_graph = new TreeGraphViewModel
        (
            node_list
        );

        var home_page_model = new HomePageModel
        (
            top_article,
            mid_article,
            tree_graph
        );
        return home_page_model;
    }
}