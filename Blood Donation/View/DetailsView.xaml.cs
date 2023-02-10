using Blood_Donation.ViewModels;
using Microsoft.Maui.Controls.Internals;

namespace Blood_Donation;

public partial class DetailsView : ContentPage
{
	public DetailsView()
	{
		InitializeComponent();

        this.BindingContext = new DetailsViewModels();

       

    }


}