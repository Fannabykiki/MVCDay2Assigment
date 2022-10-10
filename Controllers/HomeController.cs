using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCAssigment.Models;
using MVCAssigment.Services;
namespace MVCAssigment.Controllers;
public class HomeController : Controller
{
    private MemberServices _services;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _services = new MemberServices();
    }

    public IActionResult Index()
    {
        var listPerson = _services.ListPerson();
        return View(listPerson);
    }

    public IActionResult SaveFile()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
