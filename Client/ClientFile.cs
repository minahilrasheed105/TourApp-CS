using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Client
{
    public class ClientFile
    {
        private string filePath = "clients.txt";

        public void SaveClients(List<ClientModel> clients)
        {
            List<string> lines = new List<string>();

            foreach (ClientModel client in clients)
            {
                string line = client.ClientId + "|" +
                              client.Password + "|" +
                              client.ClientName + "|" +
                              client.Email + "|" +
                              client.Phone;

                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        public List<ClientModel> LoadClients()
        {
            List<ClientModel> clients = new List<ClientModel>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    ClientModel client = new ClientModel();

                    client.ClientId = data[0];
                    client.Password = data[1];
                    client.ClientName = data[2];
                    client.Email = data[3];
                    client.Phone = data[4];

                    clients.Add(client);
                }
            }

            return clients;
        }
    }
}