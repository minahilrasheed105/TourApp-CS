using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Client
{
    public class ClientRepo
    {
        //private readonly string file = "clients.txt";
        public ClientRepo()
        {
            clientFile = new ClientFile();
            clients = clientFile.LoadClients();
        }

        //public void SaveClients(ClientModel clients)
        //{
        //    using (StreamWriter stream = new StreamWriter(file, true))
        //    {
        //        stream.Write(clients.ToString());
        //    }
        //}

        //public List<ClientModel> LoadClients()
        //{
        //    List<ClientModel> clients = new List<ClientModel>();

        //    if (File.Exists(file))
        //    {
        //        string[] lines = File.ReadAllLines(file);

        //        foreach (string line in lines)
        //        {
        //            string[] data = line.Split('|');

        //            ClientModel client = new ClientModel();

        //            client.ClientId = data[0];
        //            client.Password = data[1];
        //            client.ClientName = data[2];
        //            client.Email = data[3];
        //            client.Phone = data[4];

        //            clients.Add(client);
        //        }
        //    }

        //    return clients;
        //}





        private List<ClientModel> clients;
        private ClientFile clientFile;


        public List<ClientModel> GetAllClients()
        {
            return clients;
        }

        public void AddClient(ClientModel client)
        {
            clients.Add(client);
            clientFile.SaveClients(clients);
        }
    }
    
}



