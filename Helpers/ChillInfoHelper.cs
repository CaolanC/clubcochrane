namespace CC.Helpers;
using CC.Models;

public class ChillInfoHelper
{
    public ChillInfoModel HomePage() 
    {
        var ImgModelList = new List<ChillInfoSubArticleCardModel>();

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Operating Systems",
            "I primarily develop on Linux, ",
            "background-color: rgb(255, 57, 136);"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Chess Engines",
            "I create a new chess engine or game roughly every six months; it's my go-to project for learning OOP-based languages because there are many interesting ways to visualize the relationships between Piece, Board, Move, GameRules, etc. In my opinion, it's also an incredibly intuitive introduction to graph theory. Currently, I'm working on a full-stack project at school where we're supposed to build a chess game, but to spice things up, we're allowing users to define custom pieces. We're having lots of really interesting discussions on implementation: daemon vs. game engine, how to make the piece definition intuitive to the user on the frontend, how the backend should interpret this data to instantiate a new custom piece, how the chess engine should value and weight a custom piece, etc. I'm having a lot of fun with that right now. I still have lots to learn, so I'm glad to have the opportunity to engage with these challenges during my school work.",
            "white"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Operating Systems",
            "lol",
            "rgb(149, 206, 255);"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Operating Systems",
            "lol",
            "yellow"
            )
        );

        
        var model = new ChillInfoModel (
            "What I want to learn:",
            "I want to learn all of computer science, to at least some degree! I love to teach and want to attempt to make a learning platform from which people can learn at their own pace, but with a bit of guidance. I'm currently in the midst of a number of projects, some school related, some not. I need to get this site up and running, but I also need to create the frontend for a chess engine project, as well as work on the backend c++ with session data tracked by a node server that boots an instance of the engine per session. We want to implement custom pieces so it's gonna be a pretty huge workload. We're absolutely excited though. Now here's me, diving back into the world of dotnet (OOP SCARY!) ;)",
            "Currently focusing on frontend skills.",
            ImgModelList
        );

        return model;
    }
}