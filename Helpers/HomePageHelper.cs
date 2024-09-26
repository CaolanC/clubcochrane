using CC.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CC.Helpers;

public class HomePageHelper
{
    public HomePageModel MakeHomePage()

    {
        var article_card = new ArticleCardViewModel
        (
            "Hi!",
            "My name is Caolan. I'm a computer science student studying in DCU. I'm a programmer, as well as a musician and a speedrunner with multiple world records. I put a lot of time into this thang",
            "/images/generic/placeholder.jpg"
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