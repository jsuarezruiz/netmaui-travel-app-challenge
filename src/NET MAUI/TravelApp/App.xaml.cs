using TravelApp.Views;

namespace TravelApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());
	}
}
