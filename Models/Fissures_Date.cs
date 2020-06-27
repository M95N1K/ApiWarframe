using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    public class Fissures_Date
    {

        public int tierNum { get; set; }
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public Boolean active { get; set; }
        public string node { get; set; }
        public string missionType { get; set; }
        public string enemy { get; set; }
        public string tier { get; set; }
        public Boolean expired { get; set; }
        public string eta { get; set; }

        public Fissures_Date()
        { }
    }
}
