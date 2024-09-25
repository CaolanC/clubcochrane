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
            "Not Welcome!",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
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