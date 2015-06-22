using Imaginera.UnityExtensions.Interception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Model
{
   [InterceptClass]
   public class TimesheetRecord : INotifyPropertyChanged, IDataErrorInfo
    {
        private DateTime enteredDate;
        private double hoursWorked;
        private string task;
        private string projectName;

        public DateTime EnteredDate 
        { 
            get
            {
                return this.enteredDate;
            }

            set
            {
                this.enteredDate = value;
                this.OnPropertyChanged("EnteredDate");
            }
        }

        public double HoursWorked 
        {
            get
            {
                return this.hoursWorked;
            }

            set
            {
                this.hoursWorked = value;
                
                this.OnPropertyChanged("HoursWorked");
            }
        }
        public string Task 
        {
            get
            {
                return this.task;
            }

            set
            {
                this.task = value;
                this.OnPropertyChanged("Task");
            }
        }
        public string ProjectName 
        {
            get
            {
                return this.projectName;
            }

            set
            {
                this.projectName = value;
                this.OnPropertyChanged("ProjectName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// The on property changed.
        /// </summary>
        /// <param name="caller">
        /// The caller.
        /// </param>
        public void OnPropertyChanged(
          [CallerMemberName] string caller = "")
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }


        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get { return null; }
        }
    }
}
