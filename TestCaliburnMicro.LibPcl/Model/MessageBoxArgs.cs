using System;

namespace TestCaliburnMicro.LibPcl.Model
{
    public class MessageBoxArgs
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Action<MessageBoxResult> OnClose { get; set; }
    }
}
