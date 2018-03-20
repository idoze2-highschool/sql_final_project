namespace GystClient.AdminScreens
{
    partial class EditLesson
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
            this.label_group = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_day_title
            // 
            this.label_day_title.AutoSize = true;
            this.label_day_title.Location = new System.Drawing.Point(13, 13);
            this.label_day_title.Name = "label_day_title";
            this.label_day_title.Size = new System.Drawing.Size(29, 13);
            this.label_day_title.TabIndex = 0;
            this.label_day_title.Text = "Day:";
            // 
            // label_period_title
            // 
            this.label_period_title.AutoSize = true;
            this.label_period_title.Location = new System.Drawing.Point(13, 26);
            this.label_period_title.Name = "label_period_title";
            this.label_period_title.Size = new System.Drawing.Size(40, 13);
            this.label_period_title.TabIndex = 1;
            this.label_period_title.Text = "Period:";
            // 
            // label_group_title
            // 
            this.label_group_title.AutoSize = true;
            this.label_group_title.Location = new System.Drawing.Point(13, 39);
            this.label_group_title.Name = "label_group_title";
            this.label_group_title.Size = new System.Drawing.Size(39, 13);
            this.label_group_title.TabIndex = 2;
            this.label_group_title.Text = "Group:";
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.ForeColor = System.Drawing.Color.Blue;
            this.label_group.Location = new System.Drawing.Point(58, 39);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(43, 13);
            this.label_group.TabIndex = 3;
            this.label_group.Text = "[Select]";
            this.label_group.Click += new System.EventHandler(this.label_group_Click);
            // 
            // EditPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label_group_title);
            this.Controls.Add(this.label_period_title);
            this.Controls.Add(this.label_day_title);
            this.Name = "EditPeriod";
            this.Text = "EditPeriod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_day_title;
        private System.Windows.Forms.Label label_period_title;
        private System.Windows.Forms.Label label_group_title;
        private System.Windows.Forms.Label label_group;
    }
}