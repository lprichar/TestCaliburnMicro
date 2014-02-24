using System.IO.Compression;
using System.Threading.Tasks;
using Caliburn.Micro;
using TestCaliburnMicro.LibPcl.Model;

namespace TestCaliburnMicro.ViewModels
{
    public class DialogManagerViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<MessageBoxArgs>
    {
        public DialogManagerViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }

        protected override void OnActivate()
        {
            var mainViewModel = IoC.Get<MainViewModel>();
            mainViewModel.Parent = this;
            ActivateItem(mainViewModel);
        }

        public void Handle(MessageBoxArgs args)
        {
            var messageBox = IoC.Get<MessageBoxViewModel>();
            messageBox.SetArgs(args);
            ActivateItem(messageBox);
            messageBox.Deactivated += delegate { args.OnClose(messageBox.Result); };
        }
    }
}
