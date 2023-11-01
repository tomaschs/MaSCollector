using Microsoft.Extensions.Logging;
using MauiApp2.Data;
using CommunityToolkit.Maui;

namespace MauiApp2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif



		Item nov = new Item();

		Zberac.ZoznamZaznamov.Add(nov);
		nov = new Item();
		Zberac.ZoznamZaznamov.Add(nov);
		nov = new Item();
		Zberac.ZoznamZaznamov.Add(nov);

		return builder.Build();
	}
}
