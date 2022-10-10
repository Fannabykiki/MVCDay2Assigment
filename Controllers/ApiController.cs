using Microsoft.AspNetCore.Mvc;
using MVCAssigment.Models;
namespace MVCAssigment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        public static List<Person> list = Function.AddMember();
        [HttpGet("{yob}")]
        public ActionResult<List<Person>> ShowPersonByYoB(int yob)
        {
            List<Person> personList = new List<Person>();
            if (yob == 2000)
            {
                foreach (Person p in list)
                {
                    if (p.DateOfBirth.Year == 2000)
                    {
                        personList.Add(p);
                    }
                }
            }
            if (yob > 2000)
            {
                foreach (Person p in list)
                {
                    if (p.DateOfBirth.Year > 2000)
                    {
                        personList.Add(p);
                    }
                }
            }
            if (yob < 2000)
            {
                foreach (Person p in list)
                {
                    if (p.DateOfBirth.Year < 2000)
                    {
                        personList.Add(p);
                    }
                }
            }

            return Ok(personList);
        }
    }
}