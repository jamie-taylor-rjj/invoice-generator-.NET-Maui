namespace InvoiceGenerator_dotnet_maui_UI;

public partial class StartPage : ContentPage
{
    private readonly ClientDetailsPage _clientDetailsPage;
	public StartPage(ClientDetailsPage clientDetailsPage)
    {
        InitializeComponent();
        _clientDetailsPage = clientDetailsPage;
    }

    private async void btn_generateInvoice_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InvoiceGenerationPage());
    }

    private async void btn_clientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_clientDetailsPage);
    }
}