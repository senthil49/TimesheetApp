using Imaginera.UnityExtensions.Interception;
using Imaginera.UnityExtensions.Interception.PropertyNotification;
using Imaginera.UnityExtensions.Interception.Threading;
using Imaginera.UnityExtensions.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Model;
using Timesheet.Services;

namespace Timesheet.ViewModel.RunTime
{
    [InterceptClass]
    public class ViewTimesheetViewModel : BaseViewModel, IViewTimesheetViewModel
    {
        private readonly IDataService dataService;

        public ViewTimesheetViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [NotifyPropertyChanged]
        public virtual List<string> Months { get; set; }

        [NotifyPropertyChanged]
        public virtual List<string> Projects { get; set; }

        [NotifyPropertyChanged]
        public virtual string SelectedMonth { get; set; }

        [NotifyPropertyChanged]
        public virtual List<TimesheetRecord> timesheets { get; set; }


        public override void OnNavigatedTo(Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
        {
            this.init();
            this.InvokeOnPropertyChanged("SelectedMonth", () => this.LoadTimesheets());
        }

        private void LoadTimesheets()
        {
            this.timesheets = this.dataService.GetTimesheets(this.SelectedMonth);
        }

        [ThreadingStrategy(ThreadingStrategyMode=ThreadingStrategyMode.Background)]
        public virtual void init()
        {
            this.Months = this.dataService.GetMonths();
            this.Projects = this.dataService.GetProjets();
        }

    }
}
