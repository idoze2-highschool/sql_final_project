namespace GystClient.AdminScreens.Manage_Courses
{
    partial class ManageCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourses));
            this.panel_CourseView = new System.Windows.Forms.Panel();
            this.pictureBox_Grade_Edit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Course_Name_Edit = new System.Windows.Forms.PictureBox();
            this.listBox_Course_Subjects = new System.Windows.Forms.ListBox();
            this.label_Course_Subjects = new System.Windows.Forms.Label();
            this.label_Grade = new System.Windows.Forms.Label();
            this.label_Course_Name = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_ViewLesson = new System.Windows.Forms.Panel();
            this.treeView_Search = new System.Windows.Forms.TreeView();
            this.label_Grade_Value = new System.Windows.Forms.Label();
            this.panel_CourseView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grade_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Course_Name_Edit)).BeginInit();
            this.panel_ViewLesson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_CourseView
            // 
            this.panel_CourseView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CourseView.Controls.Add(this.label_Grade_Value);
            this.panel_CourseView.Controls.Add(this.pictureBox_Grade_Edit);
            this.panel_CourseView.Controls.Add(this.pictureBox_Course_Name_Edit);
            this.panel_CourseView.Controls.Add(this.listBox_Course_Subjects);
            this.panel_CourseView.Controls.Add(this.label_Course_Subjects);
            this.panel_CourseView.Controls.Add(this.label_Grade);
            this.panel_CourseView.Controls.Add(this.label_Course_Name);
            this.panel_CourseView.Controls.Add(this.label_Name);
            this.panel_CourseView.Location = new System.Drawing.Point(230, 12);
            this.panel_CourseView.Name = "panel_CourseView";
            this.panel_CourseView.Size = new System.Drawing.Size(208, 240);
            this.panel_CourseView.TabIndex = 6;
            this.panel_CourseView.Visible = false;
            // 
            // pictureBox_Grade_Edit
            // 
            this.pictureBox_Grade_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Grade_Edit.Image")));
            this.pictureBox_Grade_Edit.Location = new System.Drawing.Point(104, 71);
            this.pictureBox_Grade_Edit.Name = "pictureBox_Grade_Edit";
            this.pictureBox_Grade_Edit.Size = new System.Drawing.Size(19, 17);
            this.pictureBox_Grade_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Grade_Edit.TabIndex = 7;
            this.pictureBox_Grade_Edit.TabStop = false;
            this.pictureBox_Grade_Edit.Visible = false;
            // 
            // pictureBox_Course_Name_Edit
            // 
            this.pictureBox_Course_Name_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Course_Name_Edit.Image")));
            this.pictureBox_Course_Name_Edit.Location = new System.Drawing.Point(120, 50);
            this.pictureBox_Course_Name_Edit.Name = "pictureBox_Course_Name_Edit";
            this.pictureBox_Course_Name_Edit.Size = new System.Drawing.Size(19, 17);
            this.pictureBox_Course_Name_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Course_Name_Edit.TabIndex = 6;
            this.pictureBox_Course_Name_Edit.TabStop = false;
            // 
            // listBox_Course_Subjects
            // 
            this.listBox_Course_Subjects.FormattingEnabled = true;
            this.listBox_Course_Subjects.Location = new System.Drawing.Point(3, 109);
            this.listBox_Course_Subjects.Name = "listBox_Course_Subjects";
            this.listBox_Course_Subjects.Size = new System.Drawing.Size(148, 95);
            this.listBox_Course_Subjects.TabIndex = 5;
            // 
            // label_Course_Subjects
            // 
            this.label_Course_Subjects.AutoSize = true;
            this.label_Course_Subjects.Location = new System.Drawing.Point(4, 93);
            this.label_Course_Subjects.Name = "label_Course_Subjects";
            this.label_Course_Subjects.Size = new System.Drawing.Size(87, 13);
            this.label_Course_Subjects.TabIndex = 4;
            this.label_Course_Subjects.Text = "Course Subjects:";
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(3, 71);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(39, 13);
            this.label_Grade.TabIndex = 2;
            this.label_Grade.Text = "Grade:";
            // 
            // label_Course_Name
            // 
            this.label_Course_Name.AutoSize = true;
            this.label_Course_Name.Location = new System.Drawing.Point(44, 50);
            this.label_Course_Name.Name = "label_Course_Name";
            this.label_Course_Name.Size = new System.Drawing.Size(74, 13);
            this.label_Course_Name.TabIndex = 1;
            this.label_Course_Name.Text = "[CourseName]";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(4, 50);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
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
            this.panel_ViewLesson.TabIndex = 5;
            // 
            // treeView_Search
            // 
            this.treeView_Search.Location = new System.Drawing.Point(3, 3);
            this.treeView_Search.Name = "treeView_Search";
            this.treeView_Search.Size = new System.Drawing.Size(204, 232);
            this.treeView_Search.TabIndex = 1;
            // 
            // label_Grade_Value
            // 
            this.label_Grade_Value.AutoSize = true;
            this.label_Grade_Value.Location = new System.Drawing.Point(44, 71);
            this.label_Grade_Value.Name = "label_Grade_Value";
            this.label_Grade_Value.Size = new System.Drawing.Size(54, 13);
            this.label_Grade_Value.TabIndex = 8;
            this.label_Grade_Value.Text = "[Grade] th";
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 270);
            this.Controls.Add(this.panel_CourseView);
            this.Controls.Add(this.panel_ViewLesson);
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.panel_CourseView.ResumeLayout(false);
            this.panel_CourseView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grade_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Course_Name_Edit)).EndInit();
            this.panel_ViewLesson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_CourseView;
        private System.Windows.Forms.PictureBox pictureBox_Grade_Edit;
        private System.Windows.Forms.PictureBox pictureBox_Course_Name_Edit;
        private System.Windows.Forms.ListBox listBox_Course_Subjects;
        private System.Windows.Forms.Label label_Course_Subjects;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.Label label_Course_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Panel panel_ViewLesson;
        private System.Windows.Forms.TreeView treeView_Search;
        private System.Windows.Forms.Label label_Grade_Value;
    }
}