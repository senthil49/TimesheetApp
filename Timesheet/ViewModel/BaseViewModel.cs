using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.ViewModel
{
   public class BaseViewModel: INavigationAware, INotifyPropertyChanged, IDisposable
    {
        public void Dispose()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            this.Dispose();
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }


        protected void InvokeOnPropertyChanged(string property, Action action)
        {
            this.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == property)
                {
                    action();
                }
            };
        }
    }
}
