namespace StartScreen
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.label_Clock = new System.Windows.Forms.Label();
            this.button_CurrentLesson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Location = new System.Drawing.Point(12, 9);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(84, 13);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Welcome, \'User\'";
            // 
            // timer_Clock
            // 
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // label_Clock
            // 
            this.label_Clock.AutoSize = true;
            this.label_Clock.Location = new System.Drawing.Point(12, 22);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(34, 13);
            this.label_Clock.TabIndex = 1;
            this.label_Clock.Text = "Clock";
            // 
            // button_CurrentLesson
            // 
            this.button_CurrentLesson.Location = new System.Drawing.Point(301, 131);
            this.button_CurrentLesson.Name = "button_CurrentLesson";
            this.button_CurrentLesson.Size = new System.Drawing.Size(84, 47);
            this.button_CurrentLesson.TabIndex = 2;
            this.button_CurrentLesson.Text = "Current Lesson";
            this.button_CurrentLesson.UseVisualStyleBackColor = true;
            this.button_CurrentLesson.Click += new System.EventHandler(this.button_CurrentLesson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 309);
            this.Controls.Add(this.button_CurrentLesson);
            this.Controls.Add(this.label_Clock);
            this.Controls.Add(this.label_Welcome);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Label label_Clock;
        private System.Windows.Forms.Button button_CurrentLesson;
    }
}