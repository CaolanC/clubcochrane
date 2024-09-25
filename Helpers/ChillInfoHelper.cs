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
            "lol"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Chess Engines",
            "lol"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Operating Systems",
            "lol"
            )
        );

        ImgModelList.Add(
            new ChillInfoSubArticleCardModel (
            "/images/neofetch-debian.jpg",
            "Operating Systems",
            "lol"
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