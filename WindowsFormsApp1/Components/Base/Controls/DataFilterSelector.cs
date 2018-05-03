using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL.Component;

namespace Client.Components.Base
{
    public partial class DataFilterSelector : UserControl
    {
        [Browsable(true),EditorBrowsable(EditorBrowsableState.Always),DisplayName("Component"),Description("Component Type"),DefaultValue(Component.User)]
        public Component Component{get;set;}
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
                 if (textBox_FilterValue.Text != "" && !textBox_FilterValue.Text.Contains("'"))
                 {
                     button_Add.Enabled = true;
                 }
                 else
                 {
                     button_Add.Enabled = false;
                 }
             };
            button_Add.Click += (object sender, EventArgs e) =>
             {
                 ApplyFilter(comboBox_AvailableFilters.SelectedIndex, textBox_FilterValue.Text);
             };
            listView_AppliedFilters.SelectedIndexChanged += (object sender, EventArgs e) =>
             {
                 RemoveFilter(listView_AppliedFilters.SelectedIndices[0]);
             };

            #endregion
            InitializeFilterCollection();
        }
        public void InitializeFilterCollection()
        {
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
            if (AppliedFilters.Add(Filter, true))
            {
                textBox_FilterValue.Hide();
                textBox_FilterValue.Text = "";
                label_FilterName.Hide();
                comboBox_AvailableFilters.Show();
            }
            SyncFilterCollections();
        }
        //Base Method
        public void RemoveFilter(int Index)
        {
            Filter Removed = AppliedFilters.Remove(Index).Reset();
            AvailableFilters.Add(Removed);
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
            Invalidate();
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
