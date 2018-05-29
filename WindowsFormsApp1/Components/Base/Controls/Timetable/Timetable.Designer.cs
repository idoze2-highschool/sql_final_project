namespace Client
{
    partial class Timetable
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
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.label_Friday = new MetroFramework.Controls.MetroLabel();
            this.label_Thursday = new MetroFramework.Controls.MetroLabel();
            this.label_Wednesday = new MetroFramework.Controls.MetroLabel();
            this.label_Tuesday = new MetroFramework.Controls.MetroLabel();
            this.label_Monday = new MetroFramework.Controls.MetroLabel();
            this.label_Sunday = new MetroFramework.Controls.MetroLabel();
            this.Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 7;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.Table.Controls.Add(this.label_Friday, 6, 0);
            this.Table.Controls.Add(this.label_Thursday, 5, 0);
            this.Table.Controls.Add(this.label_Wednesday, 4, 0);
            this.Table.Controls.Add(this.label_Tuesday, 3, 0);
            this.Table.Controls.Add(this.label_Monday, 2, 0);
            this.Table.Controls.Add(this.label_Sunday, 1, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Margin = new System.Windows.Forms.Padding(0);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Size = new System.Drawing.Size(410, 46);
            this.Table.TabIndex = 0;
            // 
            // label_Friday
            // 
            this.label_Friday.AutoSize = true;
            this.label_Friday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Friday.Location = new System.Drawing.Point(275, 1);
            this.label_Friday.Name = "label_Friday";
            this.label_Friday.Size = new System.Drawing.Size(132, 20);
            this.label_Friday.TabIndex = 6;
            this.label_Friday.Text = "Fri";
            this.label_Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Friday.UseCustomBackColor = true;
            this.label_Friday.UseCustomForeColor = true;
            // 
            // label_Thursday
            // 
            this.label_Thursday.AutoSize = true;
            this.label_Thursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Thursday.Location = new System.Drawing.Point(224, 1);
            this.label_Thursday.Name = "label_Thursday";
            this.label_Thursday.Size = new System.Drawing.Size(44, 20);
            this.label_Thursday.TabIndex = 5;
            this.label_Thursday.Text = "Thu";
            this.label_Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Thursday.UseCustomBackColor = true;
            this.label_Thursday.UseCustomForeColor = true;
            // 
            // label_Wednesday
            // 
            this.label_Wednesday.AutoSize = true;
            this.label_Wednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Wednesday.Location = new System.Drawing.Point(173, 1);
            this.label_Wednesday.Name = "label_Wednesday";
            this.label_Wednesday.Size = new System.Drawing.Size(44, 20);
            this.label_Wednesday.TabIndex = 4;
            this.label_Wednesday.Text = "Wed";
            this.label_Wednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Wednesday.UseCustomBackColor = true;
            this.label_Wednesday.UseCustomForeColor = true;
            // 
            // label_Tuesday
            // 
            this.label_Tuesday.AutoSize = true;
            this.label_Tuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Tuesday.Location = new System.Drawing.Point(122, 1);
            this.label_Tuesday.Name = "label_Tuesday";
            this.label_Tuesday.Size = new System.Drawing.Size(44, 20);
            this.label_Tuesday.TabIndex = 3;
            this.label_Tuesday.Text = "Tue";
            this.label_Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Tuesday.UseCustomBackColor = true;
            this.label_Tuesday.UseCustomForeColor = true;
            // 
            // label_Monday
            // 
            this.label_Monday.AutoSize = true;
            this.label_Monday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Monday.Location = new System.Drawing.Point(71, 1);
            this.label_Monday.Name = "label_Monday";
            this.label_Monday.Size = new System.Drawing.Size(44, 20);
            this.label_Monday.TabIndex = 2;
            this.label_Monday.Text = "Mon";
            this.label_Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Monday.UseCustomBackColor = true;
            this.label_Monday.UseCustomForeColor = true;
            // 
            // label_Sunday
            // 
            this.label_Sunday.AutoSize = true;
            this.label_Sunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Sunday.Location = new System.Drawing.Point(20, 1);
            this.label_Sunday.Name = "label_Sunday";
            this.label_Sunday.Size = new System.Drawing.Size(44, 20);
            this.label_Sunday.TabIndex = 1;
            this.label_Sunday.Text = "Sun";
            this.label_Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Sunday.UseCustomBackColor = true;
            this.label_Sunday.UseCustomForeColor = true;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(410, 46);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label_Friday;
        private MetroFramework.Controls.MetroLabel label_Thursday;
        private MetroFramework.Controls.MetroLabel label_Wednesday;
        private MetroFramework.Controls.MetroLabel label_Tuesday;
        private MetroFramework.Controls.MetroLabel label_Monday;
        private MetroFramework.Controls.MetroLabel label_Sunday;
        public System.Windows.Forms.TableLayoutPanel Table;
        //private Client.DBDataSet dbDataSet1;
    }
}
