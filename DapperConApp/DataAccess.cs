using System.Configuration;
using System.Data;
using System.Data.Common;

namespace DapperConApp
{
    public abstract class DataAccess
    {
        protected virtual string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["SqlServer"].ToString(); }
        }

        public static DataManager Data
        {
            get { return DataManager.Instance; }
        }
        
        protected int ExecuteNonQuery(DbCommand cmd)
        {
            return cmd.ExecuteNonQuery();
        }

        protected IDataReader ExecuteReader(DbCommand dbCommand)
        {
            return ExecuteReader(dbCommand, CommandBehavior.Default);
        }

        protected IDataReader ExecuteReader(DbCommand cmd, CommandBehavior behavior)
        {
            return cmd.ExecuteReader(behavior);
        }

        protected object ExecuteScalar(DbCommand cmd)
        {
            return cmd.ExecuteScalar();
        }
    }
}