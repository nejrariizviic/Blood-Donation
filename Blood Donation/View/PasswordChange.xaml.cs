namespace Blood_Donation.View;
using Blood_Donation.Data;
using SQLite;

public partial class PasswordChange : ContentPage
{
	public PasswordChange()
	{
		InitializeComponent();

		imePrezime.Text = "Welcome " + App.users.Name + " " + App.users.LastName + "!";
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		if(oldPassword.Text != App.users.Pass)
		{
			statusMessage.Text = "Your password is incorrect!";
		}
		else
		{
			if (string.IsNullOrEmpty(newPassword.Text))
			{
				statusMessage.Text = "Please input new password!";
			}
			else
			{
				App.users.Pass = newPassword.Text;
				statusMessage.TextColor = Colors.Green;
				statusMessage.Text = "Success!!";
                using (var conn = new SQLiteConnection(Database.DatabasePath, Database.Flags))
				{
                    conn.Update(App.users);
                }
				await Navigation.PopAsync();
			}
		}
	}
}