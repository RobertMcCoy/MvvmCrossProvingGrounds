using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Threading.Tasks;

namespace MvvmCrossTest.Core
{
    public class TertiaryViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService MvxNavigationService;

        public IMvxAsyncCommand GoBackCommand { get; set; }

        private MyObject myObject;
        public MyObject MyObject { get => myObject; set => this.SetProperty(ref myObject, value); }

        public TertiaryViewModel(IMvxNavigationService mvxNavigationService)
        {
            this.GoBackCommand = new MvxAsyncCommand(this.DoGoBack);

            MvxNavigationService = mvxNavigationService;
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            this.MyObject = await this.DelayGettingMyObject();
        }

        private async Task<MyObject> DelayGettingMyObject()
        {
            await Task.Delay(500);

            return new MyObject { MyObjectString = "Howdy There!" };
        }

        private async Task DoGoBack()
        {
            await this.MvxNavigationService.Close(this);
        }
    }

    public class MyObject
    {
        public string MyObjectString { get; set; }
    }
}
