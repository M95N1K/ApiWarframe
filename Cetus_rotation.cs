using System;
using System.Text.Json;
using System.Net;


namespace ApiWarframe
{
    public class Cetus_rotation : API_Warframe //Цетус День-Ночь
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public string activation { get; set; }
        public Boolean isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }
        public Boolean isCetus { get; set; }
        public string sString { get; set; }

        public void Update_data(int Api, int Platform)
        {
            string json = GetJson("cetusCycle");
            Cetus_rotation ad = JsonSerializer.Deserialize<Cetus_rotation>(json);
            id = ad.id;
            expiry = ad.expiry;
            activation = ad.activation;
            isDay = ad.isDay;
            state = ad.state;
            timeLeft = ad.timeLeft;
            isCetus = ad.isCetus;
            sString = ad.sString;
        }
    }
}
