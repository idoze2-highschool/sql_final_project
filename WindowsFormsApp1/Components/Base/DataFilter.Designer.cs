namespace Client.Components.Base
{
    partial class DataFilter
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
            this.comboBox_FilterName = new System.Windows.Forms.ComboBox();
            this.label_FilterName = new System.Windows.Forms.Label();
            this.label_FilterValue = new System.Windows.Forms.Label();
            this.textBox_FilterValue = new System.Windows.Forms.TextBox();
            this.AddFilter = new System.Windows.Forms.Button();
            this.listView_Filters = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_FilterName
            // 
            this.comboBox_FilterName.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_FilterName.FormattingEnabled = true;
            this.comboBox_FilterName.Location = new System.Drawing.Point(60, 0);
            this.comboBox_FilterName.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_FilterName.Name = "comboBox_FilterName";
            this.comboBox_FilterName.Size = new System.Drawing.Size(95, 21);
            this.comboBox_FilterName.TabIndex = 1;
            // 
            // label_FilterName
            // 
            this.label_FilterName.AutoSize = true;
            this.label_FilterName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_FilterName.Location = new System.Drawing.Point(0, 0);
            this.label_FilterName.Margin = new System.Windows.Forms.Padding(0);
            this.label_FilterName.Name = "label_FilterName";
            this.label_FilterName.Size = new System.Drawing.Size(60, 13);
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
            this.label_FilterValue.Size = new System.Drawing.Size(59, 13);
            this.label_FilterValue.TabIndex = 4;
            this.label_FilterValue.Text = "FilterValue:";
            this.label_FilterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AddFilter
            // 
            this.AddFilter.AutoSize = true;
            this.AddFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddFilter.Enabled = false;
            this.AddFilter.Location = new System.Drawing.Point(267, 0);
            this.AddFilter.Name = "AddFilter";
            this.AddFilter.Size = new System.Drawing.Size(36, 23);
            this.AddFilter.TabIndex = 6;
            this.AddFilter.Text = "Add";
            this.AddFilter.UseVisualStyleBackColor = true;
            // 
            // listView_Filters
            // 
            this.listView_Filters.BackColor = System.Drawing.Color.White;
            this.listView_Filters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listView_Filters.FullRowSelect = true;
            this.listView_Filters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Filters.HideSelection = false;
            this.listView_Filters.LabelWrap = false;
            this.listView_Filters.Location = new System.Drawing.Point(0, 36);
            this.listView_Filters.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Filters.MultiSelect = false;
            this.listView_Filters.Name = "listView_Filters";
            this.listView_Filters.ShowGroups = false;
            this.listView_Filters.Size = new System.Drawing.Size(251, 120);
            this.listView_Filters.TabIndex = 7;
            this.listView_Filters.UseCompatibleStateImageBehavior = false;
            this.listView_Filters.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Applied Filters:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.AddFilter);
            this.panel1.Controls.Add(this.textBox_FilterValue);
            this.panel1.Controls.Add(this.label_FilterValue);
            this.panel1.Controls.Add(this.comboBox_FilterName);
            this.panel1.Controls.Add(this.label_FilterName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(243, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 23);
            this.panel1.TabIndex = 9;
            // 
            // DataFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Filters);
            this.Name = "DataFilter";
            this.Size = new System.Drawing.Size(303, 156);
            this.UseCustomBackColor = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_FilterName;
        private System.Windows.Forms.Label label_FilterName;
        private System.Windows.Forms.Label label_FilterValue;
        private System.Windows.Forms.TextBox textBox_FilterValue;
        private System.Windows.Forms.Button AddFilter;
        private System.Windows.Forms.ListView listView_Filters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
