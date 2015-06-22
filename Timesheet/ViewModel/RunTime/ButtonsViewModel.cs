using Imaginera.UnityExtensions.Interception;
using Imaginera.UnityExtensions.Interception.PropertyNotification;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Timesheet.Enums;
using Timesheet.Extensions;

namespace Timesheet.ViewModel.RunTime
{
    [InterceptClass]
    public class ButtonsViewModel : BaseViewModel, IButtonsViewModel
    {
        private readonly IRegionManager regionManager;

        public ButtonsViewModel(IRegionManager regionManager)
        {
            this.AddTimesheetCommand = new DelegateCommand(this.GoToAddTimesheet);
            this.ViewTimesheetCommand = new DelegateCommand(this.GoToViewTimesheet);
            this.ProjectAdminCommand = new DelegateCommand(this.GoToProjectAdmin);
            this.regionManager = regionManager;
            this.SelectedTab = ViewNames.AddTimesheetView;
        }

        public ICommand AddTimesheetCommand { get; set; }
        public ICommand ViewTimesheetCommand { get; set; }
        public ICommand ProjectAdminCommand { get; set; }

        [NotifyPropertyChanged]
        public virtual string SelectedTab { get; set; }

        public void GoToAddTimesheet()
        {
            this.regionManager.Navigate("ContentRegion", ViewNames.AddTimesheetView, null);
            this.SelectedTab = ViewNames.AddTimesheetView;
        }

        public void GoToViewTimesheet()
        {
            this.regionManager.Navigate("ContentRegion", ViewNames.ViewTimesheetView, null);
            this.SelectedTab = ViewNames.ViewTimesheetView;
        }

        public void GoToProjectAdmin()
        {
            this.regionManager.Navigate("ContentRegion", ViewNames.ProjectAdminView, null);
            this.SelectedTab = ViewNames.ProjectAdminView;
        }
    }
}

