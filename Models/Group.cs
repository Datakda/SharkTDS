using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string TypeRedirect { get; set; }
        public string Header { get; set; }
        public string UrlORCode{ get; set; }
        public string ReplaceToCURL { get; set; }
        public string GeoBase { get; set; }
        public string UniquenessCheck { get; set; }
        public int TermUniqueness { get; set; }
        public bool IsActiveBanGroupToTime { get; set; }
        public int LimitQestion { get; set; }
        public int TimePeriod { get; set; }
        public bool SaveKeys { get; set; }
        public bool SaveKeysOfReferer { get; set; }
        public bool GroupIsActive { get; set; }
        public string Comment { get; set; }
        public  List<Flow> Flows { get; set; }

    }
}
