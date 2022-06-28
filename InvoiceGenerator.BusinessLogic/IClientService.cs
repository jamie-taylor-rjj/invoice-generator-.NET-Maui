using InvoiceGenerator.Domain.Models;
using System.Collections.Generic;

namespace InvoiceGenerator.BusinessLogic
{
    public interface IClientService
    {
        //int AddClient(ClientViewModel viewModel);
        List<Client> GetClientNames();
        List<Client> GetClients();
    }
}