using Blood_Donation.ViewModels;

namespace Blood_Donation.View;


public partial class PhoneDialerPage : ContentPage
{
	public PhoneDialerPage()
	{
		InitializeComponent();
        BindingContext = new PhoneDialerViewModel();
    }
}