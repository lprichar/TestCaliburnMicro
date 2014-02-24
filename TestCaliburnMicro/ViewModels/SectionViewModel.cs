using Caliburn.Micro;
using TestCaliburnMicro.Events;
using TestCaliburnMicro.LibPcl;

namespace TestCaliburnMicro.ViewModels
{
    public class SectionViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;
        private Section _section;

        public SectionViewModel()
        {

        }

        public SectionViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void SetSection(Section section)
        {
            _section = section;
            DisplayName = _section.Name;
        }

        public void OpenMessageBox()
        {
            _eventAggregator.Publish(new MessageBoxArgs
            {
                Title = "Delete " + DisplayName,
                Message = "Are you sure you want to delete " + DisplayName + "?",
            });
        }
    }
}
