using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Models
{
    public class Stat
    {
        public int Id { set; get; }

        public int FlowID { set; get; }

        public DateTime DateTime { set; get; }

        public string Out { set; get; }
        public string Keyword { set; get; }
        public string Redirect { set; get; }
        public string Device { set; get; }
        public string Wap { set; get; }
        public string Country { set; get; }
        public string City { set; get; }
        public string Region { set; get; }
        public string lang { set; get; }
        public bool Uniq { set; get; }
        public bool Bot { set; get; }
        public string IP { set; get; }
        public string Domain { set; get; }
        public string Page { set; get; }
        public string Referer { set; get; }
        public string UserAgent { set; get; }

    }
}
