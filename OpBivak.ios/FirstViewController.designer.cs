// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace OpBivak.ios
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnCallKipdorp { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextView txtIntro { get; set; }

		[Action ("btnCallKipdorp_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnCallKipdorp_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCallKipdorp != null) {
				btnCallKipdorp.Dispose ();
				btnCallKipdorp = null;
			}
			if (txtIntro != null) {
				txtIntro.Dispose ();
				txtIntro = null;
			}
		}
	}
}
