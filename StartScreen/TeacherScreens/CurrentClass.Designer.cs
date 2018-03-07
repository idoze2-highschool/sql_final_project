namespace GystClient.TeacherScreens
{
    partial class CurrentClass
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
            this.Panel_Lable_StudentNames = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_Lable_StudentNames
            // 
            this.Panel_Lable_StudentNames.AutoSize = true;
            this.Panel_Lable_StudentNames.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Lable_StudentNames.Location = new System.Drawing.Point(12, 12);
            this.Panel_Lable_StudentNames.Name = "Panel_Lable_StudentNames";
            this.Panel_Lable_StudentNames.Size = new System.Drawing.Size(0, 0);
            this.Panel_Lable_StudentNames.TabIndex = 0;
            // 
            // CurrentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 311);
            this.Controls.Add(this.Panel_Lable_StudentNames);
            this.Name = "CurrentClass";
            this.Text = "CurrentClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Lable_StudentNames;
    }
}