namespace Blood_Donation.View;

public partial class Share : ContentPage
{
	public Share()
	{
		InitializeComponent();
	}

    private async void LookButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SharePage());
    }
}