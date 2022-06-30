using InvoiceGenerator.Maui.BusinessLogic;
using InvoiceGenerator.Maui.Domain;
using InvoiceGenerator_dotnet_maui_UI.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InvoiceGenerator_dotnet_maui_UI;

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


		var a = Assembly.GetExecutingAssembly();
		using var stream = a.GetManifestResourceStream("InvoiceGenerator_dotnet_maui_UI.appsettings.json");

		var config = new ConfigurationBuilder()
					.AddJsonStream(stream)
					.Build();

		builder.Services
			.AddTransient<AppShell>()
			.AddTransient<StartPage>()
			.AddTransient<ClientDetailsPage>()
			.AddSingleton<ClientDetailsViewPage>()
			.AddTransient<ClientDetailsViewModel>()
			.AddTransient<IClientService, ClientService>()
			.AddTransient(typeof(IRepository<>), typeof(Repository<>))
			.AddDbContext<InvoiceDbContext>(options
				=> options.UseSqlServer(config.GetConnectionString("invoiceConnectionString")));

        return builder.Build();
	}

}
