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
        var page =  new ContactPageModel();
        return View(page);
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
