using Blood_Donation.Data;
using Blood_Donation.Moduli;
using Blood_Donation.View;

namespace Blood_Donation;

public partial class HomePageLogin : ContentPage
{
    UserRepository userRepository;
	public HomePageLogin()
	{
		InitializeComponent();

        userRepository = new UserRepository();
	}

    private async void RegistrationButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
        EmailUser.Text = null;
        PasswordUser.Text = null;
        StatusMessage.Text = null;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var user = userRepository.GetUserByEmail(EmailUser.Text);

        if(user != null && user.Pass == PasswordUser.Text)
        {
            App.users = user;
            await Shell.Current.GoToAsync("//Home");
            EmailUser.Text = null;
            PasswordUser.Text = null;
            StatusMessage.Text = null;
        }
        else
        {
            StatusMessage.Text = "Email is incorrect or password. Please try again!!";
        }
    }

    public bool ValidateUser(string email, string pass)
    {
        var user = userRepository.GetUserByEmail(email);
        if(user != null && user.Pass == pass)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public User GetUserByEmail(string email)
    {
        return userRepository.GetUserByEmail(email);
    }

}