using ContactsList.Model;

namespace ContactsList.UI.Data;

public interface IPersonDataService
{
    IEnumerable<Person> GetAll();
}