using InvoiceGenerator.Maui.Domain;
using InvoiceGenerator.Maui.Domain.Models;

namespace InvoiceGenerator.Maui.BusinessLogic
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _clientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Client> GetClients()
        {
            var clients = _clientRepository.GetAll(); // Assign a bunch of client objects to a list

            return clients;
        }

        public List<Client> GetClientNames()
        {

            var clientNames = _clientRepository.GetAll();

            return clientNames;
        }
    }
}