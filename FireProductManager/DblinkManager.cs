using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager
{
    class DbLinkManager
    {
        public static DatabaseType databaseType = DatabaseType.MySql;
        public static string connectString = "Server=localhost;user id=root;password=mysql;database=cangku";
        //public static string connectString = "server=.;database=cangku;uid=sa;pwd=sa";
        public static DbLinkFactory factory = DbLinkGateway.CreateFactory(databaseType);
    }
}
