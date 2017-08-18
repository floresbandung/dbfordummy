using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDriverDB
{
    public abstract class DalBase
    {
        private string strConnectionString;
        //private IDbConnection connection;
        //private IDbCommand command;
        //private IDbTransaction transaction;

        public string ConnectionString
        {
            get
            {
                if (strConnectionString == string.Empty || strConnectionString.Length == 0)
                    throw new ArgumentException("Invalid database connection string.");

                return strConnectionString;
            }
            set
            { strConnectionString = value; }
        }

        protected DalBase() { }

        //public abstract IDbConnection GetDataProviderConnection();

        //public abstract IDbCommand GeDataProviderCommand();

        //public abstract IDbDataAdapter GetDataProviderDataAdapter();

        #region Database Transaction

        //public string OpenConnection()
        //{
        //    string Response = string.Empty;
        //    try
        //    {
        //        connection = GetDataProviderConnection(); // instantiate a connection object
        //                                                  //connection.ConnectionString = this.ConnectionString;
        //                                                  //connection.Open(); // open connection
        //        Response = ((System.Reflection.MemberInfo)(connection.GetType())).Name + "Open Successfully";
        //    }
        //    catch
        //    {
        //        connection.Close();
        //        Response = "Unable to Open " +
        //                   ((System.Reflection.MemberInfo)(connection.GetType())).Name;
        //    }
        //    return Response;
        //}

        #endregion    }
    }
}