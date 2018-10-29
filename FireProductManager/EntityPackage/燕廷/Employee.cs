using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    public class Employee : ActiveRecord
    {
        public int? Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }

        public Employee() : base("Employee", "Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }

    }
}
