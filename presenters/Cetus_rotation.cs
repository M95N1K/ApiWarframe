using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Cetus_rotation : API_Warframe //Цетус День-Ночь
        {
            public MCetus_rotation CetusRotation { get; private set; }

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData(int Api, int Platform)
            {
                CetusRotation = GetDate<MCetus_rotation>("cetusCycle");
            }
        }
    }
}
