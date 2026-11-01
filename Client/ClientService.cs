using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Client
{
    public class ClientService
    {
        private ClientRepo clientRepo;

        public ClientService()
        {
            clientRepo = new ClientRepo();
        }

        public List<ClientModel> GetAllClients()
        {
            return clientRepo.GetAllClients();
        }

        public void RegisterClient(ClientModel client)
        {
            clientRepo.AddClient(client);
        }
    }
}
