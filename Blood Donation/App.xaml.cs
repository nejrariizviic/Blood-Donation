using Blood_Donation.Moduli;

namespace Blood_Donation;

public partial class App : Application

{
	public static User users { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
