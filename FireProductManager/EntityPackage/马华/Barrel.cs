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

        public int? Ba_Id { get; set; }
        public int? Ba_IsRemoved { get; set; }

        public Barrel() : base("Barrel", "Ba_Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
