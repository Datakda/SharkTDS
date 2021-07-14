using SharkTDS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.ViewModels
{
    public class EditGroupModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Identifier { get; set; }
        public string TypeRedirect { get; set; }
        public string Header { get; set; }
        public string UrlORCode { get; set; }
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

        public List<SharkTDS.Models.Flow> Flows{ get; set; }


}
}
