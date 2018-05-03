namespace Client.Components.Admin_UI.Users
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilterSelector = new Client.Components.Base.DataFilterSelector();
            this.button_New_User = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid
            // 
            this.ResultGrid.AllowUserToAddRows = false;
            this.ResultGrid.AllowUserToDeleteRows = false;
            this.ResultGrid.AllowUserToResizeColumns = false;
            this.ResultGrid.AllowUserToResizeRows = false;
            this.ResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(0, 20);
            this.ResultGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            this.ResultGrid.RowHeadersVisible = false;
            this.ResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultGrid.Size = new System.Drawing.Size(277, 176);
            this.ResultGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search In Users";
            // 
            // FilterSelector
            // 
            this.FilterSelector.AutoSize = true;
            this.FilterSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterSelector.BackColor = System.Drawing.Color.Transparent;
            this.FilterSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FilterSelector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilterSelector.Location = new System.Drawing.Point(280, 0);
            this.FilterSelector.Margin = new System.Windows.Forms.Padding(0);
            this.FilterSelector.Name = "FilterSelector";
            this.FilterSelector.Size = new System.Drawing.Size(243, 143);
            this.FilterSelector.TabIndex = 1;
            this.FilterSelector.TabStop = false;
            // 
            // button_New_User
            // 
            this.button_New_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New_User.Location = new System.Drawing.Point(0, 196);
            this.button_New_User.Margin = new System.Windows.Forms.Padding(0);
            this.button_New_User.Name = "button_New_User";
            this.button_New_User.Size = new System.Drawing.Size(75, 23);
            this.button_New_User.TabIndex = 4;
            this.button_New_User.Text = "New User";
            this.button_New_User.UseVisualStyleBackColor = true;
            // 
            // ViewUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_New_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterSelector);
            this.Controls.Add(this.ResultGrid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(523, 219);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid;
        private Base.DataFilterSelector FilterSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_New_User;
    }
}
