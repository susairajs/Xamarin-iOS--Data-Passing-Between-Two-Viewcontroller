using Foundation;
using System;
using UIKit;

namespace XamarinIosDataPass
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController(IntPtr handle) : base(handle)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			lblDisplay.Text = CommonClass.value;

		}
	}
}