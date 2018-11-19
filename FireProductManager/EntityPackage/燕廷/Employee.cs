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
        //public uint? em_id { get; set; }
        public int? em_id { get; set; }
        public string em_employeenumber { get; set; }
        public string em_name { get; set; }
        public string em_sex { get; set; }
        public int? em_departmentid { get; set; }

        public Employee() : base("employee", "em_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }

    }
}
