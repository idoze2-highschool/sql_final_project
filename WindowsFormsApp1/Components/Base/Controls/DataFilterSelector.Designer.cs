using System.ComponentModel;

namespace Client.Components.Base
{
    partial class DataFilterSelector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Applied Filters:", System.Windows.Forms.HorizontalAlignment.Left);
            this.comboBox_AvailableFilters = new System.Windows.Forms.ComboBox();
            this.label_FilterName = new System.Windows.Forms.Label();
            this.label_FilterValue = new System.Windows.Forms.Label();
            this.textBox_FilterValue = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.listView_AppliedFilters = new System.Windows.Forms.ListView();
            this.panel_Input = new System.Windows.Forms.Panel();
            this.label_Desc = new System.Windows.Forms.Label();
            this.panel_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_AvailableFilters
            // 
            this.comboBox_AvailableFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_AvailableFilters.FormattingEnabled = true;
            this.comboBox_AvailableFilters.Location = new System.Drawing.Point(60, 0);
            this.comboBox_AvailableFilters.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_AvailableFilters.Name = "comboBox_AvailableFilters";
            this.comboBox_AvailableFilters.Size = new System.Drawing.Size(95, 21);
            this.comboBox_AvailableFilters.TabIndex = 1;
            // 
            // label_FilterName
            // 
            this.label_FilterName.AutoSize = true;
            this.label_FilterName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_FilterName.Location = new System.Drawing.Point(0, 0);
            this.label_FilterName.Margin = new System.Windows.Forms.Padding(0);
            this.label_FilterName.Name = "label_FilterName";
            this.label_FilterName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label_FilterName.Size = new System.Drawing.Size(60, 19);
            this.label_FilterName.TabIndex = 1;
            this.label_FilterName.Text = "FilterName:";
            this.label_FilterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_FilterName.Visible = false;
            // 
            // label_FilterValue
            // 
            this.label_FilterValue.AutoSize = true;
            this.label_FilterValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_FilterValue.Location = new System.Drawing.Point(155, 0);
            this.label_FilterValue.Margin = new System.Windows.Forms.Padding(0);
            this.label_FilterValue.Name = "label_FilterValue";
            this.label_FilterValue.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label_FilterValue.Size = new System.Drawing.Size(59, 19);
            this.label_FilterValue.TabIndex = 4;
            this.label_FilterValue.Text = "FilterValue:";
            this.label_FilterValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_FilterValue.Visible = false;
            // 
            // textBox_FilterValue
            // 
            this.textBox_FilterValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_FilterValue.Location = new System.Drawing.Point(214, 0);
            this.textBox_FilterValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_FilterValue.Name = "textBox_FilterValue";
            this.textBox_FilterValue.Size = new System.Drawing.Size(53, 20);
            this.textBox_FilterValue.TabIndex = 6;
            this.textBox_FilterValue.Visible = false;
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add.Enabled = false;
            this.button_Add.Location = new System.Drawing.Point(267, 0);
            this.button_Add.Margin = new System.Windows.Forms.Padding(0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(36, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // listView_AppliedFilters
            // 
            this.listView_AppliedFilters.BackColor = System.Drawing.Color.White;
            this.listView_AppliedFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_AppliedFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listView_AppliedFilters.FullRowSelect = true;
            listViewGroup1.Header = "Applied Filters:";
            listViewGroup1.Name = "listViewGroup1";
            this.listView_AppliedFilters.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView_AppliedFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_AppliedFilters.HideSelection = false;
            this.listView_AppliedFilters.LabelWrap = false;
            this.listView_AppliedFilters.Location = new System.Drawing.Point(0, 23);
            this.listView_AppliedFilters.Margin = new System.Windows.Forms.Padding(0);
            this.listView_AppliedFilters.MultiSelect = false;
            this.listView_AppliedFilters.Name = "listView_AppliedFilters";
            this.listView_AppliedFilters.ShowGroups = false;
            this.listView_AppliedFilters.Size = new System.Drawing.Size(167, 120);
            this.listView_AppliedFilters.TabIndex = 7;
            this.listView_AppliedFilters.UseCompatibleStateImageBehavior = false;
            this.listView_AppliedFilters.View = System.Windows.Forms.View.List;
            // 
            // panel_Input
            // 
            this.panel_Input.AutoSize = true;
            this.panel_Input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Input.Controls.Add(this.button_Add);
            this.panel_Input.Controls.Add(this.textBox_FilterValue);
            this.panel_Input.Controls.Add(this.label_FilterValue);
            this.panel_Input.Controls.Add(this.comboBox_AvailableFilters);
            this.panel_Input.Controls.Add(this.label_FilterName);
            this.panel_Input.Location = new System.Drawing.Point(0, 0);
            this.panel_Input.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Input.MinimumSize = new System.Drawing.Size(243, 23);
            this.panel_Input.Name = "panel_Input";
            this.panel_Input.Size = new System.Drawing.Size(303, 23);
            this.panel_Input.TabIndex = 9;
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Location = new System.Drawing.Point(-3, 143);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(60, 13);
            this.label_Desc.TabIndex = 10;
            this.label_Desc.Text = "Description";
            // 
            // DataFilterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.panel_Input);
            this.Controls.Add(this.listView_AppliedFilters);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataFilterSelector";
            this.Size = new System.Drawing.Size(303, 156);
            this.panel_Input.ResumeLayout(false);
            this.panel_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ComboBox comboBox_AvailableFilters;
        private System.Windows.Forms.Label label_FilterName;
        private System.Windows.Forms.Label label_FilterValue;
        private System.Windows.Forms.TextBox textBox_FilterValue;
        private System.Windows.Forms.ListView listView_AppliedFilters;
        private System.Windows.Forms.Panel panel_Input;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Desc;
    }
}
