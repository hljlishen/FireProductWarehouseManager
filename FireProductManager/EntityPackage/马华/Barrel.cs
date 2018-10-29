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

        public int? Id { get; set; }
        public int? IsRemoved { get; set; }

        public Barrel() : base("Barrel", "Id", DatabaseType.MySql, "")
        {

        }
    }
}
