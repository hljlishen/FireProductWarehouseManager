using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.EntityPackage
{
    class Project : ActiveRecord
    {
        public uint? pr_id { get; set; }
        public string pr_name { get; set; }
        public string pr_projectPassword { get; set; }
        public string pr_note { get; set; }

        public Project() : base("project", "pr_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }
    }
}
