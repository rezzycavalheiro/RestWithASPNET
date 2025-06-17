using RestWithASPNET.Models;

namespace RestWithASPNET.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        void Delete(Person person);
        void Delete(long id);
    }
}
