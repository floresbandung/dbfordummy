using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.EntityFrameworkCore.DbContext;

namespace DynamicDriverDB
{
    public class MySqlContext
    {
        public MySqlContext(/*string con*/)
        {
            //ConnectionString = con;
        }
        public string ConnectionString { get; set; }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;port=3306;database=test;user=root;sslmode=none");
        }
    }

    //public class SqlContext : DbContext
    //{
    //    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    //    {

    //    }
    //}
}
