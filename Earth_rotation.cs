using System;
using System.Text.Json;
using System.Net;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Earth_rotation : API_Warframe //Земля День-Ночь
        {
            public string id { get; set; }
            public string expiry { get; set; }
            public string activation { get; set; }
            public Boolean isDay { get; set; }
            public string state { get; set; }
            public string timeLeft { get; set; }

            public void Update_data(int Api, int Platform)
            {
                string json = GetJson("earthCycle");
                Earth_rotation ad = JsonSerializer.Deserialize<Earth_rotation>(json);
                id = ad.id;
                expiry = ad.expiry;
                activation = ad.activation;
                isDay = ad.isDay;
                state = ad.state;
                timeLeft = ad.timeLeft;
            }
        }
    }
}
