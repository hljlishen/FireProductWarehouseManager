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

        public int? Er_Id { get; set; }
        public double? Er_Temperature { get; set; }
        public double? Er_Humidity { get; set; }
        public DateTime? Er_TimeStmp { get; set; }

        public EvirmentRecord() : base("EvirmentRecord", "Er_Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
