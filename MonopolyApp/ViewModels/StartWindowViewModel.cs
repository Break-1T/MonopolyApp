using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Navigation;
using MonopolyApp.Infrastructure.Commands.Base;
using MonopolyApp.ViewModels.Base;

namespace MonopolyApp.ViewModels
{
    class StartWindowViewModel:ViewModel
    {
        public StartWindowViewModel()
        {
            ICommand = new Command();
        }

        private ICommand ExitCommand;
    }
}
