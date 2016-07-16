using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication13.ViewModels
{
    public class SubWindowViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; set; }

        public void Loaded()
        {

        }
    }
}
