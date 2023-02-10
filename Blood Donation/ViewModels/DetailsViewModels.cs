using Blood_Donation.Moduli;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Blood_Donation.ViewModels
{
    public class DetailsViewModels : Home
    {


        #region Properties

    private string _buttonText = "Next";
    private string _btnPrew ="";


    public string ButtonText
    {
        get => _buttonText;
        set => SetProperty(ref _buttonText, value);
    }

    public string ButtonPrew
    {
        get => _btnPrew;
        set => SetProperty(ref _btnPrew, value);
    }


    private int _position;

    public int Position
    {
         
        get => _position;
        set => SetProperty(ref _position, value, onChanged: (() =>
        {
            if (value == Details.Count - 1)
            {
                ButtonText = "Start";
                ButtonPrew = "Previous";

            }
            else if (value == 0)
            {
                ButtonText = "Next";
                ButtonPrew = "";


            }
            else
            {
                ButtonText = "Next";
                ButtonPrew = "Previous";
            }
        }));
    }


    public ObservableCollection<DetailsModel> Details { get; set; } = new ObservableCollection<DetailsModel>();
    #endregion
    public DetailsViewModels()
    {
        Details.Add(new DetailsModel
        {
            DetailImage = "gg.png",
            DetailTitle = "Blood Donation",
            DetailDescription = " \t\t Why should you do it? You may already  " +
                                "\n \t know about the ongoing need for blood and   " +
                                 "\n the importance of your blood donations. With " +
                                 "\n  \t your blood donation, you give someone a  " +
                                 "\n \t know about the ongoing need for blood and   "
        });

        Details.Add(new DetailsModel
        {
            DetailImage = "prvaslika.png",
            DetailTitle = "Application",
            DetailDescription = "\t\tWith its easiest and most intuitive User  " +
                                    " \nInterface, helps you to know people in need of " +
                                    " \n\tblood or friends available to donate blood." +
                                    " \n\t\t Donating blood is easier than ever... "
        });


        Details.Add(new DetailsModel
        {
            DetailImage = "treca.jpg",
            DetailTitle = "Use of the app",
            DetailDescription = "\t\t\t1. Create your membership card" +
                                    "\n\t\t2. Start using the application" +
                                    "\n\t3. Contact the donation institutions" +
                                    "\n\t\t4. Meet more heroes in your area" +
                                    "\n\t5.All that remains is to go and donate"
        });


        Details.Add(new DetailsModel
        {
            DetailImage = "zadnja.jpg",
            DetailTitle = "Become a donor",
            DetailDescription = "Every Blood Donar is a hero " +
                                    "\n\tBe a Hero Give Blood..."
        });
    }
    

    public ICommand NextCommand => new Command(async () =>
    {
        Console.WriteLine(Position);
        if (Position == Details.Count - 1)
        {
         await AppShell.Current.GoToAsync($"//{nameof(HomePageLogin)}");

        }
        else if(Position == 0)
        {
            Position = 1;
            Position--;
            Position++;
        }
        else
        {
            Position += 1;
            Console.WriteLine(Position);
        }
        
        
    });

    public ICommand PreviousCommand => new Command( () =>
        {
            Console.WriteLine(Position);
            if (Position == 0)
                
                ButtonPrew = "";
            else
                Position -= 1;
                Console.WriteLine(Position);




        });


    }
}
