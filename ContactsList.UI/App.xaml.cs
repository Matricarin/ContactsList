using System.Windows;
using ContactsList.UI.Data;
using ContactsList.UI.ViewModels;

namespace ContactsList.UI;

public partial class App : Application
{
    private void Application_OnStartUp(object sender, StartupEventArgs e)
    {
        var personDataService = new PersonDataService();
        var viewModel = new MainViewModel(personDataService);
        var window = new MainWindow(viewModel);
        window.Show();
    }
}