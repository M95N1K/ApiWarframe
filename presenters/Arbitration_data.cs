using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Arbitration_data : API_Warframe //Арбитраж
        {

            public MArbitration_data ArbitrationData { get; private set; }

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData()
            {
                ArbitrationData = GetDate<MArbitration_data>("arbitration");
            }
        }
    }
}
