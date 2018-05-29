namespace Client.Components.Admin_UI.Users.Profiles
{
    partial class Teacher
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
            this.label_Name = new System.Windows.Forms.Label();
            this.button_View_Timetable = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(246, 85);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(54, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "%NAME%";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_View_Timetable
            // 
            this.button_View_Timetable.Location = new System.Drawing.Point(235, 101);
            this.button_View_Timetable.Name = "button_View_Timetable";
            this.button_View_Timetable.Size = new System.Drawing.Size(75, 23);
            this.button_View_Timetable.TabIndex = 8;
            this.button_View_Timetable.TabStop = false;
            this.button_View_Timetable.Text = "Timetable";
            this.button_View_Timetable.UseSelectable = true;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_View_Timetable);
            this.Controls.Add(this.label_Name);
            this.Name = "Teacher";
            this.Size = new System.Drawing.Size(516, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private MetroFramework.Controls.MetroButton button_View_Timetable;
    }
}
