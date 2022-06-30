using InvoiceGenerator.Maui.Domain.Models;

namespace InvoiceGenerator.Maui.BusinessLogic
{
    public interface IClientService
    {
        List<Client> GetClientNames();
        List<Client> GetClients();
    }
}