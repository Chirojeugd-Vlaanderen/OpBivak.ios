using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace OpBivak.ios
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
			//Title = NSBundle.MainBundle.LocalizedString ("SOS", "SOS");
			TabBarItem.Image = UIImage.FromBundle ("ios7-telephone");
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		partial void btnHulp_TouchUpInside (UIButton sender){
			Call("112");
		}

		partial void btnAntigif_TouchUpInside (UIButton sender){
			Call("+3270245245");
		}

		partial void btnApotheek_TouchUpInside (UIButton sender){
			Call("+3290010500");

		}

		partial void btnDokter_TouchUpInside (UIButton sender){
			Call("1733");
		}

		partial void btnPolitie_TouchUpInside (UIButton sender){
			Call("101");
		}
		public bool Call(string number){
			var urlToSend = new NSUrl ("tel://" + number);
			if (UIApplication.SharedApplication.CanOpenUrl (urlToSend)) {
				UIApplication.SharedApplication.OpenUrl (urlToSend);
				return true;
			} else {
				UIAlertView alert = new UIAlertView ();
				alert.Title = "Foutje";
				alert.AddButton ("OK");
				alert.Message = "Dit toestel heeft heeft geen telefoon functionaliteit. Zoek een telefoon en bel " + number + ".";
				alert.Show ();
				return false;


			}
		}
		#endregion
	}
}

