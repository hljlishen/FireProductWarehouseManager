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

        public int? Id { get; set; }
        public int? PackageID { get; set; }
        public int? EmployeeId { get; set; }
        public string Direction { get; set; }
        public DateTime? TimeStmp { get; set; }

        public InOutRecord() : base("InOutRecord", "Id", DatabaseType.MySql, "")
        {

        }
    }
}
