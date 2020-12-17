using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WetherAPp.ViewModel.command
{
    public class Command : ICommand
    {
        public Command(accViewModel viewModel)
        {
            vm = viewModel;
        }
        public accViewModel vm { get; set; }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.GetCities();
        }
    }
}
