namespace StartScreen
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
            this.radio_P = new System.Windows.Forms.RadioButton();
            this.radio_A = new System.Windows.Forms.RadioButton();
            this.label_StudentName = new System.Windows.Forms.Label();
            this.label_CurrentClass_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio_P
            // 
            this.radio_P.AutoSize = true;
            this.radio_P.Location = new System.Drawing.Point(164, 94);
            this.radio_P.Name = "radio_P";
            this.radio_P.Size = new System.Drawing.Size(61, 17);
            this.radio_P.TabIndex = 0;
            this.radio_P.TabStop = true;
            this.radio_P.Text = "Present";
            this.radio_P.UseVisualStyleBackColor = true;
            // 
            // radio_A
            // 
            this.radio_A.AutoSize = true;
            this.radio_A.Location = new System.Drawing.Point(100, 94);
            this.radio_A.Name = "radio_A";
            this.radio_A.Size = new System.Drawing.Size(58, 17);
            this.radio_A.TabIndex = 1;
            this.radio_A.TabStop = true;
            this.radio_A.Text = "Absent";
            this.radio_A.UseVisualStyleBackColor = true;
            // 
            // label_StudentName
            // 
            this.label_StudentName.AutoSize = true;
            this.label_StudentName.Location = new System.Drawing.Point(112, 78);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(44, 13);
            this.label_StudentName.TabIndex = 2;
            this.label_StudentName.Text = "Student";
            // 
            // label_CurrentClass_Title
            // 
            this.label_CurrentClass_Title.AutoSize = true;
            this.label_CurrentClass_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_CurrentClass_Title.Location = new System.Drawing.Point(97, 41);
            this.label_CurrentClass_Title.Name = "label_CurrentClass_Title";
            this.label_CurrentClass_Title.Size = new System.Drawing.Size(107, 18);
            this.label_CurrentClass_Title.TabIndex = 3;
            this.label_CurrentClass_Title.Text = "Current Class: ";
            // 
            // CurrentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 311);
            this.Controls.Add(this.label_CurrentClass_Title);
            this.Controls.Add(this.label_StudentName);
            this.Controls.Add(this.radio_A);
            this.Controls.Add(this.radio_P);
            this.Name = "CurrentClass";
            this.Text = "CurrentClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_P;
        private System.Windows.Forms.RadioButton radio_A;
        private System.Windows.Forms.Label label_StudentName;
        private System.Windows.Forms.Label label_CurrentClass_Title;
    }
}