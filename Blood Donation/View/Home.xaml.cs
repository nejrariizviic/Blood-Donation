using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

namespace Blood_Donation.View;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    [Obsolete]

    private void Button1_MouseHover(object sender, EventArgs e)
    {
        button1.BackgroundColor = Color.FromHex("#ab0218");
        button1.TextColor = Colors.White;
    }

    [Obsolete]
    private void Button2_MouseHover(object sender, EventArgs e)
    {
        button2.BackgroundColor = Color.FromHex("#ab0218");
        button2.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button3_MouseHover(object sender, EventArgs e)
    {
        button3.BackgroundColor = Color.FromHex("#ab0218");
        button3.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button4_MouseHover(object sender, EventArgs e)
    {
        button4.BackgroundColor = Color.FromHex("#ab0218");
        button4.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button5_MouseHover(object sender, EventArgs e)
    {
        button5.BackgroundColor = Color.FromHex("#ab0218");
        button5.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button6_MouseHover(object sender, EventArgs e)
    {
        button6.BackgroundColor = Color.FromHex("#ab0218");
        button6.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button7_MouseHover(object sender, EventArgs e)
    {
        button7.BackgroundColor = Color.FromHex("#ab0218");
        button7.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button8_MouseHover(object sender, EventArgs e)
    {
        button8.BackgroundColor = Color.FromHex("#ab0218");
        button8.TextColor = Colors.White;

    }
    [Obsolete]
    private void Button9_MouseHover(object sender, EventArgs e)
    {
        button9.BackgroundColor = Color.FromHex("#ab0218");
        button9.TextColor = Colors.White;

    }

    [Obsolete]
    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        btnSearch.BackgroundColor = Color.FromHex("#ab0218");
        btnSearch.TextColor = Colors.White;
        await Navigation.PushAsync(new Ustanove());
    }
}