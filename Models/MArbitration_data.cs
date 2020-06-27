using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    public class MArbitration_data
    {
        public string activation { get; set; }
        public string expiry { get; set; }
        public string enemy { get; set; }
        public string type { get; set; }
        public Boolean archwing { get; set; }
        public Boolean sharkwing { get; set; }
        public string node { get; set; }

        public MArbitration_data() { }
    }
}
