using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Threading.Tasks;

namespace MvvmCrossTest.Core
{
    public class MainViewModel : MvxViewModel
    {
        public IMvxCommand GoToNextViewModelCommand { get; set; }

        public string HelloText => "Hello";

        public MainViewModel()
        {
            this.GoToNextViewModelCommand = new MvxCommand(this.DoGoToNextViewModel);
        }

        private void DoGoToNextViewModel()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
