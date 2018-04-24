namespace GystClient.AdminScreens.Manage_Groups
{
    partial class ManageGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroups));
            this.treeView_Search = new System.Windows.Forms.TreeView();
            this.panel_ViewLesson = new System.Windows.Forms.Panel();
            this.panel_GroupView = new System.Windows.Forms.Panel();
            this.pictureBox_Course_Edit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Group_Name_Edit = new System.Windows.Forms.PictureBox();
            this.listBox_Group_Members = new System.Windows.Forms.ListBox();
            this.label_Group_Members = new System.Windows.Forms.Label();
            this.label_Course_Name = new System.Windows.Forms.LinkLabel();
            this.label_Course = new System.Windows.Forms.Label();
            this.label_Group_Name = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_ViewLesson.SuspendLayout();
            this.panel_GroupView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Course_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Group_Name_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_Search
            // 
            this.treeView_Search.Location = new System.Drawing.Point(3, 3);
            this.treeView_Search.Name = "treeView_Search";
            this.treeView_Search.Size = new System.Drawing.Size(204, 232);
            this.treeView_Search.TabIndex = 1;
            // 
            // panel_ViewLesson
            // 
            this.panel_ViewLesson.AutoSize = true;
            this.panel_ViewLesson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ViewLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ViewLesson.Controls.Add(this.treeView_Search);
            this.panel_ViewLesson.Location = new System.Drawing.Point(12, 12);
            this.panel_ViewLesson.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_ViewLesson.Name = "panel_ViewLesson";
            this.panel_ViewLesson.Size = new System.Drawing.Size(212, 240);
            this.panel_ViewLesson.TabIndex = 3;
            // 
            // panel_GroupView
            // 
            this.panel_GroupView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GroupView.Controls.Add(this.pictureBox_Course_Edit);
            this.panel_GroupView.Controls.Add(this.pictureBox_Group_Name_Edit);
            this.panel_GroupView.Controls.Add(this.listBox_Group_Members);
            this.panel_GroupView.Controls.Add(this.label_Group_Members);
            this.panel_GroupView.Controls.Add(this.label_Course_Name);
            this.panel_GroupView.Controls.Add(this.label_Course);
            this.panel_GroupView.Controls.Add(this.label_Group_Name);
            this.panel_GroupView.Controls.Add(this.label_Name);
            this.panel_GroupView.Location = new System.Drawing.Point(230, 12);
            this.panel_GroupView.Name = "panel_GroupView";
            this.panel_GroupView.Size = new System.Drawing.Size(208, 240);
            this.panel_GroupView.TabIndex = 4;
            this.panel_GroupView.Visible = false;
            // 
            // pictureBox_Course_Edit
            // 
            this.pictureBox_Course_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Course_Edit.Image")));
            this.pictureBox_Course_Edit.Location = new System.Drawing.Point(132, 72);
            this.pictureBox_Course_Edit.Name = "pictureBox_Course_Edit";
            this.pictureBox_Course_Edit.Size = new System.Drawing.Size(19, 17);
            this.pictureBox_Course_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Course_Edit.TabIndex = 7;
            this.pictureBox_Course_Edit.TabStop = false;
            // 
            // pictureBox_Group_Name_Edit
            // 
            this.pictureBox_Group_Name_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Group_Name_Edit.Image")));
            this.pictureBox_Group_Name_Edit.Location = new System.Drawing.Point(124, 49);
            this.pictureBox_Group_Name_Edit.Name = "pictureBox_Group_Name_Edit";
            this.pictureBox_Group_Name_Edit.Size = new System.Drawing.Size(19, 17);
            this.pictureBox_Group_Name_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Group_Name_Edit.TabIndex = 6;
            this.pictureBox_Group_Name_Edit.TabStop = false;
            // 
            // listBox_Group_Members
            // 
            this.listBox_Group_Members.FormattingEnabled = true;
            this.listBox_Group_Members.Location = new System.Drawing.Point(3, 109);
            this.listBox_Group_Members.Name = "listBox_Group_Members";
            this.listBox_Group_Members.Size = new System.Drawing.Size(148, 95);
            this.listBox_Group_Members.TabIndex = 5;
            // 
            // label_Group_Members
            // 
            this.label_Group_Members.AutoSize = true;
            this.label_Group_Members.Location = new System.Drawing.Point(4, 93);
            this.label_Group_Members.Name = "label_Group_Members";
            this.label_Group_Members.Size = new System.Drawing.Size(85, 13);
            this.label_Group_Members.TabIndex = 4;
            this.label_Group_Members.Text = "Group Members:";
            // 
            // label_Course_Name
            // 
            this.label_Course_Name.AutoSize = true;
            this.label_Course_Name.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.label_Course_Name.Location = new System.Drawing.Point(52, 71);
            this.label_Course_Name.Name = "label_Course_Name";
            this.label_Course_Name.Size = new System.Drawing.Size(74, 13);
            this.label_Course_Name.TabIndex = 3;
            this.label_Course_Name.TabStop = true;
            this.label_Course_Name.Text = "[CourseName]";
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(3, 71);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(43, 13);
            this.label_Course.TabIndex = 2;
            this.label_Course.Text = "Course:";
            // 
            // label_Group_Name
            // 
            this.label_Group_Name.AutoSize = true;
            this.label_Group_Name.Location = new System.Drawing.Point(48, 49);
            this.label_Group_Name.Name = "label_Group_Name";
            this.label_Group_Name.Size = new System.Drawing.Size(70, 13);
            this.label_Group_Name.TabIndex = 1;
            this.label_Group_Name.Text = "[GroupName]";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(4, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 263);
            this.Controls.Add(this.panel_GroupView);
            this.Controls.Add(this.panel_ViewLesson);
            this.Name = "ManageGroups";
            this.Text = "ManageGroups";
            this.panel_ViewLesson.ResumeLayout(false);
            this.panel_GroupView.ResumeLayout(false);
            this.panel_GroupView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Course_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Group_Name_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Search;
        private System.Windows.Forms.Panel panel_ViewLesson;
        private System.Windows.Forms.Panel panel_GroupView;
        private System.Windows.Forms.LinkLabel label_Course_Name;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Label label_Group_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Group_Members;
        private System.Windows.Forms.ListBox listBox_Group_Members;
        private System.Windows.Forms.PictureBox pictureBox_Course_Edit;
        private System.Windows.Forms.PictureBox pictureBox_Group_Name_Edit;
    }
}