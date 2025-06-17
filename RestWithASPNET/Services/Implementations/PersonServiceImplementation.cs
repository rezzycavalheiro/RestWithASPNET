using System.Reflection.Metadata.Ecma335;
using RestWithASPNET.Models;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long person)
        {

        }

        public List<Person> FindAll()
        {
            // return list of people
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindByID(long id)
        {
            // mock

            return new Person 
            {  Id = IncrementAndGet(),
               FirstName = "Renata",
               LasttName = "Silva",
               Address = "Curitiba",
               Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person name" + i,
                LasttName = "Person last name" + i,
                Address = "Some address" + i,
                Gender = "Gender"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
