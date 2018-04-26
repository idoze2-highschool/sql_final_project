﻿namespace Client.Components.Admin_UI.Users
{
    partial class ViewUsers
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
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataFilter1 = new Client.Components.Base.DataFilter();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid
            // 
            this.ResultGrid.AllowUserToAddRows = false;
            this.ResultGrid.AllowUserToDeleteRows = false;
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.UName,
            this.UType});
            this.ResultGrid.Location = new System.Drawing.Point(0, 42);
            this.ResultGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            this.ResultGrid.Size = new System.Drawing.Size(226, 45);
            this.ResultGrid.TabIndex = 0;
            // 
            // UID
            // 
            this.UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UID.HeaderText = "ID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UID.Width = 43;
            // 
            // UName
            // 
            this.UName.FillWeight = 20F;
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            this.UName.Width = 83;
            // 
            // UType
            // 
            this.UType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UType.HeaderText = "Type";
            this.UType.Name = "UType";
            this.UType.ReadOnly = true;
            this.UType.Width = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search In Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(225, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter: ";
            // 
            // dataFilter1
            // 
            this.dataFilter1.AutoSize = true;
            this.dataFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataFilter1.BackColor = System.Drawing.Color.Transparent;
            this.dataFilter1.Location = new System.Drawing.Point(280, 0);
            this.dataFilter1.Margin = new System.Windows.Forms.Padding(0);
            this.dataFilter1.Name = "dataFilter1";
            this.dataFilter1.Size = new System.Drawing.Size(251, 156);
            this.dataFilter1.TabIndex = 1;
            this.dataFilter1.UseCustomBackColor = true;
            this.dataFilter1.UseCustomForeColor = true;
            this.dataFilter1.UseSelectable = true;
            // 
            // ViewUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFilter1);
            this.Controls.Add(this.ResultGrid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(520, 330);
            this.UseCustomBackColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UType;
        private Base.DataFilter dataFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
