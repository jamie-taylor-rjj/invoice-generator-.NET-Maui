using InvoiceGenerator.BusinessLogic;

namespace InvoiceGenerator_dotnet_maui_UI;

public partial class ClientDetailsViewPage : ContentPage
{
	private readonly IClientService _clientService;
	public ClientDetailsViewPage(IClientService clientService)
    {
        InitializeComponent();
        _clientService = clientService;
    }
}