namespace GystClient.AdminScreens
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.button_Manage_Timetable = new System.Windows.Forms.Button();
            this.label_Clock = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.button_Manage_Groups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Manage_Timetable
            // 
            this.button_Manage_Timetable.Location = new System.Drawing.Point(265, 134);
            this.button_Manage_Timetable.Name = "button_Manage_Timetable";
            this.button_Manage_Timetable.Size = new System.Drawing.Size(75, 40);
            this.button_Manage_Timetable.TabIndex = 0;
            this.button_Manage_Timetable.Text = "Manage Timetable";
            this.button_Manage_Timetable.UseVisualStyleBackColor = true;
            this.button_Manage_Timetable.Click += new System.EventHandler(this.button_Manage_Timetable_Click);
            // 
            // label_Clock
            // 
            this.label_Clock.AutoSize = true;
            this.label_Clock.Location = new System.Drawing.Point(12, 22);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(34, 13);
            this.label_Clock.TabIndex = 3;
            this.label_Clock.Text = "Clock";
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Location = new System.Drawing.Point(12, 9);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(84, 13);
            this.label_Welcome.TabIndex = 2;
            this.label_Welcome.Text = "Welcome, \'User\'";
            // 
            // button_Manage_Groups
            // 
            this.button_Manage_Groups.Location = new System.Drawing.Point(346, 134);
            this.button_Manage_Groups.Name = "button_Manage_Groups";
            this.button_Manage_Groups.Size = new System.Drawing.Size(75, 40);
            this.button_Manage_Groups.TabIndex = 4;
            this.button_Manage_Groups.Text = "Manage Groups";
            this.button_Manage_Groups.UseVisualStyleBackColor = true;
            this.button_Manage_Groups.Click += new System.EventHandler(this.button_Manage_Groups_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 309);
            this.Controls.Add(this.button_Manage_Groups);
            this.Controls.Add(this.label_Clock);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.button_Manage_Timetable);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Manage_Timetable;
        private System.Windows.Forms.Label label_Clock;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Button button_Manage_Groups;
    }
}