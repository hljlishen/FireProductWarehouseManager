using DbLink;

namespace FireProductManager.EntityPackage
{
    public class Barrel : ActiveRecord
    {

        public uint? ba_id { get; set; }
        public uint? ba_isRemoved { get; set; }

        public Barrel() : base("barrel", "ba_id", DbLinkManager.databaseType, DbLinkManager.connectString)
        {

        }
    }
}
