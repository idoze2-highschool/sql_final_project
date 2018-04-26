using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL = DALOrg;
using DALOrg.Component;

namespace Client.Components.Base
{
    public partial class DataFilter : MetroFramework.Controls.MetroUserControl
    {
        private Component Component;
        public DataFilter()
        {
            InitializeComponent();
            comboBox_FilterName.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                label_FilterName.Text = ((Filter)comboBox_FilterName.SelectedItem).Name;
                comboBox_FilterName.Hide();
                label_FilterName.Show();
                textBox_FilterValue.Show();
            };
            textBox_FilterValue.TextChanged += (object sender, EventArgs e) =>
             {
                 ((Filter)comboBox_FilterName.SelectedItem).SetValue(textBox_FilterValue.Text, textBox_FilterValue.Text);
                 AddFilter.Enabled = true;
             };
            AddFilter.Click += (object sender, EventArgs e) =>
             {
                 Filter F = ((Filter)comboBox_FilterName.SelectedItem);
                 ListViewItem I = new ListViewItem(F.Format);
                 I.Tag = F;
                 listView_Filters.Items.Add(I);
             };
            listView_Filters.SelectedIndexChanged += (object sender, EventArgs e) =>
             {
                 listView_Filters.Items.RemoveAt(listView_Filters.SelectedIndices[0]);
             };
        }
        #region Handle Different Component Types
        public void SetComponentType(Component Component)
        {
            this.Component = Component;
            comboBox_FilterName.Items.AddRange(GetFilters(Component));
        }
        private FilterCollection GetFilters(Component Component)
        {
            switch (Component)
            {
                default:
                    break;
                case Component.User:
                    return FilterCollections.UserFilters;
                case Component.Course:
                    return new Filter[] { };
                case Component.Subject:
                    return new Filter[] { };
                case Component.Group:
                    return new Filter[] { };

            }
            return null;
        }
        private string getTableName(Component Component)
        {
            string tableName = "";
            switch (Component)
            {
                case Component.User:
                    tableName = "Users";
                    break;
                case Component.Course:
                    tableName = "Courses";
                    break;
                case Component.Group:
                    tableName = "Groups";
                    break;
                case Component.Subject:
                    tableName = "Subjects";
                    break;
            }
            return tableName;
        }
        #endregion
        #region Handle Filter List
        private string getFiltersAsSQLConditions()
        {
            string query = "";
            foreach (ListViewItem item in listView_Filters.Items)
            {
                Filter filter = (Filter)item.Tag;
                query += string.Format("AND ({0}) ", filter.Query);
            }
            return query.Remove(query.LastIndexOf(" "), 1);
        }
        public string GetFiltersAsQuery(Component Component)
        {
            string query = "";
            query += getSelectStatement(Component);
            query += string.Format("{0}",1.ToString());
            return query;
        }
        #endregion
    }
}
