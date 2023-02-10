

namespace Blood_Donation.View;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();

    }


	public void Button_Clicked(object sender, EventArgs e)
	{
		App.users = null;
        Navigation.PushModalAsync(new HomePageLogin());
    }

	private async void ImageButton_Clicked_1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new EditProfilePage());
	}

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new PasswordChange());
    }
}