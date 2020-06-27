using System;
using System.Net;
using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Cetus_rotation : API_Warframe //Цетус День-Ночь
        {
            public MCetus_rotation CetusRotation;

            public void UpdateData(int Api, int Platform)
            {
                CetusRotation = GetJson<MCetus_rotation>("cetusCycle");
            }
        }
    }
}
