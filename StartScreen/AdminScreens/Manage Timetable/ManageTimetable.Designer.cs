﻿namespace GystClient.AdminScreens.Manage_Timetable
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_ViewLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_table
            // 
            this.panel_table.AutoSize = true;
            this.panel_table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_table.Location = new System.Drawing.Point(226, 32);
            this.panel_table.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(10, 10);
            this.panel_table.TabIndex = 0;
            // 
            // treeView_Search
            // 
            this.treeView_Search.Location = new System.Drawing.Point(3, 16);
            this.treeView_Search.Name = "treeView_Search";
            this.treeView_Search.Size = new System.Drawing.Size(204, 232);
            this.treeView_Search.TabIndex = 1;
            // 
            // panel_ViewLesson
            // 
            this.panel_ViewLesson.AutoSize = true;
            this.panel_ViewLesson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ViewLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ViewLesson.Controls.Add(this.label1);
            this.panel_ViewLesson.Controls.Add(this.treeView_Search);
            this.panel_ViewLesson.Location = new System.Drawing.Point(12, 32);
            this.panel_ViewLesson.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_ViewLesson.Name = "panel_ViewLesson";
            this.panel_ViewLesson.Size = new System.Drawing.Size(212, 253);
            this.panel_ViewLesson.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Table For:";
            // 
            // ManageTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(654, 357);
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
        private System.Windows.Forms.Label label1;
    }
}