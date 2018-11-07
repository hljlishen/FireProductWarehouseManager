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
        public int? Ac_Id { get; set; }
        public string Ac_Accounts { get; set; }
        public string Ac_Password { get; set; }
        public int? Ac_Authority { get; set; }

        public Account() : base("account", "Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
