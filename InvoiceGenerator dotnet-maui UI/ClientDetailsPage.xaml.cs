namespace InvoiceGenerator_dotnet_maui_UI;

public partial class ClientDetailsPage : ContentPage
{
    private readonly ClientDetailsViewPage _clientDetailsViewPage;
	public ClientDetailsPage(ClientDetailsViewPage clientDetailsViewPage)
    {
        InitializeComponent();
        _clientDetailsViewPage = clientDetailsViewPage;
    }

    private async void btn_enterClientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientDetailsEntryPage());
    }

    private async void btn_viewClientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_clientDetailsViewPage);
    }
}