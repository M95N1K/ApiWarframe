using System;
using System.Net;
using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Earth_rotation : API_Warframe //Земля День-Ночь
        {
            public MEarth_rotation EarthRotation { get; private set; }

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData(int Api, int Platform)
            {
                EarthRotation = GetDate< MEarth_rotation>("earthCycle");
            }
        }
    }
}
