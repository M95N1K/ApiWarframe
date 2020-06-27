using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    public class MEarth_rotation
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public string activation { get; set; }
        public Boolean isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }

        public MEarth_rotation()
        { }
    }
}
