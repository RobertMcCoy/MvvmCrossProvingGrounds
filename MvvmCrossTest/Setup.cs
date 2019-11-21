using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Logging;
using MvvmCrossTest.Core;
using UIKit;

namespace MvvmCrossTest.Ios
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
        : base(appDelegate, presenter)
        {
        }
        protected override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.None;

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}