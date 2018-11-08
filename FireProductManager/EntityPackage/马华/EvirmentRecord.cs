using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.EntityPackage
{
    public class EvirmentRecord : ActiveRecord
    {

        public int? er_id { get; set; }
        public double? er_temperature { get; set; }
        public double? er_humidity { get; set; }
        public DateTime? er_timeStmp { get; set; }

        public EvirmentRecord() : base("evirmentrecord", "er_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
