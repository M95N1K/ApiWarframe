using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        class Orb_Vallis : API_Warframe //Долина сфер
        {
            /// <summary>
            /// Класс показывающий холодно или тепло в долине сфер
            /// </summary>
            public MOrb_Vallis OrbVallisData { get; private set; }

            public Orb_Vallis() => suburl = "cetusCycle";

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData() => OrbVallisData = GetDate<MOrb_Vallis>(suburl);
        }
    }
}
