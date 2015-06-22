using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Model;

namespace Timesheet.Services
{
   public interface IDataService
    {

       List<string> GetProjets();

       response<string> SaveTimesheet(Timesheet.Model.Timesheet timesheet);

       List<string> GetMonths();

       List<TimesheetRecord> GetTimesheets(string selectedMonth);
    }
}
