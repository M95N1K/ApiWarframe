using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        class Orb_Vallis : API_Warframe //Долина сфер
        {
            /// <summary>
            /// 
            /// </summary>
            public MOrb_Vallis OrbVallisData { get; private set; }

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData()
            {
                OrbVallisData = GetDate<MOrb_Vallis>("cetusCycle");
            }
        }
    }
}
