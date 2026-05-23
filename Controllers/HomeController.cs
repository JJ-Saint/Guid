using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ckecker.Models;

namespace ckecker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new BillExample { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
