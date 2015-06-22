using Imaginera.UnityExtensions.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timesheet.ViewModel;

namespace Timesheet.Views
{
    /// <summary>
    /// Interaction logic for AddTimesheetView.xaml
    /// </summary>
    [NamedRegistration(RegistrationName = "AddTimesheetView")]
    [RegisterAsType(RegistrationType = typeof(object))]
    public partial class AddTimesheetView : BaseView, INotifyPropertyChanged
    {
        public AddTimesheetView(IAddTimesheetViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
