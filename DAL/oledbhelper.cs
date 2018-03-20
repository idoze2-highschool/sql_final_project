using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DALOrg

{

    public static class OledbHelper
    {
        static OleDbConnection cn = new OleDbConnection(ConnectionString);
        public static string ConnectionString
        {
            get
            {

                return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf(@"\Project")) +@"\Project\Gyst\DAL\DB.accdb";
            }
        }
        public static void Execute(string com)
        {

            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }

            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            command.CommandText = com;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public static DataTable GetTable(string com)
        {

            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }

            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            command.CommandText = com;
            DataTable dt = new DataTable();
            dt.TableName = "tbl";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                throw;
            }
            finally
            {
            }
            return dt;
        }
    }
}