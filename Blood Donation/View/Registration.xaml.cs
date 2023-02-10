using Blood_Donation.Data;
using Blood_Donation.Moduli;

namespace Blood_Donation;

public partial class Registration : ContentPage
{
    public UserRepository repository;
    public List<VrstaKrvi> ListVrsteKrvi { get; set; }
    public List<Gender> ListGender { get; set; }
    public Registration()
    {
        ListVrsteKrvi = new List<VrstaKrvi>
        {
            new VrstaKrvi{Id = 1, VrsteKrviName = "A+"},
            new VrstaKrvi{Id = 2, VrsteKrviName = "O+" },
            new VrstaKrvi{Id = 3, VrsteKrviName = "B+"},
            new VrstaKrvi{Id = 4, VrsteKrviName = "AB+"},
            new VrstaKrvi{Id = 5, VrsteKrviName = "B" },
            new VrstaKrvi{Id = 6, VrsteKrviName = "A-" },
            new VrstaKrvi{Id = 7, VrsteKrviName = "O-" },
            new VrstaKrvi{Id = 8, VrsteKrviName = "B-" },
            new VrstaKrvi{Id = 8, VrsteKrviName = "AB-" }


        };

        ListGender = new List<Gender>
        {
            new Gender{Id=1, Vrsta="Male"},
            new Gender{Id=2, Vrsta="Female"},
        };

        InitializeComponent();
        VrstaKrvi.ItemsSource = ListVrsteKrvi;
        Gender.ItemsSource = ListGender;

        repository = new UserRepository();


    }

    public void SignUpButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            statusMessage.Text = "";
            statusMessage2.Text = "";
            if (string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(LastName.Text)
                    || string.IsNullOrEmpty(ContactNumber.Text) ||
                     string.IsNullOrEmpty(CityUser.Text) || string.IsNullOrEmpty(AddressUser.Text) ||
                     string.IsNullOrEmpty(EmailSignUp.Text) ||
                     string.IsNullOrEmpty(ConfirmPasswordSignUp.Text) || string.IsNullOrEmpty(PasswordSignUp.Text))
            {
                statusMessage2.Text = "Sva polja moraju biti unesena!!";
            }
            else
            {

                string DateBirthReal = string.Empty;
                DateBirthReal = DateBirth.Date.ToString();
                string BloodType = string.Empty;

                int bloodTypeChoosed = VrstaKrvi.SelectedIndex;
                string GenderUser = string.Empty;

                int genderChoosed = Gender.SelectedIndex;

                if (bloodTypeChoosed < 0 || bloodTypeChoosed > ListVrsteKrvi.Count || genderChoosed < 0 || genderChoosed > ListGender.Count)
                {

                    if (bloodTypeChoosed < 0 || bloodTypeChoosed > ListVrsteKrvi.Count)
                    {
                        statusMessage.Text = "Molimo odaberite Vašu krvnu grupu!!";
                    }
                    if (genderChoosed < 0 || genderChoosed > ListGender.Count)
                    {
                        statusMessage2.Text = "Molimo odaberite Vaš spol!!";
                    }

                }
                else
                {
                    GenderUser = Gender.Items[genderChoosed];
                    BloodType = VrstaKrvi.Items[bloodTypeChoosed];
                    if (ConfirmPasswordSignUp.Text.Equals(PasswordSignUp.Text))
                    {
                        string image = "user.jpg";
                        repository.AddUser(FirstName.Text, LastName.Text, DateBirthReal, BloodType, GenderUser, ContactNumber.Text, CityUser.Text, AddressUser.Text,image, EmailSignUp.Text, PasswordSignUp.Text);
                        statusMessage.Text = repository.StatusMessage;
                        FirstName.Text = null;
                        LastName.Text = null;
                        DateBirth = null;
                        VrstaKrvi = null;
                        Gender = null;
                        ContactNumber.Text = null;
                        CityUser.Text = null;
                        AddressUser.Text = null;
                        EmailSignUp.Text = null;
                        PasswordSignUp.Text = null;
                        ConfirmPasswordSignUp.Text = null;


                    }
                    else
                    {
                        statusMessage2.Text = "Confrim password and password are not equal!";
                    }
                }
            }
            
        }
        catch (Exception ex)
        {
            statusMessage.Text = string.Format("Prilikom registracije došlo je do pogreške, pokušajte ponovno poslije {0}", ex.Message);
        }
    }
}
