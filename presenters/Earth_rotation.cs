using System;
using System.Net;
using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        /// <summary>
        /// Класс с данными о дне и ночи в миссиях на Земле
        /// </summary>
        public class Earth_rotation : API_Warframe //Земля День-Ночь
        {
            /// <summary>
            /// Данные о дне и ночи в миссиях на Земле
            /// </summary>
            public MEarth_rotation EarthRotation { get; private set; }

            /// <summary>
            /// Конструктор
            /// </summary>
            public Earth_rotation() => suburl = "earthCycle";

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData() => EarthRotation = GetDate<MEarth_rotation>(suburl);
        }
    }
}
