//using System;
using Newtonsoft.Json;
using System.Net;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        static string https = "https";
        static string api = "ws";
        static string platform = "pc/";
        static string languege = "en";
        static string url = https + "://" + api + ".warframestat.us/" + platform;

        public static void SetOption(HTTPs httpvalue, Apis apivalue, string _platform, string _languege)
        {
            https = httpvalue.ToString();
            api = apivalue.ToString();
            platform = _platform;
            languege = _languege;
            url = https + "://" + api + ".warframestat.us/" + platform;
        }

        public T GetJson<T>(string suburl)
        {
            string json = "";
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Accept-Language", languege);
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString(url + suburl);
            }

            T js = JsonConvert.DeserializeObject<T>(json);
            return js;
        }

    }
}
