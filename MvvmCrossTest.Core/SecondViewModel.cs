using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Threading.Tasks;

namespace MvvmCrossTest.Core
{
    public class SecondViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService MvxNavigationService;

        public IMvxAsyncCommand GoToNextViewModelCommand { get; set; }

        public string HelloText => "Hello";


        public SecondViewModel(IMvxNavigationService mvxNavigationService)
        {
            this.GoToNextViewModelCommand = new MvxAsyncCommand(this.DoGoToNextViewModel);

            MvxNavigationService = mvxNavigationService;
        }

        private async Task DoGoToNextViewModel()
        {
            await this.MvxNavigationService.Navigate<TertiaryViewModel>();
        }
    }
}
