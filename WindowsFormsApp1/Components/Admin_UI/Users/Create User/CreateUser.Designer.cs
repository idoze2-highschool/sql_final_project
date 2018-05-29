namespace Client.Components.Admin_UI.Users
{
    partial class CreateUser
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
            this.label_FName_Title = new System.Windows.Forms.Label();
            this.label_Type_Title = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Grade_Title = new System.Windows.Forms.Label();
            this.numericUpDown_Grade = new System.Windows.Forms.NumericUpDown();
            this.label_Class_Title = new System.Windows.Forms.Label();
            this.groupBox_Student = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Class = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Teacher = new System.Windows.Forms.GroupBox();
            this.button_Select_Subject = new System.Windows.Forms.Button();
            this.label_Subject_Title = new System.Windows.Forms.Label();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.label_LName_Title = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_ID_Title = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grade)).BeginInit();
            this.groupBox_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Class)).BeginInit();
            this.groupBox_Teacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FName_Title
            // 
            this.label_FName_Title.AutoSize = true;
            this.label_FName_Title.Location = new System.Drawing.Point(21, 40);
            this.label_FName_Title.Name = "label_FName_Title";
            this.label_FName_Title.Size = new System.Drawing.Size(38, 13);
            this.label_FName_Title.TabIndex = 0;
            this.label_FName_Title.Text = "Name:";
            // 
            // label_Type_Title
            // 
            this.label_Type_Title.AutoSize = true;
            this.label_Type_Title.Location = new System.Drawing.Point(21, 118);
            this.label_Type_Title.Name = "label_Type_Title";
            this.label_Type_Title.Size = new System.Drawing.Size(34, 13);
            this.label_Type_Title.TabIndex = 1;
            this.label_Type_Title.Text = "Type:";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(65, 37);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(74, 20);
            this.textBox_FName.TabIndex = 0;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.comboBox_Type.Location = new System.Drawing.Point(65, 115);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(74, 21);
            this.comboBox_Type.TabIndex = 2;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label_Grade_Title
            // 
            this.label_Grade_Title.AutoSize = true;
            this.label_Grade_Title.Location = new System.Drawing.Point(6, 23);
            this.label_Grade_Title.Name = "label_Grade_Title";
            this.label_Grade_Title.Size = new System.Drawing.Size(39, 13);
            this.label_Grade_Title.TabIndex = 4;
            this.label_Grade_Title.Text = "Grade:";
            // 
            // numericUpDown_Grade
            // 
            this.numericUpDown_Grade.Location = new System.Drawing.Point(51, 21);
            this.numericUpDown_Grade.Name = "numericUpDown_Grade";
            this.numericUpDown_Grade.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown_Grade.TabIndex = 0;
            // 
            // label_Class_Title
            // 
            this.label_Class_Title.AutoSize = true;
            this.label_Class_Title.Location = new System.Drawing.Point(6, 49);
            this.label_Class_Title.Name = "label_Class_Title";
            this.label_Class_Title.Size = new System.Drawing.Size(35, 13);
            this.label_Class_Title.TabIndex = 6;
            this.label_Class_Title.Text = "Class:";
            // 
            // groupBox_Student
            // 
            this.groupBox_Student.Controls.Add(this.numericUpDown_Class);
            this.groupBox_Student.Controls.Add(this.label_Grade_Title);
            this.groupBox_Student.Controls.Add(this.label_Class_Title);
            this.groupBox_Student.Controls.Add(this.numericUpDown_Grade);
            this.groupBox_Student.Location = new System.Drawing.Point(168, 40);
            this.groupBox_Student.Name = "groupBox_Student";
            this.groupBox_Student.Size = new System.Drawing.Size(137, 97);
            this.groupBox_Student.TabIndex = 3;
            this.groupBox_Student.TabStop = false;
            this.groupBox_Student.Text = "Additional Information";
            this.groupBox_Student.Visible = false;
            // 
            // numericUpDown_Class
            // 
            this.numericUpDown_Class.Location = new System.Drawing.Point(51, 47);
            this.numericUpDown_Class.Name = "numericUpDown_Class";
            this.numericUpDown_Class.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown_Class.TabIndex = 1;
            // 
            // groupBox_Teacher
            // 
            this.groupBox_Teacher.Controls.Add(this.button_Select_Subject);
            this.groupBox_Teacher.Controls.Add(this.label_Subject_Title);
            this.groupBox_Teacher.Location = new System.Drawing.Point(168, 40);
            this.groupBox_Teacher.Name = "groupBox_Teacher";
            this.groupBox_Teacher.Size = new System.Drawing.Size(137, 97);
            this.groupBox_Teacher.TabIndex = 3;
            this.groupBox_Teacher.TabStop = false;
            this.groupBox_Teacher.Text = "Additional Information";
            this.groupBox_Teacher.Visible = false;
            // 
            // button_Select_Subject
            // 
            this.button_Select_Subject.Location = new System.Drawing.Point(9, 44);
            this.button_Select_Subject.Name = "button_Select_Subject";
            this.button_Select_Subject.Size = new System.Drawing.Size(85, 23);
            this.button_Select_Subject.TabIndex = 0;
            this.button_Select_Subject.Text = "Select Subject";
            this.button_Select_Subject.UseVisualStyleBackColor = true;
            // 
            // label_Subject_Title
            // 
            this.label_Subject_Title.AutoSize = true;
            this.label_Subject_Title.Location = new System.Drawing.Point(6, 28);
            this.label_Subject_Title.Name = "label_Subject_Title";
            this.label_Subject_Title.Size = new System.Drawing.Size(83, 13);
            this.label_Subject_Title.TabIndex = 0;
            this.label_Subject_Title.Text = "Default Subject:";
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(73, 63);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(74, 20);
            this.textBox_LName.TabIndex = 1;
            // 
            // label_LName_Title
            // 
            this.label_LName_Title.AutoSize = true;
            this.label_LName_Title.Location = new System.Drawing.Point(21, 66);
            this.label_LName_Title.Name = "label_LName_Title";
            this.label_LName_Title.Size = new System.Drawing.Size(46, 13);
            this.label_LName_Title.TabIndex = 10;
            this.label_LName_Title.Text = "Surame:";
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(24, 142);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(105, 142);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Title.Location = new System.Drawing.Point(21, 16);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(101, 18);
            this.label_Title.TabIndex = 11;
            this.label_Title.Text = "Create A User";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ID_Title
            // 
            this.label_ID_Title.AutoSize = true;
            this.label_ID_Title.Location = new System.Drawing.Point(21, 92);
            this.label_ID_Title.Name = "label_ID_Title";
            this.label_ID_Title.Size = new System.Drawing.Size(61, 13);
            this.label_ID_Title.TabIndex = 12;
            this.label_ID_Title.Text = "ID Number:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(88, 89);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(74, 20);
            this.textBox_ID.TabIndex = 13;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_LName_Title);
            this.Controls.Add(this.groupBox_Teacher);
            this.Controls.Add(this.textBox_LName);
            this.Controls.Add(this.groupBox_Student);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.label_Type_Title);
            this.Controls.Add(this.label_FName_Title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(434, 320);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grade)).EndInit();
            this.groupBox_Student.ResumeLayout(false);
            this.groupBox_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Class)).EndInit();
            this.groupBox_Teacher.ResumeLayout(false);
            this.groupBox_Teacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FName_Title;
        private System.Windows.Forms.Label label_Type_Title;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Grade_Title;
        private System.Windows.Forms.NumericUpDown numericUpDown_Grade;
        private System.Windows.Forms.Label label_Class_Title;
        private System.Windows.Forms.GroupBox groupBox_Student;
        private System.Windows.Forms.NumericUpDown numericUpDown_Class;
        private System.Windows.Forms.GroupBox groupBox_Teacher;
        private System.Windows.Forms.Button button_Select_Subject;
        private System.Windows.Forms.Label label_Subject_Title;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.Label label_LName_Title;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_ID_Title;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}
