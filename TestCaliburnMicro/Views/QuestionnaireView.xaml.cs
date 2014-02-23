// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

using Windows.UI;
using Windows.UI.Xaml.Media;

namespace TestCaliburnMicro.Views
{
    public sealed partial class QuestionnaireView
    {
        public QuestionnaireView()
        {
            InitializeComponent();

            // support non-transparent background @ design time from: http://stackoverflow.com/questions/12078204/metro-winrt-determine-if-in-editor-design-time
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
        }
    }
}
