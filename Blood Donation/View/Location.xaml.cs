namespace Blood_Donation.View;
using Blood_Donation.Data;
using Blood_Donation.Moduli;
using System.Collections.ObjectModel;

public partial class Location : ContentPage
{
    UserRepository Repository;
    public IList<User> SviDonatori { get; set; }
    public ObservableCollection<User> FiltriraniDonatori { get; set; }
    public Location()
    {
        InitializeComponent();
        Repository = new UserRepository();
        SviDonatori = KreirajListuDonatora(App.users.City, App.users.Id);
        FiltriraniDonatori = new ObservableCollection<User>(SviDonatori);
        ListaDonatora.ItemsSource = FiltriraniDonatori;

      
    }
        public List<User> KreirajListuDonatora(string city, int id)
    {
        List<User> source = Repository.GetAllUsers().Where(user => user.City == city && user.Id != id).ToList();

        return source;
    }

    public List<User> FiltrirajListuDonatora(string searchText)
    {
        List<User> filteredSource = SviDonatori.Where(donatori => donatori.Name.Contains(searchText, StringComparison.InvariantCultureIgnoreCase)).ToList();
        return filteredSource;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        //DisplayAlert("Key", searchBar.Text, "OK");

        ListaDonatora.ItemsSource = FiltrirajListuDonatora(searchBar.Text);


    }
 
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        var selectedUser = (User)((ImageButton)sender).BindingContext;

        await DisplayAlert("\t\tDetalji profila", $"\n\nIme: {selectedUser.Name}\nGrad: {selectedUser.City}\nEmail: {selectedUser.Email}", "Close...");
    }
}