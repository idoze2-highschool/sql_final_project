﻿namespace Client.Components.Teacher_UI.Dashboard
{
    partial class LandingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timetable1 = new Client.Timetable();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(151, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, {0}!\r\nHere\'s Your Timetable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-15, -15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(12, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "`";
            // 
            // timetable1
            // 
            this.timetable1.AutoSize = true;
            this.timetable1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable1.BackColor = System.Drawing.Color.Salmon;
            this.timetable1.Location = new System.Drawing.Point(61, 70);
            this.timetable1.Margin = new System.Windows.Forms.Padding(0);
            this.timetable1.Name = "timetable1";
            this.timetable1.Size = new System.Drawing.Size(411, 43);
            this.timetable1.TabIndex = 4;
            this.timetable1.UseCustomBackColor = true;
            this.timetable1.UseCustomForeColor = true;
            this.timetable1.UseSelectable = true;
            this.timetable1.Load += new System.EventHandler(this.timetable1_Load);
            // 
            // LandingPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Client.Properties.Resources.colored_pencils;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.timetable1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LandingPage";
            this.Size = new System.Drawing.Size(520, 330);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Timetable timetable1;
    }
}
