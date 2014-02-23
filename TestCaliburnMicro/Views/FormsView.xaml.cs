using Windows.UI;
using Windows.UI.Xaml.Media;

namespace TestCaliburnMicro.Views
{
    public sealed partial class FormsView
    {
        public FormsView()
        {
            InitializeComponent();

            // support non-transparent background @ design time from: http://stackoverflow.com/questions/12078204/metro-winrt-determine-if-in-editor-design-time
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Background = new SolidColorBrush(Color.FromArgb(255,0,0,0));
            }

        }
    }
}
