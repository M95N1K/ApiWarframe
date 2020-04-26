//using System;
//using System.Text.Json;
using System.Net;

namespace ApiWarframe
{
    public class API_Warframe
    {
        static string https = "https";
        static string api = "ws";
        static string platform = "pc/";
        static string languege = "en";
        static string url = https + "://"+api+".warframestat.us/" + platform;

        public static void SetOption(HTTPs httpvalue, Apis apivalue, string _platform, string _languege)
        {            
            https = httpvalue.ToString();
            api = apivalue.ToString();
            platform = _platform;
            languege = _languege;
            url = https + "://" + api + ".warframestat.us/" + platform;
        }

        public string GetJson(string suburl)
        {
            string json = "";
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Accept-Language", languege);
                json = wc.DownloadString(url + suburl);
            }
            return json;
        }

       

       /* public class Arbitration_data //Арбитраж
        {
            public string activation { get; set; }
            public string expiry { get; set; }
            public string enemy { get; set; }
            public string type { get; set; }
            public Boolean archwing { get; set; }
            public Boolean sharkwing { get; set; }
            public string node { get; set; }

            public void Update_data(int Api, int Platform)
            {
                string urls = url + "arbitration";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept-Language", languege);
                    string json = wc.DownloadString(urls);
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
        } */

        /* public class Earth_rotation  //Земля День-Ночь
        {
            public string id { get; set; }
            public string expiry { get; set; }
            public string activation { get; set; }
            public Boolean isDay { get; set; }
            public string state { get; set; }
            public string timeLeft { get; set; }

            public void Update_data(int Api, int Platform)
            {
                string urls = url  + "earthCycle";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept-Language", languege);
                    string json = wc.DownloadString(urls);
                    Earth_rotation ad = JsonSerializer.Deserialize<Earth_rotation>(json);
                    id = ad.id;
                    expiry = ad.expiry;
                    activation = ad.activation;
                    isDay = ad.isDay;
                    state = ad.state;
                    timeLeft = ad.timeLeft;
                }
            }
        }*/

        /*public class Cetus_rotation //Цетус День-Ночь
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
                string urls = url + "cetusCycle";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept-Language", languege);
                    string json = wc.DownloadString(urls);
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
        }*/

        /*public class Orb_Vallis //Долина сфер
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
                string urls = url + "cetusCycle";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept-Language", languege);
                    string json = wc.DownloadString(urls);
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
        }*/

        /*public class Fissures_Date //Миссия разрыва
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
        }*/

        /*public class Get_Fissures //Список миссий разрыва
        {
            public Fissures_Date[] Fissures { get; set; }

            public void Update_data(int Api, int Platform)
            {
                string urls = url + "fissures";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Accept-Language", languege);
                    string json = "{\"Fissures\":" + wc.DownloadString(urls) + "}";
                    Get_Fissures ad = JsonSerializer.Deserialize<Get_Fissures>(json);
                    Fissures = ad.Fissures;
                }
            }
        }*/
    }
}
