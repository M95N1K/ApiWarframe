//using System;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace ApiWarframe
{
    /// <summary>
    /// Базовый класс взаимодействия с сервером WarFrame, в котором устанавливаются опции взаимодействия
    /// </summary>
    public partial class API_Warframe
    {
        static internal HTTPs https { get; private set; }
        static internal Apis api { get; private set; }
        static internal string platform { get; private set; }
        static internal string languege { get; private set; }
        static internal string url { get; private set; }

        internal string suburl;

        static API_Warframe()
        {
            https = HTTPs.https;
            api = Apis.api;
            platform = "pc/";
            languege = "en";
            url = https + "://" + api + ".warframestat.us/" + platform;
        }

        /// <summary>
        /// Указывает тип соединения, платформу и язык, которые будут использоваться при загрузке данных
        /// </summary>
        /// <param name="httpvalue"> Http или HttpS</param>
        /// <param name="apivalue">API или WS</param>
        /// <param name="_platform">Для какой платформы считывать данные</param>
        /// <param name="_languege">язык данных</param>
        public static void SetOption(HTTPs httpvalue, Apis apivalue, string _platform, string _languege)
        {
            https = httpvalue;
            api = apivalue;
            platform = _platform;
            languege = _languege;
            url = https.ToString() + "://" + api.ToString() + ".warframestat.us/" + platform;
        }

        /// <summary>
        /// Считывает данные из сервера в модель этих данных
        /// </summary>
        /// <typeparam name="T">Модель данных (класс)</typeparam>
        /// <param name="suburl">Подстрока адресса по которой выдаются данные</param>
        /// <returns></returns>
        public T GetDate<T>(string suburl)
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
