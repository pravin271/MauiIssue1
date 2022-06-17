namespace MauiApp28;

public partial class ViewPage : ContentPage
{
	public ViewPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new NavigationPage(new LandingPage());
    }
}