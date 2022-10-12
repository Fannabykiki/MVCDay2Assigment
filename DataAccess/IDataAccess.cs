using MVCAssigment.DataAccess;
namespace MVCAssigment.Services.Container
{
    public interface IDataAccess
    {
        List<Person> ShowAllPerson();
        void AddPerson(Person person);
    }
}