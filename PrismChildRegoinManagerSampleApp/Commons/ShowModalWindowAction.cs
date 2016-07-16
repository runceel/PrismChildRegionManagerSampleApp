using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace WpfApplication13.Commons
{
    public class ShowModalWindowAction : TriggerAction<DependencyObject>
    {
        public Type WindowType
        {
            get { return (Type)GetValue(WindowTypeProperty); }
            set { SetValue(WindowTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowTypeProperty =
            DependencyProperty.Register("WindowType", typeof(Type), typeof(ShowModalWindowAction), new PropertyMetadata(typeof(Window)));

        protected override void Invoke(object parameter)
        {
            var currentRegionManager = RegionManager.GetRegionManager(Window.GetWindow(this.AssociatedObject));
            var w = (Window)Activator.CreateInstance(this.WindowType);
            RegionManager.SetRegionManager(w, currentRegionManager.CreateRegionManager());
            w.ShowDialog();
        }
    }
}
