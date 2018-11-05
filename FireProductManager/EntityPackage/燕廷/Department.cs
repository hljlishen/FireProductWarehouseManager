using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    public class Department : ActiveRecord
    {
        public int? de_id { get; set; }
        public string de_name { get; set; }
        public int? de_belongId { get; set; }
        private List<Department> departments;

        public Department() : base("department", "de_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
            
        }
    }
}
