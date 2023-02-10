using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Blood_Donation.Data;
using Plugin.LocalNotification;

namespace Blood_Donation;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseLocalNotification()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<Registration>();
		builder.Services.AddSingleton<UserRepository>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
