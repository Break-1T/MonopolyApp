using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;
using MonopolyApp.ViewModels.Base;

namespace MonopolyApp.ViewModels
{
    class StartWindowViewModel:ViewModel
    {
        public StartWindowViewModel()
        {
            _Title = "Начать игру!";
        }

        private string _Title;

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
