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
        public int? pa_id { get; set; }
        public string pa_modle { get; set; }
        public double pa_weigth { get; set; }
        public int? pa_barrelId { get; set; }
        public int? pa_isinWarehouse { get; set; }
        public DateTime? pa_purchaseTime { get; set; }

        public Package() : base("package", "pa_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }

       
    }
}
