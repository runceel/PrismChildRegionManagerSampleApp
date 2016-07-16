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
    public class ViewAViewModel : BindableBase
    {
        public InteractionRequest<INotification> ShowWindowRequest { get; } = new InteractionRequest<INotification>();

        public DelegateCommand ShowWindowCommand { get; }

        public ViewAViewModel()
        {
            this.ShowWindowCommand = new DelegateCommand(() =>
            {
                this.ShowWindowRequest.Raise(new Notification
                {
                    Title = "Hello",
                    Content = "Sample",
                });
            });
        }
    }
}
