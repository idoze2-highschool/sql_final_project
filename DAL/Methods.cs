using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Component;

namespace DAL
{
    public static class Methods
    {
        #region Filtered Table
        public static DataTable GetFilteredTable(string TableName, params Filter[] Filters)
        {
            return GetFilteredTable(TableName, new string[] { "*" }, Filters);
        }
        public static DataTable GetFilteredTable(string TableName, string[] Columns, params Filter[] Filters)
        {
            return GetFilteredTable(TableName, Columns, new FilterCollection(Filters));
        }
        //base method
        public static DataTable GetFilteredTable(string TableName, string[] Columns, FilterCollection Filters)
        {
            //Format an Expression:
            // Handle Columns Part
            #region Format Columns To an SQL Select-Cmpatible Format
            //Form
            Columns = Columns.Select(
                C => //Initializes Variable string C - Current Column 
                string.Format("{0}.{1}", TableName, C) + (
                (C == Columns.Last())//Setsa boolean Expression that checks if C is the Last Column
                ? ""//If Expression is true add a blank string (Do nothing)
                : "," //If Expression is false add ","
                ) + " "
                ).ToArray();
            #endregion
            #region Create ColumnsString
            string ColumnsString = "";
            foreach (string Column in Columns) { ColumnsString += Column; }
            string expr = string.Format("SELECT {0}", ColumnsString);
            #endregion
            // Handle TableName Part
            expr += string.Format(" FROM {0}", TableName);
            // Handle Conditions Part
            string[] Conditions = Filters.GetQueries();
            if (Conditions.Count() > 0)
            {
                #region Format Conditions To an SQL Condition Format
                //Format Conditions To Easily Chain Them.
                //Formats The Last Condition To "(ConditionString)"
                //Formats The Other Conditions To "(ConditionString) AND "
                Conditions = Conditions.Select(
                    C => //Initializes Variable string C - Current Condition
                    string.Format("({0})", C) + (
                    ((C == Conditions.Last())) //Sets a boolean Expression that checks if C is the Last Condition
                    ? "" //If Expression is true add a blank string (Do nothing),
                    : " AND " //If Expression is false add " AND ".
                    )
                    ).ToArray();
                #endregion
                #region Create ConditionsString
                string ConditionsString = "";
                foreach (string Condition in Conditions) { ConditionsString += Condition; }
                expr += string.Format(" WHERE ({0})", ConditionsString);
                #endregion
            }
            // Close expression With a Semicolon
            expr += ";";
            return OledbHelper.GetTable(expr);
        }
        #endregion
        #region Pull
        public static User GetUserByID(int UserID)
        {
            DataRow dr = GetFilteredTable(User.Tablename, User.Columns, Filter.CloneWithValue(Filters.User.ID, UserID.ToString())).Rows[0];
            return new User(
                (int)dr["UserID"],
                (string)dr["FName"],
                (string)dr["LName"],
                (int)dr["UserType"]
                );
        }
        public static User GetUserByCredentials(string Username, string Password)
        {
            Filter FUsername = Filter.CloneWithValue(Filters.User.Username, Username);
            Filter FPassword = Filter.CloneWithValue(Filters.User.Password, Password);
            DataRow dr = GetFilteredTable(User.Tablename, User.Columns, FUsername, FPassword).Rows[0];
            return new User(
            (int)dr["UserID"],
            (string)dr["FName"],
            (string)dr["LName"],
            (int)dr["UserType"]
            );
        }
        #endregion
        #region Push

        #endregion
        #region Update

        #endregion
    }
}
