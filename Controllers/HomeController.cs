using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCAssigment.Models;

namespace MVCAssigment.Controllers;

public class HomeController : Controller
{
    public static List<Person> list = Function.AddMember();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult SearchMalePerson()
    {
        foreach (Person item in list)
        {
            if (item.Gender.Equals("Male"))
            {
                Debug.WriteLine(item);
            }
        }
        return View();
    }

    public IActionResult SearchOldestPerson()
    {
        Person p = Function.GetOldestPerson(list);
        Debug.WriteLine(p);
        return View();
    }

    [Route("/Nashtech/Rookies/Index")]
    public IActionResult ShowFullNameOfPerson()
    {
        Function.GetFullNameOfPerson(list);
        return View();
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
