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
}