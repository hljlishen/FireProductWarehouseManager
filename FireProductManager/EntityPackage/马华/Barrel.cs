using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    class Barrel : ActiveRecord
    {

        public int? ba_id { get; set; }
        public int? ba_isRemoved { get; set; }

        public Barrel() : base("barrel", "ba_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
