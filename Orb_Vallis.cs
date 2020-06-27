using System;
using System.Net;
using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe 
    {
        class Orb_Vallis : API_Warframe //Долина сфер
        {
            public MOrb_Vallis Orb_Vallis_Date;

            public void UpdateData()
            {
                Orb_Vallis_Date = GetJson<MOrb_Vallis>("cetusCycle");
            }
        }
    }
}
