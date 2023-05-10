using MySql.Data.MySqlClient;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppStudy.DAL
{
    class DataAccess
    {
        string dbConfig = ConfigurationManager.ConnectionStrings["db_config"].ToString();
        MySqlConnection con;    
        MySqlCommand cmd;
        MySqlDataReader dataReader = null;

        private void Dispose()
        {
            if (dataReader != null)
            {
                dataReader = null;
            }
            if (cmd != null)
            {
                cmd= null;
            }
            if(con != null)
            {
                con.Close();
            }
        }

        private MySqlDataReader gettData(string sql)
        {
            try
            {
                con = new MySqlConnection(dbConfig);
                con.Open();
                cmd = con.CreateCommand();
                if (sql != "")
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    dataReader = cmd.ExecuteReader();
                }
                return dataReader;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            
        }



    }
}
