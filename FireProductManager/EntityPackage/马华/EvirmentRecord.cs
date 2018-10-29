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

        public int? Id { get; set; }
        public double? Temperature { get; set; }
        public double? Humidity { get; set; }
        public DateTime? TimeStmp { get; set; }

        public EvirmentRecord() : base("EvirmentRecord", "Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
