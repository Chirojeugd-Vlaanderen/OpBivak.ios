using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using System;


namespace OpBivak.ios
{
	partial class SettingsViewController : UITableViewController
	{
		public SettingsViewController (IntPtr handle) : base (handle)
		{
			//Title = NSBundle.MainBundle.LocalizedString ("Instellingen", "Instellingen");
			TabBarItem.Image = UIImage.FromBundle ("gear");

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();
			this.txtVoornaam.ShouldReturn += (textField) => {
				this.txtLastName.BecomeFirstResponder();
				return true;
			};

			this.txtLastName.ShouldReturn += (textField) => {
				this.txtStamNummer.BecomeFirstResponder();
				return true;
			};
			this.txtStamNummer.ShouldReturn += (textField) => {
				this.txtGroepNaam.BecomeFirstResponder();
				return true;
			};
			this.txtGroepNaam.ShouldReturn += (textField) => {
				this.txtGroepGemeente.BecomeFirstResponder();
				return true;
			};
			this.txtGroepGemeente.ShouldReturn += (textField) => {
				textField.ResignFirstResponder();
				return true;
			};
		

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			// get settings

			string firstname = NSUserDefaults.StandardUserDefaults.StringForKey ("firstNameKey");
			string lastname = NSUserDefaults.StandardUserDefaults.StringForKey("lastNameKey");
			string stamnummer = NSUserDefaults.StandardUserDefaults.StringForKey("stamNummerKey");
			string groep = NSUserDefaults.StandardUserDefaults.StringForKey("chiroGroepKey");
			string gemeente = NSUserDefaults.StandardUserDefaults.StringForKey("groepGemeenteKey");
			if (!string.IsNullOrWhiteSpace (firstname)) {
				txtVoornaam.Text = firstname;
			}
			if (!string.IsNullOrWhiteSpace(lastname)){
					txtLastName.Text= lastname;
			}
			if (!string.IsNullOrWhiteSpace(stamnummer)){
				txtStamNummer.Text= stamnummer;
			}
			if (!string.IsNullOrWhiteSpace(groep)){
				txtGroepNaam.Text= groep;
			}
			if (!string.IsNullOrWhiteSpace(gemeente)){
				txtGroepGemeente.Text= gemeente;
			}
			//btnSendSms.SetState (NSUserDefaults.StandardUserDefaults.BoolForKey ("noSmsKey"), false);
		}

		partial void txtName_Changed (UITextField sender){
			saveSettings();
		}

		public void saveSettings(){
			NSBundle.MainBundle.PathForResource ("Settings", @"bundle");
			if (txtVoornaam.Text != null) {
				NSUserDefaults.StandardUserDefaults.SetString (txtVoornaam.Text, "firstNameKey");
			}
			if (txtLastName.Text != null) {
				NSUserDefaults.StandardUserDefaults.SetString (txtLastName.Text, "lastNameKey");
			}
			if (txtStamNummer.Text != null) {
				NSUserDefaults.StandardUserDefaults.SetString (txtStamNummer.Text, "stamNummerKey");
			}
			if (txtGroepNaam.Text != null) {
				NSUserDefaults.StandardUserDefaults.SetString (txtGroepNaam.Text, "chiroGroepKey");
			}
			if (txtGroepGemeente.Text != null) {
				NSUserDefaults.StandardUserDefaults.SetString (txtGroepGemeente.Text, "groepGemeenteKey");
			}
			if (NSUserDefaults.StandardUserDefaults.Synchronize () == true) {
				Console.WriteLine ("Settings saved");

			} else {
				Console.WriteLine ("saving failed");

			}
			//if btnSendSms.
			//NSUserDefaults.StandardUserDefaults.SetValueForKey((bool)btnSendSms.State, "noSmsKey");
		}
	}
}
