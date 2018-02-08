namespace GystClient
{
    partial class LoginScreen
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
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Logo_SubPlaceHolder = new System.Windows.Forms.Label();
            this.label_Logo_MainPlaceHolder = new System.Windows.Forms.Label();
            this.label_InvalidLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RememberMe.Location = new System.Drawing.Point(220, 195);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(117, 20);
            this.checkBox_RememberMe.TabIndex = 2;
            this.checkBox_RememberMe.Text = "Remember Me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.Enabled = false;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(231, 157);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(94, 32);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(231, 132);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(94, 22);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(231, 107);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(94, 22);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.Text = "Username";
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label_Logo_SubPlaceHolder
            // 
            this.label_Logo_SubPlaceHolder.AutoSize = true;
            this.label_Logo_SubPlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Logo_SubPlaceHolder.Location = new System.Drawing.Point(154, 80);
            this.label_Logo_SubPlaceHolder.Name = "label_Logo_SubPlaceHolder";
            this.label_Logo_SubPlaceHolder.Size = new System.Drawing.Size(249, 24);
            this.label_Logo_SubPlaceHolder.TabIndex = 4;
            this.label_Logo_SubPlaceHolder.Text = "Get Your Students Together.";
            // 
            // label_Logo_MainPlaceHolder
            // 
            this.label_Logo_MainPlaceHolder.AutoSize = true;
            this.label_Logo_MainPlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Logo_MainPlaceHolder.Location = new System.Drawing.Point(253, 56);
            this.label_Logo_MainPlaceHolder.Name = "label_Logo_MainPlaceHolder";
            this.label_Logo_MainPlaceHolder.Size = new System.Drawing.Size(51, 24);
            this.label_Logo_MainPlaceHolder.TabIndex = 5;
            this.label_Logo_MainPlaceHolder.Text = "Gyst.";
            this.label_Logo_MainPlaceHolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_InvalidLogin
            // 
            this.label_InvalidLogin.AutoSize = true;
            this.label_InvalidLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.label_InvalidLogin.Location = new System.Drawing.Point(217, 218);
            this.label_InvalidLogin.Name = "label_InvalidLogin";
            this.label_InvalidLogin.Size = new System.Drawing.Size(171, 48);
            this.label_InvalidLogin.TabIndex = 6;
            this.label_InvalidLogin.Text = "Invalid Login Information,\r\nIf you belive this is an Issue,\r\nContact Local Suppor" +
    "t.\r\n";
            this.label_InvalidLogin.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 326);
            this.Controls.Add(this.label_InvalidLogin);
            this.Controls.Add(this.label_Logo_MainPlaceHolder);
            this.Controls.Add(this.label_Logo_SubPlaceHolder);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_RememberMe;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Logo_SubPlaceHolder;
        private System.Windows.Forms.Label label_Logo_MainPlaceHolder;
        private System.Windows.Forms.Label label_InvalidLogin;
    }
}

