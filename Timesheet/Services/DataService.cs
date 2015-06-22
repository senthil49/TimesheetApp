using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Model;

namespace Timesheet.Services
{
   public class DataService : IDataService
    {
        public List<string> GetProjets()
        {
            using(var context = new TimesheetEntities())
            {
                var projects = context.Projects.Select(x => x.Project1).ToList();
                return projects;
            }
        }

        public response<string> SaveTimesheet(Timesheet.Model.Timesheet timesheet)
        {
            var response = new response<string>();

            try
            {
                using (var context = new TimesheetEntities())
                {
                    context.Timesheets.Add(timesheet);
                    context.SaveChanges();
                }

                response.result = true;

                return response;
            }
            catch (Exception ex)
            {
                response.result = false;
                response.data = ex.ToString();
                return response;
            }
        }

       public List<string> GetMonths()
        {
           var months = new List<DateTime>();
           var months2 = new List<string>();

           using (var context = new TimesheetEntities())
           {
               var timesheetDates = context.Timesheets.OrderBy(x => x.EnteredDate).Select(x => x.EnteredDate).ToList();

               foreach (var dt in timesheetDates)
               {
                 var d = dt ?? new DateTime();
                   months.Add(d);
               }

               foreach (var date in months)
               {
                       months2.Add(date.ToString("MMMM"));
               }

               return months2.Distinct().ToList();
           }

        }

       public List<TimesheetRecord> GetTimesheets(string selectedMonth)
       {
           var timesheets = new List<TimesheetRecord>();

           using (var context = new TimesheetEntities())
           {
              var _timesheets = context.Timesheets.Select(x => x).ToList();

              foreach (var ts in _timesheets)
              {
                  {
                       TimesheetRecord timesheet = new TimesheetRecord();

                       timesheet.EnteredDate = ts.EnteredDate ?? new DateTime();
                       timesheet.HoursWorked = ts.HoursWorked ?? 0.0;
                       timesheet.ProjectName = ts.Project;
                       timesheet.Task = ts.Task;
                       timesheets.Add(timesheet);
                  }
              }

               var m  = timesheets.Where(x => x.EnteredDate.ToString("MMMM") == selectedMonth).ToList();
               return m;
           }
       }

    }
}
