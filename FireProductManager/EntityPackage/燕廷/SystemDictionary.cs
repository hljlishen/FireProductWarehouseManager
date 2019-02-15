using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.EntityPackage
{
    class SystemDictionary : ActiveRecord
    {
        public int? sy_id { get; set; }
        public string sy_type { get; set; }
        public string sy_text { get; set; }

        public SystemDictionary() : base("systemdictionary", "sy_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }
    }
}
