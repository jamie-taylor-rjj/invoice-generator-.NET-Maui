using InvoiceGenerator.Domain;
using InvoiceGenerator.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceGenerator.BusinessLogic
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

            //var viewModels = new List<ClientViewModel>();

            //foreach (var db in clients)
            //{
            //    viewModels.Add(ClientViewModel.FromDbModel(db)); // Add the client details to a list
            //}
            //return viewModels;
        }

        public List<Client> GetClientNames()
        {

            var clientNames = _clientRepository.GetAll();

            return clientNames;

            //var nameModels = new List<ClientNameViewModel>();

            //foreach (var db in clientNames)
            //{
            //    nameModels.Add(ClientNameViewModel.FromDbModel(db));
            //}
            //return nameModels;
        }

        //public int AddClient(ClientViewModel viewModel)
        //{

        //    var client = ClientViewModel.ToDbModel(viewModel);

        //    var recordsChanged = _clientRepository.Add(client);
        //    return recordsChanged;
        //}
    }
}
