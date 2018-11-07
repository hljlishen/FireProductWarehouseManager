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

        public int? Ior_Id { get; set; }
        public int? Ior_PackageID { get; set; }
        public int? Ior_EmployeeId { get; set; }
        public string Ior_Direction { get; set; }
        public DateTime? Ior_TimeStmp { get; set; }

        public InOutRecord() : base("inOutRecord", "Ior_Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
