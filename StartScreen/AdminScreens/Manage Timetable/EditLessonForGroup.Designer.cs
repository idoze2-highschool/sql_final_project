namespace GystClient.AdminScreens.Manage_Timetable
{
    partial class EditLesson_ForGroup
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
            this.label_day_title = new System.Windows.Forms.Label();
            this.label_period_title = new System.Windows.Forms.Label();
            this.label_group_title = new System.Windows.Forms.Label();
            this.label_subject_title = new System.Windows.Forms.Label();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.label_course_title = new System.Windows.Forms.Label();
            this.label_teacher_title = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_grade_title = new System.Windows.Forms.Label();
            this.comboBox_Teacher = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_day_title
            // 
            this.label_day_title.AutoSize = true;
            this.label_day_title.Location = new System.Drawing.Point(13, 10);
            this.label_day_title.Name = "label_day_title";
            this.label_day_title.Size = new System.Drawing.Size(29, 13);
            this.label_day_title.TabIndex = 0;
            this.label_day_title.Text = "Day:";
            // 
            // label_period_title
            // 
            this.label_period_title.AutoSize = true;
            this.label_period_title.Location = new System.Drawing.Point(12, 44);
            this.label_period_title.Name = "label_period_title";
            this.label_period_title.Size = new System.Drawing.Size(40, 13);
            this.label_period_title.TabIndex = 1;
            this.label_period_title.Text = "Period:";
            // 
            // label_group_title
            // 
            this.label_group_title.AutoSize = true;
            this.label_group_title.Location = new System.Drawing.Point(14, 112);
            this.label_group_title.Name = "label_group_title";
            this.label_group_title.Size = new System.Drawing.Size(39, 13);
            this.label_group_title.TabIndex = 2;
            this.label_group_title.Text = "Group:";
            // 
            // label_subject_title
            // 
            this.label_subject_title.AutoSize = true;
            this.label_subject_title.Location = new System.Drawing.Point(14, 146);
            this.label_subject_title.Name = "label_subject_title";
            this.label_subject_title.Size = new System.Drawing.Size(46, 13);
            this.label_subject_title.TabIndex = 5;
            this.label_subject_title.Text = "Subject:";
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Location = new System.Drawing.Point(66, 143);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Subject.TabIndex = 6;
            // 
            // label_course_title
            // 
            this.label_course_title.AutoSize = true;
            this.label_course_title.Location = new System.Drawing.Point(13, 78);
            this.label_course_title.Name = "label_course_title";
            this.label_course_title.Size = new System.Drawing.Size(43, 13);
            this.label_course_title.TabIndex = 7;
            this.label_course_title.Text = "Course:";
            // 
            // label_teacher_title
            // 
            this.label_teacher_title.AutoSize = true;
            this.label_teacher_title.Location = new System.Drawing.Point(14, 179);
            this.label_teacher_title.Name = "label_teacher_title";
            this.label_teacher_title.Size = new System.Drawing.Size(50, 13);
            this.label_teacher_title.TabIndex = 9;
            this.label_teacher_title.Text = "Teacher:";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(13, 215);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(64, 23);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(84, 215);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_grade_title
            // 
            this.label_grade_title.AutoSize = true;
            this.label_grade_title.Location = new System.Drawing.Point(150, 78);
            this.label_grade_title.Name = "label_grade_title";
            this.label_grade_title.Size = new System.Drawing.Size(39, 13);
            this.label_grade_title.TabIndex = 13;
            this.label_grade_title.Text = "Grade:";
            // 
            // comboBox_teacher
            // 
            this.comboBox_Teacher.FormattingEnabled = true;
            this.comboBox_Teacher.Location = new System.Drawing.Point(66, 176);
            this.comboBox_Teacher.Name = "comboBox_teacher";
            this.comboBox_Teacher.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Teacher.TabIndex = 14;
            // 
            // EditLesson_ForGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBox_Teacher);
            this.Controls.Add(this.label_grade_title);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_teacher_title);
            this.Controls.Add(this.label_course_title);
            this.Controls.Add(this.comboBox_Subject);
            this.Controls.Add(this.label_subject_title);
            this.Controls.Add(this.label_group_title);
            this.Controls.Add(this.label_period_title);
            this.Controls.Add(this.label_day_title);
            this.Name = "EditLesson_ForGroup";
            this.Text = "EditPeriod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_day_title;
        private System.Windows.Forms.Label label_period_title;
        private System.Windows.Forms.Label label_group_title;
        private System.Windows.Forms.Label label_subject_title;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Label label_course_title;
        private System.Windows.Forms.Label label_teacher_title;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_grade_title;
        private System.Windows.Forms.ComboBox comboBox_Teacher;
    }
}