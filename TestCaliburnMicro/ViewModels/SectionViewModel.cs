using Caliburn.Micro;
using TestCaliburnMicro.LibPcl;

namespace TestCaliburnMicro.ViewModels
{
    public class SectionViewModel : Screen
    {
        private readonly Section _section;

        // for design time support
        public SectionViewModel() { }

        public SectionViewModel(Section section)
        {
            _section = section;
            DisplayName = _section.Name;
        }
    }
}
