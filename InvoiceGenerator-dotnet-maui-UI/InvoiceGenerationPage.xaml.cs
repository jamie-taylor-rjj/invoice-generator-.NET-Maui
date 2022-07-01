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
		pcker_clientName.TextColor = Color.FromRgb(255, 255, 255);

        var selectedClientViewModel = (ClientNameViewModel)pcker_clientName.SelectedItem;

		var clientName = selectedClientViewModel.ClientName;
		var todayAsString = DateTime.Today.ToString("dd-mm-yyyy");
		txt_invoiceReference.Text = $"RJJ-{clientName}-{todayAsString}"; // Create invoice reference
    }

    private void txt_lineItemDescription_TextChanged(object sender, TextChangedEventArgs e)
    {
		((InvoiceGenerationViewModel)this.BindingContext)._lineItemVm.Description = txt_lineItemDescription.Text;
    }

    private void txt_lineItemCost_TextChanged(object sender, TextChangedEventArgs e)
    {
        ((InvoiceGenerationViewModel)this.BindingContext)._lineItemVm.Cost = Convert.ToDouble(txt_lineItemCost.Text);
    }

    private void txt_lineItemQuantity_TextChanged(object sender, TextChangedEventArgs e)
    {
        ((InvoiceGenerationViewModel)this.BindingContext)._lineItemVm.Quantity = Convert.ToInt32(txt_lineItemQuantity.Text);
    }
}