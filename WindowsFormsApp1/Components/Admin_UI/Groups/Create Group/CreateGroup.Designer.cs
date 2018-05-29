namespace Client.Components.Admin_UI.Groups
{
    partial class CreateGroup
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
            this.label_Name_Title = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.label_Course_Title = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name_Title
            // 
            this.label_Name_Title.AutoSize = true;
            this.label_Name_Title.Location = new System.Drawing.Point(21, 40);
            this.label_Name_Title.Name = "label_Name_Title";
            this.label_Name_Title.Size = new System.Drawing.Size(38, 13);
            this.label_Name_Title.TabIndex = 0;
            this.label_Name_Title.Text = "Name:";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(74, 37);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(74, 20);
            this.textBox_FName.TabIndex = 2;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(73, 63);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(74, 20);
            this.textBox_LName.TabIndex = 9;
            // 
            // label_Course_Title
            // 
            this.label_Course_Title.AutoSize = true;
            this.label_Course_Title.Location = new System.Drawing.Point(21, 63);
            this.label_Course_Title.Name = "label_Course_Title";
            this.label_Course_Title.Size = new System.Drawing.Size(46, 13);
            this.label_Course_Title.TabIndex = 10;
            this.label_Course_Title.Text = "Surame:";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(24, 131);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(105, 131);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Course_Title);
            this.Controls.Add(this.textBox_LName);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.label_Name_Title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateGroup";
            this.Size = new System.Drawing.Size(614, 339);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name_Title;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.Label label_Course_Title;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}
