using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    class InRecord : ActiveRecord
    {
        public int? ir_id { get; set; }
        public int? ir_outid { get; set; } 
        public string ir_direction { get; set; }
        public DateTime? ir_timeStmp { get; set; }
        public double? ir_consumption { get; set; } //消耗量
        public double? ir_returnWeight { get; set; } //归还重量
        public string ir_accountName { get; set; }
        public double? ir_packageTare { get; set; }//袋子皮重

        public InRecord() : base("inrecord", "ir_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
