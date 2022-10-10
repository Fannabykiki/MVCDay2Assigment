using MVCAssigment.DataAccess;
namespace MVCAssigment.Services
{
    public class MemberServices
    {
        public List<Person> ListPerson()
        {
            var dataAccess = new StaticDataAccess();
            return dataAccess.ShowAllPerson();
        }      
    }
}