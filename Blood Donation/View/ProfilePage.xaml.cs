
using Blood_Donation.Data;
using Blood_Donation.Moduli;
using Blood_Donation.Services;

namespace Blood_Donation.View;

public partial class ProfilePage : ContentPage
{
    UploadImage uploadImage { get; set; }
    DonationHistoryRepository dons;
    public ProfilePage()
	{
        InitializeComponent();
        dons = new DonationHistoryRepository();
        uploadImage = new UploadImage();
        imePrezime.Text = App.users.Name + " " + App.users.LastName;
        cityUser.Text = App.users.City;
        bloodgroupUser.Text = App.users.BloodGroup;
        placeForEmail.Text = App.users.Email;
        placeForDate.Text = App.users.DateOfBirth;
        placeForGender.Text = App.users.Gender;
        cityAndAddress.Text = App.users.City + ", " + App.users.Address;
        numberUser.Text = App.users.ContactNumber;
     
        ListaUstanovaZaKrv.ItemsSource = dons.GetDonationHistoryByUserId(App.users.Id);

        numberOfDonations.Text = dons.GetDonationHistoryByUserId(App.users.Id).Count().ToString();

        DateTime times = DateTime.Now;
        dateOfdonation.Text = times.ToString().Substring(0, 12);

        DateTime nextDate = times.AddMonths(3);
        string next = nextDate.ToString();
        dateOfNext.Text = next.Substring(0, 12);
    }

    private async void UploadImage_Clicked(object sender, EventArgs e)
    {
        var img = await uploadImage.OpenMediaPickerAsync();

        var imagefile = await uploadImage.Upload(img);
        //var imgByteArray = uploadImage.StringToByteBase64(imagefile.byteBase64);
        //var imgString = Convert.ToBase64String(imgByteArray);
        
        Image_Upload.Source = ImageSource.FromStream(() =>
            uploadImage.ByteArrayToStream(uploadImage.StringToByteBase64(imagefile.byteBase64))
        );
    }

}