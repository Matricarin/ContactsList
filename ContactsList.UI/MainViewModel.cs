using System.Collections.ObjectModel;
using ContactsList.Model;
using ContactsList.UI.Data;

namespace ContactsList.UI;

public class MainViewModel
{
    private IPersonDataService _personDataService;

    public ObservableCollection<Person> StoredPersonsList { get; }

    public MainViewModel(IPersonDataService personDataService)
    {
        StoredPersonsList = new ObservableCollection<Person>();
        _personDataService = personDataService;
    }

    public void LoadPersons()
    {
        var persons = _personDataService.GetAll();
        StoredPersonsList.Clear();
        foreach (var person in persons)
        {
            StoredPersonsList.Add(person);
        }
    }

    private Person _selectedPerson;
    
    public Person SelectedPerson
    {
        get { return _selectedPerson;}
        set { _selectedPerson = value; }
    }
}