using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    public class Package : ActiveRecord
    {
        //public uint? pa_id { get; set; }
        public int? pa_id { get; set; }
        public string pa_type { get; set; }
        public string pa_specifications { get; set; }
        public double? pa_weight { get; set; }
        public int? pa_barrelId { get; set; }
        public int? pa_isinWarehouse { get; set; }
        public string pa_productionCompany { get; set; }
        public DateTime? pa_purchaseTime { get; set; }
        public double? pa_beginningweight { get; set; }

        public Package() : base("package", "pa_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }
    }
}
