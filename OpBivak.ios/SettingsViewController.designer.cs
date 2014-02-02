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
	[Register ("SettingsViewController")]
	partial class SettingsViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtGroepGemeente { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtGroepNaam { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtLastName { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtStamNummer { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtVoornaam { get; set; }

		[Action ("txtName_Changed:")]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		partial void txtName_Changed (UITextField sender);

		void ReleaseDesignerOutlets ()
		{
			if (txtGroepGemeente != null) {
				txtGroepGemeente.Dispose ();
				txtGroepGemeente = null;
			}
			if (txtGroepNaam != null) {
				txtGroepNaam.Dispose ();
				txtGroepNaam = null;
			}
			if (txtLastName != null) {
				txtLastName.Dispose ();
				txtLastName = null;
			}
			if (txtStamNummer != null) {
				txtStamNummer.Dispose ();
				txtStamNummer = null;
			}
			if (txtVoornaam != null) {
				txtVoornaam.Dispose ();
				txtVoornaam = null;
			}
		}
	}
}
