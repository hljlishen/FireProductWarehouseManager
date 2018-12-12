﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    class InOutRecord : ActiveRecord
    {
        public uint? ior_id { get; set; }
        public uint? ior_packageId { get; set; }
        public uint? ior_employeeId { get; set; }
        public uint? ior_projectId { get; set; }
        public string ior_direction { get; set; }
        public string ior_borrowName { get; set; }
        public DateTime? ior_timeStmp { get; set; }
        public string ior_accountName { get; set; }
        public string ior_projectPassword { get; set; }

        public InOutRecord() : base("inoutrecord", "ior_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
