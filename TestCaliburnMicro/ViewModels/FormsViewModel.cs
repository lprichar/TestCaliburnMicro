using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using TestCaliburnMicro.LibPcl.Model;
using TestCaliburnMicro.Services;

namespace TestCaliburnMicro.ViewModels
{
    public class FormsViewModel : Screen
    {
        readonly FormService _formService;

        public FormsViewModel(FormService formService)
        {
            _formService = formService;
        }

        private ObservableCollection<Form> _forms;

        public ObservableCollection<Form> Forms
        {
            get { return _forms; }
            set
            {
                _forms = value;
                NotifyOfPropertyChange(() => Forms);
            }
        }

        public async Task LoadForms()
        {
            await Task.Delay(500);
            var products = _formService.GetProducts();
            Forms = new ObservableCollection<Form>(products);
        }
    }
}
