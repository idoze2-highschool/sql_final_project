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
using DALOrg.Components;

namespace Client.Components.Base
{
    public partial class DataFilterSelector : MetroFramework.Controls.MetroUserControl
    {
        private Component Component;
        private FilterCollection AvailableFilters;
        private FilterCollection AppliedFilters;
        public DataFilterSelector()
        {
            InitializeComponent();
            #region Hook Input Events
            comboBox_AvailableFilters.SelectedIndexChanged += (object sender, EventArgs e) =>
    {
        label_FilterName.Text = ((string)comboBox_AvailableFilters.SelectedItem);
        comboBox_AvailableFilters.Hide();
        label_FilterName.Show();
        textBox_FilterValue.Show();
    };
            textBox_FilterValue.TextChanged += (object sender, EventArgs e) =>
             {
                 button_Add.Enabled = true;
             };
            button_Add.Click += (object sender, EventArgs e) =>
             {
                 ApplyFilter(comboBox_AvailableFilters.SelectedIndex, textBox_FilterValue.Text);
             };
            listView_AppliedFilters.SelectedIndexChanged += (object sender, EventArgs e) =>
             {
                 listView_AppliedFilters.Items.RemoveAt(listView_AppliedFilters.SelectedIndices[0]);
             };
            listView_AppliedFilters.ItemSelectionChanged += (object sender, ListViewItemSelectionChangedEventArgs e) =>
             {
                 listView_AppliedFilters.Items.Remove(listView_AppliedFilters.SelectedItems[0]);
             };
            #endregion
        }
        public void SetComponentType(Component Component)
        {
            this.Component = Component;
            AvailableFilters = Component.GetFilters();
            AppliedFilters = new FilterCollection();
            SyncFilterCollections();
        }
        public void ApplyFilter(int Index, string Value)
        {
            ApplyFilter(Index, Value, Value);
        }
        public void ApplyFilter(int Index, string CheckValue, string FormatValue)
        {
            ApplyFilter(AvailableFilters.Remove(Index), CheckValue, FormatValue);
            RefreshAvailableFilters();
        }
        public void ApplyFilter(Filter Filter, string Value)
        {
            ApplyFilter(Filter, Value, Value);
        }
        public void ApplyFilter(Filter Filter, string CheckValue, string FormatValue)
        {
            ApplyFilter(Filter.CloneWithValue(Filter, CheckValue, FormatValue));
        }
        //Base Method
        public void ApplyFilter(Filter Filter)
        {
            AppliedFilters.Add(Filter, true);
            SyncFilterCollections();
        }
        public DataTable GetTable()
        {
            return DAL.UserMethods.GetFilteredTable(Component.GetTableName(), Component.GetTableColumns(), AppliedFilters);
        }
        private void SyncFilterCollections()
        {
            RefreshAppliedFilters();
            RefreshAvailableFilters();
        }
        private void RefreshAppliedFilters()
        {
            listView_AppliedFilters.Items.Clear();
            foreach (string FilterFormat in AppliedFilters.GetFilterFormats())
            {
                listView_AppliedFilters.Items.Add(new ListViewItem(FilterFormat)
                {
                    BackColor = Color.Red,
                    ForeColor = Color.Honeydew
                });
            }
        }
        private void RefreshAvailableFilters()
        {
            comboBox_AvailableFilters.Items.Clear();
            foreach (string FilterName in AvailableFilters.GetNames())
            {
                comboBox_AvailableFilters.Items.Add(FilterName);
            }
        }

    }
}
