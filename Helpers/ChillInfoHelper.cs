namespace CC.Helpers;
using CC.Models;

public class ChillInfoHelper
{

    private ChillInfoSubArticleCardModel CreateCard(string imagePath, string title, List<string> paragraphs)
    {
        return new ChillInfoSubArticleCardModel(imagePath, title, paragraphs);
    }
    public ChillInfoModel HomePage() 
    {
        var ImgModelList = new List<ChillInfoSubArticleCardModel>
        {
            CreateCard(
                "/images/neofetch-debian.jpg",
                "Operating Systems",
                new List<string>() 
                {
                    "I primarily develop on Linux and have gained a deep understanding of its file system. Last year, for a school project, I built a custom shell, which gave me valuable insights into how shell builtins work versus calling system binaries. The experience also taught me about process creation and control, especially the (surprising to me) way that forking in C effectively involves running the program again to manage threading. I think it's absolutely one of the most beneficial projects I've undertaken with regards to low level learning.",
                    "My knowledge of Windows is nowhere near as advanced, but I think Windows itself has given me a better understanding on how the kernel tracks and manages memory per process, and how to take advantage of this with the windows API, through long and extensive reading of the Serious's T7 Injector."
                }
            ),
            CreateCard(
                "/images/neofetch-debian.jpg",
                "Chess Engines",
                new List<string>() 
                {"I create a new chess engine or game roughly every six months; it's my go-to project for learning OOP-based languages because there are many interesting ways to visualize the relationships between Piece, Board, Move, GameRules, etc. In my opinion, it's also an incredibly intuitive introduction to graph theory.",
                 "Currently, I'm working on a full-stack project at school where we're supposed to build a chess game, but to spice things up, we're allowing users to define custom pieces. We're having lots of really interesting discussions on implementation: daemon vs. game engine, how to make the piece definition intuitive to the user on the frontend, how the backend should interpret this data to instantiate a new custom piece, how the chess engine should value and weight a custom piece, etc. I'm having a lot of fun with that right now. ", 
                 "I still have lots to learn, so I'm glad to have the opportunity to engage with these challenges during my school work."
                 }
            ),
            CreateCard(
                "/images/neofetch-debian.jpg",
                "Game Hacking",
                new List<string>() {
                    "I've spent dozens of hours analyzing the source code of Serious's T7 Injector, a tool used for injecting GSC (Game Script Code) into Call of Duty: Black Ops III. The injector uses techniques like dynamically renaming functions to evade Windows Defender. One of its key features is the runtime (hotload) injection system, where a custom function is injected into memory, which can they be used to hook onto core game functionality such as GSC::Execute (used for executing GSC scripts) and allow scripts to be executed dynamically.",
                    "I’m working on developing an anti-cheat to detect this runtime injection. I’m in the process of creating a unique bytecode signature from the assembly of the compiled hotload function. The goal is to scan for this signature during gameplay, allowing for detection on injection.",
                    "We can already detect non-hotload injections by comparing the game's script parse tree with the checksums of the compiled script files, (found by a programmer known as Scrappy).",
                }
            ),
            CreateCard(
                "/images/neofetch-debian.jpg",
                "Full Stack",
                new List<string>() {"lol", "leeel"}
            ),
        };
        
        var model = new ChillInfoModel (
            "What I'm Learning:",
            "I want to learn all of computer science, to at least some degree! I love to teach and want to attempt to make a learning platform from which people can learn at their own pace, but with a bit of guidance. I'm currently in the midst of a number of projects, some school related, some not. I need to get this site up and running, but I also need to create the frontend for a chess engine project, as well as work on the backend c++ with session data tracked by a node server that boots an instance of the engine per session. We want to implement custom pieces so it's gonna be a pretty huge workload. We're absolutely excited though. Now here's me, diving back into the world of dotnet (OOP SCARY!) ;)",
            "Currently focusing on frontend skills.",
            ImgModelList
        );

        return model;
    }
}