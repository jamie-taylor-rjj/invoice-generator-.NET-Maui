namespace InvoiceGenerator_dotnet_maui_UI;

public partial class StartPage : ContentPage
{
    private readonly InvoiceGenerationPage _invoiceGenerationPage;
    private readonly ClientDetailsPage _clientDetailsPage;
	public StartPage(ClientDetailsPage clientDetailsPage, InvoiceGenerationPage invoiceGenerationPage)
    {
        InitializeComponent();
        _invoiceGenerationPage = invoiceGenerationPage;
        _clientDetailsPage = clientDetailsPage;
    }

    private async void btn_generateInvoice_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_invoiceGenerationPage);
    }

    private async void btn_clientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_clientDetailsPage);
    }
}