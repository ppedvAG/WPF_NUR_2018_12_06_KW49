using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands
{
    public class CloseCommand : ICommand
    {
       public bool CanExecute(object parameter)
        {
            return (parameter as MainWindow).Width > 402;
        }

        public void Execute(object parameter)
        {
            (parameter as MainWindow).Close();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
