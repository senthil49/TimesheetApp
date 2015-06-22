using Imaginera.UnityExtensions.Interception;
using Imaginera.UnityExtensions.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.ViewModel.DesignTime
{
    [InterceptClass]
    [ExcludeRegistration]
    public class ButtonsViewModel : BaseViewModel, IButtonsViewModel
    {


    }
}
