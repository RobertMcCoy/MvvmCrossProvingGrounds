using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using MvvmCross.iOS.Views.Presenters.Attributes;
using MvvmCross.iOS.Views;
using MvvmCrossTest.Core;
using MvvmCross.Binding.BindingContext;
using CoreGraphics;

namespace MvvmCrossTest.Ios.Views
{
    //[MvxRootPresentation(WrapInNavigationController = true)]
    public class MainViewController : MvxViewController<MainViewModel>
    {
        public MainViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            var myButton = new UIButton(new CGRect(0, 200, 200, 50));
            myButton.SetTitle("Go to second VM", UIControlState.Normal);
            myButton.BackgroundColor = UIColor.Black;

            this.View.AddSubview(myButton);
            this.View.BackgroundColor = UIColor.White;

            var label = new UILabel(new CGRect(0, 300, 200, 50));
            this.View.AddSubview(label);

            this.View.BringSubviewToFront(myButton);

            var bindingSet = this.CreateBindingSet<MainViewController, MainViewModel>();

            bindingSet.Bind(myButton).To(vm => vm.GoToNextViewModelCommand);
            bindingSet.Bind(label).To(vm => vm.HelloText);

            bindingSet.Apply();
            // Perform any additional setup after loading the view
        }
    }
}