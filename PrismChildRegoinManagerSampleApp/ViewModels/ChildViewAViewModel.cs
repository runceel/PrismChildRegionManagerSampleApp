using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication13.ViewModels
{
    public class ChildViewAViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; set; }

        public DelegateCommand NavigateCommand { get; }

        public ChildViewAViewModel()
        {
            this.NavigateCommand = new DelegateCommand(() =>
            {
                this.RegionManager.RequestNavigate("ChildMain", "ChildViewB");
            });
        }
    }
}
