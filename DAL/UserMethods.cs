using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public static class UserMethods
    {
        #region Data Pulling
        public static Component.User GetUser(string username, string password)
        {
                DataTable Data = OledbHelper.GetTable("Select UserID, FName From Users Where UName='" + username + "' AND PWord='" + password + "'");
                DataRow DataR = Data.Rows[0];
                return new Component.User(int.Parse(DataR["UserID"].ToString()),DataR["FName"].ToString());
            
        }
        #endregion
        #region Data Validation
        public static bool UserExists(string Username, string Password)
        {
            try
            {
                GetUser(Username, Password);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Data Modification
        #region Add
        public static bool AddUser(string Username, string Password)
        {
            try
            {
                if (!UserExists(Username, Password))
                {
                    string cmd = "INSERT INTO Users (UName,PWord) Values ('" + Username + "','" + Password + "');";
                    OledbHelper.Execute(cmd);
                    return true;
                }
                else
                {
                    throw new Exception("User Exists");
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Update

        #endregion
        #endregion
    }
}
