using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    class InOutRecord : ActiveRecord
    {

        public int? ior_id { get; set; }
        public int? ior_packageId { get; set; }
        public int? ior_employeeId { get; set; }
        public string ior_direction { get; set; }
        public DateTime? ior_timeStmp { get; set; }

        public InOutRecord() : base("inOutRecord", "ior_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
