using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvoiceGenerator.Maui.BusinessLogic;
using System.Collections.ObjectModel;

namespace InvoiceGenerator_dotnet_maui_UI.ViewModels
{
    public partial class ClientDetailsViewModel : BaseViewModel
    {
        public ObservableCollection<ClientViewModel> Clients { get; } = new();

        private readonly IClientService _clientService;
        public ClientDetailsViewModel(IClientService clientService)
        {
            _clientService = clientService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        public void GetClients()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var allClients = _clientService.GetClients();
                if (Clients.Count != 0)
                    Clients.Clear();

                foreach (var client in allClients)
                {
                    var newVm = new ClientViewModel
                    {
                        ClientName = client.ClientName,
                        ClientAddress = client.ClientAddress,
                        ContactEmail = client.ContactEmail,
                        ContactName = client.ContactName
                    };
                    Clients.Add(newVm);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                IsRefreshing = false;
                IsBusy = false;
            }


        }

    }

    public class ClientViewModel
    {
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
    }

    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
    }
}
