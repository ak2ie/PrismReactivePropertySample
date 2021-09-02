using PrismReactivePropertySample.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Model.Views;

namespace PrismReactivePropertySample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<Model.Models.Model>(new Model.Models.Model());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Model.ModelModule>(InitializationMode.WhenAvailable);
        }
    }
}
