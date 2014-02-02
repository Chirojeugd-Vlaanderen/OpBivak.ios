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
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnAntigif { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnApotheek { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnDokter { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnHulp { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnPolitie { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextView txtSos { get; set; }

		[Action ("btnAntigif_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnAntigif_TouchUpInside (UIButton sender);

		[Action ("btnApotheek_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnApotheek_TouchUpInside (UIButton sender);

		[Action ("btnDokter_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnDokter_TouchUpInside (UIButton sender);

		[Action ("btnHulp_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnHulp_TouchUpInside (UIButton sender);

		[Action ("btnPolitie_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnPolitie_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAntigif != null) {
				btnAntigif.Dispose ();
				btnAntigif = null;
			}
			if (btnApotheek != null) {
				btnApotheek.Dispose ();
				btnApotheek = null;
			}
			if (btnDokter != null) {
				btnDokter.Dispose ();
				btnDokter = null;
			}
			if (btnHulp != null) {
				btnHulp.Dispose ();
				btnHulp = null;
			}
			if (btnPolitie != null) {
				btnPolitie.Dispose ();
				btnPolitie = null;
			}
			if (txtSos != null) {
				txtSos.Dispose ();
				txtSos = null;
			}
		}
	}
}
