using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication13.Views;

namespace WpfApplication13
{
    class AppModule : IModule
    {
        private IRegionManager RegionManager { get; }

        private IUnityContainer Container { get; }

        public AppModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.RegionManager = regionManager;
            this.Container = container;
        }
        public void Initialize()
        {
            this.Container.RegisterTypeForNavigation<ViewA>();
            this.Container.RegisterTypeForNavigation<ChildViewA>();
            this.Container.RegisterTypeForNavigation<ChildViewB>();

            this.RegionManager.RequestNavigate("Main", "ViewA");
        }
    }
}
