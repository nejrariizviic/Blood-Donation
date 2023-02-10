using Blood_Donation.Data;
using SQLite;

namespace Blood_Donation.View;

public partial class EditProfilePage : ContentPage
{
     public EditProfilePage()
    {
        InitializeComponent();

        imePrezime.Text = "Welcome " + App.users.Name + " " + App.users.LastName + "!";

        nameEntry.Text = App.users.Name;
        lastnameEntry.Text = App.users.LastName;
        addressEntry.Text = App.users.Address;
        cityEntry.Text = App.users.City;
        emailEntry.Text = App.users.Email;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(lastnameEntry.Text) || string.IsNullOrEmpty(addressEntry.Text) ||
            string.IsNullOrEmpty(cityEntry.Text) || string.IsNullOrEmpty(emailEntry.Text))
        {
            statusMessage.Text = "Check if there is empty field!!";
        }
        else
        {
            App.users.Name = nameEntry.Text;
            App.users.LastName = lastnameEntry.Text;
            App.users.Address = addressEntry.Text;
            App.users.City = cityEntry.Text;
            App.users.Email = emailEntry.Text;
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
