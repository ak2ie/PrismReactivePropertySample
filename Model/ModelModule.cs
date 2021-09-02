using Model.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Model
{
    public class ModelModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("ViewA", typeof(Views.ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Models.Model>();
        }
    }
}