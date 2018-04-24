namespace Client
{
    partial class table
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
            this.timetable1 = new Client.Timetable();
            this.SuspendLayout();
            // 
            // timetable1
            // 
            this.timetable1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable1.BackColor = System.Drawing.Color.Transparent;
            this.timetable1.Location = new System.Drawing.Point(244, 0);
            this.timetable1.Margin = new System.Windows.Forms.Padding(0);
            this.timetable1.Name = "timetable1";
            this.timetable1.Size = new System.Drawing.Size(405, 59);
            this.timetable1.TabIndex = 0;
            this.timetable1.UseCustomBackColor = true;
            this.timetable1.UseCustomForeColor = true;
            this.timetable1.UseSelectable = true;
            // 
            // table
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.timetable1);
            this.Name = "table";
            this.Size = new System.Drawing.Size(649, 308);
            this.ResumeLayout(false);

        }

        #endregion

        private Timetable timetable1;
    }
}
