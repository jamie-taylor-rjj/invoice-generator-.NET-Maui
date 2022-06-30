using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator_dotnet_maui_UI.ViewModels;

namespace InvoiceGenerator_dotnet_maui_UI;

public partial class InvoiceGenerationPage : ContentPage
{
	public InvoiceGenerationPage(InvoiceGenerationViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void pcker_clientName_SelectedIndexChanged(object sender, EventArgs e)
    {
		var selectedClientViewModel = (ClientNameViewModel)pcker_clientName.SelectedItem;

		var clientName = selectedClientViewModel.ClientName;
		var todayAsString = DateTime.Today.ToString("dd-mm-yyyy");
		txt_invoiceReference.Text = $"RJJ-{clientName}-{todayAsString}"; // Create invoice reference
    }
}