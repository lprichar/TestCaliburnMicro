using Caliburn.Micro;
using TestCaliburnMicro.LibPcl;
using TestCaliburnMicro.Services;

namespace TestCaliburnMicro.ViewModels
{
    public class QuestionnaireViewModel : Conductor<IScreen>
    {

        private SectionsService _sectionsService;

        public QuestionnaireViewModel(SectionsService sectionsService)
        {
            _sectionsService = sectionsService;
            var sections = _sectionsService.GetSections();
            Sections = new BindableCollection<Section>(sections);
        }

        private BindableCollection<Section> _sections;

        public BindableCollection<Section> Sections
        {
            get { return _sections; }
            set
            {
                if (Equals(value, _sections)) return;
                _sections = value;
                NotifyOfPropertyChange(() => Sections);
            }
        }

        public void SetActiveSection(Section section)
        {
            var sectionViewModel = IoC.Get<SectionViewModel>();
            sectionViewModel.SetSection(section);
            ActivateItem(sectionViewModel);
        }
    }
}
