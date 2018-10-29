using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLink;

namespace FireProductManager.EntityPackage
{
    class Package : ActiveRecord
    {
        public int? Id { get; set; }
        public string Modle { get; set; }
        public double Weigth { get; set; }
        public int? IsInWarehouse { get; set; }
        public DateTime? PurchaseTime { get; set; }

        protected Package() : base("Package", "Id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {
        }

       
    }
}
