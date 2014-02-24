using Caliburn.Micro;

namespace TestCaliburnMicro.ViewModels
{
    public class MainViewModel : Conductor<IScreen>
    {
        private string _pageTitle;

        public MainViewModel()
        {
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
            questionnaireViewModel.Parent = this;
            ActivateItem(questionnaireViewModel);
        }

        public void ShowForms()
        {
            var formsViewModel = IoC.Get<FormsViewModel>();
            ActivateItem(formsViewModel);
        }
    }
}
