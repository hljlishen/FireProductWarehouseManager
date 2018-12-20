using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    class InOutRecord : ActiveRecord
    {
        public uint? ior_id { get; set; }
        public uint? ior_packageId { get; set; }
        public uint? ior_employeeId { get; set; }
        public uint? ior_projectId { get; set; }
        public string ior_direction { get; set; }
        public string ior_borrowName { get; set; }
        public DateTime? ior_timeStmp { get; set; }
        public string ior_accountNumber { get; set; }
        public string ior_projectPassword { get; set; }

        public InOutRecord() : base("inoutrecord", "ior_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
