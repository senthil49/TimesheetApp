using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imaginera.UnityExtensions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;



namespace Timesheet
{
    using System.Windows;
    using Microsoft.Practices.Prism.UnityExtensions;
    using Timesheet.Views;
    using Timesheet.Extensions;
    using System.Reflection;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.ServiceLocation;

    public class Bootstrapper : UnityBootstrapper
    {
        public Bootstrapper(IEnumerable<Assembly> assemblies)
        {
            this.assemblies = assemblies;
        }

        public IEnumerable<Assembly> assemblies;

        protected override DependencyObject CreateShell()
        {
            var shellView = this.Container.Resolve<MainWindow>();
            Application.Current.MainWindow = shellView;
            return shellView;
        }

        protected override void InitializeShell()
        {

            var regionManager = this.Container.Resolve<IRegionManager>();
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(this.Container));

            base.InitializeShell();
            Application.Current.MainWindow.Show();

            regionManager.Navigate("NavigationRegion", "ButtonsView", null);
            regionManager.Navigate("ContentRegion", "AddTimesheetView", null);
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.AutoConfigure(this.assemblies);
        }
    }
}

