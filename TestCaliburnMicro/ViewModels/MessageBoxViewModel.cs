using Caliburn.Micro;
using TestCaliburnMicro.LibPcl.Model;

namespace TestCaliburnMicro.ViewModels
{
    public class MessageBoxViewModel : Screen
    {
        public void Ok()
        {
            Result = MessageBoxResult.Ok;
            TryClose();
        }

        public void Cancel()
        {
            Result = MessageBoxResult.Cancel;
            TryClose();
        }

        public void SetArgs(MessageBoxArgs message)
        {
            Result = MessageBoxResult.Unknown;
            Title = message.Title;
            Message = message.Message;
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public MessageBoxResult Result { get; set; }
    }
}
