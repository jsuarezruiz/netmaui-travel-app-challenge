namespace TravelApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("rockolf.ttf", "Rockolf");
				fonts.AddFont("rockolf-bold.ttf", "Rockolf Bold");
				fonts.AddFont("rockoultraflf.ttf", "Rockoultraflf");
				fonts.AddFont("rockoultraflf-bold.ttf", "Rockoultraflf Bold");
				fonts.AddFont("MaterialIcons-Regular.ttf", "Material");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		return builder.Build();
	}
}