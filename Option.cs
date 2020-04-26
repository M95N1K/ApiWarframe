using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe
{
    public enum Apis
    {
        api ,
        ws,
    }

    public enum HTTPs
    {
        https,
        http,
    }

    public static class MyExtensions
    {
        public static string ToString(this Apis _apis)
        {
            switch (_apis)
            {
                case Apis.api:
                    return "api";
                case Apis.ws:
                    return "ws";
                default:
                    return "api";
            }
        }

        public static string ToString(this HTTPs httpvalue)
        {
            switch (httpvalue)
            {
                case HTTPs.https:
                    return "https";
                case HTTPs.http:
                    return "http";
                default:
                    return "https";
            }
        }
    }
}
