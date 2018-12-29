using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    class OutRecord : ActiveRecord
    {
        public uint? or_id { get; set; }
        public uint? or_packageId { get; set; }
        public uint? or_employeeId { get; set; }
        public uint? or_projectId { get; set; }
        public string or_direction { get; set; }
        public string or_borrowName { get; set; }
        public DateTime? or_timeStmp { get; set; }
        public string or_accountName { get; set; }
        public double? or_outWeight { get; set; } //出库重量

        public OutRecord() : base("outrecord", "or_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
