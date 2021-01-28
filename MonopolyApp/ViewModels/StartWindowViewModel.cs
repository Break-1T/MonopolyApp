using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using MonopolyApp.Infrastructure.Commands;
using MonopolyApp.Infrastructure.Commands.Base;
using MonopolyApp.View;
using MonopolyApp.ViewModels.Base;

namespace MonopolyApp.ViewModels
{
    class StartWindowViewModel:ViewModel
    {
        public StartWindowViewModel()
        {
            #region Commands
            
            ExitCommand = new LambdaCommand(OnExitApplicationCommandExecuted,CanExitApplicationCommandExecute);
            OpenGameCommand =
                new LambdaCommand(OnOpenGameApplicationCommandExecuted, CanOpenGameApplicationCommandExecute);

            #endregion

        }

        #region Windows

        private MainGame maingame;
        

        #endregion

        #region Commands
        public ICommand ExitCommand { get; }
        public ICommand OpenGameCommand { get; }
        
        private void OnExitApplicationCommandExecuted(object p)
        {
            Application.Current.MainWindow.Close();
        }
        private bool CanExitApplicationCommandExecute(object p)
        {
            return true;
        }

        private void OnOpenGameApplicationCommandExecuted(object p)
        {
            maingame = new MainGame();
            maingame.Show();
        }
        private bool CanOpenGameApplicationCommandExecute(object p)
        {
            return true;
        }


        #endregion
    }
}
