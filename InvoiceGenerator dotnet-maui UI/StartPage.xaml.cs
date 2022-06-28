namespace InvoiceGenerator_dotnet_maui_UI;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private async void btn_generateInvoice_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InvoiceGenerationPage());
    }

    private async void btn_clientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientDetailsPage());
    }
}