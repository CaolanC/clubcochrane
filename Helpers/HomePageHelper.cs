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

        plans.Add("Learn the .NET Framework");
        plans.Add("As a place to host my GSC documentation project, and hopefully turn it into a community project.");
        plans.Add("Practice Frontend Design");
        plans.Add("Provide a platform for any public APIs I might develop in the future.");
        plans.Add("I plan to create an \"Introduction to Programming\" course on YouTube, and hope to host notes and demos here, as well as an automated testing API so people can run their code against test cases.");
        var article_card = new ArticleCardViewModel
        (
            "Welcome!",
            "My name is Caolan, a computer science student at Dublin City University (DCU) in Ireland. I created this website to:",
            "I'm incredibly passionate about computer science and spend as much time as possible programming. In addition to coding, I'm a guitarist with gigging experience and a speedrunner holding a few cheeky world records. I pride myself on my persistence and continuously learn from the many (many) mistakes I've made along the way. Thank you for visiting, and I hope you find something here that piques your interest!",
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