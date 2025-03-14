using System.Windows;
using Autofac;
using ContactsList.UI.StartUp;

namespace ContactsList.UI;

public partial class App : Application
{
    private void Application_OnStartUp(object sender, StartupEventArgs e)
    {
        var bootstrapper = new Bootstrapper();
        var container = bootstrapper.Bootstrap();
        var window = container.Resolve<MainWindow>();
        window.Show();
    }
}