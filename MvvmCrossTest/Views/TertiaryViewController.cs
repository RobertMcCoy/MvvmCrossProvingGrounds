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
    //[MvxRootPresentation]
    public class TertiaryViewController : MvxViewController<TertiaryViewModel>
    {
        public TertiaryViewController()
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
            myButton.SetTitle("Go back to Second VM", UIControlState.Normal);
            myButton.BackgroundColor = UIColor.Black;
            this.View.AddSubview(myButton);
            this.View.BackgroundColor = UIColor.White;

            var label = new UILabel(new CGRect(0, 300, 200, 50));
            this.View.AddSubview(label);

            var input = new UITextField(new CGRect(0, 250, 250, 50));
            input.Placeholder = "My Cool Placeholder";
            input.BackgroundColor = UIColor.Green;
            this.View.AddSubview(input);

            var bindingSet = this.CreateBindingSet<TertiaryViewController, TertiaryViewModel>();

            bindingSet.Bind(myButton).To(vm => vm.GoBackCommand);
            bindingSet.Bind(label).To(vm => vm.MyObject.MyObjectString);
            bindingSet.Bind(input).To(vm => vm.MyObject.MyObjectString);

            bindingSet.Apply();
            // Perform any additional setup after loading the view
        }
    }
}