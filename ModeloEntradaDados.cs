using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AnaliseCasoAPI
{
    public class ModeloEntradaDados
    {
      
        public ModeloEntradaDados(int id, string name, string username, string email, string phone, string website)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Phone = phone;
            Website = website;
        
    }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Street { get; set; }

        [JsonProperty("address")]
        public Address Endereco { get; set; }
        
        [JsonPropertyName("company")]
        public Company Empresa { get; set; }


        public class Address
        {
            public string Street { get; set; }
            public string Suite { get; set; }
            public string City { get; set; }
            public string Zipcode { get; set; }
            public Geo geo { get; set; }
        }

        public class Company
        {
            public string Name { get; set; }
            public string CatchPhrase { get; set; }
            public string Bs { get; set; }
        }

        public class Geo
        {
            public string Lat { get; set; }
            public string Lng { get; set; }
        }

 



    }

}
