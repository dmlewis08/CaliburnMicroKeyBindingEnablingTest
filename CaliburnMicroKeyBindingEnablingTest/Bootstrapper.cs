using Caliburn.Micro;
using CaliburnMicroKeyBindingEnablingTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroKeyBindingEnablingTest
{
    internal class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container;

        public Bootstrapper()
        {
            _container = new SimpleContainer();
            Initialize();
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
            => _container.GetAllInstances(service);

        protected override object GetInstance(Type service, string key)
            => _container.GetInstance(service, key);

        protected override void BuildUp(object instance)
            => _container.BuildUp(instance);

        protected override void Configure()
        {
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.Singleton<IWindowManager, WindowManager>();

            _container.PerRequest<IShellViewModel, ShellViewModel>();
            base.Configure();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<IShellViewModel>();
        }
    }
}
