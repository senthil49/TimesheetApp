using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Model
{
   public class response<T>
    
   {
       public bool result { get; set; }
       public T data { get; set; }
    }
}
