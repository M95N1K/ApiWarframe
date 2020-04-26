using System;
using System.Text.Json;
using System.Net;

namespace ApiWarframe
{
    public class Get_Fissures : API_Warframe //Список миссий разрыва
    {
        public struct Fissures_Date //Миссия разрыва
        {
            public string id { get; set; }
            public string activation { get; set; }
            public string startString { get; set; }
            public string expiry { get; set; }
            public Boolean active { get; set; }
            public string node { get; set; }
            public string missionType { get; set; }
            public string enemy { get; set; }
            public string tier { get; set; }
            public int tierNum { get; set; }
            public Boolean expired { get; set; }
            public string eta { get; set; }
        }

        public Fissures_Date[] Fissures { get; set; }

        public void Update_data(int Api, int Platform)
        {
            string json = "{\"Fissures\":" + GetJson("fissures") + "}";
            Get_Fissures ad = JsonSerializer.Deserialize<Get_Fissures>(json);
            Fissures = ad.Fissures;
        }
    }
}
