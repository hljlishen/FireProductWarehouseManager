using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DbLink
{
    public abstract class ActiveRecord
    {
        private List<TableField> _dataBaseFields;
        protected string TableName;
        protected IDatabaseDrive DatabaseDrive;
        private readonly string _primaryKeyName;
        private TableField _primaryKeyField;
        private const string Space = " ";
        private TableFieldPropertyMap _tableFieldPropertyMap;
        private DatabaseType _databaseType;

        protected ActiveRecord(string tableName, string primaryKeyName, DatabaseType databaseType, string connectionStr)
        {
            TableName = tableName;
            _primaryKeyName = primaryKeyName;
            SetDatabaseConnection(databaseType, connectionStr);
        }

        public void SetDatabaseConnection(DatabaseType databaseType, string connectionStr)
        {
            _databaseType = databaseType;
            DbLinkFactory factory = DbLinkGateway.CreateFactory(databaseType);
            DatabaseDrive = factory.CreateDatabaseDrive(connectionStr);

            _dataBaseFields = new List<TableField>();
            _tableFieldPropertyMap = new TableFieldPropertyMap(this);
            CreateTableFields();
            _primaryKeyField = FindTableFieldByName(_primaryKeyName);
        }

        private void CreateTableFields()
        {
            IEnumerable<TableField> fields = GenerateTableFields();
            foreach (TableField tableField in fields)
            {
                AddField(tableField);
            }
        }

        private IEnumerable<TableField> GenerateTableFields()
        {
            var propertyInfoes = GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfoes)
            {
                TableField field = TableField.Parse(propertyInfo, _databaseType);
                _tableFieldPropertyMap.AddMap(propertyInfo, field);
                yield return field;
            }
        }

        private void AddField(TableField field)
        {
            string fieldName = field.GetFieldName();

            if (FieldNameAlreadyExists(fieldName))
                throw new Exception($"添加的域已经在列表中<{fieldName}>");

            _dataBaseFields.Add(field);
        }

        private bool FieldNameAlreadyExists(string fieldName)
        {
            foreach (TableField field in _dataBaseFields)
            {
                if (field.GetFieldName() == fieldName)
                    return true;
            }

            return false;
        }

        private TableField FindTableFieldByName(string fieldName)
        {
            if (!FieldNameAlreadyExists(fieldName))
                throw new Exception($"域{fieldName}不存在");

            foreach (TableField field in _dataBaseFields)
            {
                if (field.GetFieldName() == fieldName)
                    return field;
            }

            return null;
        }

        public string MakeInsertSqlCommand() => $"insert into {TableName} " + MakeSelectFieldsClause() + MakeSelectValuesClause();

        private string MakeSelectFieldsClause()
        {
            string fieldsClause = "(";

            foreach (TableField field in _dataBaseFields)
            {
                if(!field.HasValue())
                {
                    if (IsTheLastField(field))      //列表中最后一个域为空值时，应该删除上一个
                        fieldsClause = RemoveLastChar(fieldsClause);
                    continue;
                }
                fieldsClause += field.GetFieldName();
                if (!IsTheLastField(field))
                    fieldsClause += ",";
            }

            fieldsClause += ")" + Space;
            return fieldsClause;
        }

        private bool IsTheLastField(TableField field) => field == _dataBaseFields[_dataBaseFields.Count - 1];

        private string RemoveLastChar(string str) => str.Substring(0, str.Length - 1);

        private string MakeSelectValuesClause()
        {
            string valuesClause = "values (";

            foreach (TableField field in _dataBaseFields)
            {
                if (!field.HasValue())
                {
                    if (IsTheLastField(field))      
                        valuesClause = RemoveLastChar(valuesClause);
                    continue;
                }
                valuesClause += field.GetValueString();
                if (!IsTheLastField(field))
                    valuesClause += ",";
            }

            valuesClause += ")";
            return valuesClause;
        }

        public virtual string MakeUpdateSqlCommand()
        {
            string updateSql = $"update {TableName} set" + Space;
            updateSql += MakeUpdateValuesClause() + Space;
            updateSql += $"where {_primaryKeyField.MakeClause()}";
            return updateSql;
        }

        protected string MakeUpdateValuesClause()
        {
            UpdateTableFieldsValue();
            string updateValuesClause = "";
            foreach (TableField field in _dataBaseFields)
            {
                if (!field.HasValue())
                {
                    if (IsTheLastField(field))
                        updateValuesClause = RemoveLastChar(updateValuesClause);
                    continue;
                }
                if(field != _primaryKeyField)
                {
                    updateValuesClause += field.MakeClause();
                    if (!IsTheLastField(field))
                        updateValuesClause += ",";
                }
            }

            return updateValuesClause;
        }

        public void UpdateTableFieldsValue() => _tableFieldPropertyMap.UpdateFields(); 

        public string MakeDeleteSqlCommand() => $"delete from {TableName} where {_primaryKeyField.MakeClause()}";

        public virtual void Insert()
        {
            UpdateTableFieldsValue();
            if (!IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteInsert(MakeInsertSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值不为null，不能执行Insert");
        }

        private bool IsThisRecordAlreadyInDataBase() => _primaryKeyField.FieldValue != null;

        public virtual void Update()
        {
            UpdateTableFieldsValue();
            if (IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteUpdate(MakeUpdateSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值为null，不能执行update");
        }

        public virtual void Delete()
        {
            UpdateTableFieldsValue();
            if (IsThisRecordAlreadyInDataBase())
                DatabaseDrive.ExecuteDelete(MakeDeleteSqlCommand());
            else
                throw new Exception($"主键{_primaryKeyName}值为null，不能执行delete");
        }

        public static DataTable Select(string selectSql, IDatabaseDrive dbDrive)
        {
            DataSet queryResult = dbDrive.ExecuteSelect(selectSql);
            return queryResult.Tables[0];
        }

        public DataTable Select(string selectSql) => Select(selectSql, DatabaseDrive);

        public virtual void LoadDataRow(DataRow row)
        {
            PropertyInfo[] property = GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in property)
            {
                string name = propertyInfo.Name;
                object value = row[name];
                if(value == null || value is DBNull)
                    propertyInfo.SetValue(this, null);
                else
                    propertyInfo.SetValue(this, value);
            }
        }

        public virtual void LoadDataGridViewRow(DataGridViewRow row)
        {
            PropertyInfo[] property = GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in property)
            {
                string name = propertyInfo.Name;
                object value = row.Cells[name].Value;
                if (value == null || value is DBNull)
                    propertyInfo.SetValue(this, null);
                else
                    propertyInfo.SetValue(this, value);
            }
        }
    }
}
