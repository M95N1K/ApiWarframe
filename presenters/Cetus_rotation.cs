using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        /// <summary>
        /// Класс с данными о дне и ночи на Равнинах Эйдолона
        /// </summary>
        public class Cetus_rotation : API_Warframe //Цетус День-Ночь
        {
            /// <summary>
            /// Данные о дне и ночи на Равнинах Эйдолона
            /// </summary>
            public MCetus_rotation CetusRotation { get; private set; }

            /// <summary>
            /// Конструктор
            /// </summary>
            public Cetus_rotation() => suburl = "cetusCycle";

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData() => CetusRotation = GetDate<MCetus_rotation>(suburl);
        }
    }
}
