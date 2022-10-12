using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCAssigment.Models;
using MVCAssigment.Services;
using MVCAssigment.Services.Container;
namespace MVCAssigment.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IServicesInterface _services;
    public HomeController(ILogger<HomeController> logger, IServicesInterface services)
    {
        _logger = logger;
        _services = services;
    }

    public IActionResult Index()
    {
        return View(_services.ListPerson());
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(PersonCreateModel model)
    {
        if (ModelState.IsValid)
        {
            _services.AddPerson(model);
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
