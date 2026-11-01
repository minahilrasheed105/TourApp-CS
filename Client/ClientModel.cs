using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TourApp.Client
{
    public class ClientModel
    {
        public string ClientId { get; set; }
        public string Password { get; set; }
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public ClientModel(string ClId, string Pw, string ClName, string email, string Ph)
        {
            this.ClientId = ClId;
            this.Password = Pw;
            this.ClientName = ClName;
            this.Email = email;
            this.Phone = Ph;

        }

        public ClientModel()
        {
            this.ClientId = "";
            this.Password = "";
            this.ClientName = "";
            this.Email = "";
            this.Phone = "";
        }
        public override string ToString()
        {
            return $"{ClientId},{Password},{ClientName},{Email},{Phone}";
        }

    }
}

