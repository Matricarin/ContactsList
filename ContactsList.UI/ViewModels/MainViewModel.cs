using System.Collections.ObjectModel;
using ContactsList.Model;
using ContactsList.UI.Data;
using ContactsList.UI.ViewModels.Base;

namespace ContactsList.UI.ViewModels;

public class MainViewModel : BaseViewModel
{
    private IPersonDataService _personDataService;

    public ObservableCollection<Person> StoredPersonsList { get; set; }

    public MainViewModel(IPersonDataService personDataService)
    {
        _personDataService = personDataService;
        StoredPersonsList = new ObservableCollection<Person>();
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

    private Person? _selectedPerson;
    
    public Person? SelectedPerson
    {
        get { return _selectedPerson;}
        set
        {
            _selectedPerson = value;
            OnPropertyChanged();
        }
    }
}