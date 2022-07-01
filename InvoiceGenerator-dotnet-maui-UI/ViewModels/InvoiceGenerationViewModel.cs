using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvoiceGenerator.Maui.BusinessLogic;
using System.Collections.ObjectModel;

namespace InvoiceGenerator_dotnet_maui_UI.ViewModels
{
    public partial class InvoiceGenerationViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _areClientNamesLoading;

        public ObservableCollection<ClientNameViewModel> ClientNames { get; } = new ObservableCollection<ClientNameViewModel>();

        private readonly IClientService _clientService;
        public InvoiceGenerationViewModel(IClientService clientService)
        {
            _clientService = clientService;
            GetClientNames();
        }

        [RelayCommand]
        public void GetClientNames()
        {
            _areClientNamesLoading = true;

            var allClientNames = _clientService.GetClientNames();

            if (ClientNames.Count != 0)
            {
                ClientNames.Clear();
            }

            foreach (var clientName in allClientNames)
            {
                var newVm = new ClientNameViewModel
                {
                    ClientName = clientName.ClientName
                };
                ClientNames.Add(newVm);
            }

            _areClientNamesLoading = false;
        }
    }

    public class ClientNameViewModel
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
    }
}
