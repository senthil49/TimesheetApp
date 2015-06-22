using Imaginera.UnityExtensions.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.ViewModel.DesignTime
{
    [ExcludeRegistration]
   public class ViewTimesheetViewModel :BaseViewModel, IViewTimesheetViewModel
    {
        public virtual List<string> Months { get; set; }

        public ViewTimesheetViewModel()
        {
            this.Months = new List<string> { "Januray, February, March" };
        }
    }
}
