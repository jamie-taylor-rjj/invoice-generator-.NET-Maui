using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvoiceGenerator.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator_dotnet_maui_UI.ViewModels
{
    public partial class InvoiceGenerationViewModel : ObservableObject
    {
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
        }
    }

    public class ClientNameViewModel
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
    }
}
