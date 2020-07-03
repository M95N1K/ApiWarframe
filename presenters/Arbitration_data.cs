using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        /// <summary>
        /// Класс с данными миссии арбитража
        /// </summary>
        public class Arbitration_data : API_Warframe 
        {
            /// <summary>Данные миссии арбитража</summary>
            public MArbitration_data ArbitrationData { get; private set; }

            /// <summary>Конструктор</summary>
            public Arbitration_data() => suburl = "arbitration";

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData() => ArbitrationData = GetDate<MArbitration_data>(suburl);
        }
    }
}
