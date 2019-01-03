using DbLink;

namespace FireProductManager.EntityPackage
{
    public class Barrel : ActiveRecord
    {

        public int? ba_id { get; set; }
        public int? ba_isRemoved { get; set; }

        public Barrel() : base("barrel", "ba_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
