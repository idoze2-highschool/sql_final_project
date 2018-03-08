namespace GystClient.AdminScreens
{
    partial class ManageTimetable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_table = new System.Windows.Forms.Panel();
            this.treeView_Search = new System.Windows.Forms.TreeView();
            this.panel_ViewLesson = new System.Windows.Forms.Panel();
            this.comboBox_Filter_Selection = new System.Windows.Forms.ComboBox();
            this.label_Filter_Title = new System.Windows.Forms.Label();
            this.panel_ViewLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_table
            // 
            this.panel_table.AutoSize = true;
            this.panel_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_table.Location = new System.Drawing.Point(230, 12);
            this.panel_table.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(10, 10);
            this.panel_table.TabIndex = 0;
            // 
            // treeView_Search
            // 
            this.treeView_Search.Location = new System.Drawing.Point(3, 30);
            this.treeView_Search.Name = "treeView_Search";
            this.treeView_Search.Size = new System.Drawing.Size(204, 232);
            this.treeView_Search.TabIndex = 1;
            this.treeView_Search.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Search_AfterSelect);
            // 
            // panel_ViewLesson
            // 
            this.panel_ViewLesson.AutoSize = true;
            this.panel_ViewLesson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ViewLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ViewLesson.Controls.Add(this.label_Filter_Title);
            this.panel_ViewLesson.Controls.Add(this.comboBox_Filter_Selection);
            this.panel_ViewLesson.Controls.Add(this.treeView_Search);
            this.panel_ViewLesson.Location = new System.Drawing.Point(12, 12);
            this.panel_ViewLesson.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_ViewLesson.Name = "panel_ViewLesson";
            this.panel_ViewLesson.Size = new System.Drawing.Size(212, 267);
            this.panel_ViewLesson.TabIndex = 1;
            // 
            // comboBox_Filter_Selection
            // 
            this.comboBox_Filter_Selection.FormattingEnabled = true;
            this.comboBox_Filter_Selection.Location = new System.Drawing.Point(86, 3);
            this.comboBox_Filter_Selection.Name = "comboBox_Filter_Selection";
            this.comboBox_Filter_Selection.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_Selection.TabIndex = 2;
            // 
            // label_Filter_Title
            // 
            this.label_Filter_Title.AutoSize = true;
            this.label_Filter_Title.Location = new System.Drawing.Point(3, 6);
            this.label_Filter_Title.Name = "label_Filter_Title";
            this.label_Filter_Title.Size = new System.Drawing.Size(77, 13);
            this.label_Filter_Title.TabIndex = 3;
            this.label_Filter_Title.Text = "Filter Table By:";
            // 
            // ManageTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 361);
            this.Controls.Add(this.panel_ViewLesson);
            this.Controls.Add(this.panel_table);
            this.Name = "ManageTimetable";
            this.Text = "ManageTimetable";
            this.panel_ViewLesson.ResumeLayout(false);
            this.panel_ViewLesson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.TreeView treeView_Search;
        private System.Windows.Forms.Panel panel_ViewLesson;
        private System.Windows.Forms.Label label_Filter_Title;
        private System.Windows.Forms.ComboBox comboBox_Filter_Selection;
    }
}