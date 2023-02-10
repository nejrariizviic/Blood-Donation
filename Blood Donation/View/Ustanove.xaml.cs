using System.Collections.ObjectModel;
using Blood_Donation.Data;
using Blood_Donation.Moduli;
using Plugin.LocalNotification;

namespace Blood_Donation.View;

public partial class Ustanove : ContentPage
{
    public IList<ListaUstanova> SveUstanove { get; set; }
    public ObservableCollection<ListaUstanova> FiltriraneUstanove { get; set; }
    public DonationHistoryRepository dons;
    public Ustanove()
    {
        InitializeComponent();
        SveUstanove = KreirajListuUstanova();
        FiltriraneUstanove = new ObservableCollection<ListaUstanova>(SveUstanove);
        ListaUstanovaZaKrv.ItemsSource = FiltriraneUstanove;

        dons = new DonationHistoryRepository();
    }

    private List<ListaUstanova> KreirajListuUstanova()
    {
        List<ListaUstanova> source = new List<ListaUstanova>
            {
                new ListaUstanova
                {

                    Name = "Firos nv",
                    Location="Franklin, Alibama    ",
                    Image="apoz.png"
                },

                new ListaUstanova
                {
                    Name = "Abraham Zack",
                    Location="San Francisco, CA   ",
                    Image="apoz.png"
                },

                new ListaUstanova
                {

                    Name = "Sunil Kumar",
                    Location="Washington, DC      ",
                    Image="apoz.png"
                },

                new ListaUstanova
                {
                    Name = "John Thomas",
                    Location="San Francisco, CA   ",
                    Image="apoz.png"
                },

                new ListaUstanova
                {

                    Name = "Alex Smith",
                    Location="Springfield, Florida",
                    Image="apoz.png"
                }

            };

        return source;
    }

    private List<ListaUstanova> FiltrirajListuUstanova(string searchText)
    {
        List<ListaUstanova> filteredSource = SveUstanove.Where(ustanove => ustanove.Name.Contains(searchText, StringComparison.InvariantCultureIgnoreCase)).ToList();
        return filteredSource;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        ListaUstanovaZaKrv.ItemsSource = FiltrirajListuUstanova(searchBar.Text);


    }

    private async void CallButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhoneDialerPage());
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        DateTime trenutno = DateTime.Now;
        DateTime time;
        if(trenutno.Hour < 15 && trenutno.Hour > 0)
        {
           time = trenutno.AddDays(1);
        }
        else
        {
           time = trenutno.AddDays(2);
        }
        var selectedUstanova = (ListaUstanova)((ImageButton)sender).BindingContext;
       bool answer = await DisplayAlert("\t\tQuestion??", $"\n\n{selectedUstanova.Name}\n\nDo you suffer from or have suffered from any of the following diseases?\n - Heart Disease, Diabetes, STD, LungDisease, Allergic Disease, Epilepsy, Cancer, Malaria\nAre you taking or have you taken any of these in the past 72 hours?\n - Antibiotics, Steroids, Aspirin, Vaccinations, Alcohol\nIn the last six months have you had any of the following?\n- Ear piercing, Dental extraction, Tattoing\n\n If you had any of these, please press CANCEL, if not press OK and you will get notification about your appointment! If you are not,, please allow notifications from our app!", "OK", "Cancel");

        var request = new NotificationRequest
        {
            NotificationId = 123,
            Title = "Obavijest o darivanju krvi!",
            Description = selectedUstanova.Name + " - " + selectedUstanova.Location + time.ToString(),
            BadgeNumber = 42,
        };
        if (answer)
        {
          
           await LocalNotificationCenter.Current.Show(request);
            dons.AddOne(selectedUstanova.Location,time.ToString(),App.users.Id);
            Console.Write("Ok");
        }
        else
        {

            Console.Write("Nije ok");
        }
    }
}