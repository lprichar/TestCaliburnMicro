using Caliburn.Micro;
using TestCaliburnMicro.Events;

namespace TestCaliburnMicro.ViewModels
{
    public class DialogManagerViewModel : Conductor<IScreen>, IHandle<MessageBoxArgs>
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

        public void Handle(MessageBoxArgs message)
        {
            var messageBox = IoC.Get<MessageBoxViewModel>();
            messageBox.SetArgs(message);
            ActivateItem(messageBox);
        }
    }
}
