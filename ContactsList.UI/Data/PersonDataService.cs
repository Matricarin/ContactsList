using ContactsList.Model;

namespace ContactsList.UI.Data;

public class PersonDataService : IPersonDataService
{
    public IEnumerable<Person> GetAll()
    {
        yield return new Person(1, "Alexander", "Goldman", " ga@mail.com", "+799988855");
    }
}