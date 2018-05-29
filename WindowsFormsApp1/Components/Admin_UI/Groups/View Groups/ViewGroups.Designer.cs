namespace Client.Components.Admin_UI.Groups
{
    partial class ViewGroups
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
            this.button_New_Group = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.FilterSelector = new Client.Components.Base.DataFilterSelector();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_New_Group
            // 
            this.button_New_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New_Group.Location = new System.Drawing.Point(0, 196);
            this.button_New_Group.Margin = new System.Windows.Forms.Padding(0);
            this.button_New_Group.Name = "button_New_Group";
            this.button_New_Group.Size = new System.Drawing.Size(89, 23);
            this.button_New_Group.TabIndex = 8;
            this.button_New_Group.Text = "New Group";
            this.button_New_Group.UseVisualStyleBackColor = true;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Margin = new System.Windows.Forms.Padding(0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(135, 20);
            this.label_Title.TabIndex = 7;
            this.label_Title.Text = "Search In Groups";
            // 
            // FilterSelector
            // 
            this.FilterSelector.AutoSize = true;
            this.FilterSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterSelector.BackColor = System.Drawing.Color.Transparent;
            this.FilterSelector.Component = Client.Components.Base.Component.Group;
            this.FilterSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FilterSelector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilterSelector.Location = new System.Drawing.Point(280, 0);
            this.FilterSelector.Margin = new System.Windows.Forms.Padding(0);
            this.FilterSelector.Name = "FilterSelector";
            this.FilterSelector.Size = new System.Drawing.Size(243, 163);
            this.FilterSelector.TabIndex = 6;
            this.FilterSelector.TabStop = false;
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
            this.ResultGrid.TabIndex = 5;
            // 
            // ViewGroups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_New_Group);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.FilterSelector);
            this.Controls.Add(this.ResultGrid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewGroups";
            this.Size = new System.Drawing.Size(434, 320);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_New_Group;
        private System.Windows.Forms.Label label_Title;
        private Base.DataFilterSelector FilterSelector;
        private System.Windows.Forms.DataGridView ResultGrid;
    }
}
