using Microsoft.AspNetCore.Components.WebView.Maui;
using Login_MAUI.Data;
using Syncfusion.Blazor;

namespace Login_MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSyncfusionBlazor();
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
