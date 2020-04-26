using System;
using System.Text.Json;
using System.Net;

namespace ApiWarframe
{
    class Orb_Vallis : API_Warframe //Долина сфер
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public Boolean isWarm { get; set; }
        public string state { get; set; }
        public string activation { get; set; }
        public string timeLeft { get; set; }
        public string sString { get; set; }

        public void Update_data(int Api, int Platform)
        {
            string json = GetJson("cetusCycle");
            Orb_Vallis ad = JsonSerializer.Deserialize<Orb_Vallis>(json);
            id = ad.id;
            expiry = ad.expiry;
            isWarm = ad.isWarm;
            state = ad.state;
            activation = ad.activation;
            timeLeft = ad.timeLeft;
            sString = ad.sString;
        }
    }
}
