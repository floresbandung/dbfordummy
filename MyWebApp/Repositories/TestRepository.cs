using DynamicDriverDB;
using MySql.Data.MySqlClient;
using MyWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Repositories
{
    public class TestRepository
    {
        readonly MySqlContext mysql = new MySqlContext();
        public TestRepository(/*MySqlContext _mysql*/)
        {
            //mysql = _mysql;
        }
        public List<TestModel> GetList()
        {
            List<TestModel> result = new List<TestModel>();
            MySqlConnection con = mysql.GetConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pegawai", con);
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    result.Add(new TestModel {
                        alamat = dr.GetString("alamat"),
                        id = dr.GetInt16("id"),
                        nama = dr.GetString("nama"),
                        no_tlp = dr.GetString("no_tlp")
                    });
                }
            }
            return result;
        }
    }
}
