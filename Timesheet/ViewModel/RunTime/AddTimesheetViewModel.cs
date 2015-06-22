using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Model;
using Imaginera.UnityExtensions.Interception;
using Imaginera.UnityExtensions.Interception.PropertyNotification;
using Imaginera.UnityExtensions.Interception.Threading;
using Imaginera.UnityExtensions.Registration;

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Timesheet.Services;
using System.Windows.Input;


namespace Timesheet.ViewModel.RunTime
{
   [InterceptClass]
   public class AddTimesheetViewModel : BaseViewModel, IAddTimesheetViewModel
    {
       private readonly IDataService dataService;

       private TimesheetRecord timesheet; 

       [NotifyPropertyChanged]
       public virtual TimesheetRecord Timesheet 
       { 
           get
           {
               return this.timesheet;
               timesheet.EnteredDate = DateTime.Today;
               timesheet.HoursWorked = 0;
           }
           set
           {
               this.timesheet = value;
               this.timesheet.PropertyChanged += (sender, args) => ((DelegateCommand)this.SaveCommand).RaiseCanExecuteChanged();
           }
       }

       [NotifyPropertyChanged]
       public virtual List<string> Projects { get; set;  }

       public AddTimesheetViewModel(IDataService dataService)
       {
            this.dataService = dataService;
            this.SaveCommand = new DelegateCommand(this.Save, this.CanSave);
            this.InvokeOnPropertyChanged("SelectedProject", () => ((DelegateCommand)this.SaveCommand).RaiseCanExecuteChanged());
       }

       [NotifyPropertyChanged] 
       public virtual string SelectedProject {get;set;}

       public override void OnNavigatedTo(NavigationContext navigationContext)
       {
           this.Init();
       }

       [ThreadingStrategy(ThreadingStrategyMode = ThreadingStrategyMode.Background)]
       protected virtual void Save()
       {
           var _timesheet = new Timesheet.Model.Timesheet
           {
               UserName = Environment.UserName, Project = this.SelectedProject , Task = Timesheet.Task, EnteredDate = Timesheet.EnteredDate, HoursWorked = Timesheet.HoursWorked
           };

          var response = this.dataService.SaveTimesheet(_timesheet);
       }

       private bool CanSave()
       {
           return (this.SelectedProject != null && this.Timesheet.HoursWorked >= 0); 
       }

       public ICommand SaveCommand { get; set; }

       [ThreadingStrategy(ThreadingStrategyMode=ThreadingStrategyMode.Background)]
       public virtual void Init()
       {
           // Load the Projects from Database
           this.Projects = this.dataService.GetProjets();
       }
    }
}
