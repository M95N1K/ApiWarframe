using System;
using System.Text.Json;

namespace ApiWarframe
{
    public class Get_Fissures : API_Warframe //Список миссий разрыва
    {
        public struct Fissures_Date //Миссия разрыва
        {
            public int tierNum { get; set; }
            public string id { get; set; }
            public string activation { get; set; }
            public string startString { get; set; }
            public string expiry { get; set; }
            public Boolean active { get; set; }
            public string node { get; set; }
            public string missionType { get; set; }
            public string enemy { get; set; }
            public string tier { get; set; }
            public Boolean expired { get; set; }
            public string eta { get; set; }
        }

        public Fissures_Date[] Fissures { get; set; }

        public void Update_data()
        {
            string json = "{\"Fissures\":" + GetJson("fissures") + "}";
            
            var ad = JsonSerializer.Deserialize<Get_Fissures>(json);
            Fissures = ad.Fissures;
        }
    }
}
