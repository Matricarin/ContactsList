using Autofac;
using ContactsList.UI.Data;
using ContactsList.UI.ViewModels;

namespace ContactsList.UI.StartUp;

public sealed class Bootstrapper
{
    public IContainer Bootstrap()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<MainWindow>().AsSelf();
        builder.RegisterType<MainViewModel>().AsSelf();
        builder.RegisterType<PersonDataService>().As<IPersonDataService>();
        return builder.Build();
    }
}