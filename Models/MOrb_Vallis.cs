using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    class MOrb_Vallis
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public Boolean isWarm { get; set; }
        public string state { get; set; }
        public string activation { get; set; }
        public string timeLeft { get; set; }
        public string sString { get; set; }

        public MOrb_Vallis()
        { }
    }
}
