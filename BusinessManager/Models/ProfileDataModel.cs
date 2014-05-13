using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models
{
    public class ProfileDataModel : BaseDataModel
    {
        public String email { get; set; }
        public String password { get; set; }
        public String pushnotificationid { get; set; }       
        public List<PetDataModel> pets { get; set; }

    }
}
