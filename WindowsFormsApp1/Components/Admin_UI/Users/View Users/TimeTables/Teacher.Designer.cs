namespace Client.Components.Admin_UI.Users.Timetables
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
            this.timetable_main = new Client.Timetable();
            this.SuspendLayout();
            // 
            // timetable_main
            // 
            this.timetable_main.AutoSize = true;
            this.timetable_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable_main.BackColor = System.Drawing.Color.Transparent;
            this.timetable_main.Location = new System.Drawing.Point(0, 0);
            this.timetable_main.Margin = new System.Windows.Forms.Padding(0);
            this.timetable_main.Name = "timetable_main";
            this.timetable_main.Size = new System.Drawing.Size(403, 43);
            this.timetable_main.TabIndex = 0;
            this.timetable_main.UseCustomBackColor = true;
            this.timetable_main.UseCustomForeColor = true;
            this.timetable_main.UseSelectable = true;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.timetable_main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Teacher";
            this.Size = new System.Drawing.Size(434, 320);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timetable timetable_main;
    }
}
