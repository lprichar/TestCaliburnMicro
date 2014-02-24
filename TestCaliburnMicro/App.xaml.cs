using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro;
using TestCaliburnMicro.Services;
using TestCaliburnMicro.ViewModels;

namespace TestCaliburnMicro
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App
    {
        private WinRTContainer _container;

        protected override void Configure()
        {
            _container = new WinRTContainer();
            _container.RegisterWinRTServices();
            _container.RegisterSharingService();

            _container
                .PerRequest<DialogManagerViewModel>()
                .PerRequest<MainViewModel>()
                .PerRequest<FormService>()
                .PerRequest<SectionsService>()
                .PerRequest<QuestionnaireViewModel>()
                .PerRequest<FormsViewModel>()
                .PerRequest<SectionViewModel>()
                .PerRequest<MessageBoxViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.GetInstance(service, key);
            if (instance != null)
                return instance;

            throw new Exception("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            DisplayRootViewFor<DialogManagerViewModel>();
        }
    }
}
