using MVCAssigment.DataAccess;
namespace MVCAssigment.Services.Container
{
    public interface IDataAccess
    {
        List<PersonViewModel> ShowAllPerson();
        void AddPerson(PersonViewModel person);
        
    }
}