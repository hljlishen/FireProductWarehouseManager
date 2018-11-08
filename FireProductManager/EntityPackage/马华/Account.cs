using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.EntityPackage
{
    class Account: ActiveRecord
    {
        public int? ac_id { get; set; }
        public string ac_account { get; set; }
        public string ac_password { get; set; }
        public int? ac_authority { get; set; }

        public Account() : base("account", "ac_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
