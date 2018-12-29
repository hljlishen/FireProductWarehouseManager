using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    public class EvirmentRecord : ActiveRecord
    {

        public uint? er_id { get; set; }
        public double? er_temperature { get; set; }
        public double? er_humidity { get; set; }
        public DateTime? er_timeStmp { get; set; }

        public EvirmentRecord() : base("evirmentrecord", "er_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
