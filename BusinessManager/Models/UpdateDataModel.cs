using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models
{
    public class UpdateDataModel : BaseDataModel
    {
        public DateTime date { get; set; }
        public List<BaseDataModel> collections { get; set; }
    }
}
