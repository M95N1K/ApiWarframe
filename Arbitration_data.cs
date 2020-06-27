using ApiWarframe.Models;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Arbitration_data : API_Warframe //Арбитраж
        {

            public MArbitration_data ArbitrationData;

            public void UpdateData()
            {
                ArbitrationData = GetJson<MArbitration_data>("arbitration");
            }
        }
    }
}
