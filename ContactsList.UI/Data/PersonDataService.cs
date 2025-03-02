using ContactsList.Model;

namespace ContactsList.UI.Data;

public class PersonDataService : IPersonDataService
{
    public IEnumerable<Person> GetAll()
    {
        yield return new Person()
        {
            Id = 1, FirstName = "Alexander", LastName = "Goldman", Email = "ga@mail.com", PhoneNumber = "+799988855"
        };
    }
}