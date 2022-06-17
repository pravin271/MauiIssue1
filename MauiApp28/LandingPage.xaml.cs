namespace MauiApp28;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new HomeView();
    }
}