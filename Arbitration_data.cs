using System;
using System.Text.Json;
using System.Net;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Arbitration_data : API_Warframe //Арбитраж
        {

            public string activation { get; set; }
            public string expiry { get; set; }
            public string enemy { get; set; }
            public string type { get; set; }
            public Boolean archwing { get; set; }
            public Boolean sharkwing { get; set; }
            public string node { get; set; }


            public void Update_data()
            {
                string json = GetJson("arbitration");
                Arbitration_data ad = JsonSerializer.Deserialize<Arbitration_data>(json);
                activation = ad.activation;
                expiry = ad.expiry;
                enemy = ad.enemy;
                type = ad.type;
                archwing = ad.archwing;
                sharkwing = ad.sharkwing;
                node = ad.node;
            }
        }
    }
}
