namespace InvoiceGenerator_dotnet_maui_UI;

public partial class ClientDetailsPage : ContentPage
{
	public ClientDetailsPage()
	{
		InitializeComponent();
	}

    private async void btn_enterClientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientDetailsEntryPage());
    }

    private async void btn_viewClientDetails_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientDetailsViewPage());
    }
}