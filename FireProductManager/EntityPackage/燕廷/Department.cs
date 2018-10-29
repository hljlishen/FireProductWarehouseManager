using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    class Department : ActiveRecord
    {
        public int? Id { get; set; }
        string Name { get; set; }
        int? BelongId { get; set; }
        private List<Department> departments;

        protected Department() : base("Department", "Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
            
        }
    }
}
