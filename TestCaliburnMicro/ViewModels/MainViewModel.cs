using Caliburn.Micro;
using TestCaliburnMicro.Views;

namespace TestCaliburnMicro.ViewModels
{
    public class MainViewModel : Conductor<IScreen>
    {
        private readonly WinRTContainer _winRtContainer;
        private string _pageTitle;

        public MainViewModel() {  }

        public MainViewModel(WinRTContainer winRtContainer)
        {
            _winRtContainer = winRtContainer;

            PageTitle = "Test Caliburn.Micro";
        }

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                NotifyOfPropertyChange(() => PageTitle);
            }
        }

        public void ShowQuestionnaire()
        {
            var questionnaireViewModel = IoC.Get<QuestionnaireViewModel>();
            ActivateItem(questionnaireViewModel);
        }

        public void ShowForms()
        {
            var formsViewModel = IoC.Get<FormsViewModel>();
            ActivateItem(formsViewModel);
        }
    }
}
