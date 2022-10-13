using MVCAssigment.DataAccess;

namespace MVCAssigment.Services.Container
{
    public interface IServicesInterface
    {     
        void AddPerson(PersonCreateModel personCreate);
        List<PersonViewModel> ListPerson();
    }
}