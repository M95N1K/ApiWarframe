using System.Runtime.CompilerServices;

namespace ApiWarframe
{
    /// <summary>
    /// Список API или WS
    /// </summary>
    public enum Apis
    {
        api,
        ws,
    }

    /// <summary>
    /// Защищенный протокол или нет
    /// </summary>
    public enum HTTPs
    {
        https,
        http,
    }

    //public static class Helpes
    //{
    //    /// <summary>
    //    /// Возвращает строковое значение списка
    //    /// </summary>
    //    /// <param name="date"></param>
    //    /// <returns></returns>
    //    public static string ToString(this HTTPs date)
    //    {
    //        switch (date)
    //        {
    //            case HTTPs.https:
    //                return "https";
    //            case HTTPs.http:
    //                return "http";
    //            default:
    //                return "https";
    //        }
    //    }

    //    /// <summary>
    //    /// Возвращает строковое значение списка
    //    /// </summary>
    //    /// <param name="date"></param>
    //    /// <returns></returns>
    //    public static string ToString(this Apis date)
    //    {
    //        switch (date)
    //        {
    //            case Apis.api:
    //                return "api";
    //            case Apis.ws:
    //                return "ws";
    //            default:
    //                return "api";
    //        }
    //    }
    //}
}
