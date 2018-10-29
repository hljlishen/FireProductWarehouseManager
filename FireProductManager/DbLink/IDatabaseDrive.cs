using System.Data;

namespace DbLink
{
    public interface IDatabaseDrive
    {
        void ExecuteInsert(string insertSql);
        void ExecuteUpdate(string updateSql);
        void ExecuteDelete(string deleteSql);
        DataSet ExecuteSelect(string selectSql);
    }
}
