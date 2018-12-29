using DbLink;
using System;

namespace FireProductManager.EntityPackage
{
    public class Fingerprint : ActiveRecord
    {
        public int? fi_id { get; set; }
        public string fi_accountNumber { get; set; }
        public DateTime? fi_passtime { get; set; }

        public Fingerprint() : base("fingerprint", "fi_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
