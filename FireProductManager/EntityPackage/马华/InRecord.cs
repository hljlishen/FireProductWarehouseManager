using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    class InRecord : ActiveRecord
    {
        public uint? ir_id { get; set; }
        public uint? ir_outid { get; set; } 
        public string ir_direction { get; set; }
        public DateTime? ir_timeStmp { get; set; }
        public double? ir_consumption { get; set; } //消耗量
        public double? ir_returnWeight { get; set; } //归还重量
        public string ir_accountNumber { get; set; }

        public InRecord() : base("inrecord", "ir_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
