﻿using System.Net.Http.Headers;
using JARVIS.Services;
using Microsoft.Extensions.Logging;
using Refit;
namespace JARVIS;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddRefitClient<IJarvisService>()
			.ConfigureHttpClient(client =>
			{
				client.BaseAddress = new Uri("https://api.openai.com");
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration["open-ai-key"]);
			});



        return builder.Build();
	}
}

