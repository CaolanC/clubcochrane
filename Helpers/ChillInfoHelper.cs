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
                "/images/chess.png",
                "Chess Engines",
                new List<string>() 
                {"I create a new chess engine or game roughly every six months; it's my go-to project for learning OOP-based languages because there are many interesting ways to visualize the relationships between Piece, Board, Move, GameRules, etc. In my opinion, it's also an incredibly intuitive introduction to graph theory.",
                 "Currently, I'm working on a full-stack project at school where we're supposed to build a chess game, but to spice things up, we're allowing users to define custom pieces. We're having lots of really interesting discussions on implementation: daemon vs. game engine, how to make the piece definition intuitive to the user on the frontend, how the backend should interpret this data to instantiate a new custom piece, how the chess engine should value and weight a custom piece, etc. I'm having a lot of fun with that right now. ", 
                 "I still have lots to learn, so I'm glad to have the opportunity to engage with these challenges during my school work."
                 }
            ),
            CreateCard(
                "/images/win32-api.jpg",
                "Game Hacking",
                new List<string>() {
                    "I've spent dozens of hours analyzing the source code of Serious's T7 Injector, a tool used for injecting GSC (Game Script Code) into Call of Duty: Black Ops III. The injector uses techniques like dynamically renaming functions to evade Windows Defender. One of its key features is the runtime (hotload) injection system, where a custom function is injected into memory, which can they be used to hook onto core game functionality such as GSC::Execute (used for executing GSC scripts) and allow scripts to be executed dynamically.",
                    "I’m working on developing an anti-cheat to detect this runtime injection. I’m in the process of creating a unique bytecode signature from the assembly of the compiled hotload function. The goal is to scan for this signature during gameplay, allowing for detection on injection.",
                    "We can already detect non-hotload injections by comparing the game's script parse tree with the checksums of the compiled script files, (found by a programmer known as Scrappy).",
                }
            ),
            CreateCard(
                "/images/fullstack.png",
                "Full Stack",
                new List<string>() {
                    "I wasn't always interested in Full Stack Development. Initially, CSS felt intimidating and unintuitive. However, during an internship, a friend gave me a crash course on SCSS and recommended a Udemy course on frontend design. I can credit them with most of my frontend knowledge, which I’m still developing. Right now, my experience is like being familiar with a programming language and its prominent libraries but not fully understanding how the compiler works under the hood. In this case, the compiler is the CSS rendering engine. I know I still have a lot to learn.",
                    "For me, the most important aspect of frontend development is ensuring the interface is intuitive, fluid, and works as expected. I aim to create experiences that are a joy to use compared to other solutions. Even with mostly static content, I strive to make things as convenient as possible. For instance, you might notice the navbar on this page follows you as you scroll. I find it inconvenient to scroll to the top just to navigate, so I designed it to stay accessible. It’s transparent to avoid taking up too much screen space, but it’s also blurred and shadowed to signal its presence clearly.",
                    "On the backend, this is my first real attempt at building a dedicated website. I focus on making modular, reusable components, though I'm spending a lot of time figuring out how to keep nested components loosely coupled. I’m learning about dependency injection for services and improving in this area. While I’m not yet experienced with implementing complex logic, like region-based context, I feel my understanding of the MVC model has drastically improved, thanks to the .NET framework. I still have a long way to go, but the benefits of learning this framework are becoming clear.",
                    "Previously, I was familiar with Docker and Docker Compose, but now I’m starting to see the full potential of these tools. I plan to implement custom APIs for automated testing of programming tasks, and I’ve decided to commit to a microservices architecture for this site. A monolithic approach simply doesn't meet my needs. I’m not yet experienced enough in cybersecurity to know if a machine running user-submitted code could be exploited, so keeping everything containerized adds at least some level of protection.",
                    "Currently, my website is hosted on Google Cloud Platform (GCP). It was previously hosted on a 2009 iMac running Debian (Linux users, I know), but I switched to GCP because it’s actually cheaper than the electricity cost of keeping the iMac on 24/7 (though that screen is absolutely stunning). I also ran into issues getting a static IP, as my ISP uses dynamic DNS and charges €50 a month for a static IP (which felt like robbery). I got around this with Cloudflare tunneling, which worked incredibly well, but eventually, I wanted a different solution. In the future, I’m considering moving to Oracle’s free tier for VM hosting—it’s a great option for my needs."
                }
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