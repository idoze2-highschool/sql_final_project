namespace Client.Components.Admin_UI.Users.Profiles
{
    partial class Student
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
            this.button_View_Timetable = new MetroFramework.Controls.MetroButton();
            this.button_View_Groups = new MetroFramework.Controls.MetroButton();
            this.label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_View_Timetable
            // 
            this.button_View_Timetable.Location = new System.Drawing.Point(206, 127);
            this.button_View_Timetable.Name = "button_View_Timetable";
            this.button_View_Timetable.Size = new System.Drawing.Size(75, 23);
            this.button_View_Timetable.TabIndex = 7;
            this.button_View_Timetable.Text = "Timetable";
            this.button_View_Timetable.UseSelectable = true;
            // 
            // button_View_Groups
            // 
            this.button_View_Groups.Location = new System.Drawing.Point(205, 98);
            this.button_View_Groups.Name = "button_View_Groups";
            this.button_View_Groups.Size = new System.Drawing.Size(75, 23);
            this.button_View_Groups.TabIndex = 6;
            this.button_View_Groups.Text = "View Groups";
            this.button_View_Groups.UseSelectable = true;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(202, 82);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(54, 13);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "%NAME%";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_View_Timetable);
            this.Controls.Add(this.button_View_Groups);
            this.Controls.Add(this.label_Name);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(516, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button_View_Timetable;
        private MetroFramework.Controls.MetroButton button_View_Groups;
        private System.Windows.Forms.Label label_Name;
    }
}
