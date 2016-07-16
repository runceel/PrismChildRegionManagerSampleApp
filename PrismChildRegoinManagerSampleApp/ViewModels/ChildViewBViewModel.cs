using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication13.ViewModels
{
    public class ChildViewBViewModel : BindableBase
    {
        public InteractionRequest<INotification> WindowCloseRequest { get; } = new InteractionRequest<INotification>();

        public DelegateCommand WindowCloseCommand { get; }

        public ChildViewBViewModel()
        {
            this.WindowCloseCommand = new DelegateCommand(() =>
            {
                this.WindowCloseRequest.Raise(new Notification());
            });
        }
    }
}
