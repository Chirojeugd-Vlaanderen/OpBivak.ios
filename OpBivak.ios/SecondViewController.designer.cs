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
		[Action ("btnAntigif_TouchUpInside:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void btnAntigif_TouchUpInside (UIButton sender);

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnApotheek { get; set; }
		[Action ("btnApotheek_TouchUpInside:")]
		partial void btnApotheek_TouchUpInside (UIButton sender);

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnDokter { get; set; }
		[Action ("btnDokter_TouchUpInside:")]
		partial void btnDokter_TouchUpInside (UIButton sender);

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnHulp { get; set; }
		[Action ("btnHulp_TouchUpInside:")]
		partial void btnHulp_TouchUpInside (UIButton sender);

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnPolitie { get; set; }
		[Action ("btnPolitie_TouchUpInside:")]
		partial void btnPolitie_TouchUpInside (UIButton sender);

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextView txtSos { get; set; }



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
