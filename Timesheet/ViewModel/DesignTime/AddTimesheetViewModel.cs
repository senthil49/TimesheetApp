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


namespace Timesheet.ViewModel.DesignTime
{
   [InterceptClass]
   [ExcludeRegistration]
   public class AddTimesheetViewModel : BaseViewModel, IAddTimesheetViewModel
    {
       public AddTimesheetViewModel()
       {
           timesheet = new Model.Timesheet 
                           { 
                               Task = "New Task",
                               Project = "Timesheet",
                               EnteredDate = DateTime.Today,
                               HoursWorked = 4
                           };
           this.SelectedProject = "TEST";
       }

       [NotifyPropertyChanged]
       public virtual Timesheet.Model.Timesheet timesheet { get; set; } 

       public string SelectedProject { get; set; }
     
    }
}
